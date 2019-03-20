using System;
using System.Collections.Generic;
using System.Text;

namespace Books
{
    public class Book
    {
        public string Title { get; }

        private int _pageCount;
        public int PageCount
        {
            get
            {
                return this._pageCount;
            }
            set
            {
                if (value >= 0)
                {
                    this._pageCount = value;
                }
            }
        }
        public string Author { get; set; }

        public Book(string title, int pageCount)
        {
            this.Title = title;
            this.PageCount = pageCount;
        }
    }
}
