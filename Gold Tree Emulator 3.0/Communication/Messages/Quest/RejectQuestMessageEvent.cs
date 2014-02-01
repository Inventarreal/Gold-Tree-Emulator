using System;
using GoldTree.HabboHotel.GameClients;
using GoldTree.Messages;
namespace GoldTree.Communication.Messages.Quest
{
	internal sealed class RejectQuestMessageEvent : Interface
	{
		public void Handle(GameClient Session, ClientMessage Event)
		{
			GoldTree.GetGame().GetQuestManager().method_7(0u, Session);
		}
	}
}
