﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Kredisi ödeme planı hesaplandı");
        }
    }
}
