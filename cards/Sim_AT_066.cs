using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_066 : SimTemplate //* Orgrimmar Aspirant
	{
		//Inspire: Give your weapon +1 Attack.

		public override void onInspire(Playfield p, Minion m, bool own)
        {
			if (m.own == own)
			{
                if (own)
                {
                    if (p.ownWeaponDurability > 0) p.ownWeaponAttack++;
                }
                else
                {
                    if (p.enemyWeaponDurability > 0) p.enemyWeaponAttack++;
                }
			}
        }
	}
}