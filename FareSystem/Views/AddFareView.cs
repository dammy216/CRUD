using FareSystem.Model.Managers;
using FareSystem.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareSystem.Views
{
    public partial class AddFareView : Form
    {
        private FareManager _instance = FareManager.Instance;
        public AddFareView(): this(null)
        {
        }

        public AddFareView(Fare fare)
        {
            InitializeComponent();

            if(fare == null) return;

            vehicleCB.Text = fare.VehicleName.ToString();
            basicPriceTB.Text = fare.BasicPrice.ToString();
            distancePriceTB.Text = fare.DistancePrice.ToString();
            distanceTB.Text = fare.Distance.ToString();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Enum.TryParse(vehicleCB.Text, out Vehicle vehicle);
            int.TryParse(basicPriceTB.Text, out int basicPrice);
            int.TryParse(distancePriceTB.Text, out int distancePrice);
            int.TryParse(distanceTB.Text, out int distance);
            var fare = new Fare(vehicle, basicPrice, distancePrice, distance);
            _instance.ResultFare = fare;
            DialogResult = DialogResult.OK;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
