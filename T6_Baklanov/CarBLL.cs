using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T6_Baklanov;

namespace T6_Baklanov
{
    internal class CarBLL : ICarBLL
    {
        IDBItemDAL _dbItemDAL;

        public CarBLL(IDBItemDAL dbItemDAL)
        {
            _dbItemDAL = dbItemDAL;
        }

        public void CreateCar(int id, string carBrand, string carModel)
        {
            Car car = new Car(id, carBrand, carModel);
            _dbItemDAL.Add(car);
        }
    }
}
