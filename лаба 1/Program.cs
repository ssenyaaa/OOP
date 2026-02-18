
using лаба_1;

Book MyBook = new Book()
{
    ISBN = "978-5-699-12014-7",
    NameBook = "Война и мир",
    Author = "Лев Толстой",
    Year = 1869,
    IsAvailable = true,
    Status = "Доступна"

};

Console.WriteLine($"ISBN книги: {MyBook.ISBN}");
Console.WriteLine($"Название книги: {MyBook.NameBook}");
Console.WriteLine($"Автор книги: {MyBook.Author}");
Console.WriteLine($"Год издания: {MyBook.Year}");
Console.WriteLine($"Доступность: {MyBook.IsAvailable}");
Console.WriteLine($"Статус: {MyBook.Status}");



MyBook.TakeBook("Анна");
Console.WriteLine($"Статус после взятия: {MyBook.Status}");
Console.WriteLine($"Доступность: {MyBook.IsAvailable}");