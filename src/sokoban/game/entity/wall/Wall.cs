using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_Assignment.src.sokoban.game.entity.wall {

    /// <summary>
    /// Represents the Entity 'Wall'.
    /// </summary>
    public class Wall : Entity {

        /// <summary>
        /// Draws the Entity Graphics.
        /// </summary>
        /// <param name="g">The graphics instance being used.</param>
        /// <param name="rectangle">The rectangle we're drawing inside of.</param>
        public override void Draw(Graphics g, Rectangle rectangle) {
            g.DrawImage(Properties.Resources.Wall_Black, rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        public override EntityType GetEntityType() {
            return EntityType.WALL;
        }
    }
}
