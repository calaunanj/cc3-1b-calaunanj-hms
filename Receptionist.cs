using cc3_1b_calaunanj_hms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3_1b_calaunanj_hms

{
    class Receptionist : User
    {
        public Receptionist(string name, string address, string email, int phoneNumber, string password) :
            base(name, address, email, phoneNumber, password)
        {
        }
        public void BookReservation(Guest guest, Booking booking)
        {
            guest.TotalRoomCount++;
            guest.Booking.Add(booking);
        }
    }
}
