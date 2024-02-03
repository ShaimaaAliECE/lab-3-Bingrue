using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class MagicWand : Tool 
    {

        public MagicWand(string name)
        {
            this.description = name;
        }

        public override void Display()
        {
            Console.WriteLine("MagicWand" + this.description + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }
    }
}
