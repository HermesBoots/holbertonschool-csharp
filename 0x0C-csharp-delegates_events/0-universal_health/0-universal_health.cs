using System;


/// <summary>The player-controlled avatar.</summary>
public class Player
{
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

    /// <summary>Prints the health of the player.</summary>
    public void PrintHealth() {
        Console.WriteLine("{0} has {1} / {2} health.", this.name, this.hp, this.maxHp);
    }
}
