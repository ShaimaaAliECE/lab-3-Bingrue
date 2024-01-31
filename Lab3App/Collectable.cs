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

        public CollectionBoard board;
        
        
        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(description + " Collected, Congrats!! ");

        }

        public CollectionBoard Board
        {

            get { return board; }
            set { board = value; }

        }


        public abstract void Display();
    }
}
