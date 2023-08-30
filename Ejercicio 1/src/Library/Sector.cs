using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        public List <Shelf> shelflist;
        private int sectorIdentifier { get; set; }

        public Sector (int identifier)
        {
            this.shelflist = new List<Shelf> ();
            this.sectorIdentifier = identifier;
        }

        public void addtosector (Shelf newshelf)
        {
            this.shelflist.Add (newshelf);
        }
    }
}
