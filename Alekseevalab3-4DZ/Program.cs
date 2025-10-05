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
            //string[] items = { "sword", "shield", "potion", "sword", "potion", "potion" };

            //foreach (string item in items)
            //    Console.WriteLine(item);
            //2
            //int[] points = { 10, 20, 15, 30, 25 };
            //Console.WriteLine($"Общее количество очков: {points.Sum()}");
            //3
            //int[] numbers = { 1, 3, 7, 2, 5 };
            //int max = numbers[0];

            //foreach (int n in numbers)
            //    if (n > max) max = n;

            //Console.WriteLine($"Максимальный элемент: {max}");
            //4
            //    int[] numbers = { 1, 2, 3, 4, 5 };
            //    int even = 0, odd = 0;

            //    foreach (int n in numbers)
            //        if (n % 2 == 0) even++; else odd++;

            //    Console.WriteLine($"{even} четных и {odd} нечетных");
            //}
            //5
            //int[] times = { 120, 95, 110, 105, 100 };
            //int min = times[0];

            //foreach (int t in times)
            //    if (t < min) min = t;

            //Console.WriteLine($"Самое быстрое время: {min} секунд");
            //6
            string[] results = { "win", "loss", "win", "win", "loss" };
            int wins = 0, losses = 0;

            foreach (string result in results)
                if (result == "win") wins++; else losses++;

            Console.WriteLine($"{wins} победы и {losses} поражения");
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
