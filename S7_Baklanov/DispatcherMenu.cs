using S7_Baklanov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7_Baklanov
{
    internal class DispatcherMenu : IMenu
    {
        public bool Flag { get; set; }
        IDispatcherPL dispatcherPL;
        ConsoleColor defaultColor;
        public DispatcherMenu(IDispatcherPL dispatcherPL)
        {
            this.dispatcherPL = dispatcherPL;
        }


        public void Init()
        {
            Flag = true;
            defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Init");
        }

        public void Idle()
        {
            Console.WriteLine("1 - Create Flight");
            Console.WriteLine("2 - Find All Flight");
            Console.WriteLine("3 - Find Flight By id");
            Console.WriteLine("4 - Delete Flight");
            Console.WriteLine("5 - Update Flight");
            Console.WriteLine("6 - Exit");

            int menuChoose = Convert.ToInt16(Console.ReadLine());

            switch (menuChoose)
            {
                case 1:
                    dispatcherPL.CreateFlight();
                    break;
                case 2:
                    dispatcherPL.FindAllFlight();
                    break;
                case 3:
                    dispatcherPL.FindFlightById();
                    break;
                case 4:
                    dispatcherPL.DeleteFlight();
                    break;
                case 5:
                    dispatcherPL.UpdateFlight();
                    break;
                case 6:
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
