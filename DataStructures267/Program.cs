using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures267
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Data structures....");
            CustomLinkedList<double> list = new CustomLinkedList<double>();
            {
                Console.WriteLine("\n1.Add Elements into LinkedList \n2.AddFirst \n3.AddLast \n4.RemoveFirst \n5.Removelast \n6.search \n7.size \n8:Insert at any point\n22.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        list.Add(56.4);
                        list.Add(30.4);
                        list.Add(70.6);
                        list.Display();
                        break;
                    case 2:
                        list.AddFirst(70.5);
                        list.AddFirst(30.6);
                        list.AddFirst(56.8);
                        list.AddFirst(67.0);
                        list.Display();
                        break;
                    case 3:
                        list.AddLast(70.5);
                        list.AddLast(30.6);
                        list.AddLast(56.8);
                        list.AddLast(58.1);
                        list.Display();
                        break;
                    case 4:
                        list.Add(70.5);
                        list.Add(30.6);
                        list.Add(56.8);
                        list.Add(58.1);
                        list.RemoveFirst();
                        list.Display();
                        break;
                    case 5:
                        list.Add(70.5);
                        list.Add(30.6);
                        list.Add(56.8);
                        list.Add(58.1);
                        list.RemoveLast();
                        list.Display();
                        break;
                    case 6:
                        list.Add(70.5);
                        list.Add(30.6);
                        list.Add(56.8);
                        list.Add(58.1);
                        list.Search(70.5);
                        list.Display();
                        break;
                    case 7:
                        list.Add(70.5);
                        list.Add(30.6);
                        list.Add(56.8);
                        list.Add(58.1);
                        list.Size();
                        list.Display();
                        break;
                    case 8:
                        list.Add(70.5);
                        list.Add(30.6);
                        list.Add(56.8);
                        list.Add(58.1);
                        list.InsertAtAnyPoint(70.5,58.1);
                        list.Display();
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
