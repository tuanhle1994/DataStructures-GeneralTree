using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralTree
{
    class GeneralTree
    {
    }

    public class Node<String>
    {
        public String Data { get; set; }
        public List<Node<String>> Children { get; set; }

        public Node(String mData)
        {
            this.Data = mData;
            this.Children = new List<Node<String>>();
        }

        public void Add(String data)
        {
            var node = new Node<String>(data);
            this.Children.Add(node);
        }

        public void Remove(String data)
        {
            foreach (var node in Children)
            {
                if (node.Data.Equals(data))
                {
                    Children.Remove(node);
                    break;
                }
            }
        }
    }
}
