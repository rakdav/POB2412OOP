using Lesson6._1;
using System.Text.RegularExpressions;

//Person person = new Person("Tom");
//person.Print();

//Employee emp = new Employee("Bob","Microsoft");
//emp.Print();

//person = new Employee("Tom","Google");
//person.Print();

//Client client = new Client("Sam","Standart");
//Console.WriteLine(client);

////Upcasting
//Employee employee = new Employee("John", "Beeline");
//Person bill = employee;
//Console.WriteLine(bill.Name);

//object client1 = new Client("Fred","Moscow");

////DownCasting
//Employee emp1 = (Employee)bill;
//emp1.Print();

//object obj2 = new Employee("Barak","WhiteHouse");

//Console.WriteLine(((Person)obj2).Name??"");

//Способы преобразования
//Employee person = new Employee("Tom","MTS");

//if (person is Person)
//{
//    Person? emp = person as Person;
//    //emp.Company = "Google";
//    Console.WriteLine(emp?.Name);
//}
//else
//{
//    Console.WriteLine("Объект не создан");
//}

List<Student> students = new List<Student>();
students.Add(new Student() { FirstName="Иван",
LastName="Иванов",Group="POB2316",AverageMark=4.9});
students.Add(new Aspirant()
{
    FirstName = "Петр",
    LastName = "Петров",
    Group = "ASP2316",
    AverageMark = 4.5
});
students.Add(new Student() {
    FirstName = "Семен",
    LastName = "Семенов",
    Group = "POB2316", AverageMark = 5});
foreach (var i in students)
{
    if (i is Aspirant)
        Console.WriteLine(((Aspirant)i).getScholarShip());
    else Console.WriteLine(i.getScholarShip());
}