using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisevtoo_Var2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("1. Задание");
                Console.WriteLine("2. Задание");
                Console.WriteLine("3. Задание");
                Console.Write("-> ");
                int chooose=int.Parse(Console.ReadLine());
                if (chooose == 1)
                {
                    //1
                    TasksVar2.task1();

                }
                else if (chooose == 2)
                {
                    //2
                    TasksVar2.task2();
                }
                else if (chooose == 3)
                {
                    //3 не сделано
                    TasksVar2.task3();
                }
                else 
                {
                    Console.WriteLine("Такого варианта нет");
                }

            }
        }
    }
}
