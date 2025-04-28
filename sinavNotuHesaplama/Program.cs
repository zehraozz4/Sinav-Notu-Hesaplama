using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinavNotuHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n----------ANA MENU----------");
                Console.WriteLine("Cikis icin --> E");
                Console.WriteLine("Not hesaplamak icin -->H");
                Console.Write("Lutfen yapmak istediginiz islemi giriniz:");

                char secim = Console.ReadLine()[0];

                if (secim == 'H' || secim == 'h')
                {
                    Console.Write("Lutfen dersin adını giriniz:");
                    string dersAd = Console.ReadLine();
                    int notAdedi =girisKontrolu("Lutfen girmek istediginiz not adedini giriniz:",0,int.MaxValue);
                    float toplamYuzde = 0;
                    float ort=0;
                    String harfNotu;
                    String durum;

                    for (int i = 0; i < notAdedi; i++)
                    {
                        float not, yuzde;
                        while (true)
                        {
                            not = girisKontrolu((i +1)+". notunuzu giriniz:", 0, 100);
                            break;
                        }

                        while (true)
                        {
                            yuzde = girisKontrolu((i + 1) + ". notunuzun yuzdesini giriniz:",0,100);
                            toplamYuzde += yuzde;
                            if(yuzde <0 || yuzde>100)
                            {
                                Console.WriteLine("Yuzde degeri 0-100 arasında olmalıdır.Kalan yuzde degeriniz " +(100-(toplamYuzde - yuzde))+"'dir.");
                                toplamYuzde -= yuzde;
                            }
                            else if (toplamYuzde > 100)
                            {
                                Console.WriteLine("Toplam Yuzde degeri 100'den fazla olamaz. Kalan yuzde degeriniz " +(100-(toplamYuzde - yuzde))+ "'dir.");
                                toplamYuzde -= yuzde;
                            }
                            else if(toplamYuzde<100 && i==notAdedi-1)
                            {
                                Console.WriteLine("Yuzdeler  toplami 100e eşit olmalidir!!! Kalan yuzde degeri:" + (100 - (toplamYuzde - yuzde)) + "'dir.");
                                toplamYuzde -= yuzde;
                            }
                            else
                            {
                                ort += (not * (yuzde / 100));
                                break;
                            }

                        }
                    }

                    if(ort>=90)
                    {
                        harfNotu = "AA";
                        durum = "GECTI";
                    }
                    else if(ort>=85)
                    {
                        harfNotu = "BA";
                        durum = "GECTI";
                    }
                    else if (ort >= 80)
                    {
                        harfNotu = "BB";
                        durum = "GECTI";
                    }
                    else if (ort >=75)
                    {
                        harfNotu = "CB";
                        durum = "GECTI";
                    }
                    else if (ort >=70)
                    {
                        harfNotu = "CC";
                        durum = "GECTI";
                    }
                    else if (ort >=65)
                    {
                        harfNotu = "DC"; 
                        durum = "GECTI";
                    }
                    else if (ort >=60)
                    {
                        harfNotu = "DD";
                        durum = "GECTI";
                    }
                    else
                    {
                        harfNotu = "FF";
                        durum = "KALDI";
                    }
                    Console.WriteLine("Sonuc: "+(dersAd)+" dersi not ortalamanız "+ort+" Harf notunuz "+harfNotu+" durumunuz "+durum);
                }

                else if(secim=='E'|| secim=='e')
                {
                    Console.WriteLine("Programdan cikiliyor...");
                    break;
                }
                else
                {
                    Console.Write("Lutfen gecerli deger giriniz!!!");
                }
            }
        }
        static int girisKontrolu(string mesaj, int min, int max)
        {
            int sayi;
            while (true)
            {
                Console.Write(mesaj);
                string secim = Console.ReadLine();

                if (int.TryParse(secim, out sayi))
                {
                    if (sayi >= min && sayi <= max)
                    {
                        return sayi;
                    }
                    else
                    {
                        Console.WriteLine("Lutfen " + min + " ile " + max + " arasinda bir deger giriniz!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Lutfen gecerli bir deger giriniz!!!");
                }
            }
        }
    }
}
