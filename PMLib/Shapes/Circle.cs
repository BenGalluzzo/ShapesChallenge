using System;
namespace PMLib.Shapes
{
    /// <summary>
    /// Standard circle.  
    /// </summary>
    /// <remarks>
    /// 2. Define Circle.
    /// Area and Perimeter automatically updated upon accessing properties.
    /// Methods could be added to explicitly set Area and Perimeter properties if requirements
    /// called for not having them automatically updated.
    /// </remarks>
    public class Circle : IShape
    {
        private static int instances = 0;

        /// <summary>
        /// Instance count
        /// </summary>
        public static int Instances { get { return instances; } }

        public string? Name { get { return "Circle"; } }

        public double Area { get { return CalculateArea(); } }
        public double Perimeter { get { return CalculatePerimeter(); } }

        public double Radius { get; set; }


        public Circle()
        {
            instances++;
        }

        private double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        private double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }


    }
}

