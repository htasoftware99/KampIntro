using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class KonutKrediManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("KOnut kredisi ödeme planı hesaplandı");
        }
    }
}
