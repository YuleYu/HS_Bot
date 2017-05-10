using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AT_021 : SimTemplate //* Tiny Knight of Evil
	{
        //Whenever you discard a card, gain +1/+1.
        //Only on the board
        public override bool onCardDicscard(Playfield p, Minion own, int num, bool check)
        {
            if (own == null) return false;
            if (check) return false;

            p.minionGetBuffed(own, num, num);
            return false;
        }
    }
}