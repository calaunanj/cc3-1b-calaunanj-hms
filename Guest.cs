using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cc3_1b_calaunanj_hms
{
    public class Guest : User
    {
        public int TotalRoomCount { get; set; }
        public List<Reservation> Booking = new List<Reservation>();

        public Guest(string name, string address, string email, int phoneNumber) :
            base(name, address, email, phoneNumber)
        {

        }
        public void DisplayReservations()
        {
            Console.WriteLine($"\nList of Reservations of {Name}:");
            foreach (Reservation booking in Booking)
            {
                Console.WriteLine($"{booking.ReservationNumber} Start Time: {booking.CheckIn}, End Time {booking.CheckOut}, Duration: {booking.Duration}, Total: {booking.Price} ");
            }
        }

    }

}

