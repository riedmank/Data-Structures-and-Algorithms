using System;
using Xunit;
using BinarySearch;
using static BinarySearch.Program;

namespace BinarySearchTest
{
    public class UnitTest1
    {
        [Fact]
        public void FindValueInArray()
        {
            Assert.Equal(2, ArrayBinarySearch(testArrayOne, 15));
        }

        [Fact]
        public void DidNotFindValueInArray()
        {
            Assert.Equal(-1, ArrayBinarySearch(testArrayTwo, 90));
        }

        [Fact]
        public void FindLastElementInArray()
        {
            Assert.Equal(9, ArrayBinarySearch(testArrayOne, 123));
        }

        [Fact]
        public void FindFirstElementInArray()
        {
            Assert.Equal(0, ArrayBinarySearch(testArrayTwo, 11));
        }
    }
}
