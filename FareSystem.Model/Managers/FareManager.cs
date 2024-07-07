using FareSystem.Model.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

        public void EditFare(Fare fare)
        {
            var index = _fareList.FindIndex(item => item == fare);
            _fareList[index] = ResultFare;
        }

        public void DeleteFare(Fare fare)
        {
            var sameFare = _fareList.FirstOrDefault(item => item == fare);
            _fareList.Remove(sameFare);
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

        public void LoadFromCsv()
        {
            var filePath = "D:\\Programing\\C#\\CSharpTutorial\\FareSystem\\savefolder\\save.csv";
            _fareList.Clear();
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("shift_jis")))
                {
                    while (sr.Peek() > -1)
                    {
                        string[] parts = sr.ReadLine().Split(',');

                        Enum.TryParse(parts[0], out Vehicle vehicle);
                        int.TryParse(parts[1], out int basicPrice);
                        int.TryParse(parts[2], out int distancePrice);
                        int.TryParse(parts[3], out int distance);

                        var fare = new Fare(vehicle, basicPrice, distancePrice, distance);
                        _fareList.Add(fare);
                    }
                }
            }
        }

        public void SaveToCsv()
        {
            var filePath = "D:\\Programing\\C#\\CSharpTutorial\\FareSystem\\savefolder\\save.csv";
            string[] lines = _fareList.Select(item => $"{item.VehicleName},{item.BasicPrice},{item.DistancePrice},{item.Distance}").ToArray();
            File.WriteAllLines(filePath, lines, Encoding.GetEncoding("shift_jis"));

        }
    }
}
