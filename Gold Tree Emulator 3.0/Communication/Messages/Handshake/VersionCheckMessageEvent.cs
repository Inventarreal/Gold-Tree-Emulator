using System;
using GoldTree.HabboHotel.GameClients;
using GoldTree.Messages;
namespace GoldTree.Communication.Messages.Handshake
{
	internal sealed class VersionCheckMessageEvent : Interface
	{
		public void Handle(GameClient Session, ClientMessage Event)
		{
		}
	}
}
