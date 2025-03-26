using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarRentWinForms
{
    public partial class LoginForm : Form
    {
        private CarRentManager manager = new CarRentManager();
        public LoginForm()
        {
            InitializeComponent();

            btnLogin.Click += btnLogin_Click;

            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("User");

            cmbRole.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim().ToLower();
            string password = txtPassword.Text.Trim().ToLower();
            string role = cmbRole.SelectedItem.ToString().ToLower();
            string name = txtName.Text.Trim();

            if (role == "admin" && LoginAsAdmin(username, password))
            {
                AdminForm adminform = new AdminForm(manager);
                adminform.Show();
                this.Hide();
            }
            else if (role == "user" && LoginAsUser(username, password, name))
            {
                if (!CustomerExists(name))
                {
                    MessageBox.Show("Customer not found! Please check the name.");
                    return;
                }

                if (manager == null)
                {
                    MessageBox.Show("Manager is not initialized.");
                    return;
                }

                UserForm userform = new UserForm(name, manager);
                userform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login");
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


        private bool ValidateLogin(string username, string password, string role)
        {
            string filepath = "users.txt";

            if (File.Exists(filepath))
            {
                using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (string.IsNullOrWhiteSpace(line)) continue;

                            var parts = line.Split(':');
                            if (parts.Length == 3)
                            {
                                string name = parts[0].Trim().ToLower();
                                string pass = parts[1].Trim().ToLower();
                                string rol = parts[2].Trim().ToLower();

                                if (name == username && pass == password && rol == role)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        private bool LoginAsAdmin(string username, string password)
        {
            return ValidateLogin(username, password, "admin");
        }

        private bool LoginAsUser(string username, string password, string name)
        {
            return ValidateLogin(username, password, "user") && CheckCustomerExistence(name);
        }

        private bool CheckCustomerExistence(string name)
        {
            var customer = manager.GetCustomerByName(name);
            return customer != null;
        }
    }
}
