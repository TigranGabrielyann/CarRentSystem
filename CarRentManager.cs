using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarRentWinForms
{
    public class CarRentManager
    {
        public CarRentManager()
        {
            LoadCars();
            LoadCustomers();
            LoadRentals();
        }

        private readonly string dataFolder = "Data";
        private readonly string availablecarsFile = "Data/cars.txt";
        private readonly string rentedcarsFile = "Data/rentedcars.txt";
        private readonly string customersFile = "Data/customers.txt";
        private readonly string rentalsFile = "Data/rentals.txt";

        private List<Car> cars = new List<Car>();
        private List<Customer> customers = new List<Customer>();
        private Dictionary<string, List<string>> rentalHistory = new Dictionary<string, List<string>>();

        private void LoadCars()
        {
            cars.Clear();

            if (File.Exists(availablecarsFile))
            {
                var lines = File.ReadAllLines(availablecarsFile);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        string plateNum = parts[0];
                        string Mark = parts[1];
                        string Model = parts[2];
                        int Year = int.Parse(parts[3]);
                        bool isAvailable = bool.Parse(parts[4]);

                        cars.Add(new Car(plateNum, Mark, Model, Year) { IsAvailable = isAvailable });
                    }
                }
            }

            if (File.Exists(rentedcarsFile))
            {
                var lines = File.ReadAllLines(rentedcarsFile);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length >= 1)
                    {
                        string plateNum = parts[0];
                        if (!cars.Any(c => c.PlateNum == plateNum))
                        {
                            cars.Add(new Car(plateNum, "Unknown", "Unknown", 0) { IsAvailable = false });
                        }
                    }
                }
            }
        }

        private void LoadRentals()
        {
            if (File.Exists(rentalsFile))
            {
                var lines = File.ReadAllLines(rentalsFile);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length >= 3)
                    {
                        string customerName = parts[0];
                        string record = string.Join(",", parts.Skip(1));

                        if (!rentalHistory.ContainsKey(customerName))
                        {
                            rentalHistory[customerName] = new List<string>();
                        }
                        rentalHistory[customerName].Add(record);
                    }
                }
            }
        }


        private void LoadCustomers()
        {
            if (File.Exists(customersFile))
            {
                var lines = File.ReadAllLines(customersFile);
                foreach(var line in lines)
                {
                    var parts = line.Split(",");
                    if(parts.Length == 2)
                    {
                        string name = parts[0];
                        string phone = parts[1];
                        customers.Add(new Customer(name, phone));
                    }
                }
            }
        }

        public void AddCar(Car car)
        {
            if (car != null)
            {
                cars.Add(car);
                File.AppendAllText(availablecarsFile, $"{car.PlateNum},{car.Mark},{car.Model},{car.Year},{car.IsAvailable}\n");
            }
        }

        public void AddCustomer(Customer customer)
        {
            if (customer != null)
            {
                customers.Add(customer);
                File.AppendAllText(customersFile, $"{customer.Name},{customer.Phone}\n");
            }
        }

        public void DeleteCar(string plateNum)
        {
            var car = cars.FirstOrDefault(c => c.PlateNum == plateNum);
            if (car != null)
            {
                cars.Remove(car);
                Console.WriteLine($"Car {car.Mark} {car.Model} is deleted!!! ");

                SaveCars();
            }
            else
            {
                Console.WriteLine("Car do not exist!!! ");
            };
        }

        public void SaveCars()
        {
            var carData = cars.Select(c => $"{c.PlateNum},{c.Mark},{c.Model},{c.Year},{c.IsAvailable}");
            File.WriteAllLines(availablecarsFile, carData);
        }

        public void RentCar(string customerName, string plateNum, int days)
        {
            var customer = customers.FirstOrDefault(c => c.Name == customerName);
            var car = cars.FirstOrDefault(c => c.PlateNum == plateNum);

            if (customer == null)
            {
                MessageBox.Show("Customer not found!");
                return;
            }

            if (car == null || !car.IsAvailable)
            {
                MessageBox.Show("Car is not available!");
                return;
            }

            car.IsAvailable = false;
            decimal price = car.RentPrice(days);

            File.AppendAllText(rentedcarsFile, $"{plateNum},{customerName},{days},{price},False\n");

            if (!rentalHistory.ContainsKey(customerName))
            {
                rentalHistory[customerName] = new List<string>();
            }
            rentalHistory[customerName].Add($"{plateNum},{days},{price},False");

            File.AppendAllText(rentalsFile, $"{customerName},{plateNum},{days},{price},False\n");

            SaveCars();

            MessageBox.Show($"Car {car.Mark} {car.Model} rented for {days} days. Price: ${price}");
        }


        public List<string> GetCustomerHistory(string customerName)
        {
            if (rentalHistory.ContainsKey(customerName))
            {
                return rentalHistory[customerName];
            }
            return new List<string> { "No rental history found." };
        }


        public void ReturnCar(string customerName, string plateNum)
        {
            var rentedLines = File.ReadAllLines(rentedcarsFile).ToList();
            var rentedRecord = rentedLines.FirstOrDefault(line => line.Contains(plateNum));

            if (string.IsNullOrEmpty(rentedRecord))
            {
                MessageBox.Show("Car not found in rented cars!");
                return;
            }

            var parts = rentedRecord.Split(',');
            string plate = parts[0];
            string name = parts[1];
            int days = int.Parse(parts[2]);
            decimal price = decimal.Parse(parts[3]);

            var car = cars.FirstOrDefault(c => c.PlateNum == plateNum);
            if (car != null)
            {
                car.IsAvailable = true;
            }
            else
            {
                var rentedParts = rentedRecord.Split(',');
                car = new Car(plateNum, "", "", 0) { IsAvailable = true };
                cars.Add(car);
            }

            if (rentalHistory.ContainsKey(customerName))
            {
                var customerHistory = rentalHistory[customerName];
                for (int i = 0; i < customerHistory.Count; i++)
                {
                    if (customerHistory[i].StartsWith(plateNum + ","))
                    {
                        customerHistory[i] = $"{plateNum},{days},{price},True";
                        break;
                    }
                }
            }

            var rentalLines = File.ReadAllLines(rentalsFile).ToList();
            for (int i = 0; i < rentalLines.Count; i++)
            {
                if (rentalLines[i].Contains(plateNum) && rentalLines[i].EndsWith("False"))
                {
                    rentalLines[i] = $"{customerName},{plateNum},{days},{price},True";
                    break;
                }
            }
            File.WriteAllLines(rentalsFile, rentalLines);

            rentedLines.Remove(rentedRecord);
            File.WriteAllLines(rentedcarsFile, rentedLines);

            SaveCars();

            MessageBox.Show($"Car {plateNum} returned successfully!");
        }




        public void UpdateAvailableCarsListBox(ListBox availableCarsListBox, List<Car> availableCars)
        {
            availableCarsListBox.Items.Clear();

            foreach (var car in availableCars)
            {
                availableCarsListBox.Items.Add(car.PlateNum); 
            }
        }

        private void RemoveFromRentedCarsFile(string plateNum)
        {
            var rentedCars = File.ReadAllLines(rentedcarsFile).ToList();

            rentedCars.RemoveAll(line => line.Contains(plateNum));

            File.WriteAllLines(rentedcarsFile, rentedCars);
        }


        private void SaveAvailableCars()
        {
            var availableCars = cars.Where(c => c.IsAvailable).ToList();

            File.WriteAllText(availablecarsFile, string.Empty);

            foreach (var car in availableCars)
            {
                var carData = $"{car.PlateNum},{car.Mark},{car.Model},{car.Year},{car.IsAvailable}";
                File.AppendAllText(availablecarsFile, carData + Environment.NewLine);  
            }
        }



        public void ShowAvailableCars(ListBox listBox)
        {
            var availablecar = GetAvailableCars();
            listBox.Items.Clear();
            if (availablecar.Count > 0)
            {
                Console.WriteLine("\n Available cars:  ");
                foreach (var car in availablecar)
                {
                    Console.WriteLine($"{car.PlateNum} - {car.Mark} {car.Model}, {car.Year}");
                }
            }
            else
            {
                Console.WriteLine("No cars available!!!");
            }
        }

        public void ShowCustomerHistory(string customername)
        {
            var customer = customers.FirstOrDefault(c => c.Name == customername);
            if (customer != null)
            {
                customer.ShowRentalHistory();
            }
            else
            {
                Console.WriteLine("Customer not found!!! ");
            }
        }

        public Customer GetCustomerByName(string name)
        {
            return customers.FirstOrDefault(c => c.Name == name);
        }

        public List<Car> GetAvailableCars()
        {
            return cars.Where(c => c.IsAvailable).ToList();
        }
    }
}
