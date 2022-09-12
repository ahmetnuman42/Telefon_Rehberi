using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telefon_Rehberi.Objects;

namespace Telefon_Rehberi.Repository
{
    class UpdateIslemi:IGenerics
    {
        public void Update()
        {
            tekrar:
            Console.WriteLine("Güncellemek istediğiniz kişinin adını veya soyadını giriniz.");
            string kisi = Console.ReadLine();
            Person sahis = Data.DataBase.rehber.FirstOrDefault(x => x._isim == kisi || x._soyisim == kisi);
            if (sahis != null)
            {
                Console.WriteLine("Yeni numarayı giriniz :");
                string yenino = Console.ReadLine();
                sahis._telefon = yenino;
                Console.WriteLine("Güncelleme başarı ile yapıldı");
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere göre kişi bulunamadı.Tekrar deneyiniz..");
                goto tekrar;
            }
        }
    }
}
