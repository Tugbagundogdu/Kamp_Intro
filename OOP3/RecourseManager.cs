using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RecourseManager
    {
        //başvuru yönetimi

        public void BasvuruYap(ICrediManager crediManager , IloggerService ıloggerService)
        {
            crediManager.Calculate();
            ıloggerService.Log();

        }

        public void KrediOnBilgilendirmesiYap(List<ICrediManager> credis)
        {
            foreach (var credit in credis)
            {
                credit.Calculate();
            }
        }
    }
}
