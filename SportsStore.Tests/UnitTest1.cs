using System;
using Xunit;
using sportstore;

namespace SportsStore.Tests
{
    public class sportstoreTests
    {
        [Fact]
        public void TestThing()
        {
            Assert.Equal(42, new Thing().Get(19,23));
        }
    }
}
