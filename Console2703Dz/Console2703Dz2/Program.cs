using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2703Dz2
{
    class Program
    {
        //Реализовать инвентарь.

        static void Main(string[] args)
        {
            List<string> numbers = new List<string>();

            while (true)
            {
                Console.WriteLine("1)Показать содержимое рюкзака\n2)Добавить предмет в рюкзак\n3)Удалить предмет из рюкзака\n4)Выйти из программы");
                int answer = Convert.ToInt32(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        foreach (string i in numbers)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 2:
                        string addItem = Console.ReadLine();
                        numbers.Add(addItem);
                        break;
                    case 3:
                        string removeItem = Console.ReadLine();
                        numbers.Remove(removeItem);
                        break;
                }

                if(answer == 4)
                {
                    break;
                }
            }
        }
    }
}
