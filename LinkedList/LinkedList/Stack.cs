﻿using LinkedListProblem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Stack
    {
        private Node top;
        public Stack()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if(this.top==null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack",value);
        }
        internal void Display()
        {
            Node temp = this.top;
            while(temp!=null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;           
            }
        }
        internal void Peek()
        {
            if(this.top==null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack",this.top.data);
        }
        internal void Pop()
        {
            if(this.top==null)
            {
                Console.WriteLine("Stack is empty,Deletion is not possible");
                return;
            }
            Console.WriteLine("Valued Popped is {0}",this.top.data);
            this.top = this.top.next;
        }
        internal void IsEmpty()
        {
            while(this.top!=null)
            {
                Peek();
                Pop();
            }
        }
    }
}
