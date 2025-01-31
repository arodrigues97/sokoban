﻿using Sokoban_Assignment.src.sokoban.game.entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban_Assignment.src.sokoban.game.map {

    /// <summary>
    /// A wrapper class for a location and entitys on the locaton. Rectangle and a list of Entitys make
    /// up the objects being wrapped together in this instance.
    /// </summary>
    public class MapLocation {

        /// <summary>
        /// Represents the list of entities on a map location.
        /// </summary>
        private readonly List<Entity> Entitys = new List<Entity>();

        /// <summary>
        /// Represents the Rectangle (x,y width and height) of the location.
        /// </summary>
        private Rectangle Rectangle;

        /// <summary>
        /// The row index.
        /// </summary>
        private int row;

        /// <summary>
        /// The column index.
        /// </summary>
        private int column;

        /// <summary>
        /// Constructa a new MapLocation.
        /// </summary>
        /// <param name="rectangle">The rectangle of the location.</param>
        public MapLocation(int row, int column, Rectangle rectangle) {
            this.row = row;
            this.column = column;
            this.Rectangle = rectangle;
        }

        /// <summary>
        /// Add's an entity to the loca
        /// </summary>
        /// <param name="entity"></param>
        public void AddEntity(Entity entity) {
            entity.SetLocation(this);
            Entitys.Add(entity);
        }

        /// <summary>
        /// Checks if the map location has an entity type.
        /// </summary>
        /// <param name="type">The entity type.</param>
        /// <returns>True if found.</returns>
        public bool HasEntityType(EntityType type) {
            foreach (Entity e in Entitys) {
                if (e.GetEntityType() == type)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Removes an Entity from the Map.
        /// </summary>
        /// <param name="entity">The entity to remove.</param>
        /// <returns>True if removed else False.</returns>
        public bool RemoveEntity(Entity entity) {
            if (Entitys.Contains(entity)) {
                entity.SetLocation(null);
                return Entitys.Remove(entity);
            }
            return false;
        }

        /// <summary>
        /// Clears the Entities on the map location.
        /// </summary>
        public void ClearEntities() {
            Entitys.Clear();
        }

        /// <summary>
        /// Checks if the map location has entities.
        /// </summary>
        /// <returns></returns>
        public bool HasEntitys() {
            return Entitys.Count > 0;
        }

        /// <summary>
        /// Gets the List of entities.
        /// </summary>
        /// <returns>The entity list.</returns>
        public List<Entity> GetEntitys() {
            return Entitys;
        }

        /// <summary>
        /// Gets the Row index.
        /// </summary>
        /// <returns>The Row index.</returns>
        public int GetRow() {
            return row;
        }

        /// <summary>
        /// Gets the Column index.
        /// </summary>
        /// <returns>The column index.</returns>
        public int GetColumn() {
            return column;
        }

        /// <summary>
        /// Gets the Rectangle instance on the map.
        /// </summary>
        /// <returns></returns>
        public Rectangle GetRectangle() {
            return Rectangle;
        }

    }
}
