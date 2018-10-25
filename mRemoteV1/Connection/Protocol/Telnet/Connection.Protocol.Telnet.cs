namespace mRemoteNG.Connection.Protocol.Telnet
{
	public class ProtocolTelnet : PuttyBase
	{
				
		public ProtocolTelnet(IConnectionsService connectionsService) : base(connectionsService)
		{
			this.PuttyProtocol = Putty_Protocol.telnet;
		}
				
		public enum Defaults
		{
			Port = 23
		}
	}
}