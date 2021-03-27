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
            List<string> items = new List<string>();
            bool isProgramStop = false;

            while (isProgramStop == false)
            {
                Console.WriteLine("1)Показать содержимое рюкзака\n2)Добавить предмет в рюкзак\n3)Удалить предмет из рюкзака\n4)Выйти из программы");
                int answer = Convert.ToInt32(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        ShowItems(items);
                        break;
                    case 2:
                        AddItem(ref items);
                        break;
                    case 3:
                        RemoveItem(ref items);
                        break;
                    case 4:
                        Exit(ref isProgramStop);
                        break;
                }
            }
        }

        public static void ShowItems(List<string> items)
        {
            foreach (string i in items)
            {
                Console.WriteLine(i);
            }
        }

        public static void AddItem(ref List<string> items)
        {
            string addItem = Console.ReadLine();
            items.Add(addItem);
        }

        public static void RemoveItem(ref List<string> items)
        {
            string removeItem = Console.ReadLine();
            items.Remove(removeItem);
        }

        public static void Exit(ref bool isProgramStop)
        {
            isProgramStop = true;
        }
    }
}
