namespace WrapBlox.Interfaces;

public interface IUser
{
    /// <summary>
    /// The unique identifier of the user.
    /// </summary>
    public ulong Id { get; }
    
    /// <summary>
    /// The name of the user.
    /// <remarks>A User's name must be between 3 and 20 characters. Users that had their name reset may exceed this limit (roblox_user_8389398339).</remarks>
    /// </summary>
    public string Name { get; }
    
    /// <summary>
    /// The display name of the user.
    /// <remarks>A user's display name must be between 3 and 20 characters.</remarks>
    /// </summary>
    public string DisplayName { get; }
}