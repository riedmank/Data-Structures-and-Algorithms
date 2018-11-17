using System;
using Xunit;
using static UniqueChar.Program;

namespace UniqueCharTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests to make sure the method is case sensitive.
        /// </summary>
        [Fact]
        public void NotCaseSensitive()
        {
            string test = "AaBbCcDdEe";

            Assert.True(UniqueCharMethod(test));
        }

        /// <summary>
        /// Determines whether this instance [can return true with all unique characters].
        /// </summary>
        [Fact]
        public void CanReturnTrueWithAllUniqueCharacters()
        {
            string test = "abcdefghijklmnopqrstuvwxyz";

            Assert.True(UniqueCharMethod(test));
        }

        /// <summary>
        /// Determines whether this instance [can return false with same characters].
        /// </summary>
        [Fact]
        public void CanReturnFalseWithSameCharacters()
        {
            string test = "zzzzzzzzzzz";

            Assert.False(UniqueCharMethod(test));
        }
    }
}
