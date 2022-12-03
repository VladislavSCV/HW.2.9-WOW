//string[] WOW = new[] { "шуруп", "гайка", "винт", "гвоздь", "болт" };
//for (int i = 0; i < WOW.Length; i++)
//{
//    Console.WriteLine($"Вывод всех товаров:{WOW[i]}");
//}
//string x;
//while (true)
//{
//    Console.WriteLine("Введите номер товара:");
//    x = Console.ReadLine();
//    switch (x)
//    {
//        case "1":
//            Console.WriteLine(WOW[0]);
//            break;
//        case "2":
//            Console.WriteLine(WOW[1]);
//            break;
//        case "3":
//            Console.WriteLine(WOW[2]);
//            break;
//        case "4":
//            Console.WriteLine(WOW[3]);
//            break;
//        case "5":
//            Console.WriteLine(WOW[4]);
//            break;
//        default:
//            Console.WriteLine("Товар отсутствует в данном каталоге(");
//            break;
//    }
//}
string y;
Console.WriteLine("Начнем игру? Да/Нет?");
y = Console.ReadLine();
if (y == "Да")
{
    Console.WriteLine("ХАХА, классно");
    Random rnd1 = new Random();
    int chis1 = rnd1.Next(10, 1000);
    Thread.Sleep(5000);
    Console.WriteLine(chis1);
    Thread.Sleep(1000);
}
string Print_g;
Console.WriteLine("Отлично! Хочешь взглянуть на призы? Да/Нет?");
Print_g = Console.ReadLine();
if (Print_g == "Да")
{
    int[] gifts = new[] { 1, 2, 3, 4 };
    for (int i = 3; i < gifts.Length; i++)
    {
        Console.WriteLine($"Вывод всех призов:" +
            $"\n Приз номер {gifts[0]} = 100 гемов в бравл старс " +
            $"\n Приз номер {gifts[1]} = Майнкрафт " +
            $"\n Приз номер {gifts[2]} = Футбольный мяч " +
            $"\n Приз номер {gifts[3]} = АВТОМОБИЛЬ!!!");
    }
    int gifts1 = gifts[0];
    int gifts2 = gifts[1];
    int gifts3 = gifts[2];
    int gifts4 = gifts[3];

    string x;
    Console.WriteLine("Чтобы получить приз нажмите 'U'");
    x = Console.ReadLine();
    if (x == "U")
    {
        Random rnd = new Random();
        int WOW = rnd.Next(gifts1, gifts4);
        Console.WriteLine($"Ваш приз под номером:{WOW}");

    }
}









