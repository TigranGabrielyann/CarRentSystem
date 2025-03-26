using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentWinForms
{
    public partial class UserForm : Form
    {

        private CarRentManager manager;
        private string currentUser;
        public UserForm(string username, CarRentManager rentmanager)
        {
            InitializeComponent();

            manager = rentmanager;
            currentUser = username;

            LoadAvailableCars();

            btnRentcar.Click += btnRentcar_Click;
            btnReturncar.Click += btnReturncar_Click;
            btnShowAvailablecars.Click += btnShow_Click;
            btnback.Click += btnback_Click;
            btnexit.Click += btnexit_Click;

        }

        private void LoadAvailableCars()
        {
            listBox1.Items.Clear(); 

            var availableCars = manager.GetAvailableCars();
            if (availableCars.Count > 0)
            {
                foreach (var car in availableCars)
                {
                    listBox1.Items.Add($"{car.PlateNum} - {car.Mark} {car.Model}, {car.Year}");
                }
            }
            else
            {
                MessageBox.Show("No available cars.");
            }
        }



        private void btnRentcar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a car to rent.");
                return;
            }

            string selectedCar = listBox1.SelectedItem.ToString();

            string plateNum = selectedCar.Split('-')[0].Trim(); 

            if (string.IsNullOrEmpty(plateNum))
            {
                MessageBox.Show("Invalid car selection.");
                return;
            }

            if (!int.TryParse(txtdays.Text, out int days) || days <= 0)
            {
                MessageBox.Show("Please enter a valid number of days.");
                return;
            }

            manager.RentCar(currentUser, plateNum, days);

            LoadAvailableCars();
        }



        private void btnReturncar_Click(object sender, EventArgs e)
        {
            string plateNum = txtplate.Text.Trim();

            if (string.IsNullOrEmpty(plateNum))
            {
                MessageBox.Show("Enter the car's plate number.");
                return;
            }

            manager.ReturnCar(currentUser, plateNum);
            MessageBox.Show($"Car {plateNum} returned!");

            LoadAvailableCars();
        }




        private void btnShow_Click(object sender, EventArgs e)
        {
            manager.ShowAvailableCars(listBox1);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
