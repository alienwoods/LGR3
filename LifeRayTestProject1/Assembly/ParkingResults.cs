using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeRayTestProject1
{
    public class ParkingResults
    {
        public int price, days, hours, minutes;

        public ParkingResults()
        {
        }

        public ParkingResults(int p1, int p2, int p3, int p4)
        {
            price = p1;
            days = p2;
            hours = p3;
            minutes = p4;
        }

        public string ToString()
        {
            return price.ToString() + "," + days.ToString()+"," + hours.ToString() + "," + minutes.ToString();
        }
    }
}
