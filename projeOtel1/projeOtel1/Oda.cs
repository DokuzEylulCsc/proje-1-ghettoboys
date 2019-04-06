using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace projeOtel1
{
    public class Oda
    {
        public static List<Oda> RoomList=new List<Oda>();
        private static int idSayac = 1;
        public string GuestName { get; set; }
        public String odaTuru { get; set; }
        public bool musaitMi { get; set; }
        public int id { get; set; }
        public Oda()
        {
            this.id = idSayac;
            idSayac++;
            
        }
        //rezervasyonun gerçekleştiği asıl yer
        public void rezervasyonYap(int odaSecimi,string guestName)
        {
            this.GuestName = guestName;
            this.musaitMi = false;
            switch (odaSecimi)
            {
                case 1:
                    this.odaTuru = "TEK KİŞİLİK";
                    break;
                case 2:
                    this.odaTuru = "ÇİFT KİŞİLİK";

                    break;
                case 3:
                    this.odaTuru = "DELUXE";

                    break;
            }
            RoomList.Add(this);
        }

        public void rezervasyonIptalEt(int odaSecimi)
        {
            Console.WriteLine("REZERVASYON SILINMISTIR");
            var roomToBeDeleted = RoomList.Find(x => x.id == odaSecimi);
            roomToBeDeleted.musaitMi = true;
            
        }

        public void KisiSayisi()
        {
            var toplam = 0;
            foreach (var Room in Oda.RoomList)
            {
                if (!Room.musaitMi)
                {
                    switch (Room.odaTuru)
                    {
                        case "TEK KİŞİLİK":
                            toplam++;
                            break;
                        case "ÇİFT KİŞİLİK":
                            toplam += 2;
                            break;
                        case "DELUXE":
                            toplam += 2;
                            break;
                    }
                }
            }
            Console.WriteLine("Otelde toplam {0} kisi bulunmaktadır.",toplam);
        }
    }
}
