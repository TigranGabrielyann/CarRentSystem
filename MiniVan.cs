using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentWinForms
{
    public class MiniVan : Car
    {
        public MiniVan(string platenum, string mark, string model, int year)
            : base(platenum, mark, model, year)
        {
            BasePrice = 75;
        }


        public override decimal RentPrice(int days)
        {
            decimal totalprice = days * 75;

            if (days > 7)
            {
                totalprice *= 0.9m;
            }
            return totalprice;
        }
    }
}
