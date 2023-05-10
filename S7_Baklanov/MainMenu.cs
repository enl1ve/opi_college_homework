using S7_Baklanov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_Baklanov
{
    internal class MainMenu : IMenu
    {
        public bool Flag { get; set; }
        MenuStrategy menuStrategy;
        ConsoleColor defaultColor;

        public MainMenu(MenuStrategy menuStrategy)
        {
            this.menuStrategy = menuStrategy;
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
            Console.WriteLine("1 - Dispatcher Menu");
            Console.WriteLine("2 - Exit");


            int menuChoose = Convert.ToInt16(Console.ReadLine());

            switch (menuChoose)
            {
                case 1:
                    menuStrategy.Run();
                    break;
                case 2:
                    Flag = false;
                    break;
                default:
                    Console.WriteLine("Виберіть один із пунктів меню.");
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
