﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class Loan
    {
        public Book Book { get; set; }
        public User User { get; set; }
        public DateTime ReturnDate { get; set; }

        public Loan(Book book, User user)
        {
            Book = book;
            User = user;
            ReturnDate = DateTime.Now.AddDays(new Random().Next(14, 28));
        }
        public Loan(Book book, User user, DateTime returnDate)
        {
            Book = book;
            User = user;
            ReturnDate = returnDate;
        }
    }
}
