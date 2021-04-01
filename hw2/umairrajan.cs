using System;
using System.Linq;

namespace RecipeApp
{
    class Chapter2
    {
        public int[] SortedArray(int[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                var currentValue = input[i];
                var previousValue = input[i - 1];
                if (currentValue - previousValue < 0)
                {
                    input[i] = previousValue;
                    input[i - 1] = currentValue;
                    SortedArray(input);
                }
            }
            return input;

        }
        public int[] AddElementAtStartOfArray(int[] input, int element)
        {
            var result = new int[input.Length + 1];
            result[0] = element;
            input.CopyTo(result, 1);
            return result;
        }

        public int[] AddElementAtEndOfArray(int[] input, int element)
        {
            var result = new int[input.Length + 1];
            input.CopyTo(result, 0);
            result[result.Length - 1] = element;
            return result;
        }
        /// <summary>
        /// Cuts the array from start position to end position. inclusive of element at end position
        /// </summary>
        /// <param name="input"></param>
        /// <param name="endposition"></param>
        /// <param name="startPosition"></param>
        /// <returns></returns>
        private static int[] CutArray(int[] input, int endposition, int startPosition = 0)
        {
            return input.Where((x, i) => i >= startPosition && i <= endposition - 1).ToArray();
        }
        public int[] AddElementAtProvidedPosition(int[] input, int element, int position)
        {
            var modifiedArrayStart = CutArray(input, position);
            var modifiedArrayEnd = CutArray(input, input.Length, position);

            var result = modifiedArrayStart.Concat(new int[] { element }).Concat(modifiedArrayEnd);
            return result.ToArray();
        }

        public int[] RemoveElementAtTheStart(int[] input)
        {
            return CutArray(input, input.Length, 1);
        }

        public int[] RemoveElementAtTheEnd(int[] input)
        {
            return CutArray(input, input.Length - 1, 0);
        }

        public int[] RemoveElementAtProvidedPosition(int[] input, int position)
        {
            var modifiedArrayStart = CutArray(input, position);
            var modifiedArrayEnd = CutArray(input, input.Length, position + 1);
            return modifiedArrayStart.Concat(modifiedArrayEnd).ToArray();
        }

        public void Login(string userName, string password)
        {
            if (userName.Equals(password, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Logged In!");
            }

        }
    }
}