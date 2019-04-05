using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOtel1
{
    class Rezervasyon
    {

        public void odaSorgusu()
        {

        }

        //otel class'ına gönderir
        public void rezervasyonIstegi(int odaSecimi)
        {
            Otel otel = new Otel();
            otel.rezervasyonGonder(odaSecimi);
        }

        public void rezervasyonIptali(int odaSecimi)
        {
            Otel otel = new Otel();
            otel.rezervasyonIptalIstegi(odaSecimi);
        }

        public void kacKisiVar()
        {

        }

    }
}
