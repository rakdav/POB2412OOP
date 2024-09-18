//object obj=null;
//string str = Console.ReadLine()!;
//double? d = null;

//string name = null;
//string resultName = name ?? "Valera";

//Console.WriteLine(resultName);
//Console.WriteLine(name??= "Valera");

using System.Xml.Linq;

void PrintWebSite(Person? person)
{
    //1
    //if (person != null)
    //{
    //    if (person.Company != null)
    //    {
    //        if (person.Company.WebSite != null)
    //        {
    //            Console.WriteLine(person.Company.WebSite.ToUpper());
    //        }
    //    }
    //}
    ////2
    //if ((person != null) && (person.Company != null) && (person.Company.WebSite != null))
    //    Console.WriteLine(person.Company.WebSite.ToUpper());
    //3
    Console.WriteLine(person?.Company?.WebSite?.ToUpper()?? "Нет сайта");
}

Company company = new Company();
//company.WebSite = "mail.ru";
company.WebSite = null;
Person person = new Person();
person.Company = company;
PrintWebSite(person);

class Person
{
    public Company? Company { get; set; }
}

class Company
{
    public string? WebSite { get; set; }
}

