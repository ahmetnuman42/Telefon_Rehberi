using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi.Objects
{
    internal class Person
    {
        private string isim;
        private string soyisim;
        private string telefon;

        public string _isim { get { return isim; } set { this.isim = value; } }
        public string _soyisim { get { return soyisim; } set { this.soyisim = value; } }
        public string _telefon { get { return telefon; } set { this.telefon = value; } }

        public Person(string isim,string soyisim,string tel)
        {
            this._isim = isim;
            this._soyisim = soyisim;
            this._telefon = tel;
        }

    }
}
