// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;
using System;
using data_structures;

//Console.WriteLine("Hello, World!");
//int[] ints = {  2, 4, 5, 6, 7 };
//int[] ints1 = { 3, 1,4,2, 9, 8 };

//Console.WriteLine(Exercises.moltiplay(4));
//Console.WriteLine(Exercises.maxtonum(ints));


//int[] array = { 38, 27, 43, 3, 9, 82, 10 };
//int[] litel = { 3, 2, 1 };
//int[] aux = new int[array.Length];
//Exercises.margesort(array, aux, 0, array.Length - 1);
//Exercises.margesort(litel, aux, 0, litel.Length - 1);
//Exercises.insertionSort(litel);
//Exercises.SelectionSort(litel);
//Console.WriteLine(string.Join(", ", array));
//Console.WriteLine(string.Join(", ", litel));


LinkedList linkedList =  new LinkedList();
linkedList.Add(3);
linkedList.Add(3);
linkedList.Add(5);
linkedList.Add(3);
linkedList.Add(6);
linkedList.RemoveValue(3);
//linkedList.RemoveAllValues(3);
linkedList.Display();