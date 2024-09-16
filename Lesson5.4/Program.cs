//var tuple = (5,10);
//Console.WriteLine(tuple.Item1);
//Console.WriteLine(tuple.Item2);
//tuple.Item1 += 10;
//Console.WriteLine(tuple.Item1);

//(int, double) tupleNew = (5, 8.9);
//Console.WriteLine(tupleNew.Item1);
//Console.WriteLine(tupleNew.Item2);

//(string, int, double) person = ("Tom", 30, 78.8);
//Console.WriteLine(person);
int[] mas = new int[10];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10, 100);
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
for (int i = 0; i < mas.Length-1; i++)
{
    for (int j = i+1; j < mas.Length; j++)
    {
        if (mas[i] > mas[j])
            (mas[i], mas[j]) = (mas[j], mas[i]);
    }
}
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(mas[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Max="+GetValues(mas).max);
Console.WriteLine("Min=" + GetValues(mas).min);
Console.WriteLine("Avg=" + GetValues(mas).avg);
Print(("Vasya",60));
(int max,int min,double avg) GetValues(int[] mas)
{
    int max = mas.Max();
    int min = mas.Min();
    double avg = mas.Average();
    return (max, min, avg);
}
void Print((string name,int age) person)
{
    Console.WriteLine(person.name+" "+person.age);
}

for (int i = 0; i < Sort(mas).asc.Length; i++)
{
    Console.Write(Sort(mas).asc[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < Sort(mas).desc.Length; i++)
{
    Console.Write(Sort(mas).desc[i] + " ");
}
Console.WriteLine();
(int[] asc, int[] desc) Sort(int[] mas)
{
    int[] masAsc = new int[mas.Length];
    int[] masDesc= new int[mas.Length];
    for (int i = 0; i < mas.Length - 1; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] > mas[j])
                (mas[i], mas[j]) = (mas[j], mas[i]);
        }
    }
    for (int i = 0; i < mas.Length - 1; i++)
    {
        for (int j = i + 1; j < mas.Length; j++)
        {
            if (mas[i] < mas[j])
                (mas[i], mas[j]) = (mas[j], mas[i]);
        }
    }
    masDesc = mas;
    return (masAsc,masDesc);
}