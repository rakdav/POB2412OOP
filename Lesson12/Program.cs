//Person p1=new Person();
//Person p2 = new Person()
//{
//    Name = "Vasia",
//    Age = 34
//};
//Console.WriteLine(p1.Name);
//Console.WriteLine(p1.Age);
//p1.Move();
//p1.Eat();
//Console.WriteLine(IMovable.minSpeed);
//Console.WriteLine(IMovable.maxSpeed);

//Car car = new Car() { Name = "Mersedes", Age = 5 };
//car.Move();
//car.Eat();

TaskManager taskManager = new TaskManager();
taskManager.Add(new Task()
{
    DueDate = DateTime.Parse("12.02.2024"),
    Priority = Priority.Medium,
    Title = "t1"
});
taskManager.Add(new Event()
{
    Title = "e1",
    Priority = Priority.High,
    DueDate = DateTime.Parse("9.10.2024"),
    Location="Kenig"
});
taskManager.Print();
taskManager.Remove(taskManager.Tasks[1]);
taskManager.Print();
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

class Task : ITask
{
    public string Title { get; set; }
    public DateTime DueDate { get; set; }
    public Priority Priority { get; set; }
    public void Display()
    {
        Console.WriteLine(Title+" "+DueDate+" "+Priority);
    }
}
class Event : ITask
{
    public string Location { get; set; }
    public string Title { get; set; }
    public DateTime DueDate { get; set; }
    public Priority Priority { get; set; }

    public void Display()
    {
        Console.WriteLine( Location+" "+Title+" "+DueDate+" "+Priority);
    }
}

class TaskManager
{
    public List<ITask> Tasks { get; set; } = new();
    public void Add(ITask task)
    {
        Tasks.Add(task);
    }
    public void Remove(ITask task)
    {
        Tasks.Remove(task);
    }
    public void Print()
    {
        foreach (var item in Tasks)
        {
            item.Display();
        }
    }
}
class ImplementationInt : IMyInterface<int>
{
    private int a;
    public int GetValue()
    {
        return a;
    }
    public void SetValue(int value)
    {
        a = value;
    }
}
class ImplementationString : IMyInterface<string>
{
    private string str;
    public string GetValue()
    {
        return str;
    }
    public void SetValue(string value)
    {
        str = value;
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

interface IMyInterface<T>
{
    T GetValue();
    void SetValue(T value);
}
