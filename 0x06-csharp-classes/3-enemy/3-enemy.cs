using System;

namespace Enemies
{
    /// <summary>Represents a zombie enemy.</summary>
    class Zombie
    {
        // remaining health points
        private int health;

        /// <summary>Initializes a new <see cref="Zombie"/> instance with default health.</summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>Initializes a new <see cref="Zombie"/> instance with specified health.</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            this.health = value;
        }

        /// <summary>Gets the zombie's remaining health.</summary>
        /// <returns>The zombie's remaining health.</returns>
        public int GetHealth()
        {
            return this.health;
        }
    }
}
