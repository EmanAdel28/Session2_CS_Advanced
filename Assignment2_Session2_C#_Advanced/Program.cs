using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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

        public static bool IsMatchingPair(char c1, char c2)
        {
            return (c1 == '(' && c2==')')||
                   (c1 == '{' && c2=='}')||
                   (c1 == '[' && c2 == ']');
        }

        public static bool IsBalanced(string input)
        {
            bool Balanced = true;
            Stack<char> stack = new Stack<char>();
            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                    stack.Push(ch);

                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char top = stack.Pop();

                        if (!IsMatchingPair(top, ch))
                        {
                            return false;

                        }
                    }
                }
            }
            return stack.Count == 0;
        }

        public static  int[] RemoveDuplication(int[]array)
        {
           List<int> list = new List<int>();
            

            foreach (int element in array)
            {
                if (!list.Contains(element))
                    list.Add(element);
            }
            return list.ToArray();
        }

        public static ArrayList RemoveOddNumber(ArrayList arraylist)
        {
           for(int i = 0;i<arraylist.Count; i++)
            {
                if ((int)arraylist[i] % 2 != 0)
                    arraylist.RemoveAt(i);
            }
            return arraylist;   
        }

        public static void SearchForATargetIntegerInTheStack(Stack<int> stack, int target)
        {

            

            Stack<int> stack2 = new Stack<int>(stack);
            bool FoundTarget = true;
            int count = 0;



            while (stack2.Count > 0)
            {
                count++;
                int current = stack2.Pop(); // Remove the top element of the stack

                if (current == target)
                {
                    FoundTarget = true;
                    break;
                }
            }


            if (FoundTarget)
            Console.WriteLine($"Target was found successfully and the count = {count}");
            
            else
                Console.WriteLine("Target was not found");

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

            #region Q4
            //4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //string input = Console.ReadLine();
            //bool isBalanced = IsBalanced(input);
            //Console.WriteLine(isBalanced ? "Balanced" : "Unbalanced");

            #endregion

            #region Q5
            //5. Given an array, implement a function to remove duplicate elements from an array.

            //bool Flags;
            //int Size ;

            //do
            //{
            //    Console.WriteLine("Enter Size Of Array");
            //    Flags = int.TryParse(Console.ReadLine(), out Size);

            //} while (!Flags || Size <= 0);



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
            //int[] uniqueArray = RemoveDuplication(array);
            //Console.WriteLine("Array After Removing Dublication");
            //foreach (int element in uniqueArray)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion

            #region Q6
            //6. Given an array list , implement a function to remove all odd numbers from it.
            //bool Flags;
            //int Size;

            //do
            //{
            //    Console.WriteLine("Enter Size Of Array");
            //    Flags = int.TryParse(Console.ReadLine(), out Size);

            //} while (!Flags || Size <= 0);



            //ArrayList array = new ArrayList(Size);

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

            //RemoveOddNumber(array);

            //Console.WriteLine("Array Whihout Odd Numbers");
            //foreach (int element in array)
            //{
            //    Console.WriteLine(element);
            //}
            #endregion

            #region Q7
            //7. Implement a queue that can hold different data types. And insert the following data:
            //queue.Enqueue(1)
            //queue.Enqueue(“Apple”)
            //queue.Enqueue(5.28)

            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            #endregion

            #region Q8
            //Create a function that pushes a series of integers onto a stack.
            //Then, search for a target integer in the stack. If the target is found,
            //print a message indicating that the target was found how many elements
            //were checked before finding the target (“Target was found successfully and the count = 5”).
            //If the target is not found, print a message indicating that the target was not found(“Target was not found”).

            //Stack<int> stack = new Stack<int>();
            //stack.Push(0);
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //bool Flags;
            //int target;
            //do
            //{
            //    Console.WriteLine("Enter Number");
            //    Flags = int.TryParse(Console.ReadLine(), out target);

            //} while (!Flags);

            //SearchForATargetIntegerInTheStack(stack , target);
            #endregion

        }
    }
    }

