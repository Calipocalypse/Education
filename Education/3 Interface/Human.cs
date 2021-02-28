using System;
using System.Collections.Generic;
using System.Text;

namespace Education._3_Interface
{
    public class Human : Program.IShowAll
    {
        public int hp;
        public int ap;
        public List<string> perks;

        public Human(int hp, int ap, List<string> perks)
        {
            this.hp = hp;
            this.ap = ap;
            this.perks = perks;
        }

        public void ShowHP()
        {
            Console.WriteLine("HP: " + hp);
        }

        public void ShowAP()
        {
            Console.WriteLine("AP: " + ap);
        }

        public void ShowAllPerks()
        {
            Console.Write("Perks: ");

            foreach (var perk in perks)
            {
                Console.Write(perk+", ");
            }
        }

    }
}
