using FluentAssertions;

namespace StringCalculator.UnitTests
{
    public class StringCalculatorUnitTests
    {
        [Theory]
        [InlineData("")]
        public void Add_WhenEmptyString_ShouldReturnZero(string numbers)
        {
            var sut = new Domain.StringCalculator();

            var result = sut.Add(numbers);

            result.Should().Be(0);
        }

        [Fact]
        public void Add_WhenStringIsNull_ShouldReturnZero()
        {
            var sut = new Domain.StringCalculator();

            var result = sut.Add(null);

            result.Should().Be(0);
        }

        [Theory]
        [InlineData("1,2,3")]
        public void Add_WhenMoreThenTwoNumbers_ShouldThrowArgumentException(string numbers)
        {
            var sut = new Domain.StringCalculator();

            Action add = () => sut.Add(numbers);

            add.Should().Throw<ArgumentException>().WithMessage($"*numbers*");
        }

        [Theory]
        [InlineData("1,,1")]
        public void Add_WhenCosecutiveCommas_ShouldThrowArgumentException(string numbers)
        {
            var sut = new Domain.StringCalculator();

            Action add = () => sut.Add(numbers);

            add.Should().Throw<ArgumentException>().WithMessage($"*numbers*");
        }

        [Theory]
        [InlineData("1,a")]
        public void Add_WhenContainsNonNumber_ShouldThrowArgumentException(string numbers)
        {
            var sut = new Domain.StringCalculator();

            Action add = () => sut.Add(numbers);

            add.Should().Throw<ArgumentException>().WithMessage($"*numbers*");
        }

        [Theory]
        [InlineData("1, 3")]
        public void Add_WhenValidInput_ReturnsSum(string numbers)
        {
            var sut = new Domain.StringCalculator();

            var result = sut.Add(numbers);

            result.Should().Be(4);
        }
    }
}