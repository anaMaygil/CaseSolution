using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caseSolution
{
    public class BillClass
    {
        public string locale { get; set; }
        public string description { get; set; }

        public Vertices boundingPoly { get; set; }
    }

    public class Vertices
    {
        public List<Coordinates> vertices { get; set; }

    }

    public class Coordinates
    {
        public string x{ get; set; }
        public string y{ get; set; }

    }

}
