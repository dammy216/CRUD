using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareSystem.Model.Models
{
    public class Fare
    {
        public Vehicle VehicleName { get;}
        public int BasicPrice { get;}
        public int DistancePrice { get;}

        public Fare(Vehicle vehicleName, int basicPrice, int distancePrice)
        {
            VehicleName = vehicleName;
            BasicPrice = basicPrice;
            DistancePrice = distancePrice;
        }
    }

}
