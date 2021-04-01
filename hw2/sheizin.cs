using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void SortArray(int[] arrayToSort)
        {
            Array.Sort(arrayToSort);

            Console.WriteLine("Sorted Array");

            foreach (var item in arrayToSort)
            {
                Console.WriteLine(item);
            }
        }

        static string[] AddElementInTheStartOfArray(string[] oldArray, string newElement)
        {
            string[] newArray = new string[oldArray.Length + 1];
            newArray[0] = newElement;
            Array.Copy(oldArray, 0, newArray, 1, oldArray.Length);

            return newArray;
        }

        static string[] AddElementInTheEndOfArray(string[] oldArray, string newElement)
        {
            string[] newArray = new string[oldArray.Length + 1];
            Array.Copy(oldArray, newArray, oldArray.Length);
            newArray[newArray.Length - 1] = newElement;

            return newArray;
        }

        static string[] AddElementInAnyPositionOfArray(string[] oldArray, string newElement, int position)
        {
            string[] newArray = new string[oldArray.Length + 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < position - 1)
                {
                    newArray[i] = oldArray[i];
                }
                else if (i == position - 1)
                    newArray[i] = newElement;
                else
                    newArray[i] = oldArray[i - 1];
            }

            return newArray;
        }

        static string[] RemoveElementFromStartOfArray(string[] oldArray)
        {
            string[] newArray = oldArray.Skip(1).ToArray();
            return newArray;
        }

        static string[] RemoveElementFromEndOfArray(string[] oldArray)
        {
            Array.Resize(ref oldArray, oldArray.Length - 1);
            return oldArray;
        }

        static string[] RemoveElementFromGivenIndexOfArray(string[] oldArray, int indexToRemove)
        {
            oldArray = oldArray.Where((source, index) => index != indexToRemove - 1).ToArray();
            return oldArray;
        }

        static void checkIfUsernameAndPasswordMatches()
        {
            string adminUserName = "admin";
            string adminPassword = "admin123";
            Console.WriteLine("Enter your username");
            string username = Console.ReadLine().ToLower();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();

            if (username == adminUserName && password == adminPassword)
            {
                Console.WriteLine("Logged In!");
            }
            else
            {
                Console.WriteLine("Wrong username or password");
            }
        }
    }
}
