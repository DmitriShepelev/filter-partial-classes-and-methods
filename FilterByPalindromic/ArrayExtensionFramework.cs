using System;
using System.Collections.Generic;

namespace FilterByPalindromic
{
    /// <summary>
    /// Class that contains filter operations of arrays.
    /// </summary>
    public static partial class ArrayExtension
    {
        /// <summary>
        /// Creates new array of elements that satisfy some predicate.
        /// </summary>
        /// <param name="source">Source array.</param>
        /// <returns>New array of elements that satisfy some predicate.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int[] FilterByPredicate(this int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException($"{nameof(source)} cannot be null.");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty.");
            }

            var list = new List<int>();
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == Reverse(source[i]))
                {
                    AddAccordingToPredicate(list, source[i]);
                }
            }

            return list.ToArray();
        }

        private static int Reverse(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = (result * 10) + (num % 10);
                num /= 10;
            }

            return result;
        }

        static partial void AddAccordingToPredicate(ICollection<int> collection, int item);
    }
}
