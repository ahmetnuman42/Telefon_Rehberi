using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telefon_Rehberi.Objects;

namespace Telefon_Rehberi.Repository
{
    class SearchIslemi:IGenerics
    {
        public void Search()
        {
            Search:
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz. /n *********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            Person person;
            string input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("İsim veya soyisim giriniz : ");
                String input2 = Console.ReadLine();
                person = Data.DataBase.rehber.FirstOrDefault(x => x._isim == input2 || x._soyisim == input2);
                Show(person);
            }
            else if (input == "2")
            {
                Console.WriteLine("Telefon numarası giriniz : ");
                String input3 = Console.ReadLine();
                foreach (Person item in Data.DataBase.Rehber)
                {
                    if (item._telefon.Contains(input3))
                    {
                        Show(item);
                    }
                }
            }
            else
            {
                Console.WriteLine("Gecersiz bir karakter girdiniz.Tekrar deneyiniz");
                goto Search;
            }
        }
        public void Show(Person person)
        {
            Console.WriteLine("İsim: " + person._isim);
            Console.WriteLine("Soyisim: " + person._soyisim);
            Console.WriteLine("Telefon Numarası: " + person._telefon);
            Console.WriteLine("-");
        }
    }
}
