using Sokoban_Assignment.src.sokoban.game;
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

namespace Sokoban_Assignment {
    
    /// <summary>
    /// Represents the form used for the Design screen of the game.
    /// </summary>
    public partial class DesignForm : Form {

        /// <summary>
        /// The entity type selected.
        /// </summary>
        private EntityType EntityType;

        /// <summary>
        /// Represents the Design Form instance.
        /// </summary>
        private static Form Instance;

        /// <summary>
        /// Constructs a new Design Form instance.
        /// </summary>
        public DesignForm() {
            InitializeComponent();
        }

        /// <summary>
        /// The method called when the design form loads.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void DesignForm_Load(object sender, EventArgs e) {
            Timer timer = new Timer();
            timer.Interval = (20);
            timer.Tick += new EventHandler(Tick);
            timer.Start();
            DoubleBuffered = true;
        }

        /// <summary>
        /// The method called when the generate button is clicked.
        /// </summary>
        /// <param name="sender">The object sender.</param>
        /// <param name="e">The event arguments.</param>
        private void GenerateButton_Click(object sender, EventArgs e)  {
            if (SokobanProgram.GetGameManager().IsMapCreated()) {
                DialogResult dialogResult = MessageBox.Show("Do you want to create a new map? The changes wont be saved for this one. Click file -> save to save changes.", "Do you want to create a new map?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No) {
                    return;
                }
            }
            int rows = (int)RowCountButton.Value;
            int columns = (int)ColumnCountButton.Value;
            if (rows > 27 || columns > 16)   {
                MessageBox.Show("You can't have more than 27 rows or more than 16 columns.");
                return;
            }
            SokobanProgram.GetGameManager().CreateMap(rows, columns);
            Invalidate();
        }

        /// <summary>
        /// The method called when the timer event is executed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void Tick(object sender, EventArgs e) {
            Refresh();
        }

        /// <summary>
        /// The paint event method for re-painting the design grid panel.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void designPanelPaint(object sender, PaintEventArgs e) {
            if (SokobanProgram.GetGameManager().IsMapCreated())
            {
                SokobanProgram.GetGameManager().GetGameMap().DrawMap(e.Graphics);
            }
        }

        /// <summary>
        /// The event called when the grid panel is clicked.
        /// </summary>
        /// <param name="sender">The object sender.</param>
        /// <param name="e">The mouse event arguments.</param>
        private void GridMouseClick(object sender, MouseEventArgs e) {
            if (SokobanProgram.GetGameManager().IsMapCreated()) {
                SokobanProgram.GetGameManager().GetGameMap().Click(e);
            }
        }

        /// <summary>
        /// The method called when "none" is selected on the tool box.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void NoneRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (noneRadioButton.Checked) {
                EntityType = EntityType.NONE;
            }
        }

        /// <summary>
        /// The method called when "hero" is selected on the tool box.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void HeroButton_CheckedChanged(object sender, EventArgs e) {
            if(heroButton.Checked) {
                EntityType = EntityType.HERO;
            }
        }

        /// <summary>
        /// The method called when the "wall" tool is selected.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void WallButton_CheckedChanged(object sender, EventArgs e) {
            if (wallButton.Checked) {
                EntityType = EntityType.WALL;
            }
        }

        /// <summary>
        /// The method called when the "box" button is selected for the tool box.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void BoxButton_CheckedChanged(object sender, EventArgs e) {
            if (boxButton.Checked) {
                EntityType = EntityType.BOX;
            }
        }

        /// <summary>
        /// The method called when the "destination" tool is selected.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void DestinationButton_CheckedChanged(object sender, EventArgs e) {
            if (destinationButton.Checked) {
                EntityType = EntityType.DESTINATION;
            }
        }

        /// <summary>
        /// The method called when the "save" option is clicked under the file menu.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = GameFileIO.FileName + GameFileIO.FileExtension;
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK) {
                if (save.FileName != "") {
                    GameFileIO.WriteGameFile(save.FileName);
                    MessageBox.Show("The file has been saved!");
                } else {
                    MessageBox.Show("The file has to have a name in order to be saved.");
                }
            }
        }

        /// <summary>
        /// The method called when the "exit" option is clicked under the file menu.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e) {
            SokobanProgram.GetGameManager().Unload();
            SokobanProgram.OpenGameState(GameState.SELECTION);
        }

        /// <summary>
        /// The method called when the "open" option is clicked under the file menu.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog() {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };
            if (dlg.ShowDialog() == DialogResult.OK) {
                GameFileIO.ReadGameFile(dlg.FileName);
            }
        }

        /// <summary>
        /// Gets the Entity Type selected.
        /// </summary>
        /// <returns>The Entity Type.</returns>
        public EntityType GetToolType() {
            return EntityType;
        }

        /// <summary>
        /// Represents the singleton pattern for the design form.
        /// </summary>
        /// <returns>The singleton of the design form.</returns>
        public static Form GetInstance() {
            if (Instance == null) {
                Instance = new DesignForm();
            }
            return Instance;
        }
    }
}
