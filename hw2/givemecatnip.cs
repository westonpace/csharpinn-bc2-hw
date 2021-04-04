using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHomework();
        }
        //Sorting
        static int[] SortArray(int[] array) {
            int temp;
            for(int i = 0; i < array.Length; i++) {
                Console.Write("Sorting the array by descending: ");
                PrintArray(array);
                int flag = 0; // removes pointless iterations
                for (int g = 0; g < array.Length - 1; g++)
                {
                    // sort by decending  array[g] < array[g + 1] 
                    // sort by ascending array[g] > array[g + 1]
                    if (array[g] < array[g + 1])
                    {
                        flag++;
                        temp = array[g];
                        array[g] = array[g + 1];
                        array[g + 1] = temp;
                    }
                }
                if (flag == 0) break;
            }
            return array;
        }
        // Print element by element between []
        static void PrintArray(int[] array) {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                if (i != 0) Console.Write($",{array[i]}");
                else Console.Write($"{array[i]}");
            }
            Console.Write("] \n");
        }

        static int[] AddArrayStart(int[] array, int element) {
            //adds an element at the start of the array

            int[] newArray = new int[array.Length + 1];
            Array.ConstrainedCopy(array,0, newArray,1, array.Length);
            newArray[0] = element;
            return newArray;
        }

        static int[] AddArrayEnd(int[] array, int element) {
            //adds an element at the end of the array
            int[] newArray = new int[array.Length + 1];
            Array.Copy(array, newArray, array.Length);
            newArray[newArray.Length - 1] = 200;

            return newArray;
        }
        static int[] RemoveStartArray(int[] array) {
            int[] newArray = new int[array.Length - 1];
            Array.ConstrainedCopy(array, 1, newArray, 0, array.Length-1);
            return newArray;
        }

        static int[] RemoveEndArray(int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            Array.Copy(array, newArray, array.Length - 1);
            return newArray;
        }

        static int[] RemoveACertainArray(int[] array,int index)
        {
            if (index > array.Length || index < 0) return array;
            int[] newArray = new int[array.Length - 1];
            Array.ConstrainedCopy(array, 0, newArray, 0, index);
            Array.ConstrainedCopy(array, index + 1, newArray, index, newArray.Length - index);
            return newArray;
        }
        static void Validate(string password, string passwordcheck, string username,string usernamematch) {
            if (username.Equals(usernamematch, StringComparison.OrdinalIgnoreCase) & password.Equals(passwordcheck)) {
                Console.WriteLine("You have successfully logged in ");
            }
        }

        static void PrintHomework() {
            int[] array = { 1, 2, 3, 4, 5 };
            string password = "123456";
            string passwordcheck = "123456";
            string username = "ABCD";
            string usernamematch = "abcd";

            //validating if this is the person logging in
            Console.Write("Chechking if the criteria is right: ");
            Validate(password, passwordcheck, username, usernamematch);

            //Sorting array
            SortArray(array);

            //Adding a number at the start of the array
            int[] addStart = AddArrayStart(array, 20);
            Console.Write("Adding the number 20 at the start of the array: ");
            PrintArray(addStart);

            int[] addEnd = AddArrayEnd(array, 20);
            Console.Write("Adding a number at the end of the array: ");
            PrintArray(addEnd);

            int[] removeEnd = RemoveEndArray(array);
            Console.Write("Removing the ending number: ");
            PrintArray(removeEnd);

            int[] removeStart = RemoveStartArray(array);
            Console.Write("Removing the starting number: ");
            PrintArray(removeStart);

            int[] removeAny = RemoveACertainArray(array, 3);
            Console.Write("Removing the number 3 from the array: ");
            PrintArray(removeAny);
        }
    }
}
