using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technical_Interview_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testCase1 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
            Console.WriteLine(SumOddNums(testCase1)); // Should be 36

            Console.WriteLine();
            int[] largeInts = {2147483647, 2}; // 2147483647 is the upper bound of Int32.
            Console.WriteLine(SumLargeArray(largeInts));

            Console.WriteLine();
            string testReverse= "Oregon";
            Console.WriteLine(ReverseString(testReverse));
            Console.WriteLine(testReverse);

            Console.WriteLine();
            string testRemoveDuplicates = "Software Engineer/Web Developer (Level 2)";
            Console.WriteLine(RemoveDuplicateCharacters(testRemoveDuplicates));

            Console.WriteLine();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0}: {1}", i, FizzBuzz(i));
            }

            Console.ReadLine();
        }

        //Given an array of integers, write a method to total the odd numbers.
        static int SumOddNums(int[] intArr)
        {
            return intArr.Where(x => x % 2 == 1).Sum();
        }

        //Given an array of integers, write a method to sum the elements in the array, knowing that some of the elements may be very large integers.
        static long SumLargeArray(int[] intArr)
        {
            long sum = 0;
            foreach (var num in intArr)
            {
                sum += num;
            }

            return sum;
        }


        //Given a string, reverse it. 
        static string ReverseString(string str)
        {
            char[] letters = str.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }

        //Given a string, remove any repeated letters. 
        static string RemoveDuplicateCharacters(string str)
        {
            return new string(str.ToCharArray().Distinct().ToArray());
        }

        //FizzBuzz (Look this one up and try it out)
        static string FizzBuzz(int num, int fizz = 3, int buzz = 5)
        {
            string answer = "";
            if (num % fizz == 0) answer += "Fizz";
            if (num % buzz == 0) answer += "Buzz";
            return answer;
        }
    }
}
