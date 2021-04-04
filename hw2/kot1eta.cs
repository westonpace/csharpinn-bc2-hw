using System;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = new int[] { 28, 9, 18, 6, 23, 27, 9 };
            Console.WriteLine("Where we started");
            ShowSequence(sequence);
            SortSequence(sequence);
            int num = EnterNumberToInsert();
            int spot = EnterPositionToInsert();
            int[] AddNumberInSequence = AddNumberAtAnyPosition(sequence, num, spot);
            ShowSequence(AddNumberInSequence);
            int pos = EnterPositionToDelete();
            int[] RemoveNumberInSequence = RemoveNumberAtAnyPosition(sequence, pos);
            ShowSequence(RemoveNumberInSequence);
            string result = LoginCheck();
        }
        static void ShowSequence(int[] sequence)
        {
            foreach(int number in sequence)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        static void SortSequence(int[] sequence)
        {
            int pos = 0;
            for(int x = 0; x < sequence.Length - 1; x++) 
            {
                for (int y = x + 1; y < sequence.Length; y++) 
                {
                    if (sequence[x] > sequence[y])
                    {
                        pos = sequence[x];
                        sequence[x] = sequence[y];
                        sequence[y] = pos;
                    }
                }
            }
            Console.WriteLine("Ascending sequence");
            foreach (int number in sequence)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        static int EnterNumberToInsert()
        {
            Console.Write("What do you want to insert into sequence: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        static int EnterPositionToInsert()
        {
            Console.Write("What spot of the sequence do you want to insert a number to: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num - 1;
        }
        static int[] AddNumberAtAnyPosition(int[] sequence,int extranum, int position)
        {
            int[] longseq = new int[sequence.Length + 1];
            
            for (int x = 0; x < sequence.Length + 1; x++)
            {
                if (x == position)
                {
                    longseq[x] = extranum;
                }

                else if (x < position)
                {
                    longseq[x] = sequence[x];
                }
                else
                {
                    longseq[x] = sequence[x - 1];
                }
            }
            Console.WriteLine("Longer one");
            return longseq;
        }
        static int EnterPositionToDelete()
        {
            Console.Write("Which member of the sequence do you want to remove: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num - 1;
        }
        static int[] RemoveNumberAtAnyPosition(int[] sequence, int position)
        {
            int[] shortseq = new int[sequence.Length - 1];
            for (int x = 0; x < sequence.Length - 1; x++)
            {
                if (x < position)
                {
                    shortseq[x] = sequence[x];
                }
                if (x >= position)
                {
                    shortseq[x] = sequence[x + 1];
                }
            }
            Console.WriteLine("Shorter one");
            return shortseq;
        }
        static string LoginCheck()
        {
            string outcome;
            string CorrectUser = "SVX348";
            string CorrectPass = "KoTleTA";
            Console.Write("Enter Username: ");
            string un = Console.ReadLine();
            Console.Write("Enter Password: ");
            string pwd = Console.ReadLine();
            if (CorrectUser.Equals(un, StringComparison.OrdinalIgnoreCase) && CorrectPass.Equals(pwd))
            {
                outcome = "Logged In!";
            }
            else
            {
                outcome = "Wrong ID!";
            }
            Console.WriteLine(outcome);
            return outcome;
        }
    }
}
