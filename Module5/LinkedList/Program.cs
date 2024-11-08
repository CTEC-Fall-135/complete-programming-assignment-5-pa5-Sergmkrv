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
        // create a string array with the first few words of a nursery rhyme 
        string[] rhymeWords = {"The", "wheels", "on", "the", "bus", "go", "round", "and", "round" };

        // use the string array to intitilaize a linkedlist
        LinkedList<string> rhymeList = new LinkedList<string>(rhymeWords);

        // print the rhyme on a single line using the enumerator 
        Console.WriteLine("Rhyme using enumerator:");
        foreach (string word in rhymeList)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();

        // Walk the linked list starting from the head and print each word
        Console.WriteLine("\nRhyme by walking the linked list:");
        LinkedListNode<string> currentNode = rhymeList.First;
        while (currentNode != null)
        {
            Console.Write(currentNode.Value + " ");
            currentNode = currentNode.Next;
        }
        Console.WriteLine();

        // remove a word from the middle of the list and print the list
        LinkedListNode<string> nodeToRemove = rhymeList.Find("bus");
        if (nodeToRemove != null)
        {
            rhymeList.Remove(nodeToRemove);
        }

        Console.WriteLine("\nRhyme after removing 'bus':");
        foreach (string word in rhymeList)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();

        // add the word back into the list and print the list again
        LinkedListNode<string> nodeBefore = rhymeList.Find("the");
        if (nodeBefore != null)
        {
            rhymeList.AddAfter(nodeBefore, "bus");
        }

        Console.WriteLine("\nRhyme after adding 'bus' back:");
        foreach (string word in rhymeList)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}