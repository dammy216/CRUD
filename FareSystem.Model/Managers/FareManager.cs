using FareSystem.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareSystem.Model.Managers
{
    public class FareManager
    {
        private List<Fare> _fareList = new List<Fare>();
        public Fare[] FareList { get { return _fareList.ToArray(); } }
        
        public Fare ResultFare;

        private static FareManager _instance;
        public static FareManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FareManager();
                }
                return _instance;
            }
        }

        public void AddFare()
        {
            _fareList.Add(ResultFare);
        }

        public void EditFare(int index)
        {
            _fareList[index] = ResultFare;
        }

        public void DeleteFare(int index)
        {
            _fareList.RemoveAt(index);
        }

        private int CalcPrice(int basicPrice, int distancePrice, int distance)
        {
            return basicPrice + (distancePrice * distance);
        }

        public string[] GetFareItems(Fare fare)
        {
            var name = fare.VehicleName.ToString();
            var basicPrice = fare.BasicPrice.ToString();
            var distancePrice = fare.DistancePrice.ToString();
            var distance = fare.Distance.ToString();
            var totalPrice = CalcPrice(fare.BasicPrice, fare.DistancePrice, fare.Distance).ToString();

            string[] items = {name,  basicPrice, distancePrice, distance, totalPrice};
            return items;
        }
    }
}
