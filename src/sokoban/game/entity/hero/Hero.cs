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
        private Direction Direction = Direction.NORTH;

        /// <summary>
        /// Draws the Entity Graphics.
        /// </summary>
        /// <param name="g">The graphics instance being used.</param>
        /// <param name="rectangle">The rectangle we're drawing inside of.</param>
        public override void Draw(Graphics g, Rectangle rectangle) {
            g.DrawImage(Properties.Resources.Character4, rectangle.X + 3, rectangle.Y + 2, rectangle.Width - 5, rectangle.Height - 5);
        }

        /// <summary>
        /// Gets the Entity Type Hero.
        /// </summary>
        /// <returns>The Entity Type Hero.</returns>
        public override EntityType GetEntityType() {
            return EntityType.HERO;
        }

        /// <summary>
        /// Gets the Direction of the Hero.
        /// </summary>
        /// <returns>The Direction of the Hero.</returns>
        public Direction GetDirection() {
            return Direction;
        }
    }

}
