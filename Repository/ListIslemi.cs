using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telefon_Rehberi.Objects;

namespace Telefon_Rehberi.Repository
{
    class ListIslemi:IGenerics
    {
        public void List()
        {
            List<Person> Rehber = Data.DataBase.rehber.ToList();
            foreach (Person item in Rehber)
            {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("***********************************************");
            Console.WriteLine("İsim :{0}",item._isim);
            Console.WriteLine("Soyisim :{0}", item._soyisim);
            Console.WriteLine("Telefon :{0}", item._telefon);
            Console.WriteLine("-");
            }
        }
    }
}
