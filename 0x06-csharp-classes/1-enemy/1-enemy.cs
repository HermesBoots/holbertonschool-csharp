namespace Enemies
{
    /// <summary>Records health of an enemy zombie.</summary>
    class Zombie
    {
        /// <summary>The zombie's remaining health points.</summary>
        public int health;

        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class with a default health of 0.</summary>
        public Zombie()
        {
            this.health = 0;
        }
    }
}
