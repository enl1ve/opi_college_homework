using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_Baklanov
{
    internal class Car
    {
        int _id;
        string _carBrand;
        string _carModel;

        public Car(int id, string carName, string carModel)
        {
            _id = id;
            _carBrand = carName;
            _carModel = carModel;
        }

        public int Id
        {
            get { return _id; }
        }

        public string CarBrand
        {
            get { return _carBrand; }
            set { _carBrand = value; }
        }

        public string CarModel
        {
            get { return _carModel; }
            set { _carModel = value; }
        }
    }
}
