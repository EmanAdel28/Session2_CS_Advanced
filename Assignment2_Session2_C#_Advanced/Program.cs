using System.Collections;
using System.Xml.Linq;

namespace Assignment2_Session2_C__Advanced
{
    internal class Program
    {
        public static void ReseveElements(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while(queue.Count > 0)
                stack.Push(queue.Dequeue());
        
            
            while (stack.Count > 0)
                queue.Enqueue(stack.Pop());
           

        }
        static void Main(string[] args)
        {

            #region Q1
            //1. Given an array  consists of  numbers with size N and number of queries,
            //in each query you will be given an integer X, and you should print how many
            //numbers in array that is greater than  X.

            // Method 1 => By Using List

            //bool Flags;
            //int Size, NumberOfQuery;

            //do
            //{
            //    Console.WriteLine("Enter Size Of Array");
            //    Flags = int.TryParse(Console.ReadLine(), out Size);

            //} while (!Flags || Size <= 0);

            //do
            //{
            //    Console.WriteLine("Enter Number Of Query");
            //    Flags = int.TryParse(Console.ReadLine(), out NumberOfQuery);

            //} while (!Flags || NumberOfQuery <= 0);

            //List<int> array = new List<int>(Size);

            //// Enter Elements of Array

            //Console.WriteLine("Enter Elements of Array");
            //for (int i = 0; i < Size; i++)
            //{
            //    Console.WriteLine($"Enter Element {i + 1} ");

            //    int elements;
            //    do
            //    {
            //        Flags = int.TryParse(Console.ReadLine(), out elements);

            //    } while (!Flags);
            //    array.Add(elements);
            //}

            //for (int i = 0; i < NumberOfQuery; i++)
            //{
            //    int Number;
            //    int Count = 0;
            //    Console.WriteLine($"Query  {i + 1}");
            //    do
            //    {
            //        Flags = int.TryParse(Console.ReadLine(), out Number);

            //    } while (!Flags);

            //    foreach (int element in array)
            //    {
            //        if (Number < element)
            //        {
            //            Count++;

            //        }
            //    }
            //    Console.WriteLine($"Numbers of elements Greter than {Number} = {Count}");


            //}

            /////////////////////////////////////////////////////////////////////////////////////

            // Method 2 => By Using Array

            //bool Flags;
            //int Size, NumberOfQuery;

            //do
            //{
            //    Console.WriteLine("Enter Size Of Array");
            //    Flags = int.TryParse(Console.ReadLine(), out Size);

            //} while (!Flags || Size <= 0);

            //do
            //{
            //    Console.WriteLine("Enter Number Of Query");
            //    Flags = int.TryParse(Console.ReadLine(), out NumberOfQuery);

            //} while (!Flags || NumberOfQuery <= 0);


            //int[] array = new int[Size];

            //Console.WriteLine("Enter Elements of Array");
            //for (int i = 0; i < Size; i++)
            //{
            //    Console.WriteLine($"Enter Element {i + 1} ");

            //    int elements;
            //    do
            //    {
            //        Flags = int.TryParse(Console.ReadLine(), out elements);

            //    } while (!Flags);
            //    array[i] = elements;
            //}

            //for (int i = 0; i < NumberOfQuery; i++)
            //{
            //    int Number;
            //    int Count = 0;
            //    Console.WriteLine($"Query  {i + 1}");
            //    do
            //    {
            //        Flags = int.TryParse(Console.ReadLine(), out Number);

            //    } while (!Flags);

            //    foreach (int element in array)
            //    {
            //        if (Number < element)
            //        {
            //            Count++;

            //        }
            //    }
            //    Console.WriteLine($"Numbers of elements Greter than {Number} = {Count}");


            //}
            #endregion

            #region Q2
            //2. Given a number N and an array of N numbers. Determine if it's palindrome or not.
            //int N;
            //bool Flags;
            //bool Palindrome = true;

            //do
            //{
            //    Console.WriteLine("Enter The Size Of Array");
            //    Flags = int.TryParse(Console.ReadLine(), out N);
            //}while (!Flags || N <= 0);

            //int[] array = new int[N];

            //Console.WriteLine("Enter Elements of Array");
            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine($"Enter Element {i + 1} ");

            //    int elements;
            //    do
            //    {
            //        Flags = int.TryParse(Console.ReadLine(), out elements);

            //    } while (!Flags);
            //    array[i] = elements;
            //}

            //for ( int i = 0; i< N; i++)
            //{
            //    if (array[i] != array[N - i - 1])
            //    {
            //        Palindrome = false;
            //        break;
            //    }

            //}

            //if(Palindrome)
            //{
            //    Console.WriteLine("Array is Palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("Array is Not Palindrome");

            //}


            #endregion

            #region Q3
            //3. Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //Console.WriteLine("Queue Before Reseved");
            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}

            //ReseveElements(queue);
            //Console.WriteLine("Queue After Reseved");

            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

        }
    }
    }

