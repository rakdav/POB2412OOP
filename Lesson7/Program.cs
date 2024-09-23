using Lesson7;

Person person = new Person("Иванов И.И.",
    DateOnly.Parse("2000-08-23"), "+79006753429");
person.TakeBook(3);
person.TakeBook("Пушкин А.С.","Лермонтов М.Ю.",
                "Толстой Л.Н.");
person.TakeBook(new Book() { Author="Есенин С.В.",
                             Title="Шаганэ"},
                new Book() { Author= "Пушкин А.С.", 
                             Title = "Капитанская дочь"});
Reader reader=new Reader("Иванов И.И.",
    DateOnly.Parse("2000-08-23"), "+79006753429",
    1345,"Исторический");
reader.TakeBook(3);
reader.TakeBook("Пушкин А.С.", "Лермонтов М.Ю.",
                "Толстой Л.Н.");
reader.TakeBook(new Book()
                {
                    Author = "Есенин С.В.",
                    Title = "Шаганэ"
                },
                new Book()
                {
                    Author = "Пушкин А.С.",
                    Title = "Капитанская дочь"
                });
