using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures267
{
    internal class SortingInDescending
    {
        public static void Descending()
        {
            // Create a new LinkedList
            LinkedList<int> myList = new LinkedList<int>();

            // Add some values to the list
            myList.AddLast(45);
            myList.AddLast(37);
            myList.AddLast(12);

            // Create a new node to hold the value to insert
            LinkedListNode<int> newNode = new LinkedListNode<int>(40);

            // Traverse the list until you find the correct position to insert the new node
            LinkedListNode<int> currentNode = myList.First;
            while (currentNode != null && currentNode.Value > newNode.Value)
            {
                currentNode = currentNode.Next;
            }

            // Insert the new node at the correct position
            if (currentNode == null)
            {
                myList.AddLast(newNode);
            }
            else
            {
                myList.AddBefore(currentNode, newNode);
            }

            // Print the updated list
            Console.WriteLine("Elements in the list (in descending order):");
            foreach (int element in myList)
            {
                Console.WriteLine(element);
            }

        }
    }
}
