using LinkedListProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Queue
    {
        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Dequeue()
        {
            if(this.head == null)
            {
                Console.WriteLine("Queue is Empty. Deletion is not available");
                return;
            }
            else
            {
                while(this.head !=null)
                {
                    Console.WriteLine("Value Dequeued is {0}",this.head.data);
                    this.head = this.head.next;
                    return;
                }
            }
        }

    }
}
