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
