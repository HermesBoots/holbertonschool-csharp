using System;

namespace Enemies
{
    /// <summary>Represents a zombie enemy.</summary>
    class Zombie
    {
        // remaining health
        private int health;
        // displayed name
        private string name = "(No name)";

        /// <summary>Gets and sets this zombie's displayed name.</summary>
        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>Get a nicely-formatted description of this enemy.</summary>
        /// <returns>A description of this object's fields.</returns>
        public override string ToString()
        {
            return $"Zombie name: {this.name} / Total Health: {this.health}";
        }

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
