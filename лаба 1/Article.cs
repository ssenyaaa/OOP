using System;

namespace лаба_1
{
    public class Article : EducationalMaterial
    {
        private string journal;
        private int year;

        public Article(string title, string author, string journal, int year)
            : base(title, author)
        {
            Journal = journal;
            Year = year;
        }

        public string Journal
        {
            get { return journal; }
            set { journal = value ?? ""; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year + 1)
                    year = value;
                else
                    throw new ArgumentException("Некорректный год");
            }
        }

        public override void ShowBasicInfo()
        {
            base.ShowBasicInfo();
            Console.WriteLine($"Тип: Статья");
            Console.WriteLine($"Журнал: {Journal}");
            Console.WriteLine($"Год: {Year}");
        }

        public override void DisplayContent()
        {
            Console.WriteLine($"=== Содержание статьи '{Title}' ===");
            Console.WriteLine($"Найдите журнал '{Journal}' за {Year} год");
            Console.WriteLine($"Откройте страницу с вашей статьей и прочитайте");
            Console.WriteLine("================================");
        }
    }
}