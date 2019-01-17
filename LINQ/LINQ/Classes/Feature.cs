using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Classes
{
    public enum FeatureType { Feature };

    public class Feature
    {
        public FeatureType Type { get; set; }

        public Geometry Geometry { get; set; }

        public Properties Properties { get; set; }
    }
}
