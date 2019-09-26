using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban_Assignment.src.sokoban.game {

    /// <summary>
    /// Represents the Game Manager class the main entry access to all game related actors.
    /// </summary>
    public class GameManager {

        /// <summary>
        /// Represents the current state of the game.
        /// </summary>
        private GameState GameState;

        /// <summary>
        /// Represents the GameMap used for either designing or playing.
        /// </summary>
        private GameMap GameMap;

        /// <summary>
        /// Creates a map based off a number of rows and columns.
        /// </summary>
        /// <param name="rows">The amount of rows.</param>
        /// <param name="columns">The amount of columns.</param>
        public void CreateMap(int rows, int columns) {
            GameMap = new GameMap(rows, columns);
        }

        /// <summary>
        /// Sets the new Game State.
        /// </summary>
        /// <param name="gameState">The game state to set.</param>
        public void SetGameState(GameState gameState) {
            this.GameState = gameState;
        }

        /// <summary>
        /// Checks if the Game Map is created.
        /// </summary>
        /// <returns>True if created, false if not.</returns>
        public bool IsMapCreated() {
            return GameMap != null;
        }

        /// <summary>
        /// Gets the Game State.
        /// </summary>
        /// <returns>The Game State.</returns>
        public GameState GetGameState()  {
            return GameState;
        }
        
        /// <summary>
        /// Gets the Game Map.
        /// </summary>
        /// <returns>The Game Map.</returns>
        public GameMap GetGameMap() {
            return GameMap;
        }

    }
}
