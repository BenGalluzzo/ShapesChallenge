using System.Text.Json;
using PMLib.Data.JSON;
using PMLib.Shapes;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("------- Shapes Challenge -------");
Console.WriteLine();

// 7. (part 1) - Setup to demonstrate there are currently no instances of Triangle
Console.WriteLine("Triangle objects created: {0}", Triangle.Instances.ToString());
Console.WriteLine();

IShape mCircle = new Circle() { Radius = 7 };
IShape mTriangle = new Triangle() { SideA = 10, SideB = 15, SideC = 17 };
IShape mSquare = new Quadrilateral() { Width = 10, Length = 10 };
IShape mRectangle = new Quadrilateral() { Width = 10, Length = 15 };

List<IShape> mShapes = new List<IShape>();
mShapes.Add(mCircle);
mShapes.Add(mTriangle);
mShapes.Add(mSquare);
mShapes.Add(mRectangle);


// 5. Sort collection of Shapes by Areaa or Perimeter.
Console.WriteLine("-- Shapes List: Default Order --");
foreach (IShape mShape in mShapes)
{
    Console.WriteLine("{0,10} - Area: {1,9:N3}, Perimeter: {2,7:N3}", mShape.Name, mShape.Area, mShape.Perimeter);
}

//  So many ways to do this: "Sort" sorts it in place, not preserving original sort, whereas  
//  OrderBy makes a sorted copy, preserving the original sort. Requirements might affect
//  which type is used.
//  If there were many fields and/or many unknown fields to sort by, I would use a dynamic  
//  method of determining how it could be sorted.
//  I would also add either an extension method or enhance the classes to have the dynamic
//  sort capabilities built-in
//
//  A couple of examples. 
//  ...mShapes.OrderBy(item => item.Area).ToList();
//  ...SortBy(mShapes, x => x.Area);

ShapesSorting.SortShapes(mShapes, "Area");
Console.WriteLine();
Console.WriteLine("-- Shapes List: Sorted By Area --");
foreach (IShape mShape in mShapes)
{
    Console.WriteLine("{0,10} - Area: {1,9:N3}, Perimeter: {2,7:N3}", mShape.Name, mShape.Area, mShape.Perimeter);
}

// 7. Keep track of shape objects created (per class).
Console.WriteLine();
Console.WriteLine("Triangle objects created: {0}", Triangle.Instances.ToString());
IShape mTriangle2 = new Triangle() { SideA = 10, SideB = 15, SideC = 17 };
Console.WriteLine("Triangle objects created: {0}", Triangle.Instances.ToString());
Console.WriteLine("Circle objects created: {0}", Circle.Instances.ToString());
Console.WriteLine();

// 6. Serialize shapes to JSON and save to disk
Console.WriteLine();
Console.WriteLine("Saving Shapes list to json");
Export.ExportShapes("shapes.json", mShapes);
Console.WriteLine();

Console.Write("Press any key to continue...");
Console.ReadKey();

