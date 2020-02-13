using System;

namespace Enemies
{
    class Zombie
    {
        private int health;
        private string name = "(No name)";

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            return $"Zombie name: {this.name} / Total Health: {this.health}";
        }

        public Zombie()
        {
            this.health = 0;
        }
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            this.health = value;
        }

        public int GetHealth()
        {
            return this.health;
        }
    }
}
