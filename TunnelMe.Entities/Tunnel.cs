namespace TunnelMe.Entities;

public class Tunnel
{
    public Server TunnelServer { get; set; }
    public Uri LocalAddress { get; set; }
    public Uri RemoteAddress { get; set; }
}
