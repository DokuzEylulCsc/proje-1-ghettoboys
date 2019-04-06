using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeOtel1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int secim, secim2;
            String isim;

            Rezervasyon rezervasyon = new Rezervasyon();
            Console.WriteLine("Otel rezervasyon sistemine hoşgeldiniz...\n");

            do
            {
                
                Console.WriteLine("1-Yeni rezervasyon");
                Console.WriteLine("2-Rezervasyon silme");
                Console.WriteLine("3-Otelde kaç kişi olduğunu göster");
                Console.WriteLine("4-Çıkış");

                secim = int.Parse(Console.ReadLine());
                switch(secim)
                {
                    case 1:
                        Console.WriteLine("Müşteri adını yazınız...");
                        isim = Console.ReadLine();
                        Console.WriteLine("1-Tekli Oda");
                        Console.WriteLine("2-Çiftli Oda");
                        Console.WriteLine("3-Deluxe Oda");
                        secim2 = int.Parse(Console.ReadLine());
                        rezervasyon.rezervasyonIstegi(secim2,isim);
                        break;
                    case 2:
                        Console.WriteLine("OTELDEKİ TÜM REZERVASYONLAR ASAGIDA LISTELENMISTIR... \nIptal etmek istediginiz rezervasyonun id numarasini giriniz");
                        foreach (var Room in Oda.RoomList)
                        {
                            if(!Room.musaitMi)
                            Console.WriteLine("Sayın {2} , {0} id'li {1} odada rezervasyonu bulunmaktadır.",Room.id,Room.odaTuru,Room.GuestName);
                        }

                        var rezSil = int.Parse(Console.ReadLine());
                        rezervasyon.rezervasyonIptali(rezSil);
                        break;
                    case 3:
                        rezervasyon.kacKisiVar();
                        break;
                        
                }

            } while (secim != 4);
        }
    }
}
