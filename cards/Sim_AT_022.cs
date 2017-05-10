using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_022 : SimTemplate //* Fist of Jaraxxus
	{
		//When you play or discard this, deal 4 damage to a random enemy.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);

            if (ownplay)
            {
                target = p.getEnemyCharTargetForRandomSingleDamage(dmg);
            }
            else
            {
                target = p.searchRandomMinion(p.ownMinions, Playfield.searchmode.searchLowestHP); //(pessimistic)
                if (target == null) target = p.ownHero;
            }
            p.minionGetDamageOrHeal(target, dmg);
        }

        public override bool onCardDicscard(Playfield p, Minion own, int num, bool check)
        {
            if (check) return true;

            bool ownplay = true;
            if (own != null) ownplay = own.own;
            Minion target = null;
            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);

            if (ownplay)
            {
                target = p.getEnemyCharTargetForRandomSingleDamage(dmg);
            }
            else
            {
                target = p.searchRandomMinion(p.ownMinions, Playfield.searchmode.searchLowestHP); //(pessimistic)
                if (target == null) target = p.ownHero;
            }
            p.minionGetDamageOrHeal(target, dmg);
            return true;
        }
    }
}