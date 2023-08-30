using System;
using System.Collections;
using System.Collections.Generic;

namespace SRP
{
    public class Shelf
    {
        public List <Book> bookList;
        private int shelfIdentifier { get; set; }

        public Shelf (int identifier)
        {
            this.bookList = new List <Book> ();
            this.shelfIdentifier = identifier;
        }

        public void shelve (Book newbook)
        {
            this.bookList.Add (newbook);
        }
    }
}
