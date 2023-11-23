using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Binary_Tree_HW
{
    internal class Node
    {
        public int Key {  get; set; }
        public string Value { get; set; }
        public Node rigth;
        public Node left;

        public Node(int key,string value) {
            Key = key;
            Value = value;
        }

        public void AddNode(int key, string value)
        {
            if (this.Key < key)
            {
                if (rigth == null)
                {
                    rigth = new Node(key, value);
                }
                else
                {
                    rigth.AddNode(key, value);
                }
            }
            else
            {
                if (this.Key >= key)
                {
                    if (left == null)
                    {
                        left = new Node(key, value);
                    }
                    else
                    {
                        left.AddNode(key, value);
                    }
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"({Key}:{Value})\n\t");
            if( rigth != null )
            {
                sb.Append("\n\t(");
                sb.Append( rigth.ToString() );
                
            }
            if( left != null )
            {
                sb.Append("\n\t(");
                sb.Append( left.ToString() );
            }
            sb.Append(")");
            return  sb.ToString() ;
        }
    }
}
