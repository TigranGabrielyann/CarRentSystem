using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentWinForms
{
    public class Car : IRentable
    {
        public string PlateNum { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; } = true;
        protected decimal BasePrice = 50;


        public Car(string platenum, string mark, string model, int year)
        {
            PlateNum = platenum;
            Mark = mark;
            Model = model;
            Year = year;
        }

        public virtual decimal RentPrice(int days)
        {
            decimal totalprice = days * BasePrice;

            if (days > 7)
            {
                totalprice *= 0.9m;
            }
            return totalprice;
        }
    }
}
