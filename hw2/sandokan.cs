using System;

namespace Homework_2
{
    class Program
    {
        static string[] username = { "Vankata", "Bruda" };
        static string[] password = { "Azsymivan1", "bisH" };
        static void Main(string[] args)
        {
            int[] A = { 20, 30, 40, 798 };
            SortArray(A);
            AddElementAtStart(756324, A);
            AddElementAtEnd(756324, A);
            AddElementAtGivenIndexMyWay(1, A, 4);
            RemoveElementAtStart(A);
            RemoveElementAtEnd(A);
            RemoveElementAtGivenIndex(A, 0);
            string username = Console.ReadLine(); 
            string password = Console.ReadLine();
            Login(username, password);
        }
        static int[] SortArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);
            // Sorting an array
            for (int i = 0; i < newArray.Length; i++)
            {
                // Sort one element of an array
                for (int index = 0; index < newArray.Length - 1; index++)
                {
                    if (newArray[index] < newArray[index + 1])
                    {
                        int a = newArray[index];
                        newArray[index] = newArray[index + 1];
                        newArray[index + 1] = a;
                    }
                }
            }
            PrintArray(newArray);
            return newArray;
        }
        static int[] AddElementAtStart(int element, int[] array)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[0] = element;

            for (int index = 0; index < array.Length; index++)
            {
                newArray[index + 1] = array[index];
            }
            PrintArray(newArray);
            return newArray;
        }
        static int[] AddElementAtEnd(int element, int[] array)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[array.Length] = element;

            for (int index = 0; index < array.Length; index++)
            {
                newArray[index] = array[index];
            }
            PrintArray(newArray);
            return newArray;
        }
        static int[] AddElementAtGivenIndexMyWay(int element, int[] array, int j)
        {
            int[] newArray = new int[array.Length + 1];
            for (int index = 0; index < array.Length; index++)
            {
                newArray[index] = array[index];
            }
            for (int index = j; index < newArray.Length; index++)
            {
                int a = newArray[index];
                newArray[index] = element;
                element = a;// took me 
                j = j + 1;// 2 hours 
            }
            PrintArray(newArray);
            return newArray;
        }
        static int[] RemoveElementAtStart(int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            for (int index = 1; index < array.Length; index++)
            {
                newArray[index - 1] = array[index];
            }
            PrintArray(newArray);
            return newArray;
        }
        static int[] RemoveElementAtEnd(int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            for (int index = 0; index < array.Length - 1; index++)
            {
                newArray[index] = array[index];
            }
            PrintArray(newArray);
            return newArray;
        }
        static int[] RemoveElementAtGivenIndex(int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }
            PrintArray(newArray);
            return newArray;
        }
        static void PrintArray(int[] array)
        {
            Console.Write($"[{array[0]}");
            for (int i = 1; i < array.Length - 1; i++)
            {
                Console.Write($",{array[i]}");
            }
            Console.Write($",{array[array.Length - 1]}]\n");
        }
        static void Login(string textUsername, string textPassword)
        {
            for (int index = 0; index < username.Length; index++)
            {
                if(username[index].Equals(textUsername, StringComparison.OrdinalIgnoreCase)&& password[index].Equals(textPassword))
                {
                    Console.WriteLine( "Logged in");
                }
            }
        }
    }
}
  
