using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_042b : SimTemplate //* Panther Form
	{
		//Transform into a +1/+1 and Stealth
		
        CardDB.Card Stealth = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_042t2);
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionTransform(own, Stealth);
        }
	}
}