using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGates.Models
{
    public class Gates
    {
        public int gatesSecurityLevel;

        public Gates(int securityLevel)
        {
            gatesSecurityLevel = securityLevel;
        }
    }
}
