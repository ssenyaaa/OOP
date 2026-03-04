using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace лаба_1
{
    public class Book: EducationalMaterial
    
    {
        private int pageCount;      
        private string isbn;
        
        
        
        private int yearBook;
        private bool isAvailable;
        private string status;


        public Book()
            : base("","")  
        {
            PageCount =0;
            ISBN = "";
        }

        public Book(string title, string author, int pageCount, string isbn)
       : base(title, author)
        {
            this.pageCount = pageCount;
            this.isbn = isbn ?? "";
            this.yearBook = 0;
            this.isAvailable = false;
            this.status = "Доступна";
        }

        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        //public string NameBook
        //{
        //    get { return nameBook; }
        //    set { nameBook = value; }
        //}
        //public string Author
        //{
        //    get { return author; }
        //    set { author = value; }
        //}

        public int Year
        {
            get { return yearBook; }
            set { yearBook = value; }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
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
            Console.WriteLine($"Содержание книги '{Title}'");
            Console.WriteLine($"Откройте книгу на странице 1 и начните читать...");
            Console.WriteLine($"Всего страниц: {PageCount}");
            
        }
        public void TakeBook(string person)
        {
            if (isAvailable== true)
            {
                isAvailable = false;
                Status = "Выдана";
                Console.WriteLine($"Книга \"{Title}\" успешно выдана читателю {person}!");

            }
            else
            {
                Console.WriteLine($"Книга \"{Title}\" сейчас недоступна ");
            }
        }

        public void ReturnBook(string person)
        {
            if ( isAvailable ==false)
            {
                isAvailable = true;
                Status= "Доступна";
                Console.WriteLine($"Книга \"{Title}\" успешно возвращена читателем {person}!");
            }
            else
            {
                Console.WriteLine($"Книга \"{Title}\" уже находится в библиотеке. ");
            }
        }
        
    }
}
