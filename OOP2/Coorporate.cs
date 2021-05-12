using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Coorporate: Customer
    {
        // İNHERİTANCE
        // yukarıdaki tüzel kişiye : mişteri yapmanın anlamı müşterideki bütün özellikler artık coorporate da vardır.
        // Tüzel Müşteri yani şirket
        
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }


    }
}
