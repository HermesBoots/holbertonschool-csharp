using System;


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
