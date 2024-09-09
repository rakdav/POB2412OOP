using Lesson2;

//int a = 6;
//int b = 9;
//TwoPair tp1 = new TwoPair(a,b);
//tp1.Print();
//TwoPair tp2 = new TwoPair();
//tp2.Print();
//TwoPair tp3 = new TwoPair(tp1);
//tp3.Print();

Railway railway = new Railway();
for (int i = 0; i < 5; i++)
{
    Console.Write("Введите пункт назначения:");
    string name = Console.ReadLine()!;
    Console.Write("Введите номер:");
    int number = int.Parse(Console.ReadLine()!);
    Console.Write("Введите дату и время отправления:");
    DateTime time = DateTime.Parse(Console.ReadLine()!);
    railway.Add(new Train() { 
        Name = name, Number = number, Time = time });
}
railway.Print();
Console.WriteLine();
railway.SortByNumber();
railway.Print();
railway.SortByName();
Console.WriteLine();
railway.Print();
