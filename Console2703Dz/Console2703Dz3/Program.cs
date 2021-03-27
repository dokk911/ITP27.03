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
            bool isProgramStop = false;
            int sum = 0;

            while (isProgramStop == false)
            {
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "exit":
                        isProgramStop = true;
                        break;
                    case "sum":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            sum += numbers[i];
                        }

                        Console.WriteLine(sum);
                        break;
                    default:
                        int number;
                        int.TryParse(answer, out number);
                        numbers.Add(number);
                        break;
                }
            }
        }
    }
}
