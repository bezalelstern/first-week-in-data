﻿using data_structures;
using System;


class Program
{
    static void Main(string[] args)
    {

        BinaryTree tree = new BinaryTree();

        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(70);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(60);
        tree.Insert(80);

        Console.WriteLine("In-order traversal of the binary tree:");
        tree.print();

        Console.WriteLine("\nMinimum value in the binary tree: " + tree.findmin());
        Console.WriteLine("Maximum value in the binary tree: " + tree.findmax());

        int totalTests = 0;
        int passedTests = 0;

        // Test 1: Creating an empty linked list
        totalTests++;
        try
        {
            LinkedList list1 = new LinkedList();
            if (list1.Length() == 0)
            {
                Console.WriteLine("Test 1 Passed: Creating an empty linked list.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 1 Failed: Length is not zero for an empty list.");
            }
        }
        catch
        {
            Console.WriteLine("Test 1 Failed: Unexpected exception.");
        }

        // Test 2: Adding elements to the end of the list
        totalTests++;
        try
        {
            LinkedList list2 = new LinkedList();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);

            if (list2.Length() == 3 && list2.Display() == "1 -> 2 -> 3")
            {
                Console.WriteLine("Test 2 Passed: Adding elements to the end of the list.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 2 Failed: Elements not added correctly.");
            }
        }
        catch
        {
            Console.WriteLine("Test 2 Failed: Unexpected exception.");
        }

        //Test 3: Removing a value(RemoveValue) from the list

       totalTests++;
        try
        {
            LinkedList list3 = new LinkedList();
            list3.Add(1);
            list3.Add(2);
            list3.Add(3);
            list3.RemoveValue(2);

            if (list3.Length() == 2 && list3.Display() == "1 -> 3")
            {
                Console.WriteLine("Test 3 Passed: Removing a value from the list.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 3 Failed: Value not removed correctly.");
            }
        }
        catch
        {
            Console.WriteLine("Test 3 Failed: Unexpected exception.");
        }

        // Test 4: Removing all instances of a value (RemoveAllValues)
        totalTests++;
        try
        {
            LinkedList list4 = new LinkedList();
            list4.Add(5);
            list4.Add(5);
            list4.Add(5);
            list4.RemoveAllValues(5);

            if (list4.Length() == 0 && list4.Display() == "")
            {
                Console.WriteLine("Test 4 Passed: Removing all instances of a value from the list.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 4 Failed: Not all instances of value removed.");
            }
        }
        catch
        {
            Console.WriteLine("Test 4 Failed: Unexpected exception.");
        }

        // Test 5: Removing by index (RemoveIndex)
        totalTests++;
        try
        {
            LinkedList list5 = new LinkedList();
            list5.Add(10);
            list5.Add(20);
            list5.Add(30);
            list5.RemoveIndex(1); // Should remove the second element
            if (list5.Length() == 2 && list5.Display() == "10 -> 30")
            {
                Console.WriteLine("Test 5 Passed: Removing by index.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 5 Failed: Value not removed at the correct index.");
            }
        }
        catch
        {
            Console.WriteLine("Test 5 Failed: Unexpected exception.");
        }

        // Test 6: Finding an element (Find) and getting the correct index
        totalTests++;
        try
        {
            LinkedList list6 = new LinkedList();
            list6.Add(100);
            list6.Add(200);
            int index = list6.Find(200);

            if (index == 1)
            {
                Console.WriteLine("Test 6 Passed: Finding an element returns the correct index.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 6 Failed: Incorrect index returned by Find method.");
            }
        }
        catch
        {
            Console.WriteLine("Test 6 Failed: Unexpected exception.");
        }

        // Test 7: Finding a non-existent element (Find)
        totalTests++;
        try
        {
            LinkedList list7 = new LinkedList();
            list7.Add(1);
            list7.Add(2);
            list7.Add(3);
            int index = list7.Find(4); // Element 4 does not exist

            if (index == -1) // Assuming -1 indicates not found
            {
                Console.WriteLine("Test 7 Passed: Finding a non-existent element returns -1.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 7 Failed: Incorrect result for finding a non-existent element.");
            }
        }
        catch
        {
            Console.WriteLine("Test 7 Failed: Unexpected exception.");
        }

        // Test 8: Getting a value by index (Get)
        totalTests++;
        try
        {
            LinkedList list8 = new LinkedList();
            list8.Add(101);
            list8.Add(102);
            int value = list8.Get(1);

            if (value == 102)
            {
                Console.WriteLine("Test 8 Passed: Getting a value by index.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 8 Failed: Incorrect value returned by Get method.");
            }
        }
        catch
        {
            Console.WriteLine("Test 8 Failed: Unexpected exception.");
        }

        // Test 9: Edge case - Removing from an empty list
        totalTests++;
        try
        {
            LinkedList list9 = new LinkedList();
            list9.RemoveValue(100); // Should handle gracefully without changes

            if (list9.Length() == 0)
            {
                Console.WriteLine("Test 9 Passed: Removing from an empty list does nothing.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 9 Failed: Removing from an empty list should not change length.");
            }
        }
        catch
        {
            Console.WriteLine("Test 9 Failed: Unexpected exception.");
        }

        // Test 10: Edge case - Getting from an empty list
        totalTests++;
        try
        {
            LinkedList list10 = new LinkedList();
            int value = list10.Get(0); // Should handle gracefully and return -1 or some error code

            if (value == -1) // Assuming -1 indicates an invalid index
            {
                Console.WriteLine("Test 10 Passed: Getting from an empty list returned -1.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 10 Failed: Incorrect value returned for empty list.");
            }
        }
        catch
        {
            Console.WriteLine("Test 10 Failed: Unexpected exception.");
        }

        // Test 11: Edge case - Index out of range
        totalTests++;
        try
        {
            LinkedList list11 = new LinkedList();
            list11.Add(1);
            int value = list11.Get(5); // Should handle gracefully and return -1 or some error code

            if (value == -1) // Assuming -1 indicates an invalid index
            {
                Console.WriteLine("Test 11 Passed: Out of range index correctly handled.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 11 Failed: Incorrect value returned for out of range index.");
            }
        }
        catch
        {
            Console.WriteLine("Test 11 Failed: Unexpected exception.");
        }

        // Test 12: Edge case - Removing the head of the list
        totalTests++;
        try
        {
            LinkedList list12 = new LinkedList();
            list12.Add(10);
            list12.Add(20);
            list12.RemoveValue(10); // Remove the head element

            if (list12.Length() == 1 && list12.Display() == "20")
            {
                Console.WriteLine("Test 12 Passed: Removing the head of the list.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 12 Failed: Head not removed correctly.");
            }
        }
        catch
        {
            Console.WriteLine("Test 12 Failed: Unexpected exception.");
        }

        // Test 13: Edge case - Large data set
        totalTests++;
        try
        {
            LinkedList list13 = new LinkedList();
            for (int i = 0; i < 1000; i++)
            {
                list13.Add(i);
            }

            bool correctLength = list13.Length() == 1000;
            bool correctValue = list13.Get(999) == 999;

            if (correctLength && correctValue)
            {
                Console.WriteLine("Test 13 Passed: Handling a large data set.");
                passedTests++;
            }
            else
            {
                Console.WriteLine("Test 13 Failed: Incorrect behavior with a large data set.");
            }
        }
        catch
        {
            Console.WriteLine("Test 13 Failed: Unexpected exception.");
        }

        // Final Test Summary
        Console.WriteLine("\nFinal Test Summary: " + passedTests + " out of " + totalTests + " tests passed.");


        queue q = new queue();
        q.enqueue(10);
        q.enqueue(20);
        q.enqueue(30);
        Console.WriteLine(q.Display() == "10 -> 20 -> 30" ? "Test 14 Passed" : "Failed");
        // בדיקת הפונקציה peek
        Console.WriteLine(q.peek() == 10 ? "Test 15 Passed" : "Failed");

        // בדיקת הפונקציה dequeue
        Console.WriteLine(q.dequeue().getValue() == 10 ? "Passed" : "Failed");
        Console.WriteLine(q.Display() == "20 -> 30" ? "Passed" : "Failed");

        // בדיקת פונקציית getcount
        Console.WriteLine(q.getcount() == 2 ? "Passed" : "Failed");

        // בדיקת dequeue על תור עם פריט אחד
        Console.WriteLine(q.dequeue().getValue() == 20 ? "Passed" : "Failed");
        Console.WriteLine(q.dequeue().getValue() == 30 ? "Passed" : "Failed");

        // בדיקת dequeue על תור ריק
        Console.WriteLine(q.dequeue() == null ? "Passed" : "Failed");

        // בדיקת peek על תור ריק
        Console.WriteLine(q.peek() == -1 ? "Passed" : "Failed");

        // בדיקת שילוב enqueue ו-dequeue
        q.enqueue(40);
        Console.WriteLine(q.peek() == 40 ? "Passed" : "Failed");
        q.enqueue(50);
        Console.WriteLine(q.peek() == 40 ? "Passed" : "Failed");
        Console.WriteLine(q.dequeue().getValue() == 40 ? "Passed" : "Failed");
        Console.WriteLine(q.dequeue().getValue() == 50 ? "Passed" : "Failed");
        Console.WriteLine(q.dequeue() == null ? "Passed" : "Failed");

        Console.ReadLine();

        Stack stack = new Stack();

        // בדיקת הפונקציה push
        stack.push(10);
        stack.push(20);
        stack.push(30);
        Console.WriteLine(stack.peek() == 30 ? "Passed" : "Failed");

        // בדיקת הפונקציה pop
        Console.WriteLine(stack.pop() == 30 ? "Passed" : "Failed");
        Console.WriteLine(stack.pop() == 20 ? "Passed" : "Failed");
        Console.WriteLine(stack.pop() == 10 ? "Passed" : "Failed");

        // בדיקת pop על מחסנית ריקה
        Console.WriteLine(stack.pop() == -1 ? "Passed" : "Failed");

        // בדיקת peek על מחסנית ריקה
        Console.WriteLine(stack.peek() == -1 ? "Passed" : "Failed");

        // בדיקת שילוב push ו-pop
        stack.push(40);
        Console.WriteLine(stack.peek() == 40 ? "Passed" : "Failed");
        stack.push(50);
        Console.WriteLine(stack.peek() == 50 ? "Passed" : "Failed");
        Console.WriteLine(stack.pop() == 50 ? "Passed" : "Failed");
        Console.WriteLine(stack.pop() == 40 ? "Passed" : "Failed");
        Console.WriteLine(stack.pop() == -1 ? "Passed" : "Failed");
        //Console.ReadLine();


      
    }
}