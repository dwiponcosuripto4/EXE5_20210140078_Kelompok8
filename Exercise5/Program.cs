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
        internal class QueueLinkList
        {
            Node dwiponco;
            Node suripto;

            public QueueLinkList()
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
            static void Main(string[] args)
            {
                QueueLinkList myQueue = new QueueLinkList();
                char ch;

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Menu");
                        Console.WriteLine("1. Implement Insert Operation");
                        Console.WriteLine("2. Implement delete operation");
                        Console.WriteLine("3. Display values");
                        Console.WriteLine("4. Exit");
                        Console.Write("\nEnter your choice (1-4): ");
                        ch = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine();
                        switch(ch)
                        {
                            case '1':
                                {
                                    Console.Write("Enter a data: ");
                                    string item = Console.ReadLine();
                                    myQueue.Insert(item);
                                }
                                break;
                            case '2':
                                {
                                    myQueue.Delete();
                                }
                                break;
                            case '3':
                                {
                                    myQueue.Display();
                                }
                                break;
                            case '4':
                                return;
                            default:
                                {
                                    Console.WriteLine("Invalid option");
                                }
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Check for the data entered");
                    }
                }
            }
        }
    }
}
