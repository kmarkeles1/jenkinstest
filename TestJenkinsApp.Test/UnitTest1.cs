using System;
using Xunit;

namespace TestJenkinsApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello World!", Program.GetText());
        }
    }
}
