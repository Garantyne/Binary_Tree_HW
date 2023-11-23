using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_HW
{
    internal class Root
    {
        private int key;
        private string value;
        public Node node;
        
        public Root(int key, string value) {
            
           if(node == null)
            {
                node = new Node(key, value);
                this.key = key;
            }
            else
            {
                if(node.Key <= key)
                {
                    node.left = new Node(key, value);
                }
                else
                {
                    node.rigth = new Node(key, value);
                }
            }
        }

        public void AddNode(int key, string value)
        {
            node.AddNode(key, value);
        }

        public void Print()
        {

            Console.WriteLine(node.ToString());
        }
    }
}
