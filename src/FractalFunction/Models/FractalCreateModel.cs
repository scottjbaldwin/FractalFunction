namespace FractalFunction.Models
{
    public class FractalCreateModel
    {
        public int Iterations { get; set; }
        public double BottomLeftX { get; set; }
        public double BottomLeftY { get; set; }
        public double TopRightX { get; set; }
        public double TopRightY { get; set; }
        public int Steps {get; set;}
    }
}