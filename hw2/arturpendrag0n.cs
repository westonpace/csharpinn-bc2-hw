using System;
namespace BCHomeWork2
{
    class Program
    {
        /*
         *   Sort an array
         *   Add element at the start of an array
         *   Add element at the end of an array
         *   Add element at any position of an array
         *   Remove element at the start of an array
         *   Remove element at the end of an array
         *   Remove element at a given index of an array
         *   Login: takes username and password. 
         *       If they match a hidden username and password- a message "Logged in!" is printed. 
         *       Username capitalization does not matter, password capitalization must match.
         */

        static string[] names = {"name1", "grEg", "toOdo", "MasterChief" };
        static string[] passwords = {"hehe123","gReG", "NeverGonnaGiveYouUp","C0R74n4"};


        static void Main(string[] args)
        {
            int[] nonSortedArray = {6,5,4,3,11,12,13,7,1,2,9,8};
               int[] sortedArrayASC = SortAscending(nonSortedArray);
               int[] sortedArrayDESC = SortDescending(nonSortedArray);
               int[] array1 = addAtBeginning(nonSortedArray, 123);
               int[] array2 = addAtEnd(nonSortedArray, 321);
               int[] array3 = addAtAny(nonSortedArray,213,3);
               int[] removeAtStart = removeFirstElement(nonSortedArray);
               int[] removeAtEnd = removeLastElement(nonSortedArray);
               int[] removeAny = removeAnyElement(nonSortedArray,5);

               Console.Write("Un-sorted array\t\t\t\t");
               PrintArray(nonSortedArray);
               Console.Write("sorted array (Ascending)\t\t");
               PrintArray(sortedArrayASC);
               Console.Write("sorted array (Descending)\t\t");
               PrintArray(sortedArrayDESC);
               Console.Write("Added 123 at the start\t\t\t");
               PrintArray(array1);
               Console.Write("added 321 at the end\t\t\t");
               PrintArray(array2);
               Console.Write("added 213 at position 3\t\t\t");
               PrintArray(array3);
               Console.Write("Removed element at start\t\t");
               PrintArray(removeAtStart);
               Console.Write("removed element at end\t\t\t");
               PrintArray(removeAtEnd);
               Console.Write("removed element at position 5\t\t");
               PrintArray(removeAny);

               LogIn("MasTErchief", "C0R74n4");           

        }
        static void PrintArray(int[] array)
        {
            Console.Write($"[{array[0]}");
            for (int i=1;i<array.Length-1;i++)
            {
                Console.Write($",{array[i]}");
            }
            Console.Write($",{array[array.Length-1]}]\n");
        }
        static int[] SortAscending (int[] sourceArray)
        {
            int[] array = returnArrayCopy(sourceArray);
            int temp;
            for (int i = 0; i < array.Length; i++) 
            {
                for(int j = 0; j<array.Length-1; j++)
                {
                    if (array[j]>array[j+1])
                    {
                        //we store the lesser number in temp
                        temp = array[j + 1]; 
                        //we swap the places of the two numbers
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        static int[] SortDescending(int[] sourceArray)
        {
            int[] array = returnArrayCopy(sourceArray);
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        //we store the bigger number in temp
                        temp = array[j + 1];
                        //we swap the places of the two numbers
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        static int[] returnArrayCopy(int[] sourceArray) 
        {
            int[] array = new int[sourceArray.Length];
            Array.Copy(sourceArray, array, sourceArray.Length);
            return array;
        }
        static int[] addAtEnd(int[] array, int element)
        {
            int[] expandedArray = new int[array.Length+1];
            for(int i = 0; i < array.Length; i++)
            {
                expandedArray[i] = array[i];
            }
            expandedArray[array.Length] = element;
            return expandedArray;
        }
        static int[] addAtBeginning(int[] array,int element)
        {
            int[] expandedArray = new int[array.Length + 1];
            expandedArray[0] = element;
            for (int i = 0; i < array.Length; i++)
            {
                expandedArray[i+1] = array[i];
            }
            return expandedArray;
        }
        static int[] addAtAny(int[] array, int element,int position)
        {
            if (position < 0 || position > array.Length)
            {
                Console.WriteLine($"This position is out of the array's bounds please choose between {0} and {array.Length}");
                return array;
            }
            int[] expandedArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (i == position) continue;
                expandedArray[i] = array[i];
            }
            expandedArray[position] = element;

            return expandedArray;
        }
        static int[] removeLastElement(int[] array)
        {
            int[] reducedArray = new int[array.Length - 1];
            for (int i = 0; i < reducedArray.Length; i++)
            {
                reducedArray[i] = array[i];
            }
            return reducedArray;
        }
        static int[] removeFirstElement(int[] array)
        {
            int[] reducedArray = new int[array.Length - 1];
            for (int i = 0; i < reducedArray.Length; i++)
            {
                reducedArray[i] = array[i+1];
            }
            return reducedArray;
        }
        static int[] removeAnyElement(int[] array, int position)
        {
            if (position < 0 || position > array.Length)
            {
                Console.WriteLine($"This position is out of the array's bounds please choose between {0} and {array.Length}");
                return array;
            }
            int[] reducedArray = new int[array.Length - 1];

            for (int i = 0; i <= position; i++)
            {             
                reducedArray[i] = array[i];
            }

            for(int i = position; i < reducedArray.Length; i++)
            {
                reducedArray[i] = array[i+1];
            }
            return reducedArray;
        }

        static void LogIn(string username,string password)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username)) return;

            for (int i = 0;i < names.Length;i++)
            {
                if(username.Equals(names[i],StringComparison.OrdinalIgnoreCase) && password.Equals(passwords[i]))
                {
                    Console.WriteLine("Logged in!");
                }
            }
        }
    }
}
