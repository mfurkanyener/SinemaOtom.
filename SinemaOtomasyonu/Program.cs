using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SinemaOtomasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] filmler = new string[5, 6];
            filmler[0, 0] = "Kafalar Karşık";
            filmler[0, 1] = "95 Dakika";
            filmler[0, 2] = "Komedi";
            filmler[0, 3] = "Dil: Türkçe";
            filmler[0, 4] = "Özet: Atakan, zengin sevgilisi Buse'ye aşıktır. Evlenmelerinde tek engel ise Buse'nin dedesidir. Atakan da Buse ile evlenmek için tek çare olarak Buse'nin yıllardır kayıp olan öz babasını bulmaya karar verir. Kadim dostları Fatih ve Bilal de elbette bu serüvende ona eşlik edeceklerdir. Kafalar, arayışları sonunda kendilerini bir anda Antalya'da bulacak ve işler iyiden iyiye karışmasıyla aksiyon ve komedi dolu bir macera başlayacaktır.";
            filmler[0, 5] = "Seans: 11:50 14:10 16.30 18:50";
            filmler[1, 0] = "Müslüm";
            filmler[1, 1] = "132 Dakika";
            filmler[1, 2] = "Biyografi";
            filmler[1, 3] = "Dil: Türkçe";
            filmler[1, 4] = "Özet: Müslüm Gürses ve Muhterem Nur'un hayatını anlatan film; çocuk yaşta, tesadüfen girdiği Adana Halkevi'nde bağlama ustası Limoncu Ali'yle tanışan Müslüm Gürses, kendisinden hem müzik bilgisi hem de ilerleyen yaşlarında sık sık hatırlayacağı çok önemli hayat dersleri alır. Limoncu Ali, bir öğretmen olmasının ötesinde çocuk Müslüm'e şefkat gösterir, bir nevi babalık yapar.";
            filmler[1, 5] = "Seans: 09:20 10:35 16:15 22:05 23:55";
            filmler[2, 0] = "Hedefim Sensin";
            filmler[2, 1] = "109 Dakika";
            filmler[2, 2] = "Komedi";
            filmler[2, 3] = "Dil: Tükçe";
            filmler[2, 4] = "Özet: Zekeriya Taştan, hayatını İstanbul sokaklarında çiğ köfte satarak kazanmaktadır. Bülbülün çilesi dilindendir misali, Zekeriya da bir gün yanlış yerde, yanlış zamanda öter. Böylece İstanbul'u terk etmek zorunda kalır. İlk defa ayak bastığı Gökçeada da sadece Zekeriya'nın hayatı değişmekle kalmaz, Hafize'nin, Leyla'nın ve Yarım Hasan'ın da hayatı da tamamıyla değişir; yani artık kaderin hedefinde kahramanlarımız vardır.";
            filmler[2, 5] = "Seans: 09:10 11:15 13:50 16:20 18:55 21:30 00:05";
            filmler[3, 0] = "Örümcek Adam";
            filmler[3, 1] = "117 Dakika";
            filmler[3, 2] = "Animasyon";
            filmler[3, 3] = "Dil: İngilizce";
            filmler[3, 4] = "Özet: Örümcek Evreninde, dünyayı kurtarmaya çalışan Brooklyn’li genç Miles Morales’in hikayesini konu ediyor. Peter Parker ve diğer birçok alternatif Spider-Man ile birlik olan Miles, dünyayı kurtarmak için zorlu bir mücadeleye atılıyor.";
            filmler[3, 5] = "Seans: 11:05 13:45 16:25";
            filmler[4, 0] = "Fantastik Canavarlar 2";
            filmler[4, 1] = "134 Dakika";
            filmler[4, 2] = "Macera";
            filmler[4, 3] = "Dil: İngilizce";
            filmler[4, 4] = "Özet: Fantastik Canavarlar: Grindelwald'ın Suçları. Karanlık büyücü Gellert Grindelwald, Newt Scamander'ın da yardımıyla Amerika Birleşik Devletleri Sihir Kongresi (MACUSA) tarafından yakalanır. Ancak kaçmayı başaran büyücü, kendine, gerçek niyetinden habersiz olan müritler toplamaya başlar. Asıl planı; büyü dünyasından uzak olan canlıların hepsine hükmedecek olan safkan büyücüler yetiştirmektir. Karanlık büyücünün planlarını bozmak isteyen Albus Dumbledore, eski öğrencisi Newt Scamander'dan yardım ister. Önündeki tehlikenin farkında olmayan Newt, gerçek dostluklar ve aile bağları konusunda bile sevgisinin ve sadakatinin test edileceği bir yola girecektir...";
            filmler[4, 5] = "Seans: 21:10";

            int f1Kap = 0, f2Kap = 0, f3Kap = 0, f4Kap = 0, f5Kap = 0;



            for (int i = 0; i < filmler.GetLength(0); i++)
            {
                for (int j = 0; j < filmler.GetLength(1); j++)
                {
                    Console.WriteLine(filmler[i, j] + "\t");
                }
            }
            YenidenSec:
            Console.Write("Vizyonda olan filmlerden gitmek istediğiniz filmin adını yazınız: ");
            string gidilecekFilm = Console.ReadLine();
            switch (gidilecekFilm)
            {
                case "Kafalar Karışık":
                    if (f1Kap <= 50)
                        f1Kap++;
                    else
                        Console.WriteLine("Seçtiğiniz film için boş koltuk yoktur!");
                    break;
                case "Hedefim Sensin":
                    if (f2Kap <= 50)
                        f2Kap++;
                    else
                        Console.WriteLine("Seçtiğiniz film için boş koltuk yoktur!");
                    break;
                case "Örümcek Adam":
                    if (f3Kap <= 50)
                        f3Kap++;
                    else
                        Console.WriteLine("Seçtiğiniz film için boş koltuk yoktur!");
                    break;
                case "Fantastik Canavalar":
                    if (f4Kap <= 50)
                        f4Kap++;
                    else
                        Console.WriteLine("Seçtiğiniz film için boş koltuk yoktur!");
                    break;
                case "Müslüm":
                    if (f5Kap <= 50)
                        f5Kap++;
                    else
                        Console.WriteLine("Seçtiğiniz film için boş koltuk yoktur!");
                    break;
                default:
                    Console.WriteLine("Böyle bir film mevcut değil.");
                    goto YenidenSec;
            }
            Console.Write("Ödeme Türü");
            Console.ReadLine();
        }

        
    }
}

