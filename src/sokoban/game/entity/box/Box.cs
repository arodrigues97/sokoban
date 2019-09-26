using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_Assignment.src.sokoban.game.entity.box {

    /// <summary>
    /// Represents the entity 'Box'.
    /// </summary>
    public class Box : Entity {

        /// <summary>
        /// Draws the Entity Graphics.
        /// </summary>
        /// <param name="g">The graphics instance being used.</param>
        /// <param name="rectangle">The rectangle we're drawing inside of.</param>
        public override void Draw(Graphics g, Rectangle rectangle) {
            g.DrawImage(Properties.Resources.CrateDark_Red, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        /// <summary>
        /// Gets the Entity Type 'Box' for this class type.
        /// </summary>
        /// <returns>The Entity Type Box.</returns>
        public override EntityType GetEntityType() {
            return EntityType.BOX;
        }

    }
}
