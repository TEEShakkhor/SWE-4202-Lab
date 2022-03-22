using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalDependencies
{
    internal class USER
    {
        public int UserId;
        public string UserName;
        public string Address;
        public string Destination;
        public string CarRented;
        public USER(int UserId, string UserName, string Address, string Destination)
        {
            this.UserId = UserId;
            this.UserName = UserName;
            this.Address = Address;
            this.Destination = Destination;
        }

        public void userHistory(string Model)
        {
            this.CarRented = Model;
        }
    }
}

