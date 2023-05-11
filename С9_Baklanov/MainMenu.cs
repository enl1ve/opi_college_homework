using C9_Baklanov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9_Baklanov
{
    internal class MainMenu : IMenu
    {
        public bool Flag { get; set; }
        ConsoleColor defaultColor;
        StrategyMenu librarianStrategyMenu;
        public MainMenu(StrategyMenu librarianStrategyMenu)
        {
            this.librarianStrategyMenu = librarianStrategyMenu;
        }

        public void Init()
        {
            Flag = true;
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Init");
        }

        public void Idle()
        {
            Console.WriteLine("1 - Меню бібліотекаря");
            Console.WriteLine("2 - Вихід");


            int menuChoose = int.Parse(Console.ReadLine());

            switch (menuChoose)
            {
                case 1:
                    librarianStrategyMenu.Run();
                    break;
                case 2:
                    Flag = false;
                    break;
                default:
                    Console.WriteLine("Виберіть один із пунктів меню");
                    break;
            }
        }
        public void CleanUp()
        {
            Console.ForegroundColor = defaultColor;
            Console.WriteLine("CleanUp");
        }
    }
}
