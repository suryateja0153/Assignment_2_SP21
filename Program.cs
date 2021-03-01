using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment_2_SP21
{
    class Program
    {
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

        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 2;
            ShuffleArray(ar1, n1);
            Console.WriteLine();

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
            RestoreString(s5, indices);
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
            int n10 =3;
            Stairs(n10);
            Console.WriteLine();
        }
    }
}
