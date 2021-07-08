using System;
using System.Collections.Generic;
using System.Text;

namespace usingDelegates
{
    class Filter
    {
        // public delegate bool Criteria(int value);
        public static int[] FilterArray(int[] array, Func<int, bool> myCriteriaFunction)
        {
            List<int> result = new List<int>();
            foreach (var value in array)
            {
                if (myCriteriaFunction(value))
                {
                    result.Add(value);
                }
            }
            return result.ToArray();
        }

        
    }
}
