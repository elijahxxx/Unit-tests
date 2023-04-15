using Xunit;
using System;
using Math;

namespace MathTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        [Theory]
        [InlineData(1, 0, 1, double.NaN, double.NaN)]
        [InlineData(1, 0, 0, 0, double.NaN)]
        [InlineData(1, -3, 2, 1, 2)]
        void TestSolve(double a, double b, double c, double expectedX1, double expectedX2)
        {
            // Arrange

            // Act
            QuadraticEquationSolver.Solve(a, b, c, out double x1, out double x2);

            // Assert
            Assert.Equal(expectedX1, x1, 15);
            Assert.Equal(expectedX2, x2, 15);
        }
    }
}