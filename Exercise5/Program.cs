using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Node
    {
        internal int data;
        internal Node next;

        public Node(int d)
        {
            data = d;
            next = null;

        }
        internal class LinkListQueue
        {
            Node dwiponco;
            Node suripto;

            public LinkListQueue()
            {
                this.dwiponco = this.suripto = null;
            }
            internal void Insert(int item)
            {
                Node newNode = new Node(item);
            }
        }
    }
}
