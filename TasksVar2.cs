using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtoo_Var2
{
    class TasksVar2
    {
        public static void task1() 
        {
            Console.Write("Введите слова-> ");
            string slov = Console.ReadLine();
            Console.Write("Количество слов-> ");
            Console.WriteLine(slov.Split(' ').Length);
            Console.Write("Количество пробелов-> ");
            Console.Write(slov.Split(' ').Length - 1);
            Console.WriteLine();
        }
        public static void vivodmassiva(Array n) 
        {
            Array.Sort(n);
            foreach (int item in n)
            {
                if (item == 0) //if сделан для того, чтобы не выписывались 0 из массива, которые там изначально есть из-за указания его размера
                {

                }
                else
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
        public static void task2()
        {
            Random rnd = new Random();
            int[] number = new int[20];
            int[] number_chet = new int[20];
            int[] number_nechet = new int[20];
            int d = 0;
            int c = 0;
            for (int i = 0; i < 20; i++)
            {
                number[i] = rnd.Next(1, 20);
            }
            foreach (int item in number)
            {
                if (item % 2 == 0)
                {
                    number_chet[d] = item;
                    d++;
                }

                else
                {
                    number_nechet[c] = item;
                    c++;
                }
            }
            Console.Write("Изначальный массив чисел-> ");
            foreach (int item in number) 
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine();
            Console.Write("Отсортированный массив четных чисел-> ");
            TasksVar2.vivodmassiva(number_chet);
            Console.Write("Отсортированный массив нечетных чисел-> ");
            TasksVar2.vivodmassiva(number_nechet);
        }
        public static void task3() 
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 100000);
            string chislo = a.ToString();
            string[] numbers = new string[chislo.Length];
            for (int i = 0; i < chislo.Length; i++)
            {
                numbers[i] = chislo[i].ToString();

            }
            Console.Write("Массив-> ");
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            string answer = "";
            Console.Write("Число счастливое-> ");
            int counter0 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int abi = 1;
                if (numbers[i] == numbers[chislo.Length - i - abi])
                {
                    abi++;
                    counter0++;
                }
            }
            if (counter0 == numbers.Length)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[chislo.Length - 1])
                {
                    counter++;
                }

            }
            Console.Write("Одинаковые ли все цифр-> ");
            if (counter == numbers.Length)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
            string[] numberas = new string[chislo.Length];
            Array.Copy(numbers, numberas, chislo.Length);
            Array.Sort(numberas);
            int counter2 = 0;
            int counter3 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numberas[i] == numbers[i])
                {
                    counter2++;
                }

            }
            Console.Write("Порядок расположения чисел-> ");
            if (counter2 == numbers.Length)
            {
                Console.WriteLine("по возраствнию");
            }
            Array.Reverse(numberas);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numberas[i] == numbers[i])
                {
                    counter3++;
                }

            }
            if (counter3 == numbers.Length)
            {
                Console.WriteLine("по убыванию");
            }
            else
            {
                Console.WriteLine("беспорядка");
            }
        }
    }
}
