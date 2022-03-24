using DotNetTDDKata;
using FluentAssertions;
using System;
using Xunit;

namespace DotNetTDDKataTest
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(100)]
        [InlineData(50)]
        [InlineData(115)]
        [InlineData(97)]
        public void GiveExpectedCount(int count)
        {
            //arrange

            var fizzBuzz = new FizzBuzz();

            //act
            var result = fizzBuzz.Play(count);

            //assert
            result.Should().HaveCount(count);
        }



        [Theory]
        [InlineData(100, 2, 4, 14)]
        [InlineData(100, 5, 9, 29)]
        [InlineData(100, 8, 19, 59)]
        [InlineData(100, 17, 39, 89)]
        public void GiveFizzBuzzInExpectedIndex(int count, int fizzIndex, int buzzIndex, int fizzBuzzIndex)
        {
            //arrange

            var fizzBuzz = new FizzBuzz();

            //act
            var result = fizzBuzz.Play(count);

            //assert
            result[fizzIndex].Should().Be(FizzBuzz.Fizz);
            result[buzzIndex].Should().Be(FizzBuzz.Buzz);
            result[fizzBuzzIndex].Should().Be($"{FizzBuzz.Fizz}{FizzBuzz.Buzz}");

        }

        [Theory]
        [InlineData(100, 12, "13")]
        [InlineData(100, 15, "16")]
        [InlineData(100, 55, "56")]
        public void GiveTrueNumberInExpectedIndex(int count, int expectedIndex, string trueNumber)
        {
            //arrange

            var fizzBuzz = new FizzBuzz();

            //act
            var result = fizzBuzz.Play(count);

            //assert
            result[expectedIndex].Should().Be(trueNumber);
        }


        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        [InlineData(-15)]
        [InlineData(-1)]
        public void GiveInvalidNumberThrowArgumentOutOfRangeException(int count)
        {
            //arrange

            var fizzBuzz = new FizzBuzz();

            //act
            var action = () => fizzBuzz.Play(count);

            //assert
            action.Should()
                .Throw<ArgumentOutOfRangeException>();
        }
    }
}