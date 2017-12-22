using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_079 : SimTemplate //* Mysterious Challenger
	{
		//Battlecry: Put one of each Secret from your deck into the battlefield.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            Probabilitymaker pm = Probabilitymaker.Instance;
            if (own.own)
            {
                if (p.ownSecretsIDList.Count <= 4 && pm.isAllowedSecret(CardDB.cardIDEnum.EX1_130) && !p.ownSecretsIDList.Contains(CardDB.cardIDEnum.EX1_130)) p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_130);
                if (p.ownSecretsIDList.Count <= 4 && pm.isAllowedSecret(CardDB.cardIDEnum.EX1_136) && !p.ownSecretsIDList.Contains(CardDB.cardIDEnum.EX1_136)) p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_136);
                if (p.ownSecretsIDList.Count <= 4 && pm.isAllowedSecret(CardDB.cardIDEnum.FP1_020) && !p.ownSecretsIDList.Contains(CardDB.cardIDEnum.FP1_020)) p.ownSecretsIDList.Add(CardDB.cardIDEnum.FP1_020);
                if (p.ownSecretsIDList.Count <= 4 && pm.isAllowedSecret(CardDB.cardIDEnum.EX1_132) && !p.ownSecretsIDList.Contains(CardDB.cardIDEnum.EX1_132)) p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_132);
                if (p.ownSecretsIDList.Count <= 4 && pm.isAllowedSecret(CardDB.cardIDEnum.EX1_379) && !p.ownSecretsIDList.Contains(CardDB.cardIDEnum.EX1_379)) p.ownSecretsIDList.Add(CardDB.cardIDEnum.EX1_379);
                if (p.ownSecretsIDList.Count <= 4 && pm.isAllowedSecret(CardDB.cardIDEnum.AT_073) && !p.ownSecretsIDList.Contains(CardDB.cardIDEnum.AT_073)) p.ownSecretsIDList.Add(CardDB.cardIDEnum.AT_073);                    
            }
            else
            {
                for (int i = p.enemySecretCount; i < 5; i++)
                {
                    p.enemySecretCount++;
                    p.enemySecretList.Add(pm.getNewSecretGuessedItem(p.getNextEntity(), p.enemyHeroStartClass));
                }
            }
        }
	}
}