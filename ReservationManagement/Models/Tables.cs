using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace ReservationManagement.Models
{
    public class Tables
    {
        public int TableId { get; set; }
        public string Name { get; set; }

        public List<Tables> tables { get; set; }

      
      


    }

}
