using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3_1b_calaunanj_hms
{
    public enum RoomStyle
    {
        TwinRoom,
        QueenRoom,
        KingRoom
    }
    public class HotelRoom
    {
        public int RoomNumber { get; private set; }
        public RoomStyle Style { get; set; }
        public int Price { get; set; }
        public bool IsOccupied { get; set; }
        public HotelRoom(int roomnumber, RoomStyle style, int price)
        {
            RoomNumber = roomnumber;
            Style = style;
            Price = price;
            IsOccupied = false;
        }
    }
}
