using System;

namespace Enemies
{
    /// <summary>
    /// This class represents a zombie enemy.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// This variable creates the health field for zombies.
        /// </summary>
        public int health;
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
        /// Returns health of Zombie object
        /// </summary>
        /// <returns></returns>
        public int GetHealth()
        {
            return this.health;
        }
    }
}
