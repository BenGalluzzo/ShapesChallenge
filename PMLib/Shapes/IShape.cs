using System;
namespace PMLib.Shapes
{
	/// <summary>
	/// IShape interface for uniform management of shapes.
	/// </summary>
	/// <remarks>
	///	1. Define shape interface
	/// </remarks>
	public interface IShape
	{
		/// <summary>
		/// Number of objects created.
		/// </summary>
		public static int Instances { get; }

        public string? Name { get; }

		public double Area { get; }
		public double Perimeter { get; }


	}
}

