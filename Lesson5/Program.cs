using Lesson5;

Point p1 = new Point(4, 8);
Point p2 = new Point(3, -9);
Point p3 = new Point(11, 2);
Console.WriteLine("Количество экземпляров:"+Point.getPoints());
Console.WriteLine($"Расстояние {Point.LengthPoints(p1,p2):F2}");
Console.WriteLine($"Расстояние {Point.LengthPoints(p1, p3):F2}");
Console.WriteLine($"Расстояние {Point.LengthPoints(p3, p2):F2}");