using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AT_050 : SimTemplate //* Charged Hammer
    {
        //Deathrattle: Your Hero Power becomes 'Deal 2 damage.'

        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_050);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }

        public override void onDeathrattle(Playfield p, Minion m)
        {
			CardDB.Card hewHeroPower = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_050t); //Lightning Jolt
            if (m.own)
            {
                p.ownHeroAblility.card = hewHeroPower;
                p.ownHeroPowerAllowedQuantity++;
                p.ownAbilityReady = true;
            }
            else
            {
                p.enemyHeroAblility.card = hewHeroPower;
                p.enemyHeroPowerAllowedQuantity++;
                p.enemyAbilityReady = true;
            }
        }
    }
}