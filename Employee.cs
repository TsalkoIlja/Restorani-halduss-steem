using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorani_haldussüsteem
{
    public abstract class Employee : Person
    {
        public double Palk { get; protected set; }

        protected Employee(string nimi, int id, double palk)
            : base(nimi, id)
        {
            Palk = palk;
        }

        public abstract void DoWork();
    }
}
