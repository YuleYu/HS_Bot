using Triton.Game.Mapping;

namespace HREngine.Bots
{
    using System;
    using System.Collections.Generic;

    public class miniEnch
    {
        public CardDB.cardIDEnum CARDID = CardDB.cardIDEnum.None;
        public int creator = 0; // the minion
        public int controllerOfCreator = 0; // own or enemys buff?
        public int copyDeathrattle = 0;

        public miniEnch(CardDB.cardIDEnum id, int crtr, int controler, int copydr)
        {
            this.CARDID = id;
            this.creator = crtr;
            this.controllerOfCreator = controler;
            this.copyDeathrattle = copydr;
        }

    }

    public class Minion
    {
        //dont silence----------------------------
        public int anzGotDmg = 0;
        public int GotDmgValue = 0;
        public int anzGotHealed = 0;
        public bool gotInspire = false;
        public bool isHero = false;
        public bool own;
        public int pID = 0;

        public CardDB.cardName name = CardDB.cardName.unknown;
        public TAG_CLASS cardClass = TAG_CLASS.INVALID;
        public int synergy = 0;
        public Handmanager.Handcard handcard;
        public int entitiyID = -1;
        //public int id = -1;//delete this
        public int zonepos = 0;
        public CardDB.Card deathrattle2;

        public bool playedThisTurn = false;
        public bool playedPrevTurn = false;
        public int numAttacksThisTurn = 0;
        public bool immuneWhileAttacking = false;

        public bool allreadyAttacked = false;

        
        public bool shadowmadnessed = false;//´can be silenced :D

        public bool destroyOnOwnTurnStart = false; // depends on own!
        public bool destroyOnEnemyTurnStart = false; // depends on own!
        public bool destroyOnOwnTurnEnd = false; // depends on own!
        public bool destroyOnEnemyTurnEnd = false; // depends on own!

        public bool concedal = false;
        public int ancestralspirit = 0;
        public int souloftheforest = 0;
        public int explorershat = 0;
        public int infest = 0;

        public int ownBlessingOfWisdom = 0;
        public int enemyBlessingOfWisdom = 0;
        public int ownPowerWordGlory = 0;
        public int enemyPowerWordGlory = 0;
        public int spellpower = 0;

        public bool cantBeTargetedBySpellsOrHeroPowers = false;
        public bool cantAttackHeroes = false;

        public int Hp = 0;
        public int maxHp = 0;
        public int armor = 0;

        public int Angr = 0;
        public int AdjacentAngr = 0;
        public int tempAttack = 0;

        public bool Ready = false;

        public bool taunt = false;
        public bool wounded = false;//hp red?

        public bool divineshild = false;
        public bool windfury = false;
        public bool frozen = false;
        public bool stealth = false;
        public bool immune = false;
        public bool exhausted = false;

        public int charge = 0;
        public bool poisonous = false;
        public bool cantLowerHPbelowONE = false;

        public bool silenced = false;
        public bool extraParam = false;
        public int extraParam2 = 0;

        public Minion()
        {
            this.handcard = new Handmanager.Handcard();
        }

        public Minion(Minion m)
        {
            //dont silence----------------------------
            //this.anzGotDmg = m.anzGotDmg;
            //this.GotDmgValue = m.GotDmgValue;
            //this.anzGotHealed = m.anzGotHealed;
            this.gotInspire = m.gotInspire;
            this.isHero = m.isHero;
            this.own = m.own;

            this.name = m.name;
            this.cardClass = m.cardClass;
            this.synergy = m.synergy;
            this.handcard = m.handcard;//new?
            this.deathrattle2 = m.deathrattle2;
            this.entitiyID = m.entitiyID;
            this.zonepos = m.zonepos;

            this.allreadyAttacked = m.allreadyAttacked;


            this.playedThisTurn = m.playedThisTurn;
            this.playedPrevTurn = m.playedPrevTurn;
            this.numAttacksThisTurn = m.numAttacksThisTurn;
            this.immuneWhileAttacking = m.immuneWhileAttacking;

            
            this.shadowmadnessed = m.shadowmadnessed;

            this.ancestralspirit = m.ancestralspirit;
            this.destroyOnOwnTurnStart = m.destroyOnOwnTurnStart; // depends on own!
            this.destroyOnEnemyTurnStart = m.destroyOnEnemyTurnStart; // depends on own!
            this.destroyOnOwnTurnEnd = m.destroyOnOwnTurnEnd; // depends on own!
            this.destroyOnEnemyTurnEnd = m.destroyOnEnemyTurnEnd; // depends on own!

            this.concedal = m.concedal;
            this.souloftheforest = m.souloftheforest;
            this.explorershat = m.explorershat;
            this.infest = m.infest;

            this.ownBlessingOfWisdom = m.ownBlessingOfWisdom;
            this.enemyBlessingOfWisdom = m.enemyBlessingOfWisdom;
            this.ownPowerWordGlory = m.ownPowerWordGlory;
            this.enemyPowerWordGlory = m.enemyPowerWordGlory;
            this.spellpower = m.spellpower;

            this.Hp = m.Hp;
            this.maxHp = m.maxHp;
            this.armor = m.armor;

            this.Angr = m.Angr;
            this.AdjacentAngr = m.AdjacentAngr;
            this.tempAttack = m.tempAttack;

            this.Ready = m.Ready;

            this.taunt = m.taunt;
            this.wounded = m.wounded;

            this.divineshild = m.divineshild;
            this.windfury = m.windfury;
            this.frozen = m.frozen;
            this.stealth = m.stealth;
            this.immune = m.immune;
            this.exhausted = m.exhausted;

            this.charge = m.charge;
            this.poisonous = m.poisonous;
            this.cantLowerHPbelowONE = m.cantLowerHPbelowONE;

            this.silenced = m.silenced;

            this.cantBeTargetedBySpellsOrHeroPowers = m.cantBeTargetedBySpellsOrHeroPowers;
            this.cantAttackHeroes = m.cantAttackHeroes;
        }

        public void setMinionTominion(Minion m)
        {
            //dont silence----------------------------
            this.anzGotDmg = m.anzGotDmg;
            this.GotDmgValue = m.GotDmgValue;
            this.gotInspire = m.gotInspire;
            this.isHero = m.isHero;
            this.own = m.own;

            this.name = m.name;
            this.cardClass = m.cardClass;
            this.synergy = m.synergy;
            this.handcard = m.handcard;//new?
            this.deathrattle2 = m.deathrattle2;

            this.zonepos = m.zonepos;


            this.allreadyAttacked = m.allreadyAttacked;


            this.numAttacksThisTurn = m.numAttacksThisTurn;
            this.immuneWhileAttacking = m.immuneWhileAttacking;

            
            this.shadowmadnessed = m.shadowmadnessed;

            this.ancestralspirit = m.ancestralspirit;
            this.destroyOnOwnTurnStart = m.destroyOnOwnTurnStart; // depends on own!
            this.destroyOnEnemyTurnStart = m.destroyOnEnemyTurnStart; // depends on own!
            this.destroyOnOwnTurnEnd = m.destroyOnOwnTurnEnd; // depends on own!
            this.destroyOnEnemyTurnEnd = m.destroyOnEnemyTurnEnd; // depends on own!

            this.concedal = m.concedal;
            this.souloftheforest = m.souloftheforest;
            this.explorershat = m.explorershat;
            this.infest = m.infest;

            this.ownBlessingOfWisdom = m.ownBlessingOfWisdom;
            this.enemyBlessingOfWisdom = m.enemyBlessingOfWisdom;
            this.ownPowerWordGlory = m.ownPowerWordGlory;
            this.enemyPowerWordGlory = m.enemyPowerWordGlory;
            this.spellpower = m.spellpower;

            this.Hp = m.Hp;
            this.maxHp = m.maxHp;
            this.armor = m.armor;

            this.Angr = m.Angr;
            this.AdjacentAngr = m.AdjacentAngr;
            this.tempAttack = m.tempAttack;



            this.taunt = m.taunt;
            this.wounded = m.wounded;

            this.divineshild = m.divineshild;
            this.windfury = m.windfury;
            this.frozen = m.frozen;
            this.stealth = m.stealth;
            this.immune = m.immune;
            this.exhausted = m.exhausted;

            this.charge = m.charge;
            if (m.charge > 0 && !m.frozen && !m.silenced) this.Ready = true;
            else this.Ready = false;
            this.poisonous = m.poisonous;
            this.cantLowerHPbelowONE = m.cantLowerHPbelowONE;

            this.silenced = m.silenced;

            this.cantBeTargetedBySpellsOrHeroPowers = m.cantBeTargetedBySpellsOrHeroPowers;
            this.cantAttackHeroes = m.cantAttackHeroes;
        }

        public int getRealAttack()
        {
            return this.Angr;
        }

        public void getDamageOrHeal(int dmg, Playfield p, bool isMinionAttack, bool dontCalcLostDmg)
        {
            if (this.Hp <= 0) return;

            if (this.immune && dmg > 0) return;

            if (this.isHero)
            {
                if (this.own)
                {
                    if (p.ownVioletIllusionist > 0 && dmg > 0 && p.isOwnTurn) return;
                    if (p.ownWeaponCard.name == CardDB.cardName.cursedblade) dmg += dmg;
                    if (p.anzOwnAnimatedArmor > 0 && dmg > 0) dmg = 1;
                    if (p.anzOwnBolfRamshield > 0 && dmg > 0)


                    {
                        int rest = this.armor - dmg;
                        this.armor = Math.Max(0, rest);
                        if (rest < 0)
                        {
                            foreach (Minion m in p.ownMinions)
                            {
                                if (m.name == CardDB.cardName.bolframshield)
                                {
                                    m.getDamageOrHeal(-rest, p, true, false);
                                    break;
                                }
                            }
                        }
                        return;
                    }
                }
                else
                {
                    if (p.enemyVioletIllusionist > 0 && dmg > 0 && !p.isOwnTurn) return;
                    if (p.anzEnemyAnimatedArmor > 0 && dmg > 0) dmg = 1;
                    if (p.enemyWeaponCard.name == CardDB.cardName.cursedblade) dmg += dmg;
                    if (p.anzEnemyBolfRamshield > 0 && dmg > 0)
                    {
                        int rest = this.armor - dmg;
                        this.armor = Math.Max(0, rest);
                        if (rest < 0)
                        {
                            foreach (Minion m in p.enemyMinions)
                            {
                                if (m.name == CardDB.cardName.bolframshield)
                                {
                                    m.getDamageOrHeal(-rest, p, true, false);
                                    break;
                                }
                            }
                        }
                        return;
                    }
                }

                int copy = this.Hp;
                if (dmg < 0 || this.armor <= 0)
                {
                    //if (dmg < 0) return;

                    //heal

                    this.Hp = Math.Min(30, this.Hp - dmg);
                    if (copy < this.Hp)
                    {
                        p.tempTrigger.charsGotHealed++;
                        this.anzGotHealed++;
                    }
                    if (copy - this.Hp >= 1)
                    {
                        p.secretTrigger_HeroGotDmg(this.own, copy - this.Hp);
                    }
                }
                else
                {
                    if (this.armor > 0 && dmg > 0)
                    {

                        int rest = this.armor - dmg;
                        if (rest < 0)
                        {
                            this.Hp += rest;
                            p.secretTrigger_HeroGotDmg(this.own, rest);
                        }
                        this.armor = Math.Max(0, this.armor - dmg);

                    }
                }
                if (this.cantLowerHPbelowONE && this.Hp <= 0) this.Hp = 1;

                if (this.Hp < copy)
                {
                    this.anzGotDmg++;
                    this.GotDmgValue += dmg;
                    if (this.own)
                    {
                        p.tempTrigger.ownMinionsGotDmg++;
                        p.tempTrigger.ownHeroGotDmg++;
                    }
                    else
                    {
                        p.tempTrigger.enemyMinionsGotDmg++;
                        p.tempTrigger.enemyHeroGotDmg++;
                    }
                }
                return;
            }

            //its a Minion--------------------------------------------------------------


            int damage = dmg;
            int heal = 0;
            if (dmg < 0) heal = -dmg;

            bool woundedbefore = this.wounded;
            if (heal < 0) // heal was shifted in damage
            {
                damage = -1 * heal;
                heal = 0;
            }

            if (damage >= 1) this.allreadyAttacked = true;

            if (damage >= 1 && this.divineshild)
            {
                this.divineshild = false;
                if (!own && !dontCalcLostDmg && p.turnCounter == 0)
                {
                    if (isMinionAttack)
                    {
                        p.lostDamage += damage - 1;
                    }
                    else
                    {
                        p.lostDamage += (damage - 1) * (damage - 1);
                    }
                }
                return;
            }

            if (this.cantLowerHPbelowONE && damage >= 1 && damage >= this.Hp) damage = this.Hp - 1;

            if (!own && !dontCalcLostDmg && this.Hp < damage && p.turnCounter == 0)
            {
                if (isMinionAttack)
                {
                    p.lostDamage += (damage - this.Hp);
                }
                else
                {
                    p.lostDamage += (damage - this.Hp) * (damage - this.Hp);
                }
            }

            int hpcopy = this.Hp;

            if (damage >= 1)
            {
                this.Hp = this.Hp - damage;
            }

            if (heal >= 1)
            {
                if (own && !dontCalcLostDmg && heal <= 999 && this.Hp + heal > this.maxHp) p.lostHeal += this.Hp + heal - this.maxHp;

                this.Hp = this.Hp + Math.Min(heal, this.maxHp - this.Hp);
            }



            if (this.Hp > hpcopy)
            {
                //minionWasHealed
                p.tempTrigger.minionsGotHealed++;
                p.tempTrigger.charsGotHealed++;
                this.anzGotHealed++;
            }
            else if (this.Hp < hpcopy)
            {
                if (this.own) p.tempTrigger.ownMinionsGotDmg++;
                else p.tempTrigger.enemyMinionsGotDmg++;

                if (p.anzAcidmaw > 0)
                {
                    if (p.anzAcidmaw == 1)
                    {
                        if (this.name != CardDB.cardName.acidmaw) this.Hp = 0;
                    }
                    else this.Hp = 0;
                }

                this.anzGotDmg++;
                this.GotDmgValue += dmg;
            }

            if (this.maxHp == this.Hp)
            {
                this.wounded = false;
            }
            else
            {
                this.wounded = true;
            }



            if (this.name == CardDB.cardName.lightspawn && !this.silenced)
            {
                this.Angr = this.Hp;
            }

            if (woundedbefore && !this.wounded)
            {
                this.handcard.card.sim_card.onEnrageStop(p, this);
            }

            if (!woundedbefore && this.wounded)
            {
                this.handcard.card.sim_card.onEnrageStart(p, this);
            }
            
            if (this.Hp <= 0)
            {
                this.minionDied(p);
            }

        }

        public void minionDied(Playfield p)
        {
            if (this.name == CardDB.cardName.stalagg)
            {
                p.stalaggDead = true;
            }
            else
            {
                if (this.name == CardDB.cardName.feugen) p.feugenDead = true;
            }

            

            if (own)
            {

                p.tempTrigger.ownMinionsDied++;
                if (this.taunt) p.anzOwnTaunt--;
                if (this.handcard.card.race == 20)
                {
                    p.tempTrigger.ownBeastDied++;
                }
                else if (this.handcard.card.race == 17)
                {
                    p.tempTrigger.ownMechanicDied++;
                }
                else if (this.handcard.card.race == 14)
                {
                    p.tempTrigger.ownMurlocDied++;
                }
            }
            else
            {
                p.tempTrigger.enemyMinionsDied++;
                if (this.taunt) p.anzEnemyTaunt--;
                if (this.handcard.card.race == 20)
                {
                    p.tempTrigger.enemyBeastDied++;
                }
                else if (this.handcard.card.race == 17)
                {
                    p.tempTrigger.enemyMechanicDied++;
                }
                else if (this.handcard.card.race == 14)
                {
                    p.tempTrigger.enemyMurlocDied++;
                }
            }

            if (p.diedMinions != null)
            {
                GraveYardItem gyi = new GraveYardItem(this.handcard.card.cardIDenum, this.entitiyID, this.own);
                p.diedMinions.Add(gyi);
            }
        }

        public void updateReadyness()
        {
            Ready = false;
            //default test (minion must be unfrozen!)
            if (isHero)
            {
                if (!frozen && ((charge >= 1 && playedThisTurn) || !playedThisTurn) && (numAttacksThisTurn == 0 || (numAttacksThisTurn == 1 && windfury))) Ready = true;
                return;
            }

            if (!silenced)
            {
                switch (name)
                {
                    case CardDB.cardName.ragnarosthefirelord: return;
                    case CardDB.cardName.ancientwatcher: return;
                    case CardDB.cardName.eeriestatue:
                        if (extraParam2 != 1) return;
                        break;
                    case CardDB.cardName.argentwatchman:
                        if (!gotInspire) return;
                        break;
                }
            }

            if (!frozen && ((charge >= 1 && playedThisTurn) || !playedThisTurn || shadowmadnessed) && (numAttacksThisTurn == 0 || (numAttacksThisTurn == 1 && windfury) || ( !silenced && this.name == CardDB.cardName.v07tr0n && numAttacksThisTurn <=3 )) ) Ready = true;

        }

        public void becomeSilence(Playfield p)
        {

            if (own)
            {
                p.spellpower -= spellpower;
                if (this.taunt) p.anzOwnTaunt--;
            }
            else
            {
                p.enemyspellpower -= spellpower;
                if (this.taunt) p.anzEnemyTaunt--;
            }
            spellpower = 0;

            deathrattle2 = null;
            p.minionGetOrEraseAllAreaBuffs(this, false);
            //buffs
            ancestralspirit = 0;
            destroyOnOwnTurnStart = false;
            destroyOnEnemyTurnStart = false;
            destroyOnOwnTurnEnd = false;
            destroyOnEnemyTurnEnd = false;
            concedal = false;
            souloftheforest = 0;
            explorershat = 0;
            infest = 0;
            ownBlessingOfWisdom = 0;
            enemyBlessingOfWisdom = 0;
            ownPowerWordGlory = 0;
            enemyPowerWordGlory = 0;

            cantBeTargetedBySpellsOrHeroPowers = false;
            cantAttackHeroes = false;

            charge = 0;
            taunt = false;
            divineshild = false;
            windfury = false;
            frozen = false;
            stealth = false;
            immune = false;
            poisonous = false;
            cantLowerHPbelowONE = false;
            

            //delete enrage (if minion is silenced the first time)
            if (wounded && handcard.card.Enrage && !silenced)
            {
                handcard.card.sim_card.onEnrageStop(p, this);
            }

            //reset attack
            Angr = handcard.card.Attack;
            tempAttack = 0;//we dont toutch the adjacent buffs!


            //reset hp and heal it
            if (maxHp < handcard.card.Health)//minion has lower maxHp as his card -> heal his hp
            {
                Hp += handcard.card.Health - maxHp; //heal minion
            }
            maxHp = handcard.card.Health;
            if (Hp > maxHp) Hp = maxHp;

            if (!silenced)//minion WAS not silenced, deactivate his aura
            {
                handcard.card.sim_card.onAuraEnds(p, this);
            }

            silenced = true;
            this.updateReadyness();
            p.minionGetOrEraseAllAreaBuffs(this, true);
            if (own)
            {
                p.tempTrigger.ownMinionsChanged = true;
            }
            else
            {
                p.tempTrigger.enemyMininsChanged = true;
            }
            if (this.shadowmadnessed)
            {
                this.shadowmadnessed = false;
                p.shadowmadnessed--;
                p.minionGetControlled(this, !own, false);
            }
        }

        public Minion GetTargetForMinionWithSurvival(Playfield p, bool own)
        {
            if (this.Angr == 0) return null;
            if ((own ? p.enemyMinions.Count : p.ownMinions.Count) < 1) return (own ? p.enemyHero : p.ownHero);
            Minion target = new Minion();
            Minion targetTaumt = new Minion();
            foreach (Minion m in own ? p.enemyMinions : p.ownMinions)
            {
                if (m.taunt && !m.silenced)
                {
                    if (this.Hp > m.Hp && (m.Hp + m.Angr + m.Angr * (m.windfury ? 1 : 0)) > (targetTaumt.Hp + targetTaumt.Angr + targetTaumt.Angr * (targetTaumt.windfury ? 1 : 0))) targetTaumt = m;
                }
                else
                {
                    if (this.Hp > m.Hp && (m.Hp + m.Angr + m.Angr * (m.windfury ? 1 : 0)) > (target.Hp + target.Angr + target.Angr * (target.windfury ? 1 : 0))) target = m;
                }
            }
            if (targetTaumt.Hp > 0) return targetTaumt;
            if (target.Hp > 0) return target;
            return null;
        }

        public void loadEnchantments(List<miniEnch> enchants, int ownPlayerControler)
        {
            foreach (miniEnch me in enchants)
            {
                // reborns and destoyings----------------------------------------------

                
                if (me.CARDID == CardDB.cardIDEnum.EX1_363e || me.CARDID == CardDB.cardIDEnum.EX1_363e2) //BlessingOfWisdom
                {
                    if (me.controllerOfCreator == ownPlayerControler)
                    {
                        this.ownBlessingOfWisdom++;
                    }
                    else
                    {
                        this.enemyBlessingOfWisdom++;
                    }
                }

                if (me.CARDID == CardDB.cardIDEnum.AT_013e) //PowerWordGlory
                {
                    if (me.controllerOfCreator == ownPlayerControler)
                    {
                        this.ownPowerWordGlory++;
                    }
                    else
                    {
                        this.enemyPowerWordGlory++;
                    }
                }


                if (me.CARDID == CardDB.cardIDEnum.EX1_316e) //overwhelmingpower
                {
                    if (me.controllerOfCreator == ownPlayerControler)
                    {
                        this.destroyOnOwnTurnEnd = true;
                    }
                    else
                    {
                        this.destroyOnEnemyTurnEnd = true;
                    }
                }

                if (me.CARDID == CardDB.cardIDEnum.EX1_334e) //Dark Command
                {
                    this.shadowmadnessed = true;
                }

                if (me.CARDID == CardDB.cardIDEnum.FP1_030e) //Necrotic Aura
                {
                    //todo Eure Zauber kosten in diesem Zug (5) mehr.
                }
                if (me.CARDID == CardDB.cardIDEnum.NEW1_029t) //death to millhouse!
                {
                    // todo spells cost (0) this turn!
                }
                if (me.CARDID == CardDB.cardIDEnum.EX1_612o) //Power of the Kirin Tor
                {
                    // todo Your next Secret costs (0).
                }
               // if (me.CARDID == CardDB.cardIDEnum.EX1_084e) //warsongcommander
               // {
              //      this.charge++;
              //  }
                
                switch(me.CARDID)
                {
                    //ToDo: TBUD_1	Each turn, if you have less health then a your opponent, summon a free minion


                    // destroy-------------------------------------------------
                    case CardDB.cardIDEnum.CS2_063e:
                        if (me.controllerOfCreator == ownPlayerControler) this.destroyOnOwnTurnStart = true;
                        else this.destroyOnEnemyTurnStart = true;   //corruption
                        continue;
                    case CardDB.cardIDEnum.DREAM_05e:
                        if (me.controllerOfCreator == ownPlayerControler) this.destroyOnOwnTurnStart = true;
                        else this.destroyOnEnemyTurnStart = true;   //nightmare
                        continue;

                    // deathrattles-------------------------------------------------
                    case CardDB.cardIDEnum.LOE_105e: this.explorershat++; continue;
                    case CardDB.cardIDEnum.CS2_038e: this.ancestralspirit++; continue;
                    case CardDB.cardIDEnum.EX1_158e: this.souloftheforest++; continue;
                    case CardDB.cardIDEnum.OG_045a: this.infest++; continue;
                    case CardDB.cardIDEnum.LOE_019e: this.extraParam2 = me.copyDeathrattle; continue; //unearthedraptor
                   // case CardDB.cardIDEnum.LOE_012e: this.deathrattle2 = ; continue; //zzdeletetombexplorer


                    //concedal-------------------------------------------------
                    case CardDB.cardIDEnum.EX1_128e: this.concedal = true; continue;
                    case CardDB.cardIDEnum.NEW1_014e: this.concedal = true; continue;
                    case CardDB.cardIDEnum.PART_004e: this.concedal = true; continue;
                    case CardDB.cardIDEnum.OG_080de: this.concedal = true; continue; 

                    //cantLowerHPbelowONE-------------------------------------------------
                    case CardDB.cardIDEnum.NEW1_036e: this.cantLowerHPbelowONE = true; continue; //commandingshout
                    case CardDB.cardIDEnum.NEW1_036e2: this.cantLowerHPbelowONE = true; continue; //commandingshout

                    //spellpower-------------------------------------------------
                    case CardDB.cardIDEnum.GVG_010b: this.spellpower++; continue; //velenschosen
                    case CardDB.cardIDEnum.AT_006e: this.spellpower++; continue; //dalaran
                    case CardDB.cardIDEnum.EX1_584e: this.spellpower++; continue; //ancient mage

                    //charge-------------------------------------------------
                    case CardDB.cardIDEnum.AT_071e: this.charge++; continue;
                    case CardDB.cardIDEnum.CS2_103e2: this.charge++; continue;
                    case CardDB.cardIDEnum.TB_AllMinionsTauntCharge: this.charge++; continue;
                    case CardDB.cardIDEnum.DS1_178e: this.charge++; continue;

                    //adjacentbuffs-------------------------------------------------
                    case CardDB.cardIDEnum.EX1_565o: this.AdjacentAngr += 2; continue; //flametongue
                    case CardDB.cardIDEnum.EX1_162o: this.AdjacentAngr += 1; continue; //dire wolf alpha

                    //tempbuffs-------------------------------------------------
                    case CardDB.cardIDEnum.CS2_083e: this.tempAttack += 1; continue;
                    case CardDB.cardIDEnum.EX1_549o: this.tempAttack += 2; this.immune = true; continue;
                    case CardDB.cardIDEnum.AT_039e: this.tempAttack += 2; continue;
                    case CardDB.cardIDEnum.AT_132_DRUIDe: this.tempAttack += 2; continue;
                    case CardDB.cardIDEnum.CS2_005o: this.tempAttack += 2; continue;
                    case CardDB.cardIDEnum.CS2_011o: this.tempAttack += 2; continue;
                    case CardDB.cardIDEnum.EX1_046e: this.tempAttack += 2; continue;
                    case CardDB.cardIDEnum.GVG_057a: this.tempAttack += 2; continue;
                    case CardDB.cardIDEnum.CS2_046e: this.tempAttack += 3; continue;
                    case CardDB.cardIDEnum.CS2_105e: this.tempAttack += 4; continue;
                    case CardDB.cardIDEnum.EX1_570e: this.tempAttack += 4; continue;
                    case CardDB.cardIDEnum.OG_047e: this.tempAttack += 4; continue;  
                    case CardDB.cardIDEnum.NAX12_04e: this.tempAttack += 6; continue;
                    case CardDB.cardIDEnum.GVG_011a: this.tempAttack += -2; continue;
                    case CardDB.cardIDEnum.CFM_661e: this.tempAttack += -3; continue;
                    case CardDB.cardIDEnum.BRM_001e: this.tempAttack += -1000; continue;
                    case CardDB.cardIDEnum.TU4c_008e: this.tempAttack += 8; continue;
                    case CardDB.cardIDEnum.CS2_045e: this.tempAttack += 3; continue;
                    case CardDB.cardIDEnum.CS2_188o: this.tempAttack += 2; continue;
                    case CardDB.cardIDEnum.CS2_017o: this.tempAttack += 1; continue;


                        
                    

                   



                }
            }
        }

    }

}