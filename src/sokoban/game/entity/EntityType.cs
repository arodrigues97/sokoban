using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_Assignment.src.sokoban.game {
    
    /// <summary>
    /// Represents an Entity Type.
    /// </summary>
   public enum EntityType {
        NONE = 0,
        HERO = 1,
        WALL = 2,
        DESTINATION = 3,
        BOX = 4
    }
}
