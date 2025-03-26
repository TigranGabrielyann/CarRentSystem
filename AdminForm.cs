using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentWinForms
{
    public partial class AdminForm : Form
    {
        private CarRentManager manager;
        public AdminForm(CarRentManager carManager)
        {
            InitializeComponent();
            
            manager = carManager;

            Cartype.Items.Add("Standart");
            Cartype.Items.Add("SUV");
            Cartype.Items.Add("MiniVan");
            Cartype.Items.Add("SportCar");

            Cartype.SelectedIndex = 0;

            btnAddcar.Click += btnAddcar_Click;
            btnAddcustomer.Click += btnAddcustomer_Click;
            btnDeletecar.Click += btnDeletecar_Click;
            btnCustomerhistory.Click += btnCustomerhistory_Click;
            btnback.Click += btnback_Click;
            btnexit.Click += btnexit_Click;
        }

        private void btnAddcar_Click(object sender, EventArgs e)
        {
            string plate = txtPlate.Text;
            string mark = txtMark.Text;
            string model = txtModel.Text;
            int year = int.Parse(txtYear.Text);
            string type = Cartype.SelectedItem.ToString();

            if (string.IsNullOrEmpty(plate) || string.IsNullOrEmpty(mark) || string.IsNullOrEmpty(model))
            {
                MessageBox.Show("Provide all car details!!! ");
                return;
            }

            Car newcar = null;

            switch (type)
            {
                case "Standart":
                    newcar = new Car(plate, mark, model, year);
                    break;
                case "SUV":
                    newcar = new SUV(plate, mark, model, year);
                    break;
                case "MiniVan":
                    newcar = new MiniVan(plate, mark, model, year);
                    break;
                case "SportCar":
                    newcar = new SportCar(plate, mark, model, year);
                    break;
            }

            manager.AddCar(newcar);
            MessageBox.Show($"Car {mark} {model} ({type}) added successfully!");
        }

        private void btnAddcustomer_Click(object sender, EventArgs e) 
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;

            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Provide customer details");
                return;
            }

            Customer customer = new Customer(name, phone);
            manager.AddCustomer(customer);
            MessageBox.Show($"Customer {name} added successfully!");
        }

        private void btnDeletecar_Click(object sender, EventArgs e) 
        {
            string plate = txtPlate.Text;
            if(string.IsNullOrEmpty(plate))
            {
                MessageBox.Show("Provide car plate number");
                return;
            }
            manager.DeleteCar(plate);
            MessageBox.Show($"Car with plate number {plate} deleted!");
        }

        private void btnCustomerhistory_Click(object sender, EventArgs e)
        {
            string customerName = txtName.Text.Trim();

            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please enter a valid customer name.");
                return;
            }

            listhistory.Items.Clear();

            List<string> rentalHistory = GetCustomerRentalHistory(customerName);

            if (rentalHistory.Count > 0)
            {
                foreach (var record in rentalHistory)
                {
                    listhistory.Items.Add(record);
                }
            }
            else
            {
                MessageBox.Show($"No rental history found for customer: {customerName}");
            }
        }


        private bool CustomerExists(string name)
        {
            string customersFile = "Data/customers.txt";

            if (File.Exists(customersFile))
            {
                var lines = File.ReadAllLines(customersFile);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2 && parts[0].Trim().ToLower() == name.ToLower())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public List<string> GetCustomerRentalHistory(string customerName)
        {
            List<string> rentalHistory = new List<string>();
            string rentalsFile = "Data/rentals.txt";

            if (File.Exists(rentalsFile))
            {
                var lines = File.ReadAllLines(rentalsFile);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');

                    if (parts.Length >= 1 && parts[0].Trim().Equals(customerName, StringComparison.OrdinalIgnoreCase))
                    {
                        string historyEntry;
                        if (parts.Length >= 5)
                        {
                            string status = parts[4].Trim().Equals("True", StringComparison.OrdinalIgnoreCase) ? "Returned" : "Rented";
                            historyEntry = $"Car: {parts[1]}, Days: {parts[2]}, Price: {parts[3]}, Status: {status}";
                        }
                        else
                        {
                            historyEntry = line;
                        }

                        rentalHistory.Add(historyEntry);
                    }
                }
            }
            return rentalHistory;
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
