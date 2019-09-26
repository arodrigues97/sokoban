using Sokoban_Assignment.src.sokoban.game.entity.box;
using Sokoban_Assignment.src.sokoban.game.entity.endpoint;
using Sokoban_Assignment.src.sokoban.game.entity.hero;
using Sokoban_Assignment.src.sokoban.game.entity.wall;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_Assignment.src.sokoban.game.entity {
    /// <summary>
    /// Represents an Entity in the game.
    /// </summary>
    public abstract class Entity {

        /// <summary>
        /// Draws the Entity Graphics.
        /// </summary>
        /// <param name="g">The graphics instance being used.</param>
        /// <param name="rectangle">The rectangle we're drawing inside of.</param>
        public abstract void Draw(Graphics g, Rectangle rectangle);

        /// <summary>
        /// Gets the Enum Entity Type.
        /// </summary>
        /// <returns>The EntityType.</returns>
        public abstract EntityType GetEntityType();

        /// <summary>
        /// Gets a new Entity instance by the entity type index.
        /// </summary>
        /// <param name="index">The index of the Entity in the enum values.</param>
        /// <returns></returns>
        public static Entity GetEntityByType(EntityType type) {
            switch (type) {
                case EntityType.HERO:
                    return new Hero();
                case EntityType.WALL:
                    return new Wall();
                case EntityType.DESTINATION:
                    return new Destination();
                case EntityType.BOX:
                    return new Box();
                default:
                    return null;
            }
        }
    }
}

