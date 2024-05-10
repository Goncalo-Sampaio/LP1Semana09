using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower2
{
    class Program
    {
        static void Main(string[] args)
        {
            //take the argument for the file/path
            string file = args[0];

            //variable needed for the while loop
            bool readingInput = true;

            //StreamWriter for continuous writing
            //no closing the file needed because of the "using" keyword
            using StreamWriter sw = new StreamWriter(file);

            while (readingInput)
            {
                string userInput = Console.ReadLine();
                if (userInput == "")
                {
                    break;
                }
                else
                {
                    //writes the current input in the designated fil
                    sw.WriteLine(userInput);
                }
            }
        }
    }
}
