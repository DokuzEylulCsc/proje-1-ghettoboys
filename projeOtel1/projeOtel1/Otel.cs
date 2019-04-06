using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOtel1
{
    class Otel
    {
       

        public void rezervasyonGonder(int odaSecimi,string guestName)
        {
            Oda oda = new Oda();
            oda.rezervasyonYap(odaSecimi,guestName);
        }

        public void rezervasyonIptalIstegi(int odaSecimi)
        {
            Oda oda = new Oda();
            oda.rezervasyonIptalEt(odaSecimi);
        }

        public void KisiSayisiOgren()
        {
            Oda oda=new Oda();
            oda.KisiSayisi();
        }
    }
}
