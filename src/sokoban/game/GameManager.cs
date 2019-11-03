using Sokoban_Assignment.src.sokoban.game.entity.hero;
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
        private GameState gameState;

        /// <summary>
        /// Represents the GameMap used for either designing or playing.
        /// </summary>
        private GameMap gameMap;

        /// <summary>
        /// Represents the Hero instance used while playing.
        /// </summary>
        private Hero hero;

        /// <summary>
        /// Creates a map based off a number of rows and columns.
        /// </summary>
        /// <param name="rows">The amount of rows.</param>
        /// <param name="columns">The amount of columns.</param>
        public void CreateMap(int rows, int columns) {
            gameMap = new GameMap(rows, columns);
        }

        /// <summary>
        /// Unloads the Game Manager.
        /// </summary>
        public void Unload() {
            gameMap = null;
            hero = null;
            if (gameState == GameState.PLAY)  {
                PlayForm playForm = (PlayForm)SokobanProgram.getFormFromState(GameState.PLAY);
                playForm.numberOfPushesLabel.Text = "Number of Pushes: 0";
                playForm.numberOfMovesLabel.Text = "Number of Moves: 0";
            }
        }

        /// <summary>
        /// Sets the new Game State.
        /// </summary>
        /// <param name="gameState">The game state to set.</param>
        public void SetGameState(GameState gameState) {
            this.gameState = gameState;
        }

        /// <summary>
        /// Sets the Hero instance.
        /// </summary>
        /// <param name="hero">The hero instance.</param>
        public void SetHero(Hero hero) {
            this.hero = hero;
        }

        /// <summary>
        /// Gets the Heroo Instance.
        /// </summary>
        /// <returns>The Hero.</returns>
        public Hero GetHero() {
            return hero;
        }

        /// <summary>
        /// Checks if the Game Map is created.
        /// </summary>
        /// <returns>True if created, false if not.</returns>
        public bool IsMapCreated() {
            return gameMap != null;
        }

        /// <summary>
        /// Gets the Game State.
        /// </summary>
        /// <returns>The Game State.</returns>
        public GameState GetGameState()  {
            return gameState;
        }
        
        /// <summary>
        /// Gets the Game Map.
        /// </summary>
        /// <returns>The Game Map.</returns>
        public GameMap GetGameMap() {
            return gameMap;
        }

    }
}
