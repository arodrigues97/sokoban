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
        /// The colo of the Box.
        /// </summary>
        private BoxColor color;

        /// <summary>
        /// Draws the Entity Graphics.
        /// </summary>
        /// <param name="g">The graphics instance being used.</param>
        /// <param name="rectangle">The rectangle we're drawing inside of.</param>
        public override void Draw(Graphics g, Rectangle rectangle) {
            g.DrawImage(GetBitmapFromColor(), rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        /// <summary>
        /// Gets the Bitmap from the Box color.
        /// </summary>
        /// <returns>The Bitmap.</returns>
        private Bitmap GetBitmapFromColor() {
            switch (color) {
                case BoxColor.RED:
                    return Properties.Resources.CrateDark_Red;
                case BoxColor.BLUE:
                    return Properties.Resources.CrateDark_Blue;
            }
            return null;
        }

        /// <summary>
        /// Gets the Entity Type 'Box' for this class type.
        /// </summary>
        /// <returns>The Entity Type Box.</returns>
        public override EntityType GetEntityType() {
            return EntityType.BOX;
        }

        /// <summary>
        /// Sets the Box color.
        /// </summary>
        /// <param name="color">The color to set.</param>
        public void SetColor(BoxColor color)  {
            this.color = color;
        }

    }

    public enum BoxColor
    {
        RED,
        BLUE
    }
}
