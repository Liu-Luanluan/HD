using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace HD
{
    public class HDInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "HD";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return Properties.Resources.HDIcon;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "让你的工作更加简洁，高效 (O ^ ~ ^ O) ";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("eba924d8-1abb-49f1-abcb-e7518fd69c55");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "HD医疗健康建筑设计研究中心";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "1458923113@qq.com";
            }
        }
        public override string Version
        {
            get
            {
                return "0.0.0.1";
            }
        }
    }
}
