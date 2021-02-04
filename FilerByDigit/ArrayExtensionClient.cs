using System;
using System.Collections.Generic;

namespace FilterByDigit
{
    /// <summary>
    /// Class that contains filter operations of arrays.
    /// </summary>
    public static partial class ArrayExtension
    {
        private static int digit;
        private static bool isDigitSet = false;

        public static int Digit
        {
            get
            {
                return digit;
            }

            set
            {
                if (value < 0 || value > 9)
                {
                    throw new ArgumentOutOfRangeException($"Expected digit can not be less than zero and more than nine.");
                }

                digit = value;
                isDigitSet = true;
            }
        }

        static partial void AddAccordingToPredicate(ICollection<int> collection, int item)
        {
            collection.Add(item);
        }
    }
}
