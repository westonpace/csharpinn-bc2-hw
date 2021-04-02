using System;

namespace CSINNHMW2
{
    class Program
    {
        static void Main(string[] args)
        {
            login("Admin", "12345");

            SortArray(new int[] { 3, 4, 2, 6, 0, 5, 1, 8, 9, 7 });

            addToStart("F", new string[] { "A", "B", "C" });
            addToEnd("F", new string[] { "A", "B", "C" });
            insertAt("F", 2, new string[] { "A", "B", "C" });

            deleteFirst(new string[] { "a", "b", "c" });
            deleteLast(new string[] { "a", "b", "c" });
            deleteAtIndex(3, new string[] { "a", "b", "c" });
        }

        static void SortArray(int[] array)
        {
            int temp;

            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[i - 1])
                    {
                        temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                    }
                }
            }
            Console.WriteLine("New values of array are (SORT);");
            foreach (var item in array)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        static void addToStart(string item, string[] array)
        {
            string[] arr1 = array;
            string[] arr2 = new string[arr1.Length + 1];
            arr2[0] = item;
            for (int i = 1; i < arr1.Length + 1; i++)
            {
                arr2[i] = arr1[i - 1];
            }

            Console.WriteLine("New values of array are (START);");
            foreach (var items in arr2)
            {
                Console.WriteLine(items + ",");
            }
        }

        static void addToEnd(string item, string[] array)
        {
            string[] arr1 = array;
            string[] arr2 = new string[arr1.Length + 1];

            Array.Copy(arr1, arr2, arr1.Length);
            arr2[arr2.Length - 1] = item;

            Console.WriteLine("New values of array are (END);");
            foreach (var items in arr2)
            {
                Console.WriteLine(items + ",");
            }
        }

        static void insertAt(string item, int Index, string[] array)
        {
            string[] arr1 = array;
            string[] arr2 = new string[arr1.Length + 1];

            for (int i = 0; i < Index - 1; i++)
            {
                arr2[i] = arr1[i];
            }
            arr2[Index - 1] = item;
            int remaining = arr2.Length - (Index);
            for (int i = 0; i < remaining; i++)
            {
                arr2[i + Index] = arr1[i + (Index - 1)];
            }

            Console.WriteLine("New values of array are (ANY POSITION);");
            foreach (var items in arr2)
            {
                Console.WriteLine(items + ",");
            }
        }

        static void deleteFirst(string[] array)
        {
            string[] arr2 = new string[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                arr2[i] = array[i + 1];
            }
            Console.WriteLine("New values of array are (DELETE FIRST);");
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }

        static void deleteLast(string[] array)
        {
            string[] arr2 = new string[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                arr2[i] = array[i];
            }
            Console.WriteLine("New values of array are (DELETE LAST);");
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }

        static void deleteAtIndex(int index, string[] array)
        {
            string[] arr2 = new string[array.Length - 1];

            for (int i = 0; i < index - 1; i++)
            {
                arr2[i] = array[i];
            }
            int remaining = arr2.Length - index;
            for (int i = 0; i < remaining + 1; i++)
            {
                arr2[index - 1] = array[index];
                index++;
            }

            Console.WriteLine("New values of array are (DELETE AT INDEX);");
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
        }

        static void login(string userName, string password)
        {
            string _userNameL = "admin";
            string _userNameC = "Admin";
            bool letGo = _userNameC == userName || _userNameL == userName;

            //bool username = _userName.Equals(userName, StringComparison.OrdinalIgnoreCase); // i am not sure!!!

            string _password = "12345";
            if (letGo && _password == password)
            {
                Console.WriteLine("Logged in!");
            }
            else
            {
                Console.WriteLine($"Just hold your horses, {userName}! and think about your Username and Password!.");
            }
        }
    }
}
