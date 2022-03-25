using DotNetTDDKata;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace DotNetTDDKataTest
{
    public class EvenOddTest
    {
        private EvenOrOdd _evenOrOdd;

        public EvenOddTest()
        {
            _evenOrOdd = new EvenOrOdd();
        }

        [Theory]
        [InlineData(new int[] {0}, EvenOdd.Even)] 
        [InlineData(new int[] { 2, 5, 34, 6}, EvenOdd.Odd)]
        [InlineData(new int[] { 0, -1, -5 }, EvenOdd.Even)]
        public void GetExpectedResultPerList(IEnumerable<int> numbers, EvenOdd expectedType)
        {
            //act
            var result = _evenOrOdd.GetEvenOddtype(numbers);
            
            //assert
            result.Should().Be(expectedType);
        }

    }
}