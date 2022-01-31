using System;

namespace Assignment_1_Claudio_Moncada
{
    class Program
    {
        private static string RemoveVowels(string s)
        {
            try
            {
                //Question 1

                string s = Console.ReadLine(); // string containing the words
                string result = s.Replace("a", string.Empty)
                    .Replace("e", string.Empty)
                    .Replace("i", string.Empty)
                    .Replace("o", string.Empty)
                    .Replace("u", string.Empty); // using the replace and empty functions the letters can be taken out  

                Console.WriteLine(result); // Output of the result
                String final_string = "";
                return final_string;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: word1 = ["ab", "c"], word2 = ["a", "bc"]
       Output: true
       Explanation:
       word1 represents string "ab" + "c" -> "abc"
       word2 represents string "a" + "bc" -> "abc"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["a", "cb"], word2 = ["ab", "c"]
       Output: false
       Example 3:
       Input: word1  = ["abc", "d", "defg"], word2 = ["abcddefg"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            try
            {
                //Question 2
                string bulls_string1 = "MarshallStudentCenter"; //This is the first String
                string bulls_string2 = ("Marshall" + "Student" + "Center"); // This is the second string

                if (bulls_string1.Equals(bulls_string2)) //Equals function to compare both strings. Using an If loop
                {
                    Console.WriteLine("True"); // IF it is true write "True"
                }

                else
                {
                    Console.WriteLine("False"); //If it is false then write "false"
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array nums. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: nums = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: nums = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: nums = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] nums)
        {
            try
            {
                int[] bull_bucks = new int[] { 1, 2, 3, 4, 5 }; // This is the numbers we want to find
                var add = 0; // varible addition is left blank
                var result = new int[100]; // variable result as a new integer

                for (int i = 0; i < bull_bucks.Length; i++) // start of a for loop
                {
                    result[bull_bucks[i] - 1]++;
                }

                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == 1)
                        add += i + 1;
                }

                Console.WriteLine(add); //write the answer
                return 0;

            }
            catch (Exception)
            {
                throw;
            }
        }
        /*

        <summary>
       Given a square matrix mat, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.
       Example 1:
       Input: mat = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: mat = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: mat = [[5]]
       Output: 5
       </summary>
        */

        private static int DiagonalSum(int[,] matrix)
        {
            try
            {
                int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

                return 0;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string s and an integer array indices of the same length.
        The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.
        Example 3:
        Input: s = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"
        */

        private static string RestoreString(string s, int[] indices)
        {
            try
            {
                String bulls_string = "USF"; //The string we want to rearrange
                int[] indices = { 1, 0, 2 }; //The numbers represent the order of the strings

                char[] RestoreStrings = new char[bulls_string.Length]; //Create a variable and store it using the string and calling it Restore strings
                for (int i = 0; i < indices.Length; i++) //create a for loop using the indices 
                {
                    RestoreStrings[indices[i]] = bulls_string[i]; // SInce restorestrings are a stored variable I used the indices that are numbered and equaled
                                                                  // it to the bulls string that follows the int i in the loop
                }

                Console.WriteLine(RestoreStrings); //write the output which is the answer
                return "null";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string word and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.
        Example 1:
        Input: word = "abcdefd", ch = "d"
        Output: "dcbaefd"
        Explanation: The first occurrence of "d" is at index 3. 
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "dcbaefd".
        Example 2:
        Input: word = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".
        Example 3:
        Input: word = "abcd", ch = "z"
        Output: "abcd"
        Explanation: "z" does not exist in word.
        You should not do any reverse operation, the resulting string is "abcd".
        */

        private static string ReversePrefix(string word, char ch)
        {
            try
            {
                string bulls_string = "zimmermanschoolofadvertising"; //String we desire to change
                char ch = 'x'; //character where it looka for
                var letters = bulls_string.ToCharArray(); //create a var using the main string tochararray
                for (int i = 0; i < letters.Length; i++) // start for loop with int i
                {
                    if (letters[i] == ch) //int i = to c
                    {
                        for (int j = 0; j <= i / 2; j++) // for loop stating switch letter operation
                        {
                            var t = letters[j];
                            letters[j] = letters[i - j];
                            letters[i - j] = t;
                        }
                        Console.WriteLine(letters);
                    }


                }
                String prefix_string = "";
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
    

