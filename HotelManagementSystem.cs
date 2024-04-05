using cc3_1b_calaunanj_hms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3_1b_calaunanj_hms
{
    public class HotelManagementSystem
    {
        private List<Reservation> _allReservation = new List<Reservation>();
        private List<Hotel> _allHotels = new List<Hotel>();
        private List<User> _allUsers = new List<User>();
        public void AddHotel(Hotel hotel)
        {
            _allHotels.Add(hotel);
        }
        public void RegisterUser(User user)
        {
            _allUsers.Add(user);
        }
        public void DisplayBookingDetails(int reservationNumber)
        {
            Console.WriteLine($"\nDetails of Reservation {reservationNumber}:");
            foreach (var reservation in _allReservation)
            {
                if (reservation.ReservationNumber == reservationNumber)
                {
                    Console.WriteLine($"{reservation.ReservationNumber} Start Time: {reservation.CheckIn}, End Time {reservation.CheckOut}, Duration: {reservation.Duration}, Total: {reservation.Price} ");
                }
            }
        }
        public Reservation CreateReservation(Hotel hotel, HotelRoom room, Guest guest, DateTime checkInDate, DateTime checkOutDate)
        {
            guest.TotalRoomCount++;
            var reservation = new Reservation(checkInDate, checkOutDate, room);
            guest.Booking.Add(reservation);
            _allReservation.Add(reservation);
            return reservation;
        }
        public void DisplayHotels()
        {
            Console.WriteLine("List of Hotels:");
            foreach (var hotel in _allHotels)
            {
                Console.WriteLine(hotel.Name + ", " + hotel.Address);
            }
        }
    }
}