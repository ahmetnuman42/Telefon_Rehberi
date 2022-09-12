using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telefon_Rehberi.Objects;

namespace Telefon_Rehberi.Repository
{
    class SaveIslemi:IGenerics
    {
        public void Save()
        {
            Console.Write("İsim giriniz :");
            string _isim = Console.ReadLine();
            Console.Write("Soyisim giriniz :");
            string _soyisim = Console.ReadLine();
            Console.Write("Telefon Numarası giriniz :");
            string _telefon = Console.ReadLine();
            Person yeniPerson = new Person(isim: _isim, soyisim: _soyisim, tel: _telefon);
            Data.DataBase.rehber.Add(yeniPerson);
            Console.WriteLine("Yeni kayıt eklendi");
            
        }
    }
}
