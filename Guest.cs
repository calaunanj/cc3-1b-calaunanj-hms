using cc3_1b_calaunanj_hms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cc3_1b_calaunanj_hms

{
    class Guest : User
    {
        public int TotalRoomCount { get; set; }
        public List<Booking> Booking = new List<Booking>();

        public Guest(string name, string address, string email, int phoneNumber, string password) :
            base(name, address, email, phoneNumber, password)
        {

        }
        public void DisplayBookings()
        {
            Console.WriteLine($"\nList of Reservations of {Name}:");
            foreach (Booking booking in Booking)
            {
                Console.WriteLine($"{booking.ReservationNumber} Start Time: {booking.CheckIn}, End Time {booking.CheckOut}, Duration: {booking.Duration}, Total: {booking.Price} ");
            }
        }

    }

}
