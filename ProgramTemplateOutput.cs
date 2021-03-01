using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment_2_SP21
{
    class ProgramTemplateOutput
    {
        static void Main(string[] args)
        {
            //Question1:
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                // initializing int to store array length and int array to store input array with same length
                int len = nums.Length;
                int[] res = new int[len];
                int j = -1;

                // if condition on no. of input values for shuffle and length of n*2
                if ((n <= 500 && n >= 1) && (len == 2 * n))
                {
                    // loop through all the array elements
                    for (int i = 0; i < n; i++)
                    {
                        // nums array with i as the index updates first element to result array with j as index
                        j = j + 1;
                        res[j] = nums[i];

                        // next index of the result array gets updated with nums array with the index n appended to the i counter
                        j = j + 1;
                        res[j] = nums[n + i];

                    }
                }

                // printing the result array with ", " seperator
                Console.WriteLine("[{0}]", string.Join(", ", res));
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                // initializing int counter starting index for loop
                int i = 0;

                // loop through all the array elements
                for (int j = 0; j < ar2.Length; j++)
                {
                    // if condition checking for a non-zero element and counting those values through i
                    if (ar2[j] != 0)
                        ar2[i++] = ar2[j];
                }

                // loop through the array and add zeros at the end until the intital array length is reached
                while (i < ar2.Length)
                {
                    ar2[i++] = 0;
                }

                // printing the array output with ", " seperator
                Console.WriteLine("[{0}]", string.Join(", ", ar2));
            }
            catch (Exception)
            {
                throw;
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            try
            {
                // initialize a count variable for storing index values with matched elements
                int ct = 0;

                // loop for iterating over all the array elements
                for (int i = 0; i < nums.Length; i++)
                {
                    // loop for iterating from next index of array elements
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        // if condition for checking matched array elements
                        if (nums[i] == nums[j])
                        {
                            // counting the no. of matched cases and storing in a variable
                            ct++;
                        }
                    }
                }

                // printing the count value
                Console.WriteLine(ct);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                // instantciate a paired dictionary variable to store the indexes
                var dict = new Dictionary<int, int>();

                // initializing an int array variable for storing values from key value pairs check
                int[] rVal = { 0, 0 };

                // loop for iterating over all the array elements
                for (int i = 0; i < nums.Length; ++i)
                {
                    // number needed to check as sum in the input array
                    var numTemp = target - nums[i];

                    // if condition to get the value based on a key which in this case is the index and store in the dictionary
                    if (dict.TryGetValue(numTemp, out int index))
                    {
                        // storing the index in a variable
                        rVal[0] = index;
                        rVal[1] = i;

                        // break out of the conditional statement
                        break;
                    }
                    else
                    {
                        // store elements from nums to dictionary if not found by index
                        dict[nums[i]] = i;
                    }
                }

                // printing the array output with ", " seperator 
                Console.WriteLine("[{0}]", string.Join(", ", rVal));
            }
            catch (Exception)
            {
                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                // convert the input into character array store all elements into a character variable
                var cAr = s.ToCharArray();

                // initialize a new char array of length of the input
                char[] sCh = new char[s.Length];

                // loop for iterating over all the array elements
                for (int i = 0; i < indices.Length; i++)
                {
                    // append the input string to the indices array with i as index
                    sCh[indices[i]] = cAr[i];
                }

                // print the output character array
                Console.WriteLine(sCh);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                // initialize character arrays for storing the input strings after converting those to character arrays
                char[] chs1 = new char[256];
                char[] chs2 = new char[256];
                char[] S1 = s1.ToCharArray();
                char[] T1 = s2.ToCharArray();
                int n = s1.Length;

                // if condition to check if both input strings are of same length
                if (s1.Length != s2.Length)
                {
                    // return false if the input strings length are not equal
                    return false;
                }
                else
                {
                    // loop for iterating over all the array elements
                    for (int i = 0; i < n; i++)
                    {
                        // if condition to check new character arrays are empty
                        if (chs1[S1[i]] == 0 && chs2[T1[i]] == 0)
                        {
                            // initialize input arrays to new character arrays
                            chs1[S1[i]] = T1[i];
                            chs2[T1[i]] = S1[i];
                        }
                        else
                        {
                            // check if each element in either input strings are equal
                            if (chs1[S1[i]] != T1[i] || chs2[T1[i]] != S1[i])
                            {
                                // return false if equal elements found in either input strings
                                return false;
                            }
                        }
                    }

                    // return true after looping through both the strings
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                // initializing a dictionary map to store multidimensional array
                Dictionary<int, List<int>> dictMapper = new Dictionary<int, List<int>>();

                // loop for iterating over all the array elements
                for (int i = 0; i < items.GetLength(0); i++)
                {
                    // if condition to get array elements from input array and store in the dictionary map
                    if (dictMapper.ContainsKey(items[i, 0]))
                    {
                        dictMapper[items[i, 0]].Add(items[i, 1]);
                    }
                    else
                    {
                        dictMapper.Add(items[i, 0], new List<int> { items[i, 1] });
                    }
                }

                // initializing multidimensional array of type int and a temporary variable
                int[,] result = new int[2, 2];
                int valOut = 0;

                // loop through key value pair of the dictionary map, sorting and calulating average
                foreach (KeyValuePair<int, List<int>> pair in dictMapper)
                {
                    pair.Value.Sort();
                    pair.Value.Reverse();
                    result[valOut, 0] = pair.Key;
                    result[valOut, 1] = (pair.Value.Take(5).Sum() / 5);
                    valOut = valOut + 1;
                }

                // printing the result as multidimensional array with ", " seperator
                Console.WriteLine("[" + result[0, 0] + "," + result[0, 1] + "]" + ", " + "[" + result[1, 0] + "," + result[1, 1] + "]");
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            try
            {
                // create an empty hashset
                HashSet<int> inp = new HashSet<int>();

                // loop while the condition is set true 
                while (true)
                {
                    int t = 0;

                    // loop until n is equal to 0
                    while (n != 0)
                    {
                        // store n modulo in a new int variable
                        int r = n % 10;

                        // square the new int variable and store in a new variable t 
                        t += (r * r);
                        n /= 10;
                    }

                    // if t value is equal to 1 then return true
                    if (t == 1)
                    {
                        return true;
                    }
                    // else if check for t in the hashset and return false if true
                    else if (inp.Contains(t))
                    {
                        return false;
                    }
                    // else add t to the hashset and assign t to n
                    else
                    {
                        inp.Add(t);
                        n = t;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                // check for input array length
                if (prices.Length == 0) return 0;

                // iniatialize int variables for storing minimum and maximum values
                int min = int.MaxValue, result = int.MinValue;

                // loop for iterating over all the array elements
                for (var i = 0; i < prices.Length; i++)
                {
                    // finding the min value and subtracting from the max value in the array
                    min = Math.Min(min, prices[i]);
                    result = Math.Max(result, prices[i] - min);
                }

                // returning the final result which contains the profit
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                // handling corner cases
                if (steps == 0) Console.WriteLine(0);
                if (steps == 1) Console.WriteLine(1);
                if (steps == 2) Console.WriteLine(2);

                // initializing variables
                var step1 = 1;
                var step2 = 2;

                // loop for iterating over each value until the last but one value
                for (int i = 2; i < steps; i++)
                {
                    // initializing values to new variable and storing each iteration in another variable
                    var result = step1 + step2;
                    step1 = step2;
                    step2 = result;
                }

                // printing output of total ways to climb
                Console.WriteLine(step2);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}