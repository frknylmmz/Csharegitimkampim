using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}




            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 25, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 25, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //        Console.WriteLine(number);
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 285, 6578, 10394 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> numbers = new List<int>
            //{
            //    1,2, 3, 4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}





            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Uygulaması  *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Sınıftaki öğrenci sayısını kullanıcıdan alma

            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames=new string[studentCount];
            double[] studentExamAvg=new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin İsmini Giriniz: ");
                studentNames[i] = Console.ReadLine();
                double totalExaamResult = 0;


                //Her öğrenci için 3 sınav notu girişi

                for (int j = 0;j<3;j++)
                {
                    Console.Write($"{studentNames[i]} İsimli Öğrencinin  {j + 1}. Sınav Notunu Giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExaamResult += value; //Notları topluyoruz.
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExaamResult/3;
            }

            
            //Sınav Ortalamaları 
            for (int i = 0;i < studentCount;i++) 

                {
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"{studentNames[i]} Adlı Öğrencinin Ortalaması:  {studentExamAvg[i]}");
                
                //Öğrencilerin ortalaması ve geçip kalma durumları

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersi Geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersten Kaldı");
                }
                Console.WriteLine("-----------------------------");
                }




            #endregion

            Console.Read();
        }
    }
}
