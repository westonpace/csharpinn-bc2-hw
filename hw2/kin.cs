using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 10, 5, 9, 87, 56 };
            SortArray(numbers);
            int[] addElementInArray = AddElementAtAnyPosition(numbers, 32, numbers.Length);
            PrintArray(addElementInArray);
            int[]removeElementInArray = RemoveElementAtPositon(numbers, 4);
            PrintArray(removeElementInArray);
            LoginInfo("KIN", "21lome");

        }

        static void PrintArray(int[] array)
        {
            foreach(int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        private static void SortArray(int[] numbers)
        {
            int temp = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                ;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array");
            foreach (int number in numbers)
            {

                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
       

        private static int[] AddElementAtAnyPosition(int[] numbers, int newNumber, int position)
        {
            int[] newNumbers = new int[numbers.Length + 1];
            for (int i = 0; i < numbers.Length + 1; i++)
            {
                if (i == position)
                {
                    newNumbers[i] = newNumber;
                }
                else if (i < position)
                {
                    newNumbers[i] = numbers[i];
                }
                else
                {
                    newNumbers[i] = numbers[i - 1];
                }
            }
            return newNumbers;
        }
       
        private static int[] RemoveElementAtPositon(int[] numbers, int index)
        {
            int[] newArray = new int[numbers.Length - 1];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (i < index)
                {
                    newArray[i] = numbers[i];
                }
                if (i >= index)
                {
                    newArray[i] = numbers[i + 1];
                }

            }
            return newArray;
        }

        static void LoginInfo(string name, string password)
        {
            string myName = "Kin";
            string pwd = "21Lome";
            if (myName.Equals(name, StringComparison.OrdinalIgnoreCase) && pwd.Equals(password, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Loggin in!");
            }
        }
    }
}
