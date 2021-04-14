using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HD
{
    public class MyCategoryIcon : Grasshopper.Kernel.GH_AssemblyPriority    {        public override Grasshopper.Kernel.GH_LoadingInstruction PriorityLoad()        {            Grasshopper.Instances.ComponentServer.AddCategoryIcon("HD", Properties.Resources.HDIcon);            Grasshopper.Instances.ComponentServer.AddCategoryShortName("HD", "H");            Grasshopper.Instances.ComponentServer.AddCategorySymbolName("HD", 'H');            return Grasshopper.Kernel.GH_LoadingInstruction.Proceed;        }    }
}
