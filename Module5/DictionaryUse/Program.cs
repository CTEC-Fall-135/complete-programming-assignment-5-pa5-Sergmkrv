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
        // initialize a dictionary with 3 entries
        Dictionary<int, string> dictionary = new Dictionary<int, string>
        {
            { 1, "one" },
            { 2, "two" },
            { 3, "three" }
        };

        // use the add method to add (99, "ninety-nine")
        dictionary.Add(99, "ninety-nine");

        // print out each key and value in the dictionary using KeyValuePair<>
        Console.WriteLine("Printing dictionary entries using KeyValuePair:");
        foreach (KeyValuePair<int, string> entry in dictionary)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }

        // print out each key and value in the dictionary using a var
        Console.WriteLine("\nPrinting dictionary entries using var:");
        foreach (var entry in dictionary)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }

        // reassign the value of key 99 to "99" using indexing notation
        dictionary[99] = "99";

        // print the value of key 99 using index notation
        Console.WriteLine($"\nPrinting value of key 99: {dictionary[99]}");

        // remove the entry wiht key 2
        dictionary.Remove(2);

        // print the updated dictionary
        Console.WriteLine("\nPrinting updated dictionary:");
        foreach (var entry in dictionary)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}