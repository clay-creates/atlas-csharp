using System;

namespace Enemies
{
    /// <summary>
    /// This class represents a zombie enemy.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Creates the health field for zombies.
        /// </summary>
        private int health;
        /// <summary>
        /// Creates name for Zombies.
        /// </summary>
        private string name = "(No name)";
        /// <summary>
        /// Creates new instance of Zombie class.
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }
        /// <summary>
        /// Public constructor of Zombie.
        /// </summary>
        /// <param name="value"></param>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }
        /// <summary>
        /// Gets or sets name of zombie
        /// </summary>
        /// <value></value>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Returns health of Zombie object
        /// </summary>
        /// <returns></returns>
        public int GetHealth()
        {
            return this.health;
        }

        /// <summary>
        /// Prints zombie name and health
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Zombie Name: {this.Name} / Total Health: {this.GetHealth()}";
        }
    }
}
