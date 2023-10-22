using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace slovari //var 6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> orders = new Dictionary<int, string>();

            orders.Add(1, "Петров");
            orders.Add(2, "Иванов");
            orders.Add(3, "Набицкий");
            orders.Add(4, "Устюгов");
            orders.Add(5, "Кириленко");
            orders.Add(6, "Оденцов");
            orders.Add(7, "Заворотников");
            orders.Add(8, "Глухарев");
            orders.Add(9, "Сомов");
            orders.Add(10, "Эвдокимов");

            Console.Write("Введите номер заказа: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (orders.ContainsKey(num))
            {
                Console.WriteLine($"Заказ под номером {num} - {orders[num]}");
                Console.ReadLine();

                Console.WriteLine($"Заказ под номером {num} удален");
                orders.Remove(num);
                Console.ReadLine();

                Console.WriteLine("Оставшиеся элементы словаря:");
                foreach (KeyValuePair<int, string> i in orders)
                {
                    Console.WriteLine($"{i.Key}: {i.Value}");
                }
                Console.ReadLine();

                Console.WriteLine("Удалены все элементы");
                orders.Clear();
                Console.ReadLine();

                Console.WriteLine("Оставшиеся элементы словаря:");
                foreach (KeyValuePair<int, string> i in orders)
                {
                    Console.WriteLine($"{i.Key}: {i.Value}");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"В словаре нет информации о данном заказе {num}");
                Console.ReadLine();
            }
        }
    }
}