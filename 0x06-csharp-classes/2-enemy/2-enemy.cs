using System;

namespace Enemies
{
    /// <summary>Represents a zombie enemy.</summary>
    class Zombie
    {
        /// <summary>Remaining health points.</summary>
        public int health;

        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class with default health.</summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class with specified health.</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            this.health = value;
        }
    }
}
