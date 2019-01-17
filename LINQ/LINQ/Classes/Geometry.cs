using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Classes
{
    public enum GeometryType { Point };

    public class Geometry
    {
        public GeometryType Type { get; set; }

        public List<double> Coordinates { get; set; }
    }
}
