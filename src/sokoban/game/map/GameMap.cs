using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sokoban_Assignment.src.sokoban.game.entity;
using Sokoban_Assignment.src.sokoban.game.entity.box;
using Sokoban_Assignment.src.sokoban.game.entity.endpoint;
using Sokoban_Assignment.src.sokoban.game.entity.hero;
using Sokoban_Assignment.src.sokoban.game.entity.wall;
using Sokoban_Assignment.src.sokoban.game.map;

namespace Sokoban_Assignment.src.sokoban.game {

    /// <summary>
    /// Represents the Game Map of the Sokoban Game. This map is composed of a 2d array of MapLocation objects.
    /// This class can handle the drawing of the map, handling of clicks on the map and retreiving object 
    /// instances on the map.
    /// </summary>
    public class GameMap {

        /// <summary>
        /// The size of the rectangle the map location will be contained to.
        /// </summary>
        private const int RectSize  = 30;
        
        /// <summary>
        /// The array of Map locations.
        /// </summary>
        private MapLocation[,] Map;

        /// <summary>
        /// Constructs a new GameMap instance.
        /// </summary>
        /// <param name="rows">The number of the rows.</param>
        /// <param name="columns">The number of the columns.</param>
        public GameMap(int rows, int columns) {
            Map = new MapLocation[rows, columns];
            for (int row = 0; row < rows; row++) {
                for (int col = 0; col < columns; col++) {
                    Map[row, col] = new MapLocation(row, col, new Rectangle(row * RectSize, col * RectSize, RectSize, RectSize));
                }
            }
        }

        /// <summary>
        /// Handle the Click event on the map.
        /// </summary>
        /// <param name="mouseEvent">The mouse event.</param>
        public void Click(MouseEventArgs mouseEvent) {
            int x = mouseEvent.X;
            int y = mouseEvent.Y;
            MapLocation mapLocation = GetMapLocation(x, y);
            if (mapLocation == null) {
                Console.WriteLine("Map Location was not found for: x=" + x + ", y=" + y);
                return;
            }
            if (SokobanProgram.GetGameManager().GetGameState() == GameState.DESIGN) {
                HandleDesignClick(mapLocation);
            } else if (SokobanProgram.GetGameManager().GetGameState() == GameState.PLAY) {
                HandlePlayClick(mapLocation);
            } else {
                Console.WriteLine("Error: Invalid Game State set!");
            }
        }

        /// <summary>
        /// Handles the click method specifically in design mode.
        /// </summary>
        /// <param name="mapLocation">The map location clicked.</param>
        private void HandleDesignClick(MapLocation mapLocation) {
            List<Entity> entitys = mapLocation.GetEntitys();
            EntityType entityType = ((DesignForm)SokobanProgram.getFormFromState(GameState.DESIGN)).GetToolType();
            if (entityType == EntityType.HERO && HasEntity(EntityType.HERO)) {
                MessageBox.Show("There can only be one Hero on the game board.");
                return;
            }
            if (entitys.Count > 0) {
                mapLocation.ClearEntities();
            }
            Entity entity = Entity.GetEntityByType(entityType);
            if (entity == null) {
                return;
            }
            mapLocation.AddEntity(entity);
        }

        /// <summary>
        /// Handles the click event in play mode.
        /// </summary>
        /// <param name="mapLocation">The map location clicked.</param>
        private void HandlePlayClick(MapLocation mapLocation) {
            //TODO: Play Click.
        }

        public void HandleMoveClick(Direction direction) {
            Hero hero = SokobanProgram.GetGameManager().GetHero();
            if (hero == null) {
                return;
            }
            MapLocation location = hero.GetLocation();
            hero.SetDirection(direction);
            MapLocation moveSpot = GetNextMoveSpot(location, direction);
            if (moveSpot == null) {
                return;
            }
            bool checkWinning = false;
            if (moveSpot.HasEntitys()) {
                Entity entity;
                for (int i = 0; i < moveSpot.GetEntitys().Count; i++)  {
                    entity = moveSpot.GetEntitys()[i];
                    if (entity.GetEntityType() == EntityType.BOX)  {
                        MapLocation boxMoveSpot = GetNextMoveSpot(entity.GetLocation(), direction);
                        if (boxMoveSpot == null)  {
                            return;
                        }
                        //Box attempting to move to a spot with entites.
                        if (boxMoveSpot.HasEntitys())  {
                            Entity e;
                            for (int k = 0; k < boxMoveSpot.GetEntitys().Count; k++)  {
                                e = boxMoveSpot.GetEntitys()[k];
                                if (e.GetEntityType() != EntityType.DESTINATION) {
                                    return;
                                }
                                if (e.GetEntityType() == EntityType.DESTINATION)  {
                                    ((Box) entity).SetColor(BoxColor.BLUE);
                                    checkWinning = true;
                                    break;
                                }
                            }
                        } else  {
                            //Box moving off destination
                            if (entity .GetEntityType() == EntityType.BOX) {
                                ((Box)entity).SetColor(BoxColor.RED);
                            }
                        }
                        entity.GetLocation().RemoveEntity(entity);
                        boxMoveSpot.AddEntity(entity);
                        hero.IncrementBoxesPushed();
                        break;
                    }
                    if (entity.GetEntityType() != EntityType.DESTINATION) {
                        return;
                    }
                }
            }
            location.RemoveEntity(hero);
            moveSpot.AddEntity(hero);
            hero.IncrementMoves();
            if (checkWinning) {
                CheckGameWinning();
            }
        }

        private void CheckGameWinning() {
            int destinations = 0;
            int boxes = 0;
            for (int row = 0; row < GetRowLength(); row++) {
                for (int col = 0; col < GetColumnLength(); col++) {
                    foreach (Entity entity in Map[row, col].GetEntitys()) {
                        if (entity is Box) {
                            boxes++;
                        }
                        if (entity is Destination) {
                            destinations++;
                            if (!Map[row, col].HasEntityType(EntityType.BOX)) {
                                return;
                            }
                        }
                    }
                }
            }
            if (destinations == boxes)  {
                MessageBox.Show("Congratulations, you have completed this map. Total moves: " + SokobanProgram.GetGameManager().GetHero().GetMoves() + ". Total  Boxes Pushed: " + SokobanProgram.GetGameManager().GetHero().GetBoxesPushed());
                SokobanProgram.GetGameManager().Unload();
            }
        }

        /// <summary>
        /// Gets the next spot to move.
        /// </summary>
        /// <param name="location">The location we're at.</param>
        /// <param name="direction">The direction to move.</param>
        /// <returns></returns>
        private MapLocation GetNextMoveSpot(MapLocation location, Direction direction) {
            int row = location.GetRow();
            int col = location.GetColumn();
            switch (direction)  {
                case Direction.NORTH:
                    if (col - 1 < 0) {
                        return null;
                    }
                   return Map[row, col - 1];
                case Direction.SOUTH:
                    if (col + 1 >= GetColumnLength())  {
                        return null;
                    }
                    return Map[row, col + 1];
                case Direction.EAST:
                    if (row + 1 >= GetRowLength()) {
                        return null;
                    }
                     return Map[row + 1, col];
                case Direction.WEST:
                    if (row - 1 < 0) {
                        return null;
                    }
                    return Map[row - 1, col];
            }
            return null;
        }

        /// <summary>
        /// Draws the Game Map.
        /// </summary>
        /// <param name="graphics">The graphics instance to use.</param>
        public void DrawMap(Graphics graphics) {
            int RowLength = GetRowLength();
            int ColLength = GetColumnLength();
            MapLocation MapLoc;
            for (int row = 0; row < RowLength; row++) {
                for (int col = 0; col < ColLength; col++) {
                    MapLoc = Map[row, col];
                    graphics.DrawImage(Properties.Resources.GroundGravel_Concrete, MapLoc.GetRectangle());
                    if (MapLoc.HasEntitys()) {
                        foreach (Entity entity in MapLoc.GetEntitys()) {
                            entity.Draw(graphics, MapLoc.GetRectangle());
                        }
                    }
                    graphics.DrawRectangle(Pens.Black, MapLoc.GetRectangle());
                }
            }
        }

        /// <summary>
        /// Gets the list of entitys from a coordinate on the Map.
        /// </summary>
        /// <param name="x">The X coordinate.</param>
        /// <param name="y">The Y coordinate.</param>
        /// <returns>The List of entitys on the Map coordinate.</returns>
        public List<Entity> GetEntitysFromCoordinate(int x, int y) {
            for (int row = 0;  row < GetRowLength(); row++) {
                for (int col = 0; col < GetColumnLength(); col++) {
                    if (Map[row, col].GetRectangle().Contains(x, y)) {
                        return Map[row, col].GetEntitys();
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the Map Location from the X & Y coordinate. 
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <returns>The MapLocation.</returns>
        public MapLocation GetMapLocation(int x, int y) {
            for (int row = 0; row < GetRowLength(); row++) {
                for (int col = 0; col < GetColumnLength(); col++) {
                    if (Map[row, col].GetRectangle().Contains(x, y)) {
                        return Map[row, col];
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// CHecks if an entity type exists on the Map.
        /// </summary>
        /// <param name="type">The entity type to check.</param>
        /// <returns>True if entity is found.</returns>
        public Boolean HasEntity(EntityType type) {
            for (int row = 0; row < GetRowLength(); row++) {
                for (int col = 0; col < GetColumnLength(); col++) {
                   foreach(Entity entity in Map[row, col].GetEntitys()) {
                        if (entity.GetEntityType() == type) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Gets the Row length.
        /// </summary>
        /// <returns>The length of the row.</returns>
        public int GetRowLength() {
            return Map.GetLength(0);
        }

        /// <summary>
        /// Gets the Column length.
        /// </summary>
        /// <returns>The length of the column.</returns>
        public int GetColumnLength() {
            return Map.GetLength(1);
        }

        /// <summary>
        /// Gets the Array of MapLocation.
        /// </summary>
        /// <returns>The Array of MapLocation.</returns>
        public MapLocation[,] GetMap() {
            return Map;
        }

    }
}
