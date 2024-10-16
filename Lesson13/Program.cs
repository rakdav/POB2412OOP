using System.Collections;

string[] people = { "Tom", "Sam", "Bob" };
IEnumerator peopleEnumerator= people.GetEnumerator();
while (peopleEnumerator.MoveNext())
{
    string item=(string)peopleEnumerator.Current;
    Console.WriteLine(item);
}
peopleEnumerator.Reset();
Week week = new Week();
foreach(var day in week)
{
    Console.WriteLine(day);
}
class WeekEnumerator : IEnumerator
{
    private string[] days;
    int index = -1;
    public WeekEnumerator(string[] days)
    {
        this.days = days;
    }
    
    public object Current
    {
        get
        {
            if(index==-1||index>=days.Length)
                    throw new ArgumentException();
            return days[index];
        }
    }

    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}
class Week : IEnumerable
{
    string[] days ={ "Monday",
    "Tuesday","Wednesday","Thirthday","Friday","Satarday","sanday"};
    public IEnumerator GetEnumerator()=>days.GetEnumerator();
    
}
