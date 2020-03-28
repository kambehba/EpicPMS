using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpicPMS
{
    public class Apartment
    {
        public int Id { get; set; }
        public int Bed { get; set; }
        public int Bath { get; set; }

        public decimal Rent { get; set; }

        public int sqf { get; set; }

        public int ApartmentNumber { get; set; }
    }
}
