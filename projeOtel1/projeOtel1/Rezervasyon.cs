using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace projeOtel1
{
    class Rezervasyon
    {

        //otel class'ına gönderir
        public void rezervasyonIstegi(int odaSecimi,string guestName)
        {
            Otel otel = new Otel();
            otel.rezervasyonGonder(odaSecimi, guestName);
        }

        public void rezervasyonIptali(int odaSecimi)
        {
            Otel otel = new Otel();
            otel.rezervasyonIptalIstegi(odaSecimi);
        }

        public void kacKisiVar()
        {
            Otel otel=new Otel();
            otel.KisiSayisiOgren();
        }

    }
}
