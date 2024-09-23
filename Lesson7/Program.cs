using Lesson7;

//Person person = new Person("Иванов И.И.",
//    DateOnly.Parse("2000-08-23"), "+79006753429");
//person.TakeBook(3);
//person.TakeBook("Пушкин А.С.","Лермонтов М.Ю.",
//                "Толстой Л.Н.");
//person.TakeBook(new Book() { Author="Есенин С.В.",
//                             Title="Шаганэ"},
//                new Book() { Author= "Пушкин А.С.", 
//                             Title = "Капитанская дочь"});
//Reader reader=new Reader("Иванов И.И.",
//    DateOnly.Parse("2000-08-23"), "+79006753429",
//    1345,"Исторический");
//reader.TakeBook(3);
//reader.TakeBook("Пушкин А.С.", "Лермонтов М.Ю.",
//                "Толстой Л.Н.");
//reader.TakeBook(new Book()
//                {
//                    Author = "Есенин С.В.",
//                    Title = "Шаганэ"
//                },
//                new Book()
//                {
//                    Author = "Пушкин А.С.",
//                    Title = "Капитанская дочь"
//                });

//Passanger passanger = new Passanger()
//{
//    FIO = "Иванов Иван Иванович",
//    Passport="1789 896489"
//};
//Train train = new Train()
//{
//    Number = 1,
//    Destination = "Кузнецовка",
//    TimeArived = TimeOnly.Parse("9:10:10"),
//    TimeDeparture= TimeOnly.Parse("10:40:00")
//};
//Cashier cashier = new Cashier()
//{
//    FIO="Петрова Мария Ивановна"
//};
//Reciept reciept = new Reciept()
//{
//   Number=4535354543,
//   Amount=450
//};
//Order order=new Order(passanger, train, cashier, 
//                      reciept, DateTime.Parse("2024.07.16 13:25"));
//Console.WriteLine(order);

BaseClass baseClass = new BaseClass();
baseClass.Number = 1987;
Console.WriteLine(baseClass[2]);
