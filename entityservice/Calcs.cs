using System;

/// <summary>
/// Entityservice layer
/// </summary>
namespace entityservice
{

    /// <summary>
    /// Class for calcs on entityservice layer
    /// </summary>
    public class Calcs
    {
        /// <summary>
        /// Method to get the maximum product between two integers in an array multiple of some integer
        /// </summary>
        /// <param name="arr">Array with the numbers to calculate</param>
        /// <param name="multipleOf">Integer that the product should be multiple of</param>
        /// <returns></returns>
        public (int, int, int) GetMaximumProductMultiple(int[] arr, int multipleOf)
        {
            if (arr == null || multipleOf < 0 || arr.Length < 2)
                return (-1, -1, -1);

            Array.Sort(arr);
            Array.Reverse(arr);

            for (int firstInd = 0; firstInd < arr.Length; firstInd++)
            {
                for (int secondInd = 1; secondInd < arr.Length; secondInd++)
                {
                    int prod = GetProductMultiple(arr[firstInd], arr[secondInd], multipleOf);
                    if (prod != -1)
                        return (prod, arr[firstInd], arr[secondInd]);
                }
            }

            return (-1, -1, -1);
        }

        /// <summary>
        /// Gets the product from any two numbers if it is multiple of another number
        /// </summary>
        /// <param name="x">First number</param>
        /// <param name="y">Second number</param>
        /// <param name="multipleOf">Number that the product should be multiple of</param>
        /// <returns></returns>
        public int GetProductMultiple(int x, int y, int multipleOf = -1)
        {
            int total = x * y;
            if (IsMultipleOf(total, multipleOf))
                return total;
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Checks if value is multiple of a number
        /// </summary>
        /// <param name="value">Value to test</param>
        /// <param name="multipleOf">Number to check if the value is multiple of</param>
        /// <returns></returns>
        public bool IsMultipleOf(int value, int multipleOf)
        {
            return (value % multipleOf) == 0;
        }
    }
}
