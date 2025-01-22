using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, stawberryPrice, potatoPrice, tomatoPrice;

            //applePrice=14.85;
            //orangePrice = 20.95;
            //stawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;




            //Console.WriteLine("---- Elma Birim Fiyatı: "+applePrice+" TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: "+orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: "+stawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: "+potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: "+tomatoPrice + " TL");

            //double appleGram, orangeGram, stawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //stawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double stawberryTotalPrice = stawberryGram * stawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: Elma -  Birim Fiyat:"+applePrice+" - Gramaj: "+appleGram+" - Toplam Tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal -  Birim Fiyat:"+orangePrice+" - Gramaj: "+orangeGram+" - Toplam Tutar: "+orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek -  Birim Fiyat:"+stawberryPrice+" - Gramaj: "+stawberryGram+" - Toplam Tutar: "+stawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates -  Birim Fiyat:"+potatoPrice+" - Gramaj: "+potatoGram+" - Toplam Tutar: "+potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates -  Birim Fiyat:"+tomatoPrice+" - Gramaj: "+tomatoGram+" - Toplam Tutar: "+tomatoTotalPrice);

            //double shoopingTotatlPrice = appleTotalPrice + orangeTotalPrice + stawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoopingTotatlPrice + " TL");

            #endregion


            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri String Değikenler
            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgileri ****");
            //Console.WriteLine("");

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi:");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi:");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş:");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Tc Kimlik:");
            //passengerIdentityNumber= Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No: "+passengerIdentityNumber+" - Yolcu Adı Soyadı:" + passengerName + " " + passengerSurname+" "+passengerDistrict+" "+passengerCity+" "+passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girşleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen almmış olduğunuz ayakabı sayısınnı giriniz:");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen almmış olduğunuz bilgisayar sayısını giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen almmış olduğunuz sandalye sayısını giriniz: ");
            //chairCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen almmış olduğunuz tv sayısını giriniz: ");
            //tvCount=int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairPrice * chairCount + tvPrice * tvCount;
            //Console.WriteLine();

            //Console.WriteLine("Tplama Ödemeniz Gereken Fiyat: " + totalPrice + " TL");
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 =double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 =double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);
            #endregion

            #region Klavyeden Karakter Girişleri
            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender=char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion
            Console.Read();
        }
    }
}
