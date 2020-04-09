using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EpicPMS
{
    public class Tenent
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public decimal rent { get; set; }

        public int apartmentNumber { get; set; }

        private DateTime _startDate;
        public DateTime startDate
        {
            get { return _startDate; }
            set { _startDate = value;_startDate.ToString("yyyy-MM-DD");
                }
        }

        private DateTime _enddate;
        public DateTime endDate
        {
            get { return _enddate; }
            set { _enddate.ToString("yyyy-MM-DD"); }
        }


    }
}
