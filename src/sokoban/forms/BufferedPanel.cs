using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban_Assignment.src.sokoban.forms {

    /// <summary>
    /// Represents a double buffered panel to reduce flickering on paint.
    /// <see cref="https://stackoverflow.com/questions/3113190/double-buffering-when-not-drawing-in-onpaint-why-doesnt-it-work/3113515#3113515"/>
    /// </summary>
    public class BufferedPanel : Panel {

        /// <summary>
        /// Constructs the new Buffered Panel.
        /// </summary>
        public BufferedPanel() {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }
    }
}
