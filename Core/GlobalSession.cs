namespace WrapBlox.Core;

public static class GlobalSession
{
    public static Session? Assigned { get; set; }

    public static void Assign(Session session)
    {
        if (session.Equals(Assigned))
            throw new InvalidOperationException("The provided session is already the currently assigned global session.");
        
        if (!session.IsAuthenticated)
            throw new InvalidOperationException("The provided session is not authenticated.");
        
        Assigned = session;
    }
}