using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Indıvidual: Customer
    {
        //  yukardaki classın yanında ındıvidualda nın yanındaki : customerın anlamı customer özelliklerinin hepsi ındividualda da vardır.
        // bunun adı miras hani İNHERİTANCE dır.
        // Bireysel Müşteri yani gerçek

       
        public string TcNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }


    }
}
