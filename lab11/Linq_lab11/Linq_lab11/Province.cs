using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_lab11
{
    class Province
    {
        public string pName { get; set; }
        public int nCase { get; set; }
        public int oCase { get; set; }
        public string pRegion { get; set; }
        public Province() { }
        public Province(string name, int newCases, int oldCases, string
       region)
        {
            this.pName = name;
            this.nCase = newCases;
            this.oCase = oldCases;
            this.pRegion = region;
        }

    }
}
