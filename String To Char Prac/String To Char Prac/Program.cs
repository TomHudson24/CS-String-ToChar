using System;

namespace String_To_Char_Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Aim is to print out the str string as a char array and have alternating letters be spaced in for a cool console effect
             */
            string str = "Hello World!";
            char[] charArr = str.ToCharArray();
            bool space = false;
            foreach (char c in charArr)
            {
                /* Wanted to try getting it into less lines of code but couldn't get the cascading effect I wanted 
                string s = (space != true) ? s = " " + c : s = c.ToString();
                Console.WriteLine(s);
                space = true;
                */
#if true
                if (space)
                {
                    Console.WriteLine(" " + c);
                    space = false;
                }
                else
                {
                    Console.WriteLine(c);
                    space = true;
                }
#endif
                
            }
        }
    }
}
