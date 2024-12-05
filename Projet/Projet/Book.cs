using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public AgeGroup AgeGroup { get; set; }
        public Category Category { get; set; }
        public Book(string title, string author, AgeGroup ageGroup, Category category)
        {
            Title = title;
            Author = author;
            AgeGroup = ageGroup;
            Category = category;
        }
    }
}
