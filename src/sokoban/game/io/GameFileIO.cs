using Sokoban_Assignment.src.sokoban.game.entity;
using Sokoban_Assignment.src.sokoban.game.entity.hero;
using Sokoban_Assignment.src.sokoban.game.map;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_Assignment.src.sokoban.game.io {

    /// <summary>
    /// A utility class used for handling the I/O of game map files. 
    /// </summary>
    public class GameFileIO {

        /// <summary>
        /// The base file name we use. 
        /// </summary>
        public const String FileName = "sokobanmap";

        /// <summary>
        /// The file extension we use.
        /// </summary>
        public const String FileExtension = ".txt";

        /// <summary>
        /// The stream writer field to use.
        /// </summary>
        private static StreamWriter writer;

        /// <summary>
        /// The stream reader field to use.
        /// </summary>
        private static StreamReader reader;

        /// <summary>
        /// Writes out a game map file.
        /// </summary>
        /// <param name="path">The path of the file.</param>
        public static void WriteGameFile(String path) {
            GameMap map = SokobanProgram.GetGameManager().GetGameMap();
            MapLocation maploc;
            using (writer = new StreamWriter(path)) {
                //Write the dimensions of the map array
                writer.Write(map.GetRowLength() + ",");
                writer.Write(map.GetColumnLength());
                writer.WriteLine();
                for (int row = 0; row < map.GetRowLength(); row++) {
                    for (int col = 0; col < map.GetColumnLength(); col++) {
                        maploc = map.GetMap()[row, col];
                        writer.Write(row + "," + col + ",");
                        writer.Write(maploc.GetEntitys().Count + (maploc.GetEntitys().Count > 0 ? "," : ""));
                        Entity entity;
                        for (int i = 0; i < maploc.GetEntitys().Count; i++) {
                            entity = maploc.GetEntitys()[i];
                            writer.Write((int) entity.GetEntityType() + (i + 1 != maploc.GetEntitys().Count ? "," : ""));
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        /// <summary>
        /// Reads a game map file from a path.
        /// </summary>
        /// <param name="path">The path to read.</param>
        public static void ReadGameFile(String path) {
            try {
                EntityType[] types = (EntityType[])Enum.GetValues(typeof(EntityType));
                using (reader = new StreamReader(path)) {
                    String line;
                    String[] tokens;
                    Entity entity;
                    int count = 0;
                    while ((line = reader.ReadLine()) != null) {
                        switch (count) {
                            case 0:
                                tokens = line.Split(',');
                                int rows = Int32.Parse(tokens[0]);
                                int columns = Int32.Parse(tokens[1]);
                                SokobanProgram.GetGameManager().CreateMap(rows, columns);
                                break;
                            default:
                                tokens = line.Split(',');
                                int row = Int32.Parse(tokens[0]);
                                int col = Int32.Parse(tokens[1]);
                                int size = Int32.Parse(tokens[2]);
                                int entityIndex;
                                int entityId;
                                if (size > 0) {
                                    for (int i = 0; i < size; i++) {
                                        entityIndex = 3 + i;
                                        entityId = Int32.Parse(tokens[entityIndex]);
                                        entity = Entity.GetEntityByType(types[entityId]);
                                        if (entity == null) {
                                            Console.WriteLine("Error reading entity opcode for " + tokens[i] + ", entityIndex=" + entityIndex);
                                            continue;
                                        }
                                        if (SokobanProgram.GetGameManager().GetGameState() == GameState.PLAY && types[entityId] == EntityType.HERO) {
                                            SokobanProgram.GetGameManager().SetHero((Hero) entity);
                                            Console.WriteLine("Set Hero Instance in Game Manager");
                                        }
                                        Console.WriteLine("Adding entity to " + row + ", " + col + ", " + entity);
                                        SokobanProgram.GetGameManager().GetGameMap().GetMap()[row, col].AddEntity(entity);
                                    }
                                }
                                break;
                        }
                        count++;
                    }
                }
            } catch (IOException io) {
                Console.WriteLine(io.Message);
            }
        }
    }
}
