using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ.Classes
{
    public enum City { NewYork };

    public enum State { Ny };

    public enum Borough { Manhattan };

    public enum County { NewYorkCounty };

    public class Properties
    {
        public long Zip { get; set; }

        public City City { get; set; }

        public State State { get; set; }

        public string Address { get; set; }

        public Borough Borough { get; set; }

        public string Neighborhood { get; set; }

        public County County { get; set; }
    }
}
