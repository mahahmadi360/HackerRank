using Algorithms.Implementation;

namespace AlgorithmsTest.Implementation
{
    public class BiggerIsGreaterTest
    {
        [Theory]
        [InlineData("l", "no answer")]
        [InlineData("lmno", "lmon")]
        [InlineData("dcba", "no answer")]
        [InlineData("dcbb", "no answer")]
        [InlineData("abdc", "acbd")]
        [InlineData("abcd", "abdc")]
        [InlineData("fedcbabcd", "fedcbabdc")]
        public void Test(string testCase, string expectedResult)
        {
            var result = BiggerIsGreater.biggerIsGreater(testCase);

            Assert.Equal(expectedResult,result );
        }
    }
}
