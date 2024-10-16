
void SendMessage<T>(T message) where T : Message
{
    Console.WriteLine("Отправляется сообщение:"+message.Text);
}


SendMessage(new Message("Hello"));
SendMessage(new EMailMessage("Hello, mail"));
SendMessage(new SmsMessage("Hello, sms"));

Messanger<Message> telegram=new Messanger<Message>();
telegram.SendMessage(new Message("Hello message"));

Messanger<EMailMessage> mail = new Messanger<EMailMessage>();
mail.SendMessage(new EMailMessage("Hello email"));

Messanger<SmsMessage> sms = new Messanger<SmsMessage>();
sms.SendMessage(new SmsMessage("Hello sms"));

IntMessanger<double> intMessanger = new IntMessanger<double>();
RefMessnager<string> refMessnager = new RefMessnager<string>();
PersonMessanger<Message> person=new PersonMessanger<Message>();
Instantiator<string> instantiatorString = new Instantiator<string>();
Instantiator<int> instantiatorInt = new Instantiator<int>();
List<Book> list = new List<Book>();
list.Add(new Book()
{
    Id = 1,
    Author = "fs",
    PublicationYear=DateTime.Parse("2024-01-01"),
    Title="dsds"
});
Catalog<Book> books = new Catalog<Book>(list);
books.AddBook(new Book());
class Message
{
    public string? Text { get; }
    public Message(string? text)
    {
        Text = text;
    }

    public Message()
    {
    }
}
class EMailMessage : Message
{
    public EMailMessage(string? text) : base(text){}
}
class SmsMessage : Message
{
    public SmsMessage(string? text) : base(text){}
}

class Messanger<T> where T : Message
{
    public void SendMessage(T message)
    {
        Console.WriteLine("Отправляется сообщение:"+message.Text);
    }
}

class IntMessanger<T> where T : struct{}
class RefMessnager<T> where T : class { }
class PersonMessanger<T> where T : Message,new()
{}
class Person
{
    private string? name;
    public Person(){}
}
class Instantiator<T>
{
    public T instance;
    public Instantiator()
    {
        instance = default(T);
    }
}

interface ICatalogItem
{
    public int Id { get; set; }
}
class Book:ICatalogItem
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public DateTime? PublicationYear { get; set; }
    public int Id 
    { 
        get => Id;
        set => Id=value; 
    }
}
class Catalog<T> where T : ICatalogItem
{
    private List<T>? collection;
    public Catalog(List<T>? collection)=>this.collection = collection;
    public void AddBook(T book) => collection!.Add(book);
    public List<T> GetBooks() => collection!;
    public T GetConcreteBook(int id) => collection[id];
}