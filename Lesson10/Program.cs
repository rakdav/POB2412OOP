////string x = "fdsfsf";
////Console.WriteLine(x.GetHashCode());
////string y = "dsfdsfs";
////Console.WriteLine(y.GetHashCode());
//List<string> people=new List<string>() 
//{
//    "First","Second","Ten","Nine"
//};
//LinkedList<string> list = new LinkedList<string>(people);
//Console.WriteLine(list.Count);
//Console.WriteLine(list.First!.Next!.Next!.Value);
//Console.WriteLine(list.Last!.Value);
//Console.WriteLine(list.Last!.Previous!.Value);
//var current=list.First;
//while (current != null)
//{
//    Console.WriteLine(current.Value);
//    current=current.Next;
//}
//current=list.Last;
//while (current != null)
//{
//    Console.WriteLine(current.Value);
//    current=current.Previous;
//}
//list.AddLast("seven");
//list.AddFirst("eight");
//if (list.First != null) list.AddAfter(list.First, "six");
//if (list.Last != null) list.AddBefore(list.Last,"twelve");
//Console.WriteLine();
//current = list.Last;
//while (current != null)
//{
//    Console.WriteLine(current.Value);
//    current = current.Previous;
//}
//if(list.Contains("seven")) list.Remove(list.Find("seven")!);
//list.RemoveFirst();
//list.RemoveLast();

//SortedSet<int> ints = new SortedSet<int>();
//ints.Add(6);
//ints.Add(3);
//ints.Add(6);
//foreach(int i in ints) Console.Write(i+" ");
//Console.WriteLine();

//HashSet<double> doubles = new HashSet<double>();
//doubles.Add(12);
//doubles.Add(2);
//doubles.Add(6);
//doubles.Add(12);

//foreach (double i in doubles) Console.Write(i + " ");
//Console.WriteLine();


//Создайте консольное приложение для управления списком задач.
//Используйте List для хранения задач. Пользователь должен иметь
//возможность добавлять, удалять и просматривать задачи.
//List<string> listTask=new List<string>();
//listTask.Add("first");
//listTask.Add("second");
//foreach (var item in listTask) Console.Write(item+" ");
//Console.WriteLine();

//listTask.Remove("first");
//listTask.RemoveAt(0);
//Console.WriteLine(listTask.Count);

//2.Учет посещений:
//using System.Threading.Channels;

//Dictionary<string, int> shoping = 
//    new Dictionary<string, int>();
//string? enterString = "";
//do
//{
//    Console.Write("Введите имя клиента:");
//    enterString = Console.ReadLine()!;
//    if (enterString == "exit") break;
//    if(shoping.ContainsKey(enterString))
//    {
//        shoping[enterString]++;
//    }
//    else
//    {
//        shoping.Add(enterString, 1);
//    }
//}
//while (true);
//foreach (var item in shoping)
//{
//    Console.WriteLine(item.Key+" "+item.Value);
//}

//Напишите функцию, которая принимает массив и возвращает true, если
//все элементы в массиве уникальны, и false в противном случае.
//Используйте HashSet для решения этой задачи.

//bool IsUnique(int[] mas)
//{
//    HashSet<int> result = new HashSet<int>();
//    foreach (int ma in mas) result.Add(ma);
//    return result.Count==mas.Length;
//}

//int[] m1 = { 1, 2, 3, 5 };
//int[] m2 = {6,7,7,8,9 };
//Console.WriteLine(IsUnique(m1));
//Console.WriteLine(IsUnique(m2));

//Создайте приложение для сортировки списка чисел. Реализуйте
//сортировку с использованием List, а затем сравните производительность с
//SortedSet.
using System.Net.Http.Headers;

List<int> list = new();
SortedSet<int> s=new();
Random random = new Random();
for (int i = 0; i < random.Next(50); i++)
{
    int m=random.Next(10,100);
    list.Add(m);
    s.Add(m);
}
list.Sort();
foreach (int i in list) Console.Write(i+" ");
Console.WriteLine();
foreach (int i in s) Console.Write(i+" ");


