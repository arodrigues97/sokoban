using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_Assignment.src.sokoban.game.entity.hero {

    /// <summary>
    /// Represents the entity 'Hero'.
    /// </summary>
    public class Hero : Entity {

        /// <summary>
        /// Represents the Direction of the Hero.
        /// </summary>
        private Direction direction = Direction.NORTH;

        /// <summary>
        /// The amount of moves done.
        /// </summary>
        private int moves;

        /// <summary>
        /// The amount of boxes pushed.
        /// </summary>
        private int boxesPushed;

        /// <summary>
        /// Draws the Entity Graphics.
        /// </summary>
        /// <param name="g">The graphics instance being used.</param>
        /// <param name="rectangle">The rectangle we're drawing inside of.</param>
        public override void Draw(Graphics g, Rectangle rectangle) {
            g.DrawImage(GetDirectionBitMap(), rectangle.X + 3, rectangle.Y + 2, rectangle.Width - 5, rectangle.Height - 5);
        }

        /// <summary>
        /// Gets the Entity Type Hero.
        /// </summary>
        /// <returns>The Entity Type Hero.</returns>
        public override EntityType GetEntityType() {
            return EntityType.HERO;
        }

        /// <summary>
        /// Sets the Direction of the Hero.
        /// </summary>
        /// <param name="direction">The direction to set.</param>
        public void SetDirection(Direction direction) {
            this.direction =  direction;
        }

        /// <summary>
        /// Gets the Bitmap image for the corresponding direction.
        /// </summary>
        /// <returns>The Bitmap image.</returns>
        private Bitmap GetDirectionBitMap()  {
            switch (direction) {
                case Direction.NORTH:
                    return Properties.Resources.Character7;
                case Direction.SOUTH:
                    return Properties.Resources.Character4;
                case Direction.EAST:
                    return Properties.Resources.Character3;
                case Direction.WEST:
                    return Properties.Resources.Character10;
            }
            return null;
        }

        /// <summary>
        /// Gets the Direction of the Hero.
        /// </summary>
        /// <returns>The Direction of the Hero.</returns>
        public Direction GetDirection() {
            return direction;
        }

        /// <summary>
        /// Increments the moves.
        /// </summary>
        public void IncrementMoves() {
            moves += 1;
            PlayForm playForm = (PlayForm) SokobanProgram.getFormFromState(GameState.PLAY);
            playForm.numberOfMovesLabel.Text = "Number of Moves: " + moves;
        }

        /// <summary>
        /// Increments the boxes pushed.
        /// </summary>
        public void IncrementBoxesPushed() {
            boxesPushed += 1;
            PlayForm playForm = (PlayForm)SokobanProgram.getFormFromState(GameState.PLAY);
            playForm.numberOfPushesLabel.Text = "Number of Pushes: " + boxesPushed;
        }

        /// <summary>
        /// Gets the amount of moves.
        /// </summary>
        /// <returns>The amount of moves.</returns>
        public int GetMoves()  {
            return moves;
        }

        /// <summary>
        /// Gets the amount of boxes pushed.
        /// </summary>
        /// <returns>The amount of boxes pushed.</returns>
        public int GetBoxesPushed()  {
            return boxesPushed;
        }
    }

}
