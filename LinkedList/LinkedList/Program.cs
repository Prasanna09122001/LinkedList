﻿using System;
using System.Collections.Concurrent;

namespace LinkedList
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Linked list Problem");
            linkedlist list = new linkedlist();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            list.AddInReverseOrder(56);
            list.AddInReverseOrder(30);
            list.AddInReverseOrder(70);
            list.Display();
        }
    }
}