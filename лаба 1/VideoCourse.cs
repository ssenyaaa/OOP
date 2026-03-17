using System;

namespace лаба_1
{
    public class VideoCourse : EducationalMaterial
    {
        private int duration;
        private string link;

        public VideoCourse(string title, string author, int duration, string link)
            : base(title, author)
        {
            Duration = duration;
            Link = link;
        }

        public int Duration
        {
            get { return duration; }
            set
            {
                if (value > 0)
                    duration = value;
                else
                    throw new ArgumentException("Длительность должна быть больше 0");
            }
        }

        public string Link
        {
            get { return link; }
            set { link = value ?? ""; }
        }

        public override void ShowBasicInfo()
        {
            base.ShowBasicInfo();
            Console.WriteLine($"Тип: Видеокурс");
            Console.WriteLine($"Длительность: {Duration} минут");
            Console.WriteLine($"Ссылка: {Link}");
        }

        public override void DisplayContent()
        {
            Console.WriteLine($"=== Содержание видеокурса '{Title}' ===");
            Console.WriteLine($"Перейдите по ссылке и посмотрите видео:");
            Console.WriteLine($"{Link}");
            Console.WriteLine($"Длительность курса: {Duration / 60} ч {Duration % 60} мин");
            Console.WriteLine("================================");
        }
    }
}