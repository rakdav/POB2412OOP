int i = 123;
object obj = i;
i = 456;
Console.WriteLine(i);
Console.WriteLine(obj);

try
{
    int j = (int)obj;
    Console.WriteLine(j);
}
catch (InvalidCastException e) 
{
    Console.WriteLine(e.Message);
}
