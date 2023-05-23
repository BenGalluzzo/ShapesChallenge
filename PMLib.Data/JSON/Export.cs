using System;
using System.Text.Json;
using PMLib.Shapes;

namespace PMLib.Data.JSON
{
	public class Export
	{
        /// <summary>
        /// Using the Microsoft System.Text.Json options.  I also really like using what
        /// Newtonsoft product library offers
        /// </summary>
        /// <param name="_fileName"></param>
        /// <param name="_shapes"></param>
		public static void ExportShapes(string _fileName, List<IShape> _shapes)
		{
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var jsonString = JsonSerializer.Serialize(_shapes, options);

            using (var writer = new StreamWriter(_fileName, false))
            {
                writer.Write(jsonString);
            }
        }


	}

}

