﻿using System;
using System.Collections.Generic;

using Grasshopper.Kernel;
using Rhino.Geometry;
using GH_IO.Serialization;
using Rhino;
using HD.Properties;

namespace HD
{
    namespace L_Math
    {
        public class Hello : GH_Component
        {
            /// <summary>
            /// Initializes a new instance of the Hello class.
            /// </summary>
            public Hello()
              : base("Hello", "Hello",
                  "Hello",
                  "HD", "02.Math")
            {
            }

            /// <summary>
            /// Registers all the input parameters for this component.
            /// </summary>
            protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
            {
            }

            /// <summary>
            /// Registers all the output parameters for this component.
            /// </summary>
            protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
            {
            }

            /// <summary>
            /// This is the method that actually does the work.
            /// </summary>
            /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
            protected override void SolveInstance(IGH_DataAccess DA)
            {
            }

            /// <summary>
            /// Provides an Icon for the component.
            /// </summary>
            protected override System.Drawing.Bitmap Icon
            {
                get
                {
                    //You can add image files to your project resources and access them like this:
                    // return Resources.IconForThisComponent;
                    return null;
                }
            }

            /// <summary>
            /// Gets the unique ID for this component. Do not change this ID after release.
            /// </summary>
            public override Guid ComponentGuid
            {
                get { return new Guid("9bca82d0-862b-4050-9453-7a947bc9cbd6"); }
            }
            public override GH_Exposure Exposure
            {
                get
                {
                    return GH_Exposure.primary;
                }
            }
        }
    }
}