using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Baklanov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            IDBItemDAL dbItemDAL = new DBItemDAL();
            CarBLL customerBLL = new CarBLL(dbItemDAL);
            SalesManagerPL salesManagerPL = new SalesManagerPL(customerBLL, (DBItemDAL)dbItemDAL);
            SalesManagerMenu salesManagerMenu;
            MainMenu mainMenu = null;

            customerBLL.CreateCar(1, "Daewoo", "Matiz");
            customerBLL.CreateCar(2, "Daewoo", "Lanos");
            customerBLL.CreateCar(3, "Mersedes", "mersedesovich");

            Console.Clear();

            salesManagerMenu = new SalesManagerMenu(salesManagerPL, (DBItemDAL)dbItemDAL, mainMenu);
            mainMenu = new MainMenu(salesManagerMenu);
            mainMenu.Run();

            Console.ReadKey();
        }
    }
}
