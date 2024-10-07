//int i = 123;
//object obj = i;
//i = 456;
//Console.WriteLine(i);
//Console.WriteLine(obj);

//try
//{
//    int j = (int)obj;
//    Console.WriteLine(j);
//}
//catch (InvalidCastException e) 
//{
//    Console.WriteLine(e.Message);
//}

using System.Drawing;

Person<Gender, string, Color> p1 = new Person<Gender, string, Color>(
    "Bill",20,"Town Mamba","+7900453423",170,80,Gender.men,
    "негроидная",Color.Black);
Person<string, string, Color> p2 = new Person<string, string, Color>(
    "Bill", 20, "Town Mamba", "+7900453423", 170, 80, 
    "мужской", "негроидная", Color.Black);
abstract class People<T,K,V>
{
    public double Rost { get; set; }
    public double Weight { get; set; }
    public T Pol { get; set; }
    public K Rassa { get; set; }
    public V ColorEyes { get; set; }

    public People(double rost, double weight, T pol, K rassa, V colorEyes)
    {
        Rost = rost;
        Weight = weight;
        Pol = pol;
        Rassa = rassa;
        ColorEyes = colorEyes;
    }
}
class Person<T, K, V> : People<T, K, V>
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public Person(string? _name, int _age, string? _address,
        string? _phone, double _rost, double _weight, T _pol,K _rassa,
        V _colorYeas) : base(_rost, _weight, _pol, _rassa, _colorYeas)
    { 
        Name = _name;
        Age = _age;
        Address = _address;
        Phone = _phone;
    }
}
class Employee<T, K, V> : Person<T, K, V>
{
    public Employee(string? _name, int _age, 
        string? _address, string? _phone, double _rost, 
        double _weight, T _pol, K _rassa, V _colorYeas,
        int _id,string _position,decimal _salary,DateTime _dateStart
        ) : base(_name, _age, _address, _phone, _rost, 
            _weight, _pol, _rassa, _colorYeas)
    {
        Id = _id;
        Position=_position;
        Salary = _salary;
        DateStart= _dateStart;
    }

    public int Id { get; set; }
    public string? Position { get; set; }
    public decimal? Salary { get; set; }
    public DateTime DateStart { get; set; }
}

class Teacher<T, K, V>: Employee<T, K, V>
{
    public Teacher(string? _name, int _age, string? _address,
        string? _phone, double _rost, 
        double _weight, T _pol, K _rassa, V _colorYeas, 
        int _id, string _position, decimal _salary, DateTime _dateStart,
        string _subject,int _expirience) : base(_name, _age, _address, _phone, _rost, _weight, _pol, _rassa, _colorYeas, _id, _position, _salary, _dateStart)
    {
        Subject = _subject;
        Experience = _expirience;
    }

    public string Subject { get; set; }
    public int Experience { get; set; }
}
enum Gender {men,women}