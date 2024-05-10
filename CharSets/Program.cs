using System;
using System.Collections.Generic;
using System.IO;

namespace CharSets
{
    class Program
    {
        static void Main(string[] args)
        {
            //hashSet for the intersection between each file
            HashSet<char> intersection = new HashSet<char>();

            if (args == null || args.Length == 0)
            {
                //doesn't do anything if there are no files
            }
            else
            {
                //iterating through all the files
                int fileCount = 0;
                foreach (string file in args)
                {
                    //getting all the lines from the file 
                    string[] strings = File.ReadAllLines(file);

                    //HashSet for the file's chars
                    HashSet<char> chars = new HashSet<char>();

                    //check if any line has more than 1 char
                    foreach (string c in strings)
                    {
                        if (c.Length > 1)
                        {
                            string error = "Error: more than 1 char per line";
                            Console.WriteLine(error);
                            return;
                        }
                        else
                        {
                            chars.Add(char.Parse(c));
                        }
                    }

                    if (fileCount == 0)
                    {
                        intersection = chars;
                    }
                    else
                    {
                        intersection.IntersectWith(chars);
                    }

                    //increase file count to prevent intersection from resetting
                    fileCount++;
                }
            }

            //order chars and print them
            List<char> finalList = new List<char>(intersection);
            finalList.Sort();
            foreach (char c in finalList)
            {
                Console.WriteLine(c);
            }
        }
    }
}