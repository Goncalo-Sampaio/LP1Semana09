using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            //take the argument for the file/path
            string file = args[0];

            //variable needed for the while loop
            bool readingInput = true;

            //queue to store user inputs
            Queue<string> userInputs = new Queue<string>();
            while (readingInput)
            {
                string userInput = Console.ReadLine();
                if (userInput == "")
                {
                    break;
                }
                else
                {
                    //adds the current user input to the queue
                    userInputs.Enqueue(userInput);
                }
            }
            //write all inputs in the designated file
            File.WriteAllLines(file, userInputs);
        }
    }
}
