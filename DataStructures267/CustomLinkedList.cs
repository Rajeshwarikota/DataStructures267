using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures267
{
    internal class CustomLinkedList<T>
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> newnode = new Node<T>(data);
            if (head == null)
            {
                head = newnode;
                Console.WriteLine("{0} inserted into the LinkedList", head.data);
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
                Console.WriteLine("{0} inserted into Linked List", newnode.data);
            }
        }
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} inserted into the LinkedList", newNode.data);
        }
        public void AddLast(T data)
        {
            Node<T> newnode = new Node<T>(data);
            if (head == null)
            {
                head = newnode;
                Console.WriteLine("{0} inserted into the LinkedList", head.data);
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
                Console.WriteLine("{0} inserted into Linked List", newnode.data);
            }
        }
        public void RemoveFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                Console.WriteLine("{0} is removed from the list", head.data);
                head = head.next;
            }
        }
        public void RemoveLast()
        {
            Node<T> temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
            }
            else if (temp.next == null)
            {
                T data = temp.data;
                temp = null;
                head = temp;
                Console.WriteLine("{0}  node is removed", data);
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                T lastDeleteNode = temp.next.data;
                temp.next = null;
                Console.WriteLine("{0} node is removed from the list", lastDeleteNode);

            }
        }
        public void Search(T data)
        {
            Node<T> temp = head;
            int count = 0;
            bool isFound = false;

            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                while (temp != null)
                {
                    count++;
                    if (temp.data.Equals(data))
                    {
                        Console.WriteLine("\n{0} is found at position {1}", data, count);
                        isFound = true;
                        break;
                    }
                    temp = temp.next;
                }
                if (!isFound)
                    Console.WriteLine("\n{0} is not found ", data);
            }
        }
        public void Size()
        {
            Node<T> temp = head;
            int count = 0;
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            else
            {
                while (temp != null)
                {
                    count++;
                    if (temp.next == null)
                    {
                        break;
                    }
                    temp = temp.next;
                }
                Console.WriteLine("The Size of the Linked List is {0}", count);
            }
        }
        public void InsertAtAnyPoint(T data, T data2)
        {
            Node<T> newNode = new Node<T>(data);
            Node<T> temp = head;
            bool isFound = false;

            while (temp != null)
            {
                if (temp.data.Equals(data2))
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                    isFound = true;
                    break;
                }
                else
                {
                    temp = temp.next;
                }
            }

            if (!isFound)
            {
                // Handle case where data2 is not found in the list
                throw new Exception("data2 not found in the list.");
            }
        }
        public void Display()
            {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            Node<T> temp = this.head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
