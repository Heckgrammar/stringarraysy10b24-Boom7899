using System.Diagnostics.Tracing;

namespace StringArrays10B24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a subroutine called Prefix from your pseudo-code 
             * The subroutine takes two, character arrays called word and pre as parameters and 
             * The subroutine determines whether the start of the character array word is the 
             * same as all of the character array pre.*/

            /* Your subroutine should also:
	•           work for character arrays of all lengths greater than 0
	•           not assume that the length of pre is less than the length of word.*/

            /* use fixed (hard coded) string arrays to test your code. 
             Call your subroutine using your test arrays from Main() routine
             and return the result to Main() */

            /* Starter code for your subroutine has been provided*/
            string[] word = { "u", "N", "s", "i", "g", "m", "a" };
            string[] pre = { "u", "n", "s", "i" };
            Console.WriteLine(Prefix(word, pre));

        }
        static bool Prefix(string[] word, string[] pre) 
        {
            if (pre.Length > word.Length)
            {
                return false;
            }

            for (int i = 0; i < pre.Length; i++)
            {
                if (pre[i].ToLower() != word[i].ToLower())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
