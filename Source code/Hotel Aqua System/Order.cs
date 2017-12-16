using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Aqua_System
{
    class Order
    {
        private int id;
        private DateTime startDate;
        private DateTime endDate;
        // Czy to na pewno nie kopia, tylko referencja?
        private int orderedRoom;
        private int orderingClient;
        private int discountPercentage;
        private double anotherPrice;
        private String additionalInfo;
        private bool isRealized = false;
        private bool isPaid = false;
        private static int currentId = 0;
        private static List<Order> orderList = new List<Order>();

        public Order(DateTime s, DateTime e, int r, int c, int d, double ap, String a)
        {
            id = currentId;
            startDate = s;
            endDate = e;
            orderedRoom = r;
            orderingClient = c;
            discountPercentage = d;
            anotherPrice = ap;
            additionalInfo = a;

            orderList.Add(this);
            currentId++;
        }

        public int idPub
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public DateTime startDatePub
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }

        public DateTime endDatePub
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
            }
        }

        public int orderedRoomPub
        {
            get
            {
                return orderedRoom;
            }
            set
            {
                orderedRoom = value;
            }
        }

        public int orderingClientPub
        {
            get
            {
                return orderingClient;
            }
            set
            {
                orderingClient = value;
            }
        }

        public int discountPercentagePub
        {
            get
            {
                return discountPercentage;
            }
            set
            {
                discountPercentage = value;
            }
        }

        public double anotherPricePub
        {
            get
            {
                return anotherPrice;
            }
            set
            {
                anotherPrice = value;
            }
        }

        public String additionalInfoPub
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

        public bool isRealizedPub
        {
            get
            {
                return isRealized;
            }
            set
            {
                isRealized = value;
            }
        }

        public bool isPaidPub
        {
            get
            {
                return isPaid;
            }
            set
            {
                isPaid = value;
            }
        }

        public static int getOrderAmount()
        {
            return orderList.Count();
        }

        public static Order getChosenOrder(int i)
        {
            return orderList[i];
        }

        public static void removeOrder(int i)
        {
            orderList.RemoveAt(i);
        }

        // A method that checks which rooms are not available in a certain period.
        public static List<int> notAvailableRooms(DateTime s, DateTime t)
        {
            List<int> notAvailableRooms = new List<int>();

            // An issue - date of check-out is before the date of check-in.
            if (t <= s)
            {
                for (int i = 0; i < Room.getRoomAmount(); i++)
                {
                    notAvailableRooms.Add(Room.getChosenRoom(i).roomNumberPub);
                }
            }

            else
            {
                for (int i = 0; i < getOrderAmount(); i++)
                {
                    if ((orderList[i].startDate >= t || orderList[i].endDate <= s))
                        continue;
                    else
                        notAvailableRooms.Add(orderList[i].orderedRoomPub);
                }
            }
            
            return notAvailableRooms;
        }
    }
}
