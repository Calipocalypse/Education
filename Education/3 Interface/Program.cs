using System;
using System.Collections.Generic;
using System.Text;

namespace Education._3_Interface
{
    public static class Program
    {
        public static void Run()
        {
            var piotr = new Human(30, 10, new List<string>() { "Night Kid", "Gifted" });
            piotr.ShowHP();
            piotr.ShowAP();
            piotr.ShowAllPerks();
        }
        public interface IShowAll
        {
            void ShowHP();
            void ShowAP();
            void ShowAllPerks();
        }
    }
}
