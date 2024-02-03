using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        public String description;

        public CollectionBoard collectionBoard;
        
        
        public virtual void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
            Console.WriteLine(description + " Collected, Congrats!! ");

        }

        public CollectionBoard Board
        {

            get { return collectionBoard; }
            set { collectionBoard = value; }

        }


        public abstract void Display();
    }
}
