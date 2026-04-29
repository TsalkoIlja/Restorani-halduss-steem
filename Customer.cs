using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorani_haldussüsteem
{
    public class Customer : Person
    {
        public List<Order> OrderList { get; private set; } = new List<Order>();

        public Customer(string nimi, int id)
            : base(nimi, id)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Klient: {Nimi}, ID: {ID}, tellimuste arv: {OrderList.Count}");
        }

        public void MakeOrder(Order order)
        {
            OrderList.Add(order);
            Console.WriteLine("Klient tegi uue tellimuse.");
        }
    }
}
