using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telefon_Rehberi.Objects;

namespace Telefon_Rehberi.Repository
{
    class DeleteIslemi:IGenerics
    {
        public void Delete()
        {
            while (true)
            {            
            Console.WriteLine("Silmek istediğiniz kişinin adını veya soyadını giriniz");
            string kisi = Console.ReadLine();
            bool sonuc = Kontrol(kisi);// kişi rehberde var mı yok mu diye kontrol ediyoruz.
            List<Person> liste = Data.DataBase.rehber;
            if (sonuc)
            {
                Person silinecek = Data.DataBase.rehber.FirstOrDefault(x => x._isim == kisi || x._soyisim == kisi); //Linq 
                bool cevap = sonkarar(silinecek);
                if (cevap == true)
                {
                    Data.DataBase.rehber.Remove(silinecek);
                    Console.WriteLine("Başarı ile silindi");
                    break;
                }
                else
                {
                    Console.WriteLine("{0} kişisini Silme işlemi iptal edildi",silinecek._isim);
                }
            }
                else
                {
                    int deger;
                    Console.WriteLine("Aradığınız kayıt rehberde bulunamadı. Lütfen bir seçim yapnız.");
                    geri:
                    Console.WriteLine("*Silmeyi sonlandırmak için :(1)");
                    Console.WriteLine("*Yeniden denemek için      :(2)");
                    if(int.TryParse(Console.ReadLine(),out deger))
                    {
                        if (deger == 1)
                        {
                            Console.WriteLine("Silme işlemi sonlandırıldı");
                            break;
                        }
                        else if (deger == 2)
                        {
                            Console.WriteLine("------------------------------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("geçersiz bir karakter girdiniz tekrar deneyiniz.");
                        goto geri;
                    }
                }
            }

        }

        private bool sonkarar(Person silinecek)
        {
            while (true)
            {     
           
            Console.WriteLine("{0} {1} kişisi silinecek emin misiniz(Y/N)", silinecek._isim, silinecek._soyisim);
            string karar = Console.ReadLine().ToUpper();
            if (karar == "Y")
            {
                    return true;
            }
            else if (karar == "N")
                {
                    return false;                   
                }
                else
                {
                    Console.WriteLine("Y veya N harfinden birini seçiniz");                    
                }       
            }
        }

        public bool Kontrol(string input)
        {
            bool Kontrol = Data.DataBase.Rehber.Any(x => x._isim == input || x._soyisim == input);
            return Kontrol;
        }
    }
}
