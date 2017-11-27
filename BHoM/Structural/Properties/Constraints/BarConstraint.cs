﻿using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH.oM.Structural.Properties
{
    public class BarConstraint : BHoMObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public DOFType TranslationX { get; set; }

        public DOFType TranslationY { get; set; }

        public DOFType TranslationZ { get; set; }

        public DOFType RotationX { get; set; }

        public double StiffnessX { get; set; }

        public double StiffnessY { get; set; }

        public double StiffnessZ { get; set; }

        public double RotationalStiffnessX { get; set; }


        /***************************************************/
        /**** Constructors                              ****/
        /***************************************************/

        public BarConstraint(string name = "") 
        {
            Name = name;
        }
    }

}
