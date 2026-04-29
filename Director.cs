using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorani_haldussüsteem
{
    
    public class Director : Employee, IProcessOrder
    {
        public Director(string nimi, int id, double palk)
            : base(nimi, id, palk)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Direktor: {Nimi}, ID: {ID}, palk: {Palk}");
        }

        public override void DoWork()
        {
            Console.WriteLine("Direktor haldab strateegiat.");
        }

        public void ProcessOrder(Order order)
        {
            order.Status = "Kinnitatud";
            Console.WriteLine("Direktor kinnitas tellimuse.");
        }

        public void CancelOrder(Order order)
        {
            order.Status = "Tühistatud";
            Console.WriteLine("Direktor tühistas tellimuse.");
        }
    }
}
