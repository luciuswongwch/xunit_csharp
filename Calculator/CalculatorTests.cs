using Domain;
using FluentAssertions;

namespace CalculatorTest
{
    public class CalculatorTests
    {
        [Fact]
        public void Sum_of_2_and_2_should_be_4()
        {
            var calculator = new Calculator();
            var result = calculator.Sum(2, 2);
            /*
            if (result != 4)
            {
                throw new Exception($"The Sum(2,2) was expected to be 4 but it's {result}.");
            }
            */
            // Nuget packages fluent assertions
            result.Should().Be(4);
        }

        [Fact]
        public void Sum_of_3_and_3_should_be_6()
            => new Calculator()
                .Sum(3, 3)
                .Should().Be(6);
    }
}