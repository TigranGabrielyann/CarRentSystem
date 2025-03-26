using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarRentWinForms
{
    public class Customer
    {
        public string Name { get; }
        public string Phone { get; }
        public List<(Car rentedcar, int days, decimal price)> RentalHistory { get; } = new List<(Car, int, decimal)>();

        public Customer(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public void AddRental(Car rentedcar, int days, decimal price)
        {
            RentalHistory.Add((rentedcar, days, price));
        }

        public void ShowRentalHistory()
        {
            if (RentalHistory.Count == 0)
            {
                Console.WriteLine("No rentals!!!");
            }
            else
            {
                Console.WriteLine($"\n Rental history of {Name}: ");
                foreach (var (car, days, price0) in RentalHistory)
                {
                    Console.WriteLine($"{car.Mark} {car.Model} ({car.Year}) - {days} days, Total: {car.RentPrice}$");
                }
            }
        }
    }
}
