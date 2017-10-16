using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Client
    {
        public string clientName = "Greg Hastings";
        public string clientAddress = "123 Fake Address Ave. Made Up, OH";
        public string clientBank = "321 Banking St. Made Up, OH";

        public string ClientName
        {
            get { return this.clientName; }
        }

        public string ClientAddress
        {
            get { return this.clientAddress; }
        }

        public string ClientBank
        {
            get { return this.clientBank; }
        }

        public Client()
        {

        }

        public void ClientInformation()
        {
            Console.WriteLine("\nName: " + clientName);
            Console.WriteLine("Address: " + clientAddress);
            Console.WriteLine("Local Bank: " + clientBank);
        }
    }
}
