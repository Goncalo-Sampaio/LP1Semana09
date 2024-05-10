using System;
using System.Collections.Generic;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1, 10, -30, 10, -5};
            Stack<int> stack = new Stack<int>(new int[] {1, 10, -30, 10, -5});
            Queue<int> q = new Queue<int>(new int[] {1, 10, -30, 10, -5});
            HashSet<int> hashSet = new HashSet<int>() {1, 10, -30, 10, -5};

            foreach (int i in list){
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            foreach(int i in stack){
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            foreach(int i in q){
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            foreach (int i in hashSet){
                Console.Write($"{i} ");
            }
        }
    }
}
