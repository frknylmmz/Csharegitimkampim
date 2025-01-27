using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //String[] color = new string[4];
            //color[0] = "Kırmızı";
            //color[1] = "Sarı";
            //color[2] = "Beyaz";
            //color[3] = "Mavi";

            //Console.WriteLine(color[2]);


            //string[] city = new string[5];
            //city[0] = "Milano";
            //city[1] = "Bdapeşte";
            //city[2] = "Lyon";
            //city[3] = "Kahire";
            //city[4] = "Üsküp";

            //Console.WriteLine(city[4]);

            //int[] numbers=new int[10];

            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[7]);

            //string[] citles = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(citles[2]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 688, 522, 745, 1456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', 'd','*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber=myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = {"ali","ahmet","ayşe","buse","cem","deniz"};
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion


            #region Dizi Metotlar

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };

            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] number = { 45, 85, 96, 63, 74, 10, 25, 22, 10 };
            //Console.WriteLine("Dizinin En Büyük Elmanı "+number.Max()+" Dizinin En Küçük Elamanı "+number.Min());


            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.Şehrini Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] number = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < number.Length; i++)
            //{
            //    sum += number[i];
            //}
            //Console.WriteLine(sum);

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            Console.WriteLine("Çift Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("----------------");
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                    Console.WriteLine(numbers[i]);
            }
            #endregion

            Console.Read();
        }
    }
}
