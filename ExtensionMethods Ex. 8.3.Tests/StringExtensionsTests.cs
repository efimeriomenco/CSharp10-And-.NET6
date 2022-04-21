using Xunit;

namespace ExtensionMethods_Ex._8._3.Tests
{
    public class StringExtensionsTests
    {
        [Theory]
        [InlineData(0, "zero")]
        [InlineData(1, "one")]
        [InlineData(2, "two")]
        [InlineData(3, "three")]
        [InlineData(-3, "minus three")]
        [InlineData(1000000, "one million ")]
        [InlineData(2000000000, "two billion ")]
        [InlineData(-1000000000000, "minus one trillion ")]
        [InlineData(324, "three hundred and twenty-four")]
        public void ShouldMatch(long nr, string expectedWord)
        {
            Assert.Equal(expectedWord, nr.ToText());
        }
        
    }
}