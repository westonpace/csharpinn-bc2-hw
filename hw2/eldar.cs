using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroToHeroHW2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayManipulation();

            UserLogin();

            Console.ReadLine();
        }

        static void ArrayManipulation()
        {
            //Initializes the numbers
            int[] numberRange = { 6, 5, 1, 4, 2, 3 };
            Console.WriteLine(string.Join(",", numberRange));

            //Sorts the numbers
            Array.Sort(numberRange);
            Console.WriteLine(string.Join(",", numberRange));

            //Prepends a number
            int[] preAddedNumbers = new int[numberRange.Length + 1];
            preAddedNumbers = Prepend(numberRange, 0);
            Console.WriteLine(string.Join(",", preAddedNumbers));

            //Removes at the start
            int[] removedStart = new int[preAddedNumbers.Length - 1];
            removedStart = RemoveAtIndex(preAddedNumbers, 0);
            Console.WriteLine(string.Join(",", removedStart));

            //Removes at the end
            int[] removedEnd = new int[preAddedNumbers.Length - 1];
            removedEnd = RemoveAtIndex(preAddedNumbers, preAddedNumbers.Length);
            Console.WriteLine(string.Join(",", removedEnd));

            //Removes at the end
            int[] removedMiddle = new int[preAddedNumbers.Length - 1];
            removedMiddle = RemoveAtIndex(preAddedNumbers, 4);
            Console.WriteLine(string.Join(",", removedMiddle));
        }

        static void UserLogin()
        {
            string username;
            string password;
            Console.WriteLine("Please enter your username:");
            username = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            password = Console.ReadLine();

            CheckPasswordMatch(username, password);
        }

        static void CheckPasswordMatch(string inputUsername, string inputPassword)
        {
            string[] usernames = {"Eldar", "ManMcMan, Dude" };
            string[] passwords = { "YoghurtKing1234", "Password", "SuperSecurityPassword111" };

            for (int i = 0; i < usernames.Length; i++)
            {
                if (inputUsername.ToUpper() ==  usernames[i].ToUpper() && inputPassword == passwords[i])
                {
                    Console.WriteLine("Logged In!");
                    return;
                }
            }
            Console.WriteLine("Sorry you do not have an account here.");
            return;
        }

        static int[] Prepend(int[] inputNumbers, int AddedValue)
        {
            int[] result = new int[inputNumbers.Length + 1];
            for (int i = 1; i < result.Length; i++)
            {
                result[i] = inputNumbers[i - 1];
            }
            result[0] = AddedValue;
            return result;
        }

        static int[] RemoveAtIndex(int[] inputNumbers, int removedIndex)
        {
            int[] result = new int[inputNumbers.Length - 1];
            for (int i = 0; i < result.Length; i++)
            {
                // Jumps up one index to skip the number in question
                if (i >= removedIndex)
                {
                    result[i] = inputNumbers[i + 1];
                    continue;
                }
                // Copies the numbers until it hits the removed index
                result[i] = inputNumbers[i];
            }
            return result;
        }
    }
}
