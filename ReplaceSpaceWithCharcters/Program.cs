using System;

namespace ReplaceSpaceWithCharcters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put in your senctence below");
            string sentence = Console.ReadLine();
            string output = ReplaceSpaceInString(sentence);
            Console.WriteLine(output);
        }

        public static string ReplaceSpaceInString(string Input)
        {
             Input = Input.Trim();

            Input = Input.Replace(" ", "%20");

            return Input;
        }
    }
}
