//29 centai homework2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] UsernameDatabase = { "Tom123", "PewDiePie", "ElonMusky420", "null" };
            string[] PasswordDatabase = { "123456789", "321moT", "Tesla*21", "void6547" };
            bool UserWantsToContinue = true;
            while (UserWantsToContinue)
            {
                string username = PromptInput("Username: ");
                string password = PromptInput("Password: ");
                string message = LoginUser(UsernameDatabase, PasswordDatabase, username, password);

                Console.WriteLine(message);
                UserWantsToContinue = DoesUserWantsToContinueProgram();
            }

        }
        public static bool DoesUserWantsToContinueProgram()
        {
            string usersinput = PromptInput("Continue? y/n");
            if (usersinput == "n") return false;
            else if (usersinput == "y") return true;
            else return false;
        }
        public static string LoginUser(string[] usernameDataBase, string[] passwordDataBase, string username, string password)
        {
            if (isUsernameInDataBase(usernameDataBase, username) && isPasswordInDataBase(passwordDataBase, password)) return "Logged in!";
            else return "Incorrect log in information!";
        }

        public static int[] Sort(int[] Array)
        {
            int min_value, temp;
            for (int i = 0; i < Array.Length; i++)
            {
                min_value = i;
                for (int j = i; j < Array.Length; j++)
                {
                    if (Array[min_value] > Array[j]) min_value = j;
                }

                temp = Array[min_value];
                Array[min_value] = Array[i];
                Array[i] = temp;
            }
            return Array;
        }


        public static bool isUsernameInDataBase(string[] DataBase, string userinfo)
        {
            foreach (string DataBaseItem in DataBase)
            {
                if (userinfo.Equals(DataBaseItem, StringComparison.OrdinalIgnoreCase)) return true;
            }
            return false;
        }
        public static bool isPasswordInDataBase(string[] DataBase, string userinfo)
        {
            foreach (string DataBaseItem in DataBase)
            {
                if (userinfo == DataBaseItem) return true;
            }
            return false;
        }
        public static string PromptInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public static int[] AddItemToStart(int item, int[] OldArray)
        {
            int[] NewArray = new int[OldArray.Length + 1];
            int StartOfOldArray = 0;
            int NewArraySecondElementsIndex = 1;
            Array.Copy(OldArray, StartOfOldArray, NewArray, NewArraySecondElementsIndex, OldArray.Length);
            NewArray[0] = item;

            return NewArray;
        }
        public static int[] AddItemToEnd(int item, int[] OldArray)
        {
            int[] NewArray = new int[OldArray.Length + 1];
            Array.Copy(OldArray, NewArray, OldArray.Length);
            NewArray[NewArray.Length - 1] = item;

            return NewArray;
        }

        public static int[] InsertToArray(int IndexToInsertItem, int item, int[] OldArray)
        {
            int[] NewArray = new int[OldArray.Length + 1];
            Array.Copy(OldArray, NewArray, IndexToInsertItem);
            NewArray[IndexToInsertItem] = item;
            Array.Copy(OldArray, IndexToInsertItem, NewArray, IndexToInsertItem + 1, OldArray.Length - IndexToInsertItem);

            return NewArray;
        }

        public static int[] RemoveFromStart(int[] OldArray)
        {
            int[] NewArray = new int[OldArray.Length - 1];
            int OldArraySecondElement = 1;
            int NewArrayFirstElement = 0;
            Array.Copy(OldArray, OldArraySecondElement, NewArray, NewArrayFirstElement, NewArray.Length);

            return NewArray;
        }
        public static int[] RemoveFromEnd(int[] OldArray)
        {
            int[] NewArray = new int[OldArray.Length - 1];
            Array.Copy(OldArray, NewArray, NewArray.Length);

            return NewArray;
        }
        public static int[] RemoveAtIndex(int[] OldArray, int IndexToRemoveItem)
        {
            int[] NewArray = new int[OldArray.Length - 1];
            Array.Copy(OldArray, NewArray, IndexToRemoveItem);
            Array.Copy(OldArray, IndexToRemoveItem + 1, NewArray, IndexToRemoveItem, NewArray.Length - IndexToRemoveItem);

            return NewArray;
        }

    }
}
