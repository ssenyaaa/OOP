using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace лаба_1
{
    internal class Book
    {
        private string isbn;
        private string nameBook;
        private string author;
        private int yearBook;
        private bool isAvailable;
        private string status;

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string NameBook
        {
            get { return nameBook; }
            set { nameBook = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

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

        public void TakeBook(string person)
        {
            if (isAvailable== true)
            {
                isAvailable = false;
                Status = "Выдана";
                Console.WriteLine($"Книга \"{nameBook}\" успешно выдана читателю {person}!");

            }
            else
            {
                Console.WriteLine($"Книга \"{nameBook}\" сейчас недоступна ");
            }
        }

        public void ReturnBook(string person)
        {
            if ( isAvailable ==false)
            {
                isAvailable = true;
                Status= "Доступна";
                Console.WriteLine($"Книга \"{nameBook}\" успешно возвращена читателем {person}!");
            }
            else
            {
                Console.WriteLine($"Книга \"{nameBook}\" уже находится в библиотеке. ");
            }
        }
        
    }
}
//
