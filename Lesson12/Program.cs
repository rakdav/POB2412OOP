Person p1=new Person();
Person p2 = new Person()
{
    Name = "Vasia",
    Age = 34
};
Console.WriteLine(p1.Name);
Console.WriteLine(p1.Age);
p1.Move();
p1.Eat();
Console.WriteLine(IMovable.minSpeed);
Console.WriteLine(IMovable.maxSpeed);

Car car = new Car() { Name = "Mersedes", Age = 5 };
car.Move();
car.Eat();
class Person : IMovable, IEating
{
    private string name; 
    public string Name 
    {
        get => name;
        set => name = value;
    }
    private int age;
    public int Age 
    {
        get => age;
        set
        {
            if (value > 0 && value < 150) age = value;
            else throw new Exception("Возраст не может быть больше 120");
        }
    }
    public void Move()
    {
        Console.WriteLine("Я гуляю");
    }

    public void Eat()
    {
        Console.WriteLine("Ем все, что вкусно");
    }
}

class Car : IMovable,IEating
{
    private string name;
    public string Name 
    {
        get => name; 
        set=>name=value;
    }
    private int age;
    public int Age 
    {
        get =>age; 
        set 
        {
            if (value > 0) age = value;
        }
    }
    public void Move()
    {
        Console.WriteLine("Она едет");
    }

    public void Eat()
    {
        Console.WriteLine("Пью все, что горит!!!");
    }
}
interface IMovable
{
    const int minSpeed = 0;
    static int maxSpeed = 60;
    void Move();
    string Name { get; set; }
    int Age { get; set; }
    delegate void MoveHandler(string message);
}
interface IEating
{
    void Eat();
}
enum Priority
{
    Low,Medium,High
}
interface ITask
{
    string Title { get; set; }
    DateTime DueDate { get; set; }
    Priority Priority { get; set; }
    void Display();
}
