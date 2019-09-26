using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_Assignment.src.sokoban.game.entity.endpoint {

    /// <summary>
    /// Represents the entity 'Destination'.
    /// </summary>
    public class Destination : Entity {

        /// <summary>
        /// Draws the Entity Graphics.
        /// </summary>
        /// <param name="g">The graphics instance being used.</param>
        /// <param name="rectangle">The rectangle we're drawing inside of.</param>
        public override void Draw(Graphics g, Rectangle rectangle) {
            g.DrawImage(Properties.Resources.EndPoint_Red, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        /// <summary>
        /// Gets the Entity Type Destination.
        /// </summary>
        /// <returns>The Entity Type Destination.</returns>
        public override EntityType GetEntityType() {
            return EntityType.DESTINATION;
        }

    }
}
