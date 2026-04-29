using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorani_haldussüsteem
{
    public abstract class Person
    {
        public string Nimi { get; protected set; }
        public int ID { get; protected set; }

        protected Person(string nimi, int id)
        {
            Nimi = nimi;
            ID = id;
        }

        public abstract void DisplayInfo();
    }
}
