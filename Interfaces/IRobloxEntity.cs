using WrapBlox.Core;

namespace WrapBlox.Interfaces;

public interface IRobloxEntity
{
    public string BaseUrl { get; }
    public Session? Session { get; set; }

    public async Task AttachSession(Session session)
    {
        Session = session;

        if (this is IRefreshable refreshable)
        {
            await refreshable.RefreshAsync();
        }
    }

    public void DetachSession(Session session)
    {
        Session = null;
    }
}