using Lesson9;

//string? email = "rest@mail.ru";
//if (email.IsValidEmailAddress()) Console.WriteLine("Это email");
//else Console.WriteLine("Не emal");
//Console.Write("Введите строку:");
//string str=Console.ReadLine()!;
//Console.Write("Введите символ:");
//char ch = char.Parse(Console.ReadLine()!);
//Console.WriteLine(str.CountChar(ch));

//Message mes;
//mes = Hello;
//mes();
//mes = MyMessage;
//mes();
//mes.Invoke();
//Message message1 =new Message(Welcome.Print);
//Message message1=Welcome.Print;
//message1();
//Hello hello = new Hello();
//Message message2 = new Message(hello.Display);
//Message message2=hello.Display;
//message2();

//MyClass.Main();
//void Hello()
//{
//    Console.WriteLine("Hello, world");
//}
//void MyMessage()
//{
//    Console.WriteLine($"{2+3}={5}");
//}
//delegate void Message();

//class Welcome
//{
//    public static void Print() => Console.WriteLine("Welcome");
//}
//class Hello
//{
//    public void Display()=> Console.WriteLine("Привет!");
//}
//Operation operation = Add;
//Console.WriteLine(operation(4,7));
//operation += Sub;
//operation += Mult;
//operation += Div;
//Console.WriteLine(operation(4, 7));
//Delegate[] delegates=operation.GetInvocationList();
//foreach(Operation d in operation.GetInvocationList())
//{
//    Console.WriteLine(d(4,6));
//}
//Console.WriteLine();
//operation-=Sub;
//foreach (Operation d in operation.GetInvocationList())
//{
//    Console.WriteLine(d(4, 6));
//}
//Message mes=Hello;
//mes += World;
//mes();

//Operation operation=null;
//Console.Write("Введите первую переменную:");
//int x = int.Parse(Console.ReadLine()!);
//Console.Write("Введите вторую переменную:");
//int y = int.Parse(Console.ReadLine()!);
//Console.Write("Введите операцию:");
//char op=char.Parse(Console.ReadLine()!);
//switch(op)
//{
//    case '+':operation=Add; break;
//    case '-': operation = Sub; break;
//    case '*': operation = Mult; break;
//    case '/': operation = Div; break;
//    default: Console.WriteLine("Такой операции нет!");break;
//}
//if(operation!=null) Console.WriteLine($"Result={operation(x,y)}");
//int Add(int x, int y) => x + y;
//int Sub(int x, int y) => x - y;
//int Mult(int x, int y) => x * y;
//int Div(int x, int y) => x / y;
//void Hello() => Console.WriteLine("Hello");
//void World() => Console.WriteLine("World");
//delegate void Message();
//delegate int Operation(int x,int y);

Building[] mas=new Building[]
{
    new Building{BuildingName="1",Floors=5,
                 Height=20,TotalArea=1200},
    new Building{BuildingName="2",Floors=7,
                 Height=27,TotalArea=1905},
    new Building{BuildingName="3",Floors=3,
                 Height=9,TotalArea=650}
};

void Print(Building[] mas,DelBuilding db)
{
    foreach(Building b in mas)
    {
        db = b.CalculateVolume;
        Console.WriteLine(b.BuildingName+" "+b.Height+" "+
            b.Floors+" "+b.TotalArea+"Valume:"+db());
    }
}
delegate double DelBuilding();