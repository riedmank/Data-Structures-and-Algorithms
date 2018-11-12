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

        [Fact]
        public void CanUseContainsMethodWithCollision()
        {
            HashTable HT = new HashTable();
            HT.Add("rats", "fleder");
            HT.Add("stars", "garkain");

            Assert.True(HT.Contains("rats"));
        }

        [Fact]
        public void CanFindOnHashTableWithCollision()
        {
            HashTable HT = new HashTable();
            HT.Add("rats", "katakan");
            HT.Add("stars", "ekimmara");

            Assert.Equal("stars: ekimmara", HT.Find("stars"));
        }
    }
}
