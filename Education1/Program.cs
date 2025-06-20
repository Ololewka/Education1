using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;

namespace Education1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //double number = Convert.ToDouble(Console.ReadLine());
            //double x = number;

            //x = 7 * Math.Pow(2, x) + 3 * x + 6;

            //Console.WriteLine(x);
            //int min;
            //int max;
            //Console.WriteLine("Введите стороны треугольника");

            //string num1 = Console.ReadLine();

            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите дату рождения через точку");
            //DateTime brday = new DateTime();
            //brday = Convert.ToDateTime(Console.ReadLine());

            //DateTime date = new DateTime(2022, 7, 1);



            //var age = (date - brday).Days;
            //int age = date.Year - brday.Year;                                   //Сколько лет человеку

            //if(brday.Month > date.Month | brday.Month == date.Month & brday.Day  > date.Day)
            //{
            //    age--;
            //}


            //double sum = 1000;                                    //Проценты по вкладу
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    sum = sum + sum / 100 * 1.5;
            //}
            //Console.WriteLine(sum);


            //Console.WriteLine(age);

            //Console.WriteLine(date.Subtract(brday));
            //char[] letters = num1.ToCharArray();
            //char[] srettel = new char[letters.Length];
            //char[] srettel = Array.Empty<char>();
            //foreach(char num in num1)
            //{
            //    Console.Write(num + " ");
            //}
            //int k = 0;
            //int help = letters.Length - 1;
            //char help2 = letters[help];
            //Console.WriteLine(help2);

            //for (int i = help; i >= 0; i--)       //вывод числа с конца
            //{
            //    srettel[k] = letters[i];
            //    k++;
            //}

            //int end1 = int.Parse(letters);
            //int end2 = int.Parse(srettel);

            //if (int.Parse(letters) == int.Parse(srettel))     //Сравнение двух чисел предварительно вытащенных из массива char
            //{
            //    Console.WriteLine("Это палиэндром");
            //}
            //else
            //{
            //    Console.WriteLine("Обычное число");
            //}

            //for (int i = 0; i <= srettel.Length - 1; i++)
            //{
            //    Console.Write(srettel[i]);
            //}



            //if (help >= 2)                            //Выводит третью цифру числа
            //{
            //    Console.WriteLine(letters[2]);
            //}
            //else
            //{
            //    Console.WriteLine("Число не трехзначное");
            //}


            //if (num1 == 6 | num1 == 7  )                  //Проверка рабочий ли день
            //{
            //    Console.WriteLine("Выходной");
            //}
            //else
            //{
            //    Console.WriteLine("Рабочий день");
            //}

            //for(int i = 0; i < arr1.Length; i++)
            //{

            //}
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= num1; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}


            //if (a == b | a == c | b == c)                             //равнобедренность треугольника
            //{
            //    Console.WriteLine("Треугольник равнобедренный");
            //}
            //else
            //{
            //    Console.WriteLine("Треугольник не равнобедренный");
            //}


            //Console.WriteLine("Введите координаты точек через запятую");      //Расстояние между точками 3D

            //string[] Cords1 =Console.ReadLine().Split(",");           
            //string[] Cords2 = Console.ReadLine().Split(",");

            //int x1, y1, z1, x2, y2, z2;
            //double distance;

            //x1 = Convert.ToInt32(Cords1[0]);
            //y1 = Convert.ToInt32(Cords1[1]);
            //z1 = Convert.ToInt32(Cords1[2]);

            //x2 = Convert.ToInt32(Cords2[0]);
            //y2 = Convert.ToInt32(Cords2[1]);
            //z2 = Convert.ToInt32(Cords2[2]);

            //distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
            //Console.WriteLine(distance);


            //Console.WriteLine("Введите число");                   //Таблица кубов чисел от 1 до N

            //int N = Convert.ToInt32 (Console.ReadLine());

            //for (int i = 1; i <= N; i++)
            //{
            //    Console.Write(Math.Pow(i,3) + " ");
            //}


            //Console.WriteLine("Введите числа");               //Возведение числа A в степень B

            //int A = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Math.Pow(A, B));


            //int sum = 0;                                      //Сумма цифр в числе
            //char[] num = Console.ReadLine().ToCharArray();

            //for (int i = 0; i < num.Length; i++)
            //{
            //    sum = sum + Convert.ToInt32(num[i]);
            //    Console.WriteLine(num[i]);
            //    Console.WriteLine(Convert.ToInt32(num[i]));
            //    Console.WriteLine(sum);
            //}

            //Console.WriteLine(sum);
            //Console.WriteLine("string for test");


            //var rand = new Random();              //Заполнение массива случайными числами и их сортировка
            //                                            по модулю.
            //int[] numbers = new int[8];

            //for (int i =  0; i < numbers.Length; i++)
            //{
            //    numbers[i] = rand.Next(1,100);
            //    //Console.Write(numbers[i] + " ");
            //}

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}


            //int num = Convert.ToInt32(Console.ReadLine());            //Полиэндром ли число в 
            //List<int> doublenum = new List<int>();                    //          двоичной системе?
            //int end1 = 0;
            //int end2 = 0;
            //int k = 0;

            //while (num != 0)
            //{
            //    doublenum.Add(num % 2);
            //    num = num / 2;
            //}


            //int[] result = doublenum.ToArray();
            //int[] reverse = new int[result.Length];

            //for (int i = result.Length - 1;  i >= 0; i--)
            //{
            //    reverse[k] = result[i];

            //    k = k + 1;
            //}

            //for (int i = 0;  i < result.Length; i++)
            //{
            //    end1 += result[i] * Convert.ToInt32(Math.Pow(10, result.Length - i - 1));
            //    end2 += reverse[i] * Convert.ToInt32(Math.Pow(10, reverse.Length - i - 1));
            //}

            //if (end1 == end2)
            //{
            //    Console.WriteLine("Полиэндром в двоичной системе");
            //}
            //else
            //{
            //    Console.WriteLine("Не полиэндром в двоичной системе");
            //}


            //Phone xiaomi = new Phone();                   //работа с классами и методами
            //xiaomi.Manufacturer = "XIAOMI";
            //xiaomi.Model = "7 PRO MAX TOP GODD CHINESEEE";

            //Console.WriteLine(xiaomi.Manufacturer + " " + xiaomi.Model);



            //Smartphone apple = new Smartphone();          \\наследование          

            //Smartphone lenovo = new Smartphone();

            //lenovo.manufacturer = "Lenovo";
            //lenovo.model = "OOO DA SUKA";
            //lenovo.color = "Yellow";



            //Console.WriteLine(apple.manufacturer + " " + apple.model + " " + apple.color);
            //Console.WriteLine(lenovo.manufacturer + " " + lenovo.model + " " + lenovo.color);

           
            Phone phone = new Phone();
            Tablet tablet = new Tablet();

            phone.enableScreen();
            phone.powerOff();
            tablet.enableScreen();
            tablet.powerOff();
        }
    }
}

