using FareSystem.Model.Managers;
using FareSystem.Model.Models;
using FareSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareSystem
{
    public partial class FareView : Form
    {
        private FareManager _instance = FareManager.Instance;
        public FareView()
        {
            InitializeComponent();
            UpdateButton();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addFare = new AddFareView ();
            if(addFare.ShowDialog() == DialogResult.OK)
            {
                _instance.AddFare();
                UpdateGridView();
                UpdateButton();
            }
        }

        private void UpdateGridView()
        {
            fareGV.Rows.Clear();
            foreach(var fare in _instance.FareList)
            {
                int rowIndex = fareGV.Rows.Add(_instance.GetFareItems(fare));
                fareGV.Rows[rowIndex].Tag = fare;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var fare = new AddFareView(fareGV.SelectedRows[0].Tag as Fare);
            if(fare.ShowDialog() == DialogResult.OK)
            {
                _instance.EditFare(fareGV.SelectedRows[0].Index);
                UpdateGridView();
            }
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            _instance.DeleteFare(fareGV.SelectedRows[0].Index);
            UpdateGridView();
            UpdateButton();
        }

        private void UpdateButton()
        {
            editButton.Enabled = fareGV.SelectedRows.Count > 0;
            deleteButton.Enabled = fareGV.SelectedRows.Count > 0;
        }
    }
}
