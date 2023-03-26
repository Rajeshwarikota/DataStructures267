using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures267
{
    internal class BuiltInStack
    {
        public static void CRUDOperation()
        {
            // Create a new stack
            Stack<int> myStack = new Stack<int>();

            // Add some elements to the stack
            myStack.Push(45);
            myStack.Push(67);
            myStack.Push(39);

            // Print the names in the list
            Console.WriteLine("Number in the list are:");
            foreach (int numbers in myStack)
            {
                Console.WriteLine(numbers);
            }

            // Read the top element of the stack without removing it
            int topElement = myStack.Peek();
            Console.WriteLine("The top element of the stack is " + topElement);

            // Remove the top element of the stack
            int removedElement = myStack.Pop();
            Console.WriteLine("\nThe removing element from the stack is " + removedElement);

            // Print the after removing list
            Console.WriteLine("List After Removing the list is:");
            foreach (int numbers in myStack)
            {
                Console.WriteLine(numbers);
            }

            // Update the top element of the stack
            myStack.Push(49);
            int updatedTopElement = myStack.Peek();
            Console.WriteLine("\nThe updating top element of the stack is " + updatedTopElement);

            // Print the updated list
            Console.WriteLine("List After Updating the list is:");
            foreach (int numbers in myStack)
            {
                Console.WriteLine(numbers);
            }

            // Delete all elements from the stack
            myStack.Clear();
            Console.WriteLine("The number of elements in the stack after clearing is " + myStack.Count);
        }
    }
}