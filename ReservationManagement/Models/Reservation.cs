using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ReservationManagement.Models
{
   

    public class Reservation
    {
        public Reservation()
        {
          
        }
        public int ResId { get; set; }
        public int tableId { get; set; }
        
        public string tableName { get; set; }
        public DateTime date { get; set; }

        public DateTime time { get; set; }
        public string reservedName { get; set; }
        public string description { get; set; }

       public List<Tables> tables { get; set; }

    
     
    }
    



     








    }

