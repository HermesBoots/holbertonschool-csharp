using System;


/// <summary>Represents tiers of effects on HP.</summary>
public enum Modifier
{
    /// <summary>An effect half as strong as normal.</summary>
    Weak,
    /// <summary>An effect with normal strength.</summary>
    Base,
    /// <summary>An effect with 50% more strength than normal.</summary>
    Strong
}

/// <summary>Type of method that applies effects based on the tier.</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);


/// <summary>The player-controlled avatar.</summary>
public class Player
{
    /// <summary>Delegate type used to affect player health.</summary>
    public delegate void CalculateHealth(float amount);

    /// <summary>The player character's name.</summary>
    private string name;

    /// <summary>The maximum hit points of the player.</summary>
    private float maxHp;
    /// <summary>The current hit points of the player.</summary>
    private float hp;

    /// <summary>Create a player with given default values.</summary>
    /// <param name="name">The player character's name.</param>
    /// <param name="maxHp">The initial max. HP.</param>
    public Player(string name="Player", float maxHp=100f) {
        this.name = name;
        if (maxHp < 1) {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        else
            this.maxHp = maxHp;
        this.hp = this.maxHp;
    }

    /// <summary>Change the value of an effect based on a tier modifier.</summary>
    /// <param name="baseValue">The original value of the effect.</param>
    /// <param name="modifier">Which modifier to apply.</param>
    /// <returns>New value for the effect.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier) {
        switch (modifier) {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return baseValue;
        }
    }

    /// <summary>Heal the player.</summary>
    /// <param name="heal">Amount to heal player by.</param>
    public void HealDamage(float heal) {
        if (heal < 0)
            heal = 0;
        Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        if (this.hp >= 0)
            this.ValidateHP(this.hp + heal);
    }

    /// <summary>Prints the health of the player.</summary>
    public void PrintHealth() {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }

    /// <summary>Damage the player.</summary>
    /// <param name="damage">Amount of damage to deal.</param>
    public void TakeDamage(float damage) {
        if (damage < 0)
            damage = 0;
        Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        if (this.hp >= 0)
            this.ValidateHP(this.hp - damage);
    }

    /// <summary>Update player HP if possible.</summary>
    /// <param name="newHp">New amount to set as player's HP.</param>
    public void ValidateHP(float newHp) {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
    }
}
