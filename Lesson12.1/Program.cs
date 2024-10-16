using Lesson12._1;
using System.Collections;

Student<int>[] mas = new Student<int>[3];
mas[0]=new Student<int>("Vasia",16);
mas[1] = new Student<int>("Boris",13 );
mas[2] = new Student<int>("Eugen", 10);
Array.Sort(mas);
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine(mas[i]);
}

Array.Sort(mas,new FioSortComparatorInt());
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine(mas[i]);
}

Student<string>[] group = new Student<string>[3];
group[0] = new Student<string>("Vano", "qwe");
group[1] = new Student<string>("Ivan", "asd");
group[2] = new Student<string>("Viko", "zxc");
Array.Sort(group);
for (int i = 0; i < group.Length; i++)
{
    Console.WriteLine(group[i]);
}

Array.Sort(group, new FioSortComparatorString());
for (int i = 0; i < group.Length; i++)
{
    Console.WriteLine(group[i]);
}

Student<int> student = new Student<int>("Ashot", 45);
Console.WriteLine(student);
Student<int> gogi=(Student<int>)student.Clone();
Console.WriteLine(gogi);

class FioSortComparatorInt : IComparer
{
    public int Compare(object? x, object? y)
    {
        var student1 = x as Student<int>;
        var student2 = y as Student<int>;
        if (student1!.FIO.CompareTo(student2!.FIO) > 0) return 1;
        else if (student1!.FIO.CompareTo(student2!.FIO) == 0) return 0;
        return -1;
    }
}

class FioSortComparatorString : IComparer
{
    public int Compare(object? x, object? y)
    {
        var student1 = x as Student<string>;
        var student2 = y as Student<string>;
        if (student1!.FIO.CompareTo(student2!.FIO) > 0) return 1;
        else if (student1!.FIO.CompareTo(student2!.FIO) == 0) return 0;
        return -1;
    }
}