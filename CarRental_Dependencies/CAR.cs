
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarRentalDependencies
{
    internal class CAR
    {
        public string CarName;
        public string CarModel;
        public int CarNumber;

        public CAR(string CarName, string CarModel, int CarNumber)
        {
            this.CarName = CarName;
            this.CarModel = CarModel;
            this.CarNumber = CarNumber;
        }

    }
}