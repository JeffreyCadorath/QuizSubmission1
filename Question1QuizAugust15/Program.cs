using System;
using System.Collections.Generic;

namespace Question1QuizAugust15
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[10];
            Console.WriteLine(showSingles((testArray)));
            Console.WriteLine(containDuplicate(testArray));
            Console.WriteLine(containDuplicateWithSets(testArray));
            Console.ReadLine();
        }
        public static int[] showSingles(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int x = i+1; x < array.Length; x++)
                {
                    if(array[i] != array[x])
                    {
                        Console.WriteLine((array[i]));
                    }
                }
            }
            return array;
        }

        public static bool containDuplicate(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int x = i + 1; x < array.Length; x++)
                {
                    if(array[i] == array[x])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool containDuplicateWithSets(int[] array)
        {
            var nonDupes = new HashSet<int>();
            foreach(var item in nonDupes)
            {
                if (nonDupes.Contains(item))
                {
                    return false;
                }
                else
                {
                    nonDupes.Add(item);
                }
            }
            return true;
        }
    }
}
