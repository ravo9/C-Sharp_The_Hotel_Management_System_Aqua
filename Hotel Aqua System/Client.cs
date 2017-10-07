using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Aqua_System
{
    class Client
    {
        private int id;
        private string firstName = "";
        private string surname = "";
        private string gender = "";
        private DateTime dateBirth;
        private string address = "";
        private string nationality = "";
        private static int currentId = 0;
        private static List<Client> clientList = new List<Client>();
        //private static Dictionary<int, Client> clientList = new Dictionary<int, Client>();

        public Client(string f, string s, string g, DateTime d, string a, string n)
        {
            id = currentId;
            firstName = f;
            surname = s;
            gender = g;
            dateBirth = d;
            address = a;
            nationality = n;
            
            clientList.Add(this);
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

        public string firstNamePub
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string surnamePub
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
 
        public string genderPub
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public DateTime dateBirthPub
        {
            get
            {
                return dateBirth;
            }
            set
            {
                dateBirth = value;
            }
        }

        public string addressPub
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string nationalityPub
        {
            get
            {
                return nationality;
            }
            set
            {
                nationality = value;
            }
        }

        public static int getClientAmount()
        {
            return clientList.Count();
        }

        public static Client getChosenClient(int i)
        {
            return clientList[i];
        }

        /*public static Client getChosenClientById(int d)
        {
            clientList.Find()
        }*/

        public static void removeClient(int i)
        {
            clientList.RemoveAt(i);
        }
    }
}
