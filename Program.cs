using System;
using System.Globalization;

namespace Restorani_haldussüsteem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kliendiNimi;
            do
            {
                Console.Write("Sisesta kliendi nimi: ");
                kliendiNimi = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(kliendiNimi));

            var customer = new Customer(kliendiNimi, 1);
            var order = new Order();

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

                // TryParse, который принимает и запятую, и точку
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
            Console.WriteLine($"Staatus: {order.Status}");

            var director = new Director("Mari", 2, 2500);
            var chef = new Chef("Jaan", 3, 1800);

            Console.WriteLine("\nKes töötleb tellimust?");
            Console.WriteLine("1 - Direktor");
            Console.WriteLine("2 - Kokk");
            Console.Write("Vali: ");

            string valik = Console.ReadLine();

            if (valik == "1")
            {
                director.ProcessOrder(order);
            }
            else if (valik == "2")
            {
                chef.ProcessOrder(order);
            }
            else
            {
                Console.WriteLine("Vale valik.");
            }

            Console.WriteLine($"Tellimuse lõplik staatus: {order.Status}");

            Console.ReadLine();
        }
    }
}