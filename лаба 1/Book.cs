using System;

namespace лаба_1
{
    public class Book : EducationalMaterial
    {
        private int pageCount;
        private string isbn;

        public Book(string title, string author, int pageCount, string isbn)
            : base(title, author)
        {
            PageCount = pageCount;
            ISBN = isbn;
        }

        public int PageCount
        {
            get { return pageCount; }
            set
            {
                if (value > 0)
                    pageCount = value;
                else
                    throw new ArgumentException("Количество страниц должно быть больше 0");
            }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value ?? ""; }
        }

        public override void ShowBasicInfo()
        {
            base.ShowBasicInfo();
            Console.WriteLine($"Тип: Книга");
            Console.WriteLine($"Страниц: {PageCount}");
            Console.WriteLine($"ISBN: {ISBN}");
        }

        public override void DisplayContent()
        {
            Console.WriteLine($"=== Содержание книги '{Title}' ===");
            Console.WriteLine($"Откройте книгу на странице 1 и начните читать...");
            Console.WriteLine($"Всего страниц: {PageCount}");
            Console.WriteLine("================================");
        }
    }
}