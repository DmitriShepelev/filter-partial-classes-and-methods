using System;
using System.Collections.Generic;

namespace FilterByPalindromic
{
    /// <summary>
    /// Class that contains filter operations of arrays.
    /// </summary>
    public static partial class ArrayExtension
    {
        static partial void AddAccordingToPredicate(ICollection<int> collection, int item)
        {
            collection.Add(item);
        }
    }
}
