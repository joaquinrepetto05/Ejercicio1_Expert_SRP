/*

using System;

namespace SRP
{
    public class Book
    {
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; } /// El libro no debería conocer información sobre su sector, ya que no es su responsabilidad
        public string LibraryShelve { get ; set; } /// El libro no debería conocer información sobre su estante, ya que no es su responsabilidad

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        public void ShelveBook(String sector, String shelve) 
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
    }
}

Para solucionar este código, deberíamos crear 2 clases:
    ---> Shelve: Su responsabilidad es saber la lista de libros
    ---> Sector: Su responsabilidad es saber la lista de estantes

*/

using System;

namespace SRP
{
    public class Book
    {
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Book (String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
}
