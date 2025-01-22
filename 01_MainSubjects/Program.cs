using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKommutları
            //Console.WriteLine("Merhaba Dünya");
            //.Write("Selam");

            //Console.WriteLine("********** YEMEK KATAGORİLERİ **********");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("********** YEMEK KATAGORİLERİ **********");
            #endregion

            #region StringDeğişkenler
            // String
            //Değikan_türü değişken_adı;

            //string name;
            //name = "Furkan";
            //Console.Write(name);

            //String customerName;
            //string customeSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customeSurname="Can";
            //customerPhone="0555 555 55 55";
            //customerEmail = "deneme@gmail.com";
            //district = "Sancaktepe";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customeSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("E-Mail Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district+ " / "+city);
            //Console.WriteLine("-----------------------------------------");

            //customerName = "Ayşegül";
            //customeSurname = "Kaya";
            //customerPhone = "0555 000 00 00 ";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customeSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("E-Mail Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + " / " + city);
            //Console.WriteLine("-----------------------------------------");

            #endregion

            #region Int Değişkenleri
            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice=250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-------Hamburger Fiyatı: " + hamburgerPrice+" TL");
            Console.WriteLine("-------Kola Fiyatı: " + cokePrice+" TL");
            Console.WriteLine("-------Su Fiyatı: " + waterPrice+" TL");
            Console.WriteLine("-------Kızartma Fiyatı: " + friesPrice + " TL");
            Console.WriteLine("-------Pizza Fiyatı: " + pizzaPrice + " TL");
            Console.WriteLine("-------Limonata Fiyatı: " + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemaodePrice;

            
            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemaodePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice+ " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemaodePrice + " TL");
            Console.WriteLine();


            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemaodePrice;
            Console.WriteLine("Toplam Fiyat: " + totalPrice+ " TL");
            Console.WriteLine("------------------------------");
            #endregion


            Console.Read();
        }
    }
}
