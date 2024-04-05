using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3_1b_calaunanj_hms
{
    public class User
    {
        private static int _idseed = 0;
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public int ID { get; private set; }
        public User(string name, string address, string email, int phoneNumber)
        {
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            ID = _idseed++;

        }

    }
}