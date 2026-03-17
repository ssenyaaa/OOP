using System;
using лаба_1;

namespace лаба_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ДЕМОНСТРАЦИЯ ОБОБЩЕННОГО КЛАССА LIBRARY<T> ===\n");

            // Демонстрация 1: Библиотека книг (Library<Book>)
            Console.WriteLine("--- СОЗДАЕМ БИБЛИОТЕКУ КНИГ ---");
            Library<Book> bookLibrary = new Library<Book>();

            // Добавляем книги
            bookLibrary.AddMaterial(new Book("Война и мир", "Лев Толстой", 1300, "978-5-699-12014-7"));
            bookLibrary.AddMaterial(new Book("Преступление и наказание", "Федор Достоевский", 672, "978-5-17-123456-7"));
            bookLibrary.AddMaterial(new Book("Мастер и Маргарита", "Михаил Булгаков", 480, "978-5-17-098765-4"));

            // Показываем все содержимое книг
            bookLibrary.ShowAllContents();

            // Демонстрация 2: Библиотека видеокурсов (Library<VideoCourse>)
            Console.WriteLine("\n--- СОЗДАЕМ БИБЛИОТЕКУ ВИДЕОКУРСОВ ---");
            Library<VideoCourse> videoLibrary = new Library<VideoCourse>();

            videoLibrary.AddMaterial(new VideoCourse("Основы C#", "Иван Иванов", 360, "https://youtube.com/csharp-basics"));
            videoLibrary.AddMaterial(new VideoCourse("Python для начинающих", "Петр Сидоров", 480, "https://youtube.com/python-beginners"));

            videoLibrary.ShowAllContents();

            // Демонстрация 3: Библиотека статей (Library<Article>)
            Console.WriteLine("\n--- СОЗДАЕМ БИБЛИОТЕКУ СТАТЕЙ ---");
            Library<Article> articleLibrary = new Library<Article>();

            articleLibrary.AddMaterial(new Article("Новые методы ООП", "Петр Петров", "Программист", 2023));
            articleLibrary.AddMaterial(new Article("Искусственный интеллект", "Анна Смирнова", "Наука и жизнь", 2024));

            articleLibrary.ShowAllContents();

            // Демонстрация 4: Смешанная библиотека (Library<EducationalMaterial>)
            Console.WriteLine("\n--- СОЗДАЕМ СМЕШАННУЮ БИБЛИОТЕКУ (ВСЕ ТИПЫ) ---");
            Library<EducationalMaterial> mixedLibrary = new Library<EducationalMaterial>();

            mixedLibrary.AddMaterial(new Book("Краткая история времени", "Стивен Хокинг", 256, "978-5-17-098765-4"));
            mixedLibrary.AddMaterial(new VideoCourse("Машинное обучение", "Алексей Иванов", 600, "https://youtube.com/ml-course"));
            mixedLibrary.AddMaterial(new Article("Квантовые компьютеры", "Николай Петров", "Техника молодежи", 2025));

            mixedLibrary.ShowAllContents();

            // Демонстрация 5: Поиск по названию
            Console.WriteLine("\n=== ПОИСК МАТЕРИАЛА ===");
            EducationalMaterial found = mixedLibrary.FindByTitle("Краткая история времени");
            if (found != null)
            {
                Console.WriteLine("Найденный материал:");
                found.DisplayContent();
            }

            // Демонстрация 6: Статистика
            Console.WriteLine("\n=== СТАТИСТИКА ===");
            Console.WriteLine($"Книг в книжной библиотеке: {bookLibrary.Count}");
            Console.WriteLine($"Видеокурсов в видеобиблиотеке: {videoLibrary.Count}");
            Console.WriteLine($"Статей в библиотеке статей: {articleLibrary.Count}");
            Console.WriteLine($"Материалов в смешанной библиотеке: {mixedLibrary.Count}");
            Console.WriteLine($"\nВСЕГО МАТЕРИАЛОВ ВО ВСЕХ БИБЛИОТЕКАХ: {Library<EducationalMaterial>.TotalMaterialCount}");

            // Демонстрация 7: Краткая информация
            Console.WriteLine("\n=== КРАТКАЯ ИНФОРМАЦИЯ О СМЕШАННОЙ БИБЛИОТЕКЕ ===");
            mixedLibrary.ShowAllBasicInfo();

            Console.WriteLine("\nПрограмма завершена. Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}