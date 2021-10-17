using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Threading;

namespace _4ex
{
    class Program
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Text.txt");
            string line = string.Empty;
            int number = 0;
            Queue n = new Queue();
            Console.WriteLine("Читаю файл...");
            Console.WriteLine("Сортирую:");
            Thread.Sleep(1000);
            while ((line = sr.ReadLine()) != null)
            {
                number = Convert.ToInt32(line);
                if (number > 0)
                    Console.WriteLine(number);
                else n.Enqueue(number);

            }
            sr.Close();
            while (n.Count != 0)
            {
                Console.WriteLine(n.Dequeue());
            }
            Console.Write("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
