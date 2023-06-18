using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationManagement.Models
{
    public class User
    {
       
        public string userName { get; set; }
        public string Password { get; set; }


        public User(string _userName="mehmet",string _password = "1234")
        {
            userName = _userName;
            Password = _password;
        }
    }
}
