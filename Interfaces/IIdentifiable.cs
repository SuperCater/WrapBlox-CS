namespace WrapBlox.Interfaces;

public interface IIdentifiable<out T>
{
    public T Id { get; }
    public string Url { get; }
}