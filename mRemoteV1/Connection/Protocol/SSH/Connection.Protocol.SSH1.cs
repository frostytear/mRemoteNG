

namespace mRemoteNG.Connection.Protocol.SSH
{
	public class ProtocolSSH1 : PuttyBase
	{
				
		public ProtocolSSH1(IConnectionsService connectionsService) : base(connectionsService)
		{
			this.PuttyProtocol = Putty_Protocol.ssh;
			this.PuttySSHVersion = Putty_SSHVersion.ssh1;
		}
				
		public enum Defaults
		{
			Port = 22
		}
	}
}