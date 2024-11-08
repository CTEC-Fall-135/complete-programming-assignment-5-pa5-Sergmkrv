/* 
Author: Sergey Makarov
Date: 11/5/24
Assignment: Programming Assignment 5
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        #region Stack 
        // declare and initialize a stack with numbers 1 - 5
        Stack<int> stack = new Stack<int>(new int[] { 1, 2, 3, 4, 5 });

        // print members in the stack using foreach loop
        Console.WriteLine("Stack members:");
        foreach (int number in stack)
        {
            Console.WriteLine(number);
        }

        // Peek at the top member in the stack
        Console.WriteLine($"\nPeek at top member in stack: {stack.Peek()}");

        // pop elements off of the stack and print each
        Console.WriteLine("\nPopping elements from stack:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
        #endregion

        #region Queue
        // declare a queue
        Queue<int> queue = new Queue<int>();

        // initialize the queue with numbers 1 - 5 using a for loop
        for (int i = 1; i <= 5; i++)
        {
            queue.Enqueue(i);
        }

        // print members in the queue using a for each loop
        Console.WriteLine("\nQueue members:");
        foreach (int number in queue)
        {
            Console.WriteLine(number);
        }

        // peek at the top member in the queue
        Console.WriteLine($"\nPeek at front member in queue: {queue.Peek()}");

        // declare elements from the queue and print each 
        Console.WriteLine("\nDequeuing elements from queue:");
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
        #endregion
    }
}
