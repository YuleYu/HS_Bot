using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_099 : SimTemplate //* Kodorider
	{
		//Inspire: Summon a 3/5 War Kodo.

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_099t); //War Kodo
		
		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
                int place = (own) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(kid, place, own);
			}
        }
	}
}