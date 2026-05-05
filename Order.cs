using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorani_haldussüsteem
{
    public class Order
    {
        public List<MenuItem> Items { get; private set; } = new List<MenuItem>();
        public string Status { get; set; }

        public Order()
        {
            Status = "Valmistamisel";
        }

        public void AddItem(MenuItem item)
        {
            Items.Add(item);
        }

        public double CalculateTotal()
        {
            return Items.Sum(i => i.Hind);
        }
    }
}
