using лаба_1;
using System;


EducationalMaterial[] materials = new EducationalMaterial[]
{
    new Book("Война и мир", "Лев Толстой", 1300, "978-5-699-12014-7"),
    new VideoCourse("Основы C#", "Иван Иванов", 360, "https://youtube.com/csharp-basics"),
    new Article("Новые методы ООП", "Петр Петров", "Программист", 2023),
    new Book("Преступление и наказание", "Федор Достоевский", 672, "978-5-17-123456-7")
};

Console.WriteLine("\nОбработка учебных материалов через массив EducationalMaterial[]");
foreach (EducationalMaterial material in materials)
{
    material.DisplayContent(); 
    Console.WriteLine();
}