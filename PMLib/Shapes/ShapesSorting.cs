using System;

namespace PMLib.Shapes
{

    /// <summary>
    /// Shape sorting features
    /// </summary>
	public static class ShapesSorting
	{
            /// <summary>
            /// Sorts List of Shapes by use of "Sort" method. 
            /// </summary>
            /// <param name="mShapes"></param>
            /// <param name="_sortField"></param>
            public static void SortShapes(List<IShape> mShapes, string _sortField)
            {
                switch (_sortField)
                {
                    case "Area":
                        mShapes.Sort((x, y) => x.Area.CompareTo((y.Area)));
                        break;
                    case "Perimeter":
                        mShapes.Sort((x, y) => x.Area.CompareTo((y.Perimeter)));
                        break;
                }

            }


        /// <summary>
        /// Sorts List of Shapes by use of "OrderBy" method. Example option for sorting
        /// </summary>
        /// <param name="_list"></param>
        /// <param name="_property"></param>
        /// <returns></returns>
        public static List<IShape>? SortBy(List<IShape> _list, Func<IShape, IComparable> _property)
            {

                if (_list != null && _list.Count > 0)
                {
                    return _list.OrderBy(x => _property(x)).ToList();
                }
                return null;
            }


	}
}

