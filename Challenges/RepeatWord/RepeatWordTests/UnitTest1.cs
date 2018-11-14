using System;
using Xunit;
using static RepeatWord.Program;
using HashTables.Classes;

namespace RepeatWordTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Determines whether this instance [can return null].
        /// </summary>
        [Fact]
        public void CanReturnNull()
        {
            Assert.Null(RepeatWordMethod("The cheese was great"));
        }

        /// <summary>
        /// Determines whether this instance [can find word].
        /// </summary>
        [Fact]
        public void CanFindWord()
        {
            Assert.Equal("the", RepeatWordMethod("The cheese was only better than the wine."));
        }

        /// <summary>
        /// Determines whether this instance [can find numbers].
        /// </summary>
        [Fact]
        public void CanFindNumbers()
        {
            Assert.Equal("9", RepeatWordMethod("1 2 3 4 5 9 6 7 8 9"));
        }
    }
}
