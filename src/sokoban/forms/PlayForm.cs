using Sokoban_Assignment.src.sokoban.game.entity.hero;
using Sokoban_Assignment.src.sokoban.game.io;
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
            Timer timer = new Timer();
            timer.Interval = (20);
            timer.Tick += new EventHandler(Tick);
            timer.Start();
            DoubleBuffered = true;
        }

        /// <summary>
        /// The method called when the timer event is executed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void Tick(object sender, EventArgs e)
        {
            Refresh();
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


        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                GameFileIO.ReadGameFile(dlg.FileName);
            }
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            handleMoveClick(Direction.NORTH);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            handleMoveClick(Direction.WEST);
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            handleMoveClick(Direction.SOUTH);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            handleMoveClick(Direction.EAST);
        }

        private void handleMoveClick(Direction direction) 
        {
            SokobanProgram.GetGameManager().GetGameMap().HandleMoveClick(direction);
        }

        private void playPanelPaint(object sender, PaintEventArgs e)
        {
            if (SokobanProgram.GetGameManager().IsMapCreated())
            {
                SokobanProgram.GetGameManager().GetGameMap().DrawMap(e.Graphics);
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SokobanProgram.GetGameManager().Unload();
            SokobanProgram.OpenGameState(GameState.SELECTION);
        }

    
    }

  
}


