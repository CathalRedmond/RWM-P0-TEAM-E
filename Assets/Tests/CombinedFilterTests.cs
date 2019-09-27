using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CombinedFilterTests
    {
        [Test]
        public void CombineFilterTest()
        {
            List<int> input = new List<int> { 0, 1, 2, 3, 4, 5, 696969420 };
            List<int> output = CombinedFilter.combinedFilter(input);
            List<int> expected = new List<int> { 0, 2, 4, 5, 7, 8, 9 };

            List<int> wrongValues = new List<int> { 1, 2, 3, 4, 5 };
            CollectionAssert.AreNotEqual(output, wrongValues);
            CollectionAssert.AreEqual(output, expected);
        }
    }
}
