using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Root root = new Root(5, "asdf");
            root.AddNode(7, "asd");
            root.AddNode(4, "asd");
            root.AddNode(3, "asd");
            root.AddNode(8, "asd");
            root.AddNode(17, "asd");
            root.Print();
        }
    }
}
