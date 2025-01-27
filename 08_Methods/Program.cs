using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void custemerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //custemerList();
            //custemerList();
            //custemerList();
            //custemerList();



            //void sum()
            //    {
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //sum();


            #endregion

            #region Geriye Değer Döndürmeyen String Paramaetereli Metotlar

            //void writeMetod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //writeMetod("Mehmet Yıldırım");


            //void customerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //customerCard("Mehmet", "Yıldız");
            //customerCard("Ayşe", "Kaya");


            #endregion


            #region Geriye Değer Döndürmeyen İnt Paramaetereli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int resut=number1+number2 + number3;
            //    Console.WriteLine(resut);
            //}

            //Sum(4,5,6);

            #endregion


            #region Geriye Değer Döndüren Metotlar

            //string customerName()
            //{
            //    return "Buse Yıldız";
            //}

            //customerName();

            //string studentCard()

            //{
            //    string name = "Ali";
            //    string surName = " Kaya";

            //    return name + surName;
            //}
            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string coutryCard(string coutryName, string capital, string flagColor)
            //{

            //    string cardInfo = "Ülke: "+ coutryName + " - Başkent: "+ capital + " - Bayrak Rengi: "+ flagColor;
            //    return cardInfo;
            //}


            // string x, y, z;

            // Console.Write("Ülke Adını Giriniz: ");
            // x=Console.ReadLine();

            // Console.Write("Başkenti Girniz: ");
            // y=Console.ReadLine();

            // Console.Write("Bayrak Rengini Giriniz: ");
            // z=Console.ReadLine();

            //Console.WriteLine(coutryCard(x, y, z));

            // Console.WriteLine(coutryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result=number1+number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));




            #endregion


            #region Örnek Uygulama


            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result=(exam1 + exam2+exam3)/3;
                if (result >= 50)
                {
                    return student + " İsimli çğrenci sınavı geçti " + "Ortalama: " + result;  
                }
                else
                {
                    return student + " İsimli çğrenci sınavı geçemedi " + "Ortalama: " + result;
                }
            }
            Console.WriteLine(ExamResult("Ali", 25, 41, 55));
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));

            #endregion


            Console.Read();
        }

    }
}
