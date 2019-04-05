using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOtel1
{
    class Otel
    {


        public void rezervasyonGonder(int odaSecimi)
        {
            Oda oda = new Oda();
            oda.rezervasyonYap();
        }

        public void rezervasyonIptalIstegi(int odaSecimi)
        {
            Oda oda = new Oda();
            oda.rezervasyonIptalEt(odaSecimi);
        }
    }
}
