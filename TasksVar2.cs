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
            string slov = Console.ReadLine();
            Console.Write("Количество слов => ");
            Console.WriteLine(slov.Split(' ').Length);
            Console.Write("Количество пробелов => ");
            Console.Write(slov.Split(' ').Length - 1);
            Console.ReadKey();
            Console.ReadKey(true);
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
            TasksVar2.vivodmassiva(number_chet);
            TasksVar2.vivodmassiva(number_nechet);
        }
        public static void task3() 
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 10000);
            string b = Convert.ToString(a);
            int c = b.Length;
            int[] number = new int[c];
            for (int i = 0; i < b.Length; i++)
            {

            }
        }
    }
}
