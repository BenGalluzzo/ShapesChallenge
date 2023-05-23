using System;
namespace PMLib.Shapes
{
    /// <summary>
    /// Triangle without factoring details of angles.
    /// </summary>
    /// <remarks>
    /// 3. Define Triangle
    /// Area, Perimeter, and Name automatically updated upon accessing properties.
    /// Methods could be added to explicitly set Area and Perimeter properties if requirements
    /// called for not having them automatically updated.
    /// </remarks>
    public class Triangle : IShape
	{
        private static int instances = 0;

        /// <summary>
        /// Instance count
        /// </summary>
        public static int Instances { get { return instances; } }

        public string? Name { get { return DetermineName(); } }

        public double Area { get { return CalculateArea(); } }
        public double Perimeter { get { return CalculatePerimeter(); } }

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }


        public Triangle()
        {
            instances++;
        }

        private double CalculateArea() {
            double halfPerimeter = (SideA + SideB + SideC) / 2.0;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }

        private double CalculatePerimeter() {
            return SideA + SideB + SideC;
        }

        private string DetermineName() {
            return
                (SideA == SideB) && (SideB == SideC) ? "Equilateral" :
                (SideA == SideB) || (SideA == SideC) || (SideB == SideC) ? "Isosceles" :
                "Scalene";
        }


    }
}

