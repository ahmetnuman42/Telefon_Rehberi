using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telefon_Rehberi.Objects;

namespace Telefon_Rehberi.Data
{
    class DataBase
    {
        public static List<Person> rehber = new List<Person>();       
        static DataBase()
        { //Constructer Method
            rehber = new List<Person>()
        {
            new Person("Ahmet","Ecevitci","0544 222 35 36"),
            new Person("Mehmet","Erdem","0542 262 37 37"),
            new Person("Veli","Kulak","0541 125 65 17"),
            new Person("Ali","Çene","0535 155 23 65"),
            new Person("Ayşe","Duru","0546 132 65 89")
        };
        }



    public static List<Person> Rehber
        {
            get { return rehber; }
        }


    }
}
