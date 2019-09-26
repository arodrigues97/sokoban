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
                    Map[row, col] = new MapLocation(new Rectangle(row * RectSize, col * RectSize, RectSize, RectSize));
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

        public int GetRowLength() {
            return Map.GetLength(0);
        }

        public int GetColumnLength() {
            return Map.GetLength(1);
        }

        public MapLocation[,] GetMap() {
            return Map;
        }

    }
}
