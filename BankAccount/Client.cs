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

        public string ClientName
        {
            get { return this.clientName; }
        }

        public Client()
        {

        }

        public void ClientInformation()
        {
            Console.WriteLine("\nName: " + clientName);
            Console.WriteLine("Address: " + clientAddress);
        }
    }
}
