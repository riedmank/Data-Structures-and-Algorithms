using System;
using Xunit;
using static HashTables.Program;
using LinkedList.Classes;
using HashTables.Classes;

namespace HashTablesTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Determines whether this instance [can insert into hash table].
        /// </summary>
        [Fact]
        public void CanInsertIntoHashTable()
        {
            HashTable HT = new HashTable();
            HT.Add("vampire", "alp");

            Assert.Equal("vampire: alp", HT.Find("vampire"));
        }

        /// <summary>
        /// Determines whether this instance [can use contains method].
        /// </summary>
        [Fact]
        public void CanUseContainsMethod()
        {
            HashTable HT = new HashTable();
            HT.Add("vampire", "bruxa");

            Assert.True(HT.Contains("vampire"));
        }

        /// <summary>
        /// Determines whether this instance [can use contains method with collision].
        /// </summary>
        [Fact]
        public void CanUseContainsMethodWithCollision()
        {
            HashTable HT = new HashTable();
            HT.Add("rats", "fleder");
            HT.Add("stars", "garkain");

            Assert.True(HT.Contains("rats"));
        }

        /// <summary>
        /// Determines whether this instance [can find on hash table with collision].
        /// </summary>
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
