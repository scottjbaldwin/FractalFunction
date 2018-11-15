using System;
using System.Collections.Generic;

namespace FractalFunction
{
    public class Mandelbrot
    {
        private static double ROOT_5 = Math.Sqrt(5);

        public List<List<int>> CalculateArea(int iteratoins, double bottomLeftX, double bottomLeftY, double topRightY, double topRightX, int stepX, int stepY)
        {
            double stepSizeY = (topRightY - bottomLeftY)/stepY;
            double stepSizeX = (topRightX - bottomLeftX)/stepX;

            var result = new List<List<int>>(stepX);
            for (int x = 0; x < stepX; x++)
            {
                var row = new List<int>(stepY);
                result.Add(row);
                for (int y = 0; y < stepY; y++)
                {
                    row.Add(CalculatePoint(iteratoins, bottomLeftX + x * stepX, bottomLeftY + y * stepY));
                }
            }

            return result;
        }

        public int CalculatePoint(int iterations, double x, double y)
        {
            double z1 = 0;
            double z2 = 0;
            double result = 0;
            for (int i = 0; i < iterations; i++)
            {
                double z3 = z1*z1 - z2*z2 + x;
                z2 = 2*(z1*z2) + y;
                z1 = z3;
                result = Math.Sqrt(z1 * z1 + z2 * z2);

                if (result > ROOT_5)
                {
                    return i;
                }
            }

            return iterations;
        }
    }
}
