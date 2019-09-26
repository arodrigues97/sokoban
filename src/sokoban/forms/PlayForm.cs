using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban_Assignment
{
    public partial class PlayForm : Form
    {
        /// <summary>
        /// Represents the Play Form instance.
        /// </summary>
        private static Form Instance;

        public PlayForm()
        {
            InitializeComponent();
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Represents the singleton pattern for the play form.
        /// </summary>
        /// <returns>The singleton of the play form.</returns>
        public static Form GetInstance() {
            if (Instance == null) {
                Instance = new PlayForm();
            }
            return Instance;
        }
    }
}
