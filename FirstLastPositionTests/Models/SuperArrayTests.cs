using System.Collections.Generic;
using FirstLastPositionDomain.Models;
using Xunit;

namespace FirstLastPositionTests.Models
{
    public class SuperArrayTests
    {
        [Fact]
        public void SearchRange_Should_Returns_Correct_Indices()
        {
            var nums = new [] { 5, 7, 7, 8, 8, 10 };
            var target = 7;
            var result = SuperArray.SearchRange(nums, target);
            var expectedResult = new List<int> { 1, 2 };

            Assert.Equal(result, expectedResult);
        }
    }
}