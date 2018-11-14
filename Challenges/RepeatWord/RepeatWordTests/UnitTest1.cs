using System;
using Xunit;
using static RepeatWord.Program;
using HashTables.Classes;

namespace RepeatWordTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnNull()
        {
            Assert.Null(RepeatWordMethod("The cheese was great"));
        }

        [Fact]
        public void CanFindWord()
        {
            Assert.Equal("the", RepeatWordMethod("The cheese was only better than the wine."));
        }

        [Fact]
        public void CanFindNumbers()
        {
            Assert.Equal("9", RepeatWordMethod("1 2 3 4 5 9 6 7 8 9"));
        }
    }
}
