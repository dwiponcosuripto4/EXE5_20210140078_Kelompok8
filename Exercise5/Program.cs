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
                dwiponco = suripto = null;
            }
            void Insert(int item)
            {
                Node newNode = new Node(item);
                if (suripto == null)
                {
                    dwiponco = suripto = newNode;
                }
                else
                {
                    suripto.next = newNode;
                    suripto = newNode;
                }
                Console.WriteLine("{0} inseted into Queue", item);
            }
            
        }
    }
}
