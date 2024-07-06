using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareSystem.Model.Models
{
    public class Fare
    {
        public Vehicle VehicleName { get; }
        public int BasicPrice { get; }
        public int DistancePrice { get; }
        public int Distance {  get; }

        public Fare(Vehicle vehicleName, int basicPrice, int distancePrice, int distance)
        {
            VehicleName = vehicleName;
            BasicPrice = basicPrice;
            DistancePrice = distancePrice;
            Distance = distance;
        }
    }

}
