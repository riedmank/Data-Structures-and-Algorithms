using System;
using Xunit;
using static HashTables.Program;
using LinkedList.Classes;
using HashTables.Classes;

namespace HashTablesTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInsertIntoHashTable()
        {
            HashTable HT = new HashTable();
            HT.Add("vampire", "alp");

            Assert.Equal("vampire: alp", HT.Find("vampire"));
        }

        [Fact]
        public void CanUseContainsMethod()
        {
            HashTable HT = new HashTable();
            HT.Add("vampire", "bruxa");

            Assert.True(HT.Contains("vampire"));
        }
    }
}
