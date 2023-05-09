using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T6_Baklanov;

namespace T6_Baklanov
{
    internal class SalesManagerMenu : AbstractMenu
    {
        SalesManagerPL _salesManagerPL;
        DBItemDAL _dbItemDAL;
        MainMenu _mainMenu;

        public SalesManagerMenu(SalesManagerPL salesManagerPL, DBItemDAL dbItemDAL, MainMenu mainMenu)
        {
            _salesManagerPL = salesManagerPL;
            _dbItemDAL = dbItemDAL;
            _mainMenu = mainMenu;
        }

        protected override void Init()
        {
            Console.WriteLine("Меню менеджера з продажу");
        }
        protected override void Idle()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("1 - Створити car" +
                "\n2 - Знайти car за ідентифікатором" +
                "\n3 - Видалити car" +
                "\n4 - Оновити car" +
                "\n5 - Вихід");

            int menuNumber = int.Parse(Console.ReadLine());
            switch (menuNumber)
            {
                case 1:
                    Console.Clear();
                    _salesManagerPL.CreateCar();
                    break;

                case 2:
                    Console.Clear();
                    _salesManagerPL.FindCar();
                    break;

                case 3:
                    Console.Clear();
                    _salesManagerPL.DeleteCar();
                    break;

                case 4:
                    Console.Clear();
                    _salesManagerPL.UpdateCar();
                    break;

                case 5:
                    Console.Clear();
                    _mainMenu.Run();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Виберіть один із варіантів (1-6)");
                    break;
            }
        }

        protected override void CleanUp()
        {
            Console.WriteLine("Зараз ви виходите з меню менеджера з продажу.");
        }
    }
}
