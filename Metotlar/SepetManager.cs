﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + product.Adi);
        }

        public void Ekle2(string Adi, string aciklama, double fiyat, int stokAdedi)
        {
             
        }
    }
}
