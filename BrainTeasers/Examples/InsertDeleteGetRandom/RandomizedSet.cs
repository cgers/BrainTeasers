using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainTeasers.Examples.InsertDeleteGetRandom
{

    public class RandomizedSet
    {
        private List<int> ValueList { get; set; }
        /** Initialize your data structure here. */
        public RandomizedSet()
        {
            ValueList = new List<int>();
        }
        
        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            bool containsValue = ValueList.Contains(val);
            ValueList.Add(val);
            return containsValue;
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            bool containsValue = ValueList.Contains(val);
            if (containsValue)
            {
                ValueList.Remove(val);
            }
            return containsValue;
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            Random random = new Random();
            int valueCount = random.Next(ValueList.Count, ValueList.Count - 1);
            return ValueList[valueCount];
        }

    };
}
