using Algorithms.Implementation;

namespace AlgorithmsTest.Implementation
{
    public class TimeConversionTest
    {
        [Fact]
        public void Test()
        {
            var result = TimeConversion.timeConversion("07:05:45PM");
            Assert.Equal("19:05:45", result);
        }
    }
}
