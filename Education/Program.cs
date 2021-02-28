using System;

namespace Education
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Education GitHub Project");
            Console.WriteLine();

            switch (3)
            {
                case 1: _1_Yield.Program.Run();
                    break;
                case 3: _3_Interface.Program.Run();
                    break;
                default: Console.WriteLine("Choosen wrong one");
            }

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
