using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.Models
{
    public class CustomerTable
    {

        public string ReservationName { get; set; }

        public string TableName { get; set; }

       
        public DateTime ReservationDate { get; set; }
        public DateTime ReservationTime { get; set; }
    }
}
