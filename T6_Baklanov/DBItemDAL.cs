using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Baklanov
{
    internal class DBItemDAL : IDBItemDAL
    {
        List<Car> _car;

        public DBItemDAL()
        {
            _car = new List<Car>();
        }

        public void Add(Car car)
        {
            Console.OutputEncoding = Encoding.UTF8;

            _car.Add(car);
            Console.WriteLine("Car додано до колекції");
        }

        public void Delete(Car car)
        {
            Console.OutputEncoding = Encoding.UTF8;

            _car.Remove(car);
            Console.WriteLine("Car видалено з колекції");
        }

        public Car FindById(int id)
        {
            foreach (Car customer in _car)
            {
                if (customer.Id == id)
                    return customer;
            }

            return null;
        }

        public void Update(Car car)
        {
            Console.OutputEncoding = Encoding.UTF8;

            foreach (Car c in _car)
            {
                if (c.Id == car.Id)
                {
                    c.CarBrand = car.CarBrand;
                    c.CarModel = car.CarModel;
                    Console.WriteLine("Car оновлений");
                    break;
                }
            }
        }
    }
}
