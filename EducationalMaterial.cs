using System;

namespace лаба_1
{
    public abstract class EducationalMaterial
    {
        
        private string title;
        private string author;

        
        public EducationalMaterial(string title, string author)
        {
            Title = title;
            Author = author;
        }

        
        public string Title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    title = value;
                else
                    throw new ArgumentException("Название не может быть пустым");
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    author = value;
                else
                    throw new ArgumentException("Автор не может быть пустым");
            }
        }

        
        public virtual void ShowBasicInfo()
        {
            Console.WriteLine($"Материал: {Title}");
            Console.WriteLine($"Автор: {Author}");
        }

        
        public abstract void DisplayContent();
    }
}