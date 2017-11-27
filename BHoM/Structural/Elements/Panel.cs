﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.Structural.Properties;

namespace BH.oM.Structural.Elements
{
    /// <summary>
    /// BH.oM panel class - a planar surface object with a list of 'edges' (curves with properties) for both external and internal edges (openings)
    /// </summary>
    [Serializable]
    public class Panel : BH.oM.Base.BHoMObject, IAreaElement
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public List<Edge> InternalEdges = new List<Edge>();
        public List<Edge> ExpernalEdges = new List<Edge>();
        public PanelProperty PanelProperty { get; set; } = new ConstantThickness();      

        /***************************************************/
        /**** Constructors                              ****/
        /***************************************************/

        /// <summary>
        /// Constructs an empty panel
        /// </summary>
        public Panel() { }
   
        /***************************************************/   

    }
}
       