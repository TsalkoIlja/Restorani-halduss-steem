using System;
using System.Globalization;

namespace Restorani_haldussüsteem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- KLIENDI LOOMINE ---
            string kliendiNimi;
            do
            {
                Console.Write("Sisesta kliendi nimi: ");
                kliendiNimi = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(kliendiNimi));

            var customer = new Customer(kliendiNimi, 1);
            customer.DisplayInfo();

            var order = new Order();

            // --- TOODETE LISAMINE ---
            Console.WriteLine("\nMitu toodet soovid lisada?");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.Write("Palun sisesta number: ");
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write($"\nSisesta toote {i + 1} nimi: ");
                string nimi = Console.ReadLine();

                Console.Write($"Sisesta toote {i + 1} hind: ");

                double hind;

                while (!double.TryParse(
                    Console.ReadLine().Replace(",", "."),
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out hind))
                {
                    Console.Write("Palun sisesta hind numbrina: ");
                }

                var item = new MenuItem(nimi, hind);
                order.AddItem(item);
            }

            customer.MakeOrder(order);

            Console.WriteLine($"\nTellimuse summa: {order.CalculateTotal()} €");
            Console.WriteLine($"Tellimuse algne staatus: {order.Status}");

            // --- TÖÖTAJATE LOOMINE ---
            var director = new Director("Mari", 2, 2500);
            var chef = new Chef("Jaan", 3, 1800);

            Console.WriteLine("\nTöötajate info:");
            director.DisplayInfo();
            chef.DisplayInfo();

            // --- TÖÖTLEJA VALIK ---
            Console.WriteLine("\nKes töötleb tellimust?");
            Console.WriteLine("1 - Direktor");
            Console.WriteLine("2 - Kokk");
            Console.Write("Vali: ");

            string valik = Console.ReadLine();

            if (valik == "1")
            {
                director.DoWork();
                director.ProcessOrder(order);
            }
            else if (valik == "2")
            {
                chef.DoWork();
                chef.ProcessOrder(order);
            }
            else
            {
                Console.WriteLine("Vale valik.");
            }

            Console.WriteLine($"Tellimuse staatus pärast töötlemist: {order.Status}");

            // --- KAS TÜHISTADA TELLIMUS? ---
            Console.WriteLine("\nKas soovid tellimust tühistada? (jah/ei)");
            string cancel = Console.ReadLine().ToLower();

            if (cancel == "jah")
            {
                if (valik == "1")
                    director.CancelOrder(order);
                else if (valik == "2")
                    chef.CancelOrder(order);

                Console.WriteLine($"Tellimus tühistatud. Lõplik staatus: {order.Status}");
            }

            Console.WriteLine("\nTestimine lõpetatud.");
            Console.ReadLine();
        }
    }
}
