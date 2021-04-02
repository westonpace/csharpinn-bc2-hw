using System;

namespace SecondHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginUser();
        }

        static void LoginUser()
        {
            string continueTrying = "yes";

            while (UserWantsToContinue(continueTrying))
            {
                string username = PromptInput("What's your username:");
                string password = PromptInput("What's your password");

                if (IsCorrectLoginInformation(username, password))
                {
                    Console.WriteLine("Logged in!");
                    break;
                }
                else continueTrying = PromptInput("Wrong username or password! If you want to exit write: exit, else write anything");
            }
        }

        static bool UserWantsToContinue(string continueTrying)
        {
            return (continueTrying != "exit");
        }

        static string PromptInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        static bool IsCorrectLoginInformation(string username, string password)
        {
            string realUsername = "ZuVIs";
            string realPassword = "AzT2";

            return (realUsername.Equals(username, StringComparison.OrdinalIgnoreCase) && realPassword == password);
        }

        static void SortInDescendingOrder(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        static int[] AddElementAtStart(int[] array, int elementToAdd)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[0] = elementToAdd;
            Array.Copy(array, 0, newArray, 1, array.Length);

            return newArray;
        }

        static int[] AddElementAtEnd(int[] array, int elementToAdd)
        {
            int[] newArray = new int[array.Length + 1];
            Array.Copy(array, newArray, array.Length);
            newArray[newArray.Length - 1] = elementToAdd;

            return newArray;
        }

        static int[] AddElementAtIndex(int[] array, int elementToAdd, int index)
        {
            int[] newArray = new int[array.Length + 1];

            // Copy oldArray to new one till index
            Array.Copy(array, newArray, index);

            // Add selected index element to newArray.
            newArray[index] = elementToAdd;

            // Copy from index element till the end.
            Array.Copy(array, index, newArray, index + 1, array.Length - index);

            return newArray;
        }

        static int[] RemoveElementAtStart(int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            Array.Copy(array, 1, newArray, 0, array.Length - 1);

            return newArray;
        }

        static int[] RemoveElementAtEnd(int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            Array.Copy(array, newArray, array.Length - 1);

            return newArray;
        }

        static int[] RemoveElementAtIndex(int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            // Copy oldArray to the new one till we reach index
            Array.Copy(array, newArray, index);

            // Skip element we want to remove and copy from position: index + 1
            Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);

            return newArray;
        }
    }
}