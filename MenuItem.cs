using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorani_haldussüsteem
{
    public class MenuItem
    {
        public string Nimi { get; set; }
        public double Hind { get; set; }

        public MenuItem(string nimi, double hind)
        {
            Nimi = nimi;
            Hind = hind;
        }
    }
}
