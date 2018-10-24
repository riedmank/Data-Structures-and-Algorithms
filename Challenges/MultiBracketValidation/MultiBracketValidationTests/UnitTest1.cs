using System;
using Xunit;
using static MultiBracketValidation.Program;

namespace MultiBracketValidationTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests to ensure true is returned if there are no brackets, curlies, or parans
        /// </summary>
        [Fact]
        public void CanReturnTrueWithoutBCP()
        {
            string test = "Drowner";
            Assert.True(MultiBracketValidationMethod(test));
        }

        /// <summary>
        /// Tests to ensure false is returned if there are only open brackets, curlies, or parans
        /// </summary>
        [Fact]
        public void CanReturnFalseWithOnlyOpenBCP()
        {
            string test = "[{(Dragon";
            Assert.False(MultiBracketValidationMethod(test));
        }

        /// <summary>
        /// Tests to ensure false is returned if there are only close brackets, curlies, or parans
        /// </summary>
        [Fact]
        public void CanReturnFalseWithOnlyCloseBCP()
        {
            string test = "Draugr]})";
            Assert.False(MultiBracketValidationMethod(test));
        }

        /// <summary>
        /// Tests to ensure true is returned with open and close brackets, curlies, or parans
        /// </summary>
        [Fact]
        public void CanReturnTrueWithOpenAndCloseBCP()
        {
            string test = "[{(Wish I were playing the Witcher)}]";
            Assert.True(MultiBracketValidationMethod(test));
        }
    }
}
