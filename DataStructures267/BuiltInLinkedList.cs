using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures267
{
     class BuiltInLinkedList
    {
        public void CRUDOperations()
        {
            // Create a new linked list of Strings
            LinkedList<string> myList = new LinkedList<string>();

            // Add some names first to the list
            myList.AddFirst("Raji");
            myList.AddFirst("Ammu");
            myList.AddFirst("neethu");


            // Add some names last to the list
            myList.AddLast("sailu");

            // Print the names in the list
            Console.WriteLine("Names in the list are:");
            foreach (string names in myList)
            {
                Console.WriteLine(names);
            }

            // Update the second name to "Asifa"
            LinkedListNode<string> node = myList.First.Next;
            node.Value = "Asifa";

            // Print the updated list
            Console.WriteLine("\nList After Updating Second Name:");
            foreach (string names in myList)
            {
                Console.WriteLine(names);
            }

            // Find the node with value "neethu"
            LinkedListNode<string> name = myList.Find("neethu");

            // Insert a new name with name "sai" after the "neethu" name
            myList.AddAfter(name, "sai");

            // Print the updated list
            Console.WriteLine("\nList After Adding Name:");
            foreach (string names in myList)
            {
                Console.WriteLine(names);
            }

            // Remove the last name from the list
            myList.RemoveLast();

            // Print the updated list
            Console.WriteLine("\nList After Removing Last Name:");
            foreach (string names in myList)
            {
                Console.WriteLine(names);
            }
        }
    }
}

