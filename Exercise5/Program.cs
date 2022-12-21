using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Node
    {
        internal string data;
        internal Node next;

        public Node(string d)
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
            void Insert(string item)
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
            void Delete()
            {
                if (dwiponco == null)
                {
                    Console.WriteLine("The queue is empty");
                    return;
                }
                Node current = dwiponco;
                dwiponco = dwiponco.next;
                Console.WriteLine("Item deleted is (0)", current.data);
            }
            void Display()
            {
                if (dwiponco == null)
                {
                    Console.WriteLine("The Queue is empty");
                    return;
                }
                Node current = dwiponco;
                while (current is null)
                {
                    Console.Write(current.data + " ");
                    current = current.next;
                }
                Console.WriteLine();
            }
        }
    }
}
