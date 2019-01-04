using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;
using Sorting;
using StacksAndQueues;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary Search
            //BinarySearch bs = new BinarySearch();
            //bs.FindNumber(4);            

            //Sorting implemented with Factory Pattern
            //Sorting();

            //Stacks
            //StackImplementation();

            //Delimiter Check
            //string delimiterString = Console.ReadLine();
            //Check(delimiterString);

            //Queue
            //QueueImplementation();

            //PriorityQueue
            PriorityQueue pq = new PriorityQueue(5);
            pq.Insert(30);
            pq.Insert(50);
            pq.Insert(10);
            pq.Insert(40);
            pq.Insert(20);

            while (!pq.IsEmpty())
            {
                var value = pq.Remove();
                Console.WriteLine($"Value removed is {value} ");
            }

            Console.ReadKey();
        }

        private static void Check(string input)
        {
            Delimiters<char> delimStack = new Delimiters<char>(10);
            for (int i = 0; i < input.Length; i++)
            {
                var ch = input[i];
                switch (ch)
                {
                    case '{':
                    case '[':
                    case '(':
                        delimStack.Push(ch);
                        break;
                    case '}':
                    case ']':
                    case ')':
                        if(!delimStack.IsEmpty())
                        {
                            var cha = delimStack.Pop();
                            if((ch == '}' && cha != '{') || (ch == ']' && cha != '[') || (ch == ')' && cha != '('))
                            {
                                Console.WriteLine($"Error: {ch} at {i}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Error : {ch} at {i}");
                        }
                        break;
                    default:
                        break;
                }
            }
            if(!delimStack.IsEmpty())
            {
                Console.WriteLine($"Missing right delimiter is {delimStack.Peek()}!");
            }
        }

        private static void Sorting()
        {
            int maxSize = 20;
            SortFactory sortFactory = new SortStores().CreateSort("SelectionSort", maxSize);

            sortFactory.Insert(10);
            sortFactory.Insert(13);
            sortFactory.Insert(3);
            sortFactory.Insert(110);
            sortFactory.Insert(23);
            sortFactory.Insert(12);
            sortFactory.Insert(30);
            sortFactory.Insert(33);
            sortFactory.Insert(4);

            sortFactory.Display();
            Console.Write("Selection Sorting Order of Array");
            sortFactory.Sort();
            sortFactory.Display();
        }

        private static void StackImplementation()
        {
            StacksAndQueues.Stack<int> stack = new StacksAndQueues.Stack<int>(10);
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            while (!stack.IsEmpty())
            {
                var value = stack.Pop();
                Console.WriteLine($"Popped value {value}!");
            }

            string input = Console.ReadLine();
            int size = input.Length;
            string reverse = string.Empty;

            ReverseWord<char> rw = new ReverseWord<char>(size);
            Console.WriteLine($"Reversing of string started for {input}!");
            for (int i = 0; i < input.Length; i++)
            {
                var ch = input[i];
                rw.Push(ch);
            }
            while (!rw.IsEmpty())
            {
                reverse += rw.Pop();

            }
            Console.WriteLine($"Reversal of the string is : {reverse}");            
        }

        private static void QueueImplementation()
        {
            QueueX<long> queue = new QueueX<long>(5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Inserting values into Queue {i}!");
                queue.Insert(i);
            }
            

            Console.WriteLine("Removing values From Queue!");
            while (!queue.IsEmpty())
            {
                var value = queue.Remove();
                Console.WriteLine($"Removed value {value}!");
            }
        }
    }
}
