using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Aqua_System
{
    class Room
    {
        private int roomNumber;
        private string roomType;
        private int floorNo;
        private double basicNightPrice;
        private string additionalInfo;
        private static List<String> typeList = new List<String>();
        private static List<Room> roomList = new List<Room>();

        public Room(int rn, string rt, int f, double n, string a)
        {
            roomNumber = rn;
            roomType = rt;
            floorNo = f;
            basicNightPrice = n;
            additionalInfo = a;

            roomList.Add(this);
        }

        public int roomNumberPub
        {
            get
            {
                return roomNumber;
            }
            set
            {
                roomNumber = value;
            }
        }

        public string roomTypePub
        {
            get
            {
                return roomType;
            }
            set
            {
                roomType = value;
            }
        }

        public int floorNoPub
        {
            get
            {
                return floorNo;
            }
            set
            {
                floorNo = value;
            }
        }

        public double basicNightPricePub
        {
            get
            {
                return basicNightPrice;
            }
            set
            {
                basicNightPrice = value;
            }
        }
        

        public string additionalInfoPub
        {
            get
            {
                return additionalInfo;
            }
            set
            {
                additionalInfo = value;
            }
        }

        public static int getRoomAmount()
        {
            return roomList.Count();
        }

        public static Room getChosenRoom(int i)
        {
            return roomList[i];
        }
        
        public static void removeRoom(int i)
        {
            roomList.RemoveAt(i);
        }

        public static void removeAllRooms()
        {
            roomList.Clear();
        }

        public static int getTypeAmount()
        {
            return typeList.Count();
        }

        public static void addNewType(String t)
        {
            typeList.Add(t);
        }

        public static String getChosenType(int i)
        {
            return typeList[i];
        }

        public static void removeType(int i)
        {
            typeList.RemoveAt(i);
        }

        public static void removeAllTypes()
        {
            typeList.Clear();
        }

        public static void sortTypes()
        {
            typeList.Sort();
        }
    }
}
