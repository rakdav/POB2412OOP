using Lesson12._1;

Student<int>[] mas = new Student<int>[3];
mas[0]=new Student<int>("Vasia",16);
mas[1] = new Student<int>("Boris",13 );
mas[2] = new Student<int>("Eugen", 10);
Array.Sort(mas);
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine(mas[i]);
}
