using Sokoban_Assignment.src.sokoban.game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban_Assignment {

    /// <summary>
    /// Represents the main class of the program where the entry point resides.
    /// </summary>
    public static class SokobanProgram {

        /// <summary>
        /// Represents the Game Manager instance.
        /// </summary>
        private static GameManager GameManager = new GameManager();

        /// <summary>
        /// Represents the Current Form instance.
        /// </summary>
        private static Form CurrentForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OpenGameState(GameState.SELECTION, true);
        }

        /// <summary>
        /// A method used to open a game state.
        /// </summary>
        /// <param name="state">The state to open.</param>
        /// <param name="initialize">If we're initializing the game with the state to begin with.</param>
        public static void OpenGameState(GameState state, bool initialize = false) {
            if (!initialize && state == GameManager.GetGameState()) {
                Console.WriteLine("Error: GameState is already set to " + state + ".");
                return;
            }
            Form NewForm = getFormFromState(state);
            if (!initialize)  {
                CurrentForm.Hide();
                CurrentForm = NewForm;
                Console.WriteLine("Opening Game State: " + state + ", form=" + CurrentForm.ToString());
            } else {
                CurrentForm = NewForm;
                Application.Run(NewForm);
                Console.WriteLine("Initializing Game State: " + state + ", form=" + CurrentForm.ToString());
            }
            NewForm.Show();
            GameManager.SetGameState(state);
        }

        /// <summary>
        /// Gets the Form to use from the GameState specified.
        /// </summary>
        /// <param name="state">The game state to use for the condition.</param>
        /// <returns>The form to use.</returns>
        public static Form getFormFromState(GameState state) {
            return state == GameState.DESIGN ? DesignForm.GetInstance() : state == GameState.PLAY ? PlayForm.GetInstance() : SelectionForm.GetInstance();
        }

        /// <summary>
        /// Gets the Game Manager instance.
        /// </summary>
        /// <returns>The game manager instance.</returns>
        public static GameManager GetGameManager() {
            return GameManager;
        }
    }
}
