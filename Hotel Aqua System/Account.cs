using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Aqua_System
{
    class Account
    {
        private string name = "";
        private DateTime lastUpdate;
        private static Account theOnlyAccount;

        public Account(string n, DateTime d)
        {
            name = n;
            lastUpdate = d;
            theOnlyAccount = this;
        }

        public string namePub
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public DateTime lastUpdatePub
        {
            get
            {
                return lastUpdate;
            }
            set
            {
                lastUpdate = value;
            }
        }

        public static bool readFromFile()
        {
            string name = "";
            DateTime date;

            if (theOnlyAccount != null)
                return false;

            if (File.Exists("account.txt"))
            {
                System.IO.StreamReader file = new System.IO.StreamReader("account.txt");
                name = file.ReadLine();

                if (name != "")
                {
                    date = DateTime.Parse(file.ReadLine());
                    Account a = new Account(name, date);
                }
                else
                    return false;

                file.Close();
                return true;
            }
            else
                return false;
        }

        public static Account getAccount()
        {
            return theOnlyAccount;
        }

        public static void AccountEdit(string n, DateTime d)
        {
            theOnlyAccount.name = n;
            theOnlyAccount.lastUpdate = d;
        }

        public static void AccountRemove()
        {
            theOnlyAccount = null;
        }
    }
}
