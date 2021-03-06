using System;
using System.Collections.Generic;


/// <summary>A sample abstract class.</summary>
public abstract class Base
{
    /// <summary>Name of this object.</summary>
    public string name;

    /// <summary>Show the name and type of this object.</summary>
    /// <returns>A string containing this object's name and type.</returns>
    public override string ToString() {
        return String.Format("{0} is a {1}", this.name, this.GetType().Name);
    }
}


/// <summary>A sample interface for a breakable object.</summary>
public interface IBreakable
{
    /// <summary>How much damage this object can take before breaking.</summary>
    int durability { get; set; }

    /// <summary>Break this object as though it was damaged enough.</summary>
    void Break();
}

/// <summary>A sample interface for a collectible object.</summary>
public interface ICollectable
{
    /// <summary>Whether this object is being carried or is still to be found.</summary>
    bool isCollected { get; set; }

    /// <summary>Act as if this object has been picked up.</summary>
    void Collect();
}

/// <summary>A sample interface for an interactable object.</summary>
public interface IInteractive
{
    /// <summary>Perform the default interaction with this object.</summary>
    void Interact();
}


/// <summary>An openable door.</summary>
public class Door : Base, IInteractive
{
    /// <summary>Creates a door with a default name.</summary>
    /// <param name="name">The name of this object.</param>
    public Door(string name = "Door") {
        this.name = name;
    }

    /// <summary>Try to open this door.</summary>
    public void Interact() {
        Console.WriteLine("You try to open the {0}. It's locked.", this.name);
    }
}

/// <summary>A destructible decoration.</summary>
public class Decoration : Base, IBreakable, IInteractive
{
    /// <summary><see cref="IBreakable.durability"/></summary>
    public int durability { get; set; }

    /// <summary>Whether this item is essential to game progression.</summary>
    public bool isQuestItem;


    /// <summary>Creates a decoration with starting values for properties.</summary>
    /// <param name="name">The name of this item.</param>
    /// <param name="durability">The durability of this item.</param>
    /// <param name="questItem">Whether this is a quest item.</param>
    public Decoration(string name="Decoration", int durability=1, bool questItem=false) {
        if (durability < 1)
            throw new ArgumentException("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = questItem;
    }


    /// <summary>Inspect this item.</summary>
    public void Interact() {
        if (this.durability < 1)
            Console.WriteLine("The {0} has been broken.", this.name);
        else if (this.isQuestItem)
            Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
        else
            Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
    }

    /// <summary>Damage this item.</summary>
    public void Break() {
        this.durability--;
        if (this.durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", this.name);
        else if (this.durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", this.name);
        else
            Console.WriteLine("The {0} is already broken.", this.name);
    }
}

/// <summary>A collectible key.</summary>
public class Key : Base, ICollectable
{
    /// <summary>Whether this is a carried key or a hidden one.</summary>
    public bool isCollected { get; set; }

    /// <summary>Creates a key with starting values for properties.</summary>
    /// <param name="name">This object's name.</param>
    /// <param name="collected">Whether this object has been collected.</param>
    public Key(string name="Key", bool collected=false) {
        this.name = name;
        this.isCollected = collected;
    }

    /// <summary>Pick up this key.</summary>
    public void Collect() {
        if (this.isCollected)
            Console.WriteLine("You have already picked up the {0}.", this.name);
        else
            Console.WriteLine("You pick up the {0}.", this.name);
        this.isCollected = true;
    }
}

/// <summary>Stores the list of objects in a room.</summary>
public class RoomObjects
{
    /// <summary>Act upon all objects in a room.</summary>
    /// <param name="roomObjects">The list of objects in the room.</param>
    /// <param name="type">Which type of object to call functions on.</param>
    public static void IterateAction(List<Base> roomObjects, Type type) {
        foreach (Base obj in roomObjects) {
            if (type.IsInstanceOfType(obj)) {
                if (type == typeof(IBreakable))
                    ((IBreakable)obj).Break();
                if (type == typeof(ICollectable))
                    ((ICollectable)obj).Collect();
                if (type == typeof(IInteractive))
                    ((IInteractive)obj).Interact();
            }
        }
    }
}
