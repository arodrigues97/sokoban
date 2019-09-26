using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban_Assignment {
    
    /// <summary>
    /// Represents the Form used for the selection process of designing/playing.
    /// </summary>
    public partial class SelectionForm : Form {

        /// <summary>
        /// Represents the Selection Form instance.
        /// </summary>
        private static Form Instance;

        /// <summary>
        /// Constructs a new Selection Form.
        /// </summary>
        public SelectionForm() {
            InitializeComponent();
        }

        /// <summary>
        /// The method called on clicking the design button.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void DesignButton_Click(object sender, EventArgs e) {
            SokobanProgram.OpenGameState(GameState.DESIGN);
        }

        /// <summary>
        /// The method called on clicking the play button.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void PlayButton_Click(object sender, EventArgs e) {
            SokobanProgram.OpenGameState(GameState.PLAY);
        }

        /// <summary>
        /// The method called on clicking the exit button.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ExitButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// The method called when loading the selection form.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void SelectionForm_Load(object sender, EventArgs e) {
           
        }

        /// <summary>
        /// Represents the singelton pattern for the selection form.
        /// </summary>
        /// <returns>The singleton of the selection form.</returns>
        public static Form GetInstance() {
            if (Instance == null) {
                Instance = new SelectionForm();
            }
            return Instance;
        }
    }
}
