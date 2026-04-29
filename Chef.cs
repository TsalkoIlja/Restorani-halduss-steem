using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorani_haldussüsteem
{
    public class Chef : Employee, IProcessOrder
    {
        public Chef(string nimi, int id, double palk)
            : base(nimi, id, palk)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Kokk: {Nimi}, ID: {ID}, palk: {Palk}");
        }

        public override void DoWork()
        {
            Console.WriteLine("Kokk valmistab toitu.");
        }

        public void ProcessOrder(Order order)
        {
            order.Status = "Valmis";
            Console.WriteLine("Kokk valmistas tellimuse.");
        }

        public void CancelOrder(Order order)
        {
            order.Status = "Tühistatud";
            Console.WriteLine("Kokk ei saa tellimust valmistada, tellimus tühistatud.");
        }
    }
}
