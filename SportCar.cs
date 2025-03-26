using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentWinForms
{
    public class SportCar : Car
    {
        public SportCar(string platenum, string mark, string model, int year)
            : base(platenum, mark, model, year)
        {
            BasePrice = 120;
        }

        public override decimal RentPrice(int days)
        {
            decimal totalprice = days * 120;

            if (days > 7)
            {
                totalprice *= 0.9m;
            }
            return totalprice;
        }
    }
}
