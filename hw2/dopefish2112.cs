using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharp_Zero_to_Hero
{
    class Program
    {
        /*
        string[] myArray = { "herp", "derp", "twerp", "gerp", "zerp", "furp" };
        static string uI1 = "";
        static string uI2 = "";
        static string c1M = "Please type a word the append to the begining of the array. . .";
        static string c2M = "please type a word the append to the end of the array. . .";
        */

        static void Main(string[] args)
        {
            
            string[] myArray = { "herp", "derp", "twerp", "gerp", "zerp", "furp" };
            string uI1;
            int uI2;
            string c1M = "Please type a word the append to the begining of the array. . .";
            string c2M = "Please type a word the append to the end of the array. . .";
            string c3M = "Please type a word to append randomly within the array";
            string c4M = "Deleting the 1st element in the Array. . .";
            string c5M = "Deleting the last element in the Array. . .";
            string c6M = "Please choose an index number to delete. . .";

            logIn();
            print(myArray);
            waitForUser();

            sortArray(ref myArray);
            waitForUser();

            Console.WriteLine(c1M);
            uI1 = Console.ReadLine();
            changeFirstElement(ref myArray, uI1);
            waitForUser();

            Console.WriteLine(c2M);
            uI1 = Console.ReadLine();
            changeLastElement(ref myArray, uI1);
            waitForUser();

            Console.WriteLine(c3M);
            uI1 = Console.ReadLine();
            changeRandomElement(ref myArray, uI1);
            waitForUser();

            Console.WriteLine(c4M);
            delFirstElement(ref myArray);
            waitForUser();

            Console.WriteLine(c5M);
            delLastElement(ref myArray);
            waitForUser();

            Console.WriteLine(c6M);
            uI2 = Int32.Parse(Console.ReadLine());
            uI2--;
            delSelectedElement(ref myArray, uI2);
            waitForUser();
            
        }

        public static void print(string[] i)
        {
            Console.WriteLine("THIS IS THE ORIGINAL ARRAY. . .");
            foreach (var item in i)
            {
                Console.WriteLine(item);
            }
        }

        public static void sortArray(ref string[] i)
        {
            Array.Sort(i);
            Console.WriteLine("THIS IS THE SORTED ARRAY. . .");
            foreach (var item in i)
            {
                Console.WriteLine(item);
            }

        }

        public static void changeFirstElement(ref string[] i, string j)
        {
            Array.Resize(ref i, i.Length + 1);
            for (int x = i.Length - 1; x > 0; x--)
            {
                i[x] = i[x - 1];
            }
            i[i.Length - i.Length] = j;
            
            Console.WriteLine("Here is the new array. . .");
            foreach (var word in i)
                Console.WriteLine(word);
        }

        public static void changeLastElement(ref string[] i, string j)
        {
            Array.Resize(ref i, i.Length + 1);
            i[i.Length - 1] = j;
            Console.WriteLine("Here is the new array. . .");
            foreach (var word in i)
            {
                Console.WriteLine(word);
            }
        }

        public static void changeRandomElement(ref string[] i, string j)
        {
            var rand = new Random();
            int num = rand.Next(0, i.Length - 1);
            Array.Resize(ref i, i.Length + 1);
            for (int x = i.Length -1; x >= 0; x--)
            {
                if (num < x)
                {
                    i[x] = i[x - 1];
                }
                
                else if (num == x)
                {
                    i[x] = j;
                }

                else if (num > x)
                {
                    break;
                }

            }

            Console.WriteLine($"Index {num + 1} has been changed. The new array is . . .");
            foreach (var word in i)
            {
                Console.WriteLine(word);
            }
        }

        public static void delFirstElement(ref string[] i)
        {
            for (int x = 0; x < i.Length - 1; x++)
            {
                i[x] = i[x + 1];
            }
            Array.Resize(ref i, i.Length - 1);
            Console.WriteLine("The new array is . . .");
            foreach (var word in i)
            {
                Console.WriteLine(word);
            }
        }

        public static void delLastElement(ref string[] i)
        {
            Array.Resize(ref i, i.Length - 1);
            Console.WriteLine("The new array is . . .");
            foreach (var word in i)
            {
                Console.WriteLine(word);
            }
        }

        public static void delSelectedElement(ref string[] i, int j)
        {
            i[j] = "";
            for (int x = j; x < i.Length - 1; x++)
            {
                i[x] = i[x + 1];
            }
       
            Array.Resize(ref i, i.Length - 1);
            Console.WriteLine($"Removing element {j+1}. The new array is. . .");
            
            foreach (var word in i)
            {
                Console.WriteLine(word);
            }
            
        }
        public static void waitForUser()
        {
            Console.WriteLine("Press enter to continue. . .");
            Console.ReadLine();
        }

        public static void logIn()
        {
            //Login Attempts counter
            int loginAttempts = 0;

            //Simple iteration upto three times
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter username: (It's dopefish)");
                string username = Console.ReadLine().ToLower();
                Console.WriteLine("Enter password: (It's 12345)");
                string password = Console.ReadLine();

                if (username != "dopefish" || password != "12345")
                    loginAttempts++;
                else
                    break;
            }

            //Display the result
            if (loginAttempts > 2)
            {
                    Console.WriteLine("Login failure. Press enter to exit.");
                    Console.ReadLine();
                    Environment.Exit(0);    
            }
 
            else
            {
                Console.WriteLine("Login successful");
            }
            Console.ReadKey();
        }
    }
}
