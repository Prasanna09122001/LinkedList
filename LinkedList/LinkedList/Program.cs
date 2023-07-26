using System;                                                        
using System.Collections.Concurrent;                                 
                                                                     
namespace LinkedList                                                 
{                                                                    
    class program                                                    
    {                                                                
        static void Main()                                           
        {                                                            
             Console.WriteLine("Welcome to the Linked list Problem");
            // linkedlist list = new linkedlist();                      
            //list.Add(56);                                          
            //list.Add(30);                                          
            //list.Add(70);
            // list.AddInReverseOrder(56);                              
            // list.AddInReverseOrder(30);                              
            // list.AddInReverseOrder(70);
            // list.InserAtParticularPosition(2, 40);
            // list.RemoveFirstNode();
            // list.Display();
            // list.RemoveLastNode();
            // list.Display();
            //int a = list.search(70);
            //Console.WriteLine("The position of 70 is "+a);
            // list.DeleteNodeAtParticularPosition(1);
            //list.size();
            Stack stack = new Stack();
            stack.Push(56);
            stack.Push(30);
            stack.Push(70);
            stack.Display();
            stack.peek();
            stack.pop();
            stack.Display();
        }                                                            
    }                                                                
}                                                                    