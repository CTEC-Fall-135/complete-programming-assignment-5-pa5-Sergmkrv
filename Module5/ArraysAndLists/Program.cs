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
        #region SimpleArray
        // Simple Array
        int[] array = new int[5];

        // Initialize array with value 11 to 15
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 11 + i;
        }

        // print values in the array using the foreach loop 
        Console.WriteLine("Printing Array Values:");
        foreach (int value in array)
        {
            Console.WriteLine(value);
        }
        #endregion

        #region List<T>
        // List <T>
        List<int> list = new List<int>();

        // initialize list with the values 21 to 25
        for (int i = 0; i < 5; i++)
        {
            list.Add(21 + i);
        }

        // print values in the list using a foreach loop 
        Console.WriteLine("\nPrinting List Values:");
        foreach (int value in list)
        {
            Console.WriteLine(value);
        }

        // update the values in the list to 31 to 35 using a for loop
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = 31 + i;
        }

        // print updated list values using a for loop and indexing 
        Console.WriteLine("\nPrinting Updated List Values:");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
        #endregion
    }
}