using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorani_haldussüsteem
{
    public interface IProcessOrder
    {
        void ProcessOrder(Order order);
        void CancelOrder(Order order);
    }
}
