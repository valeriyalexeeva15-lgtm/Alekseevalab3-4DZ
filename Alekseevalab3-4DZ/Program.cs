namespace Alekseevalab3_4DZ
{
    internal class Program
    {
        //enum TrafficLight { Red, Yellow, Green }
        //enum OrderStatus { New, Processing, Shipped, Delivered }

        static void Main(string[] args)
        {
            //lab3
            //1
            //TrafficLight current = TrafficLight.Green;
            //TrafficLight next = TrafficLight.Red;

            //Console.WriteLine($"После {current} будет {next}");
            //2
            //CheckCancel(OrderStatus.New);
            //CheckCancel(OrderStatus.Processing);
            //CheckCancel(OrderStatus.Shipped);
            //CheckCancel(OrderStatus.Delivered);
            //3
            //for (int i = 10; i >= 1; i--)
            //    Console.WriteLine(i);
            //4
            //for (int i = 1; i <= 10; i++)
            //    Console.WriteLine($"5 * {i} = {5 * i}");
            //5
            //for (int i = 0; i < 10; i++)
            //    Console.WriteLine("Запомни: всего одна ошибка и ты ошибся.");
            //6
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= n; i++)
            //    Console.WriteLine($"Квадрат числа {i} равен {i * i}");
            //7
            //string text = Console.ReadLine();
            //int count = int.Parse(Console.ReadLine());

            //for (int i = 0; i < count; i++)
            //    Console.WriteLine(text);
            //8
            //for (int i = 0; i < 10; i++)
            //{
            //    if (int.Parse(Console.ReadLine()) % 2 != 0)
            //    {
            //        Console.WriteLine("NO");
            //        return;
            //    }
            //}
            //Console.WriteLine("YES");
            //9
            //Console.WriteLine("Добро пожаловать на стрельбище!");
            //Console.WriteLine("Введите 'Стоп', чтобы завершить стрельбу.");

            //int shots = 0;

            //for (; ; )
            //{
            //    Console.Write("Нажмите Enter для выстрела: ");
            //    if (Console.ReadLine() == "Стоп") break;

            //    shots++;
            //    Console.WriteLine("Выстрел совершен.");
            //}

            //Console.WriteLine("Стрельба завершена.");
            //Console.WriteLine($"Израсходовано боеприпасов: {shots}");

            //lab4
            //1
            string[] items = { "sword", "shield", "potion", "sword", "potion", "potion" };

            foreach (string item in items)
                Console.WriteLine(item);
        }
        //static void CheckCancel(OrderStatus status)
        //{
        //    if (status == OrderStatus.New || status == OrderStatus.Processing)
        //        Console.WriteLine($"Заказ со статусом {status} можно отменить");
        //    else
        //        Console.WriteLine($"Заказ со статусом {status} нельзя отменить");
        //}

    }
}
