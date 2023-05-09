using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T6_Baklanov;

namespace T6_Baklanov
{
    internal class SalesManagerPL : ISalesManagerPL
    {
        ICarBLL _carBLL;
        private IDBItemDAL _dbItemDAL;

        public SalesManagerPL(ICarBLL carBLL, IDBItemDAL dbItemDAL)
        {
            _carBLL = carBLL;
            _dbItemDAL = dbItemDAL;
        }

        public void CreateCar()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Car brand: ");
            string carBrand = Console.ReadLine();
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();

            _carBLL.CreateCar(id, carBrand, carModel);
        }

        public void FindCar()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Car car = _dbItemDAL.FindById(id);

            if (car == null)
            {
                Console.WriteLine("Car не знайдено");
            }

            else
            {
                Console.WriteLine($"Car brand: {car.CarBrand}, car model: {car.CarModel}");
            }
        }

        public void DeleteCar()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Car car = _dbItemDAL.FindById(id);

            if (car == null)
            {
                Console.WriteLine("Car не знайдено");
            }

            else
            {
                _dbItemDAL.Delete(car);
            }
        }

        public void UpdateCar()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Car car = _dbItemDAL.FindById(id);

            if (car == null)
            {
                Console.WriteLine("Клієнт не знайдено");
            }

            else
            {
                Console.Write("Ім'я: ");
                string carBrand = Console.ReadLine();
                Console.Write("Прізвище: ");
                string carModel = Console.ReadLine();
                car.CarBrand = carBrand;
                car.CarModel= carModel;
                _dbItemDAL.Update(car);
            }
        }
    }
}
