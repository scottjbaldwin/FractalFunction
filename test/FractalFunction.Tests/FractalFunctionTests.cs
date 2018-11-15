using FractalFunction;
using System;
using Xunit;

namespace FractalFunctionTests
{
    public class FractalFunctionTests
    {
        [Fact]
        public void BasicTest()
        {
            // Arrange
            var m = new Mandelbrot();

            // Act
            var area = m.CalculateArea(50, 0.0, 0.0, 1.0, 1.0, 50, 50);

            // Assert
            Assert.Equal(50, area.Count);
            foreach(var row in area)
            {
                Assert.Equal(50, row.Count);
            }
            
        }
    }
}
