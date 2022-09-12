using System;
using Telefon_Rehberi.Repository;

namespace Telefon_Rehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            geri:
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            string girilen=Console.ReadLine();
            switch (girilen)
            {
                case "1":
                    SaveIslemi save = new SaveIslemi();
                    save.Save();
                    break;
                case "2":
                    DeleteIslemi delete = new DeleteIslemi();
                    delete.Delete();
                    break;
                case "3":
                    UpdateIslemi update = new UpdateIslemi();
                    update.Update();
                    break;
                case "4":
                    ListIslemi list = new ListIslemi();
                    list.List();
                    break;
                case "5":
                    SearchIslemi search = new SearchIslemi();
                    search.Search();
                    break;
                default:
                    Console.WriteLine("Lütfen belirtilen seçeneklerden birini seçiniz");
                    goto geri;
                   
            }
        }
    }
}
