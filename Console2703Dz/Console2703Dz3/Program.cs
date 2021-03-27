using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2703Dz3
{
    class Program
    {
        // Пользователь вводит числа, и программа их запоминает.
        // Как только пользователь введёт команду sum, программа
        // выведет сумму всех веденных чисел.
        // Выход из программы должен происходить только
        // в том случае, если пользователь введет команду exit.

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int sum = 0;

            while (true)
            {
                string answer = Console.ReadLine();
                

                if (answer == "exit")
                {
                    break;
                }
                if (answer == "sum")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine(sum);
                }
                else
                {
                    numbers.Add(Convert.ToInt32(answer));
                }
            }
        }
    }
}
