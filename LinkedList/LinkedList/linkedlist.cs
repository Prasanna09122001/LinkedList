using LinkedListProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class linkedlist
    {
        internal Node head;
        internal void Add(int data)
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
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void AddInReverseOrder(int data)
        {
            Node newnode = new Node(data);
            if (this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                Node temp = this.head;
                head = newnode;
                head.next = temp;
            }
        }
        internal Node InserAtParticularPosition(int position,int data)
        {
            Node newestnode = new Node(data);
            if(this.head==null)
            {
                return newestnode;
            }
            if(position == 0)
            {
                newestnode.next = this.head;
                this.head = newestnode;
                return this.head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while(current!=null && count<position)
            {
               prev = current;
               current = current.next;
               count++;
            }
            newestnode.next = prev.next;
            prev.next = newestnode;
            return this.head;
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        internal Node RemoveFirstNode()
        {
            if(this.head ==null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
       internal Node RemoveLastNode()
        {
            if(head == null)
            {
                return null;
            }
            if(head.next == null)
            {
                return null;
            }
            Node newnode = head;
            while(newnode.next.next!=null)
            {
                newnode = newnode.next;
            }
            newnode.next = null;
            return head;
        }
        internal int search(int value)
        {
            Node node = this.head;
            int count = 0;
            while(node != null)
            {
                if(node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        internal void DeleteNodeAtParticularPosition(int position)
        {
            if(this.head == null)
            {
                Console.WriteLine("The Linked List is Empty");
                return;
            }
            Node temp = this.head;
            if(position == 0)
            {
                this.head = temp.next;
                return;
            }
            for(int i =0;temp  !=null && i<position-1;i++)
            {
                temp = temp.next;
            }
            if(temp==null||temp.next==null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
            size();
        }
        internal void size()
        {
            int count = 0;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                count++;
                temp = temp.next;
            }
            Console.WriteLine("The Size of The Linked List is "+count);
        }
    }
}