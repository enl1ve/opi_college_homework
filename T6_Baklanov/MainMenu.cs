using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Baklanov
{
    internal class MainMenu : AbstractMenu
    {
        SalesManagerMenu _salesManagerMenu;
        public MainMenu(SalesManagerMenu salesManagerMenu)
        {
            _salesManagerMenu = salesManagerMenu;
        }

        protected override void Init()
        {
            Console.WriteLine("Головне меню");
        }

        protected override void Idle()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("1 - Меню менеджера з продажу" +
                "\n2 - Вихід");

            int menuNumber = int.Parse(Console.ReadLine());
            switch (menuNumber)
            {
                case 1:
                    Console.Clear();
                    _salesManagerMenu.Run();
                    Console.Clear();
                    break;

                case 2:
                    flag = false;
                    break;

                default:
                    Console.WriteLine("Виберіть один із варіантів (1-2)");
                    break;
            }
        }

        protected override void CleanUp()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Іди звідси!");
        }
    }
}
