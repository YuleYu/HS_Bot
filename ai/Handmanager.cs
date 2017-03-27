namespace HREngine.Bots
{
    using System.Collections.Generic;

    public class Handmanager
    {

        public class Handcard
        {
            public int position = 0;
            public int entity = -1;
            public int manacost = 1000;
            public int addattack = 0;
            public int addHp = 0;
            public CardDB.Card card;
            public int extraParam = 0;
            public int extraParam2 = 0;
            public bool extraParam3 = false;

            public Handcard()
            {
                card = CardDB.Instance.unknownCard;
            }
            public Handcard(Handcard hc)
            {
                this.position = hc.position;
                this.entity = hc.entity;
                this.manacost = hc.manacost;
                this.card = hc.card;
                this.addattack = hc.addattack;
                this.addHp = hc.addHp;
            }
            public Handcard(CardDB.Card c)
            {
                this.position = 0;
                this.entity = -1;
                this.card = c;
                this.addattack = 0;
                this.addHp = 0;
            }
            public int getManaCost(Playfield p)
            {
                return this.card.getManaCost(p, this.manacost);
            }
            public bool canplayCard(Playfield p, bool own)
            {
                return this.card.canplayCard(p, this.manacost, own);
            }
        }

        public List<Handcard> handCards = new List<Handcard>();

        public int anzcards = 0;

        public int enemyAnzCards = 0;

        private int ownPlayerController = 0;

        Helpfunctions help;
        CardDB cdb = CardDB.Instance;

        private static Handmanager instance;

        public static Handmanager Instance
        {
            get
            {
                return instance ?? (instance = new Handmanager());
            }
        }


        private Handmanager()
        {
            this.help = Helpfunctions.Instance;

        }

        public void clearAllRecalc()
        {
            this.handCards.Clear();
            this.anzcards = 0;
            this.enemyAnzCards = 0;
            this.ownPlayerController = 0;
        }

        public void setOwnPlayer(int player)
        {
            this.ownPlayerController = player;
        }




        public void setHandcards(List<Handcard> hc, int anzown, int anzenemy)
        {
            this.handCards.Clear();
            foreach (Handcard h in hc)
            {
                this.handCards.Add(new Handcard(h));
            }
            //this.handCards.AddRange(hc);
            this.handCards.Sort((a, b) => a.position.CompareTo(b.position));
            this.anzcards = anzown;
            this.enemyAnzCards = anzenemy;
        }
        
        public void printcards()
        {
            help.logg("Own Handcards: ");
            foreach (Handmanager.Handcard c in this.handCards)
            {
                help.logg("pos " + c.position + " " + c.card.name + " " + c.manacost + " entity " + c.entity + " " + c.card.cardIDenum + " " + c.addattack + " " + c.addHp);
            }
            help.logg("Enemy cards: " + this.enemyAnzCards);
        }


    }

}