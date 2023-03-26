using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures267
{
    internal class BuiltInQue
    {
        public static void CRUDOperation()
        {
                // Create a new queue
                Queue<double> myQueue = new Queue<double>();

                // Add some elements to the queue
                myQueue.Enqueue(34.6);
                myQueue.Enqueue(45.7);
                myQueue.Enqueue(23.5);

                // Print the elements in the queue
                Console.WriteLine("Elements in the queue:");
                foreach (double element in myQueue)
                {
                    Console.WriteLine(element);
                }

                // Update the second element to 78.4
                double[] queueArray = myQueue.ToArray();
                queueArray[1] = 78.4;
                myQueue = new Queue<double>(queueArray);

                // Print the updated elements in the queue
                Console.WriteLine("\nElements in the queue after updating the second element:");
                foreach (double element in myQueue)
                {
                    Console.WriteLine(element);
                }

                // Remove the first element from the queue
                double removedElement = myQueue.Dequeue();

                // Print the removed element and the remaining elements in the queue
                Console.WriteLine("\nRemoved element: {0}", removedElement);
                Console.WriteLine("Elements in the queue after removing the first element:");
                foreach (double element in myQueue)
                {
                    Console.WriteLine(element);
                }

                // Find the element 30.6 in the queue
                bool  isFound = myQueue.Contains(30.6);

                // Print whether the element 30.6 is found in the queue or not
                if (isFound)
                {
                   Console.WriteLine("\nElement 30.6 is found in the queue.");
                }
                else
                {
                   Console.WriteLine("\nElement 30.6 is not found in the queue.");
                }

                // Clear all elements from the queue
                 myQueue.Clear();

               // Print whether the queue is empty or not
               if (myQueue.Count == 0)
               {
                  Console.WriteLine("\nQueue is empty.");
               }
               else
               {
                  Console.WriteLine("\nQueue is not empty.");
               }
        }
    }

}

