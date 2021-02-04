using System;
using System.Collections.Generic;

namespace FilterByDigit
{
    /// <summary>
    /// Class that contains filter operations of arrays.
    /// </summary>
    public static partial class ArrayExtension
    {
        /// <summary>
        /// Returns new array of elements that satisfy some predicate.
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
            if (isDigitSet)
            {
               
                for (int i = 0; i < source.Length; i++)
                {
                    if (source[i].Equals(digit) || IsContainsDigit(source[i], digit))
                    {
                        AddAccordingToPredicate(list, source[i]);
                    }
                }
            }

            return list.ToArray();
        }

        private static bool IsContainsDigit(int number, int digit)
        {
            while (number != 0)
            {
                if (Math.Abs(number % 10) == digit)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }

        /// <summary>
        /// Forms a collection of integers that match some predicate.
        /// </summary>
        /// <remarks>The predicate logic is implemented in another part of the partial class.</remarks>
        /// <param name="collection">A collection that is formed based on a predicate match.</param>
        /// <param name="item">An element that, if it contains the digit, is added to the collection.</param>
        static partial void AddAccordingToPredicate(ICollection<int> collection, int item);
    }
}
