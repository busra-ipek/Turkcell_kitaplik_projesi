using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kitaplık

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam_fiyat = 0;
            string secim; 

            //Kategori isimleri oluşturuldu
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("**  Türkçe Kitaplar Kategorisi    **  Yabancı Kitaplar Kategorisi        **");
            Console.WriteLine();
            Console.WriteLine("**  1-Çalıkuşu: Reşat Nuri        **  7-Tuna Kılavuzu: Jules Verne       **");
            Console.WriteLine();
            Console.WriteLine("**  2-Yaban: Yakup Kadri          **  8-Bir Kuzey Macerası: Jack London  **");
            Console.WriteLine();
            Console.WriteLine("**  3-Sinekli Bakkal: Halide Edip **  9-Altıncı Koğuş: Anton Çehov       **");
            Console.WriteLine();
            Console.WriteLine("**  4-Tehlikeli Oyunlar: O.Atay   **  10-Kumarbaz: Dostoyevski           **");
            Console.WriteLine();
            Console.WriteLine("**  5-Geçtiğim Günlerden: H.Yücel **  11-İki Şehrin Hikayesi: C.Dickens  **");
            Console.WriteLine();
            Console.WriteLine("**  6-Kuyucaklı Yusuf: S.Ali      **  12-Vişne Bahçesi: Anton Çehov      **");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            Console.WriteLine("***** İşlemler Menüsü *****");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Sorgulama");
            Console.WriteLine("2-Yeni Okur Kaydı");
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemin numarası: ");
            char islem;
            islem=Convert.ToChar(Console.ReadLine());

            if(islem=='1')
            {
                Console.WriteLine();
                Console.Write("Lütfen fiyatını öğrenmek istediğiniz kitabın numarasını giriniz: ");
                string numara;
                numara=Console.ReadLine();

                switch (numara)
                {
                    case "1": Console.WriteLine("Çalıkuşu: 12 TL"); break;
                    case "2": Console.WriteLine("Yaban: 14 TL"); break;
                    case "3": Console.WriteLine("Sinekli Bakkal: 16 TL"); break;
                    case "4": Console.WriteLine("Tehlikeli Oyunlar: 11 TL"); break;
                    case "5": Console.WriteLine("Geçtiğim Günlerden: 8 TL"); break;
                    case "6": Console.WriteLine("Kuyucaklı Yusuf: 13 TL"); break;
                    case "7": Console.WriteLine("Tuna kılavuzu: 17 TL"); break;
                    case "8": Console.WriteLine("Bir Kuzey Macerası: 4 TL"); break;
                    case "9": Console.WriteLine("Altıncı Koğuş: 5 TL"); break;
                    case "10": Console.WriteLine("Kumarbaz: 10 TL"); break;
                    case "11": Console.WriteLine("İki Şehrin Hikayesi: 13 TL"); break;
                    case "12": Console.WriteLine("Vişne Bahçesi: 6 TL"); break;
                   
                    default:Console.WriteLine("Yanlış kitap numarası girdiniz..."); break;
                }

            }
            if (islem == '2')
            {
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                Console.WriteLine();
                Console.Write("Adınız: ");
                ad = Console.ReadLine();
                Console.Write("Soyadınız: ");
                soyad = Console.ReadLine();
                Console.Write("Üniversiteniz: ");
                universite = Console.ReadLine();

                //masaüstünde kullanıcı kayıtları adında bir metin belgesi oluşturuldu
                string dosya = @"C:\Users\ASUS\OneDrive\Masaüstü\Kullanici kayitlari.txt";
                StreamWriter sw= new StreamWriter(dosya);
                sw.WriteLine("Adınız: " + ad);
                sw.WriteLine("Soyadınız: " + soyad);
                sw.WriteLine("Üniversiteniz: " + universite);
                sw.Close();

                Console.WriteLine("Yeni kullanıcı kaydı başarıyla oluşturulmuştur.");

            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                Console.WriteLine("***** Bugünün Kitabı: Çalıkuşu *****");
                Console.WriteLine();
                Console.WriteLine("************************************");

            }
            if (islem == '4')
            {
                //masaüstünde bulunan bir metin belgesindeki kitapları okuyup ekrana yazdıran arşiv listesi 
                Console.WriteLine();
                Console.WriteLine("************************************");
                Console.WriteLine();
                //burası kitap arşivi olacak
                FileStream fs = new FileStream(@"C:\Users\ASUS\OneDrive\Masaüstü\Turkcell c# 101\Kitap listesi.txt", FileMode.Open , FileAccess.Read);
                StreamReader sr= new StreamReader(fs);
                string metin= sr.ReadLine();
                while (metin!=null)
                {
                    Console.WriteLine(metin);
                    metin=sr.ReadLine();
                }
                sr.Close();
                fs.Close();

                Console.WriteLine();
                Console.WriteLine("************************************");
                

            }
            if (islem == '5')
            {
                for (int i = 1;i<=100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız kitabın numarası: ");
                    secim=Console.ReadLine();

                    if (secim == "1")
                    {
                        toplam_fiyat = toplam_fiyat + 12;
                    }
                    else if (secim == "2")
                    {
                        toplam_fiyat=toplam_fiyat + 14;
                    }
                    else if (secim == "3")
                    {
                        toplam_fiyat = toplam_fiyat + 16;
                    }
                    else if (secim == "4")
                    {
                        toplam_fiyat = toplam_fiyat + 11;
                    }
                    else if (secim == "5")
                    {
                        toplam_fiyat = toplam_fiyat + 8;
                    }
                    else if (secim == "6")
                    {
                        toplam_fiyat = toplam_fiyat + 13;
                    }
                    else if (secim == "7")
                    {
                        toplam_fiyat = toplam_fiyat + 17;
                    }
                    else if (secim == "8")
                    {
                        toplam_fiyat = toplam_fiyat + 4;
                    }
                    else if (secim == "9")
                    {
                        toplam_fiyat = toplam_fiyat + 5;
                    }
                    else if (secim == "10")
                    {
                        toplam_fiyat = toplam_fiyat + 10;
                    }
                    else if (secim == "11")
                    {
                        toplam_fiyat = toplam_fiyat + 13;
                    }
                    else if (secim == "12")
                    {
                        toplam_fiyat = toplam_fiyat + 6;
                    }
                    else
                    
                        Console.WriteLine("Böyle bir kitap numrası bulunmamaktadır.");
                        Console.WriteLine();
                        Console.WriteLine("Başka bir kitap almak ister misiniz?  (H/Hayır veya E/Evet)");
                        string cevap= Console.ReadLine();

                        if (cevap == "h" || cevap == "H" || cevap == "Hayır" || cevap == "hayır")
                            break;
                        //başka bir kitap istenmiyorsa döngüden çıkılır , eğer ki başka kitap isteniyorsa döngüye devam edilir.                

                }
                Console.WriteLine("Toplam tutar: " + toplam_fiyat);
                //toplam tutar başka bir kitap alınmak istenmediğinde for döngüsünden çıkıldıktan sonra gösterilir.
            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random rnd= new Random();
                int sayi = rnd.Next(1, 100);
                while(sayi!=tahmin)
                {
                    Console.Write("Sayı giriniz: ");
                    tahmin=Convert.ToInt16(Console.ReadLine());
                    if(tahmin > sayi)
                    {
                        Console.WriteLine("Daha küçük") ;
                    }
                    if (tahmin < sayi)
                    {
                        Console.WriteLine("Daha büyük");
                    }
                    if (tahmin == sayi)
                    {
                        Console.WriteLine("BİLDİNİZ TEBRİKLER...");
                        break;
                    }
                }
            }

            Console.Read();
        }
    }
}
