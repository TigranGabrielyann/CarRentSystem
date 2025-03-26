using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentWinForms
{
    public interface IRentable
    {
        decimal RentPrice(int days);
    }
}
