using System;
namespace PMLib.Shapes
{
    /// <summary>
    /// Quadrilateral design based without factoring whether it'll be a regular or irregular 
    /// quadrilateral and the only expected types will be either a square or rectangle.
    /// </summary>
    /// <remarks>
    /// 4. Define Quadrilateral (allowing for square or rectangle)
    /// Area, Perimeter, and Name automatically updated upon accessing properties.
    /// Methods could be added to explicitly set Area and Perimeter properties if requirements
    /// called for not having them automatically updated.
    /// </remarks>
    public class Quadrilateral : IShape
    {
        private static int instances = 0;

        /// <summary>
        /// Instance count
        /// </summary>
        public static int Instances { get { return instances; } }

        public string? Name { get { return DetermineName(); } }

        public double Area { get { return CalculateArea(); } }
        public double Perimeter { get { return CalculatePerimeter(); } }

        public double Width { get; set; }
        public double Length { get; set; }


        public Quadrilateral()
        {
            instances++;
        }

        private double CalculateArea() {
            return Width * Length;
        }

        private double CalculatePerimeter() {
            return (Width + Length) * 2;
        }

        private string DetermineName() {
            return
                (Width == Length) ? "Square" :
                "Rectangle";
        }


	}
}

