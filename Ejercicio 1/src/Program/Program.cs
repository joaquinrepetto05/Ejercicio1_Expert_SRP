using System;
using System.Collections.Generic;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book ("Design Patterns" , "Erich Gamma & Others" , "001-034");
            Book book2 = new Book ("Pro C#" , "Troelsen" , "001-035");
            Book book3 = new Book ("1984" , "George Orweel" , "001-036");
            Book book4 = new Book ("Oliver Twist" , "Charles Dickens" , "001-037");
        
            Shelf shelf1 = new Shelf (7);
            shelf1.shelve (book1);
            shelf1.shelve (book2);

            Shelf shelf2 = new Shelf (4);
            shelf2.shelve (book3);
            shelf2.shelve (book4);

            Sector sector1 = new Sector (2);
            sector1.addtosector (shelf1);
            sector1.addtosector (shelf2);

        }

    }
}