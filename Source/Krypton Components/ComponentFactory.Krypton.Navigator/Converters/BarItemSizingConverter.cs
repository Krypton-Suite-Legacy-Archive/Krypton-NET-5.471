﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2018. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.1.0 	www.ComponentFactory.com
// *****************************************************************************

using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Navigator
{
    /// <summary>
    /// Custom type converter so that BarItemSizing values appear as neat text at design time.
    /// </summary>
    public class BarItemSizingConverter : StringLookupConverter
    {
        #region Static Fields

        #endregion
                                             
        #region Identity
        /// <summary>
        /// Initialize a new instance of the BarItemSizingConverter clas.
        /// </summary>
        public BarItemSizingConverter()
            : base(typeof(BarItemSizing))
        {
        }
        #endregion

        #region Protected
        /// <summary>
        /// Gets an array of lookup pairs.
        /// </summary>
        protected override Pair[] Pairs { get; } =
        { new Pair(BarItemSizing.Individual,           "Individual Sizing"),
            new Pair(BarItemSizing.SameHeight,           "All Same Height"),
            new Pair(BarItemSizing.SameWidth,            "All Same Width"),
            new Pair(BarItemSizing.SameWidthAndHeight,   "All Same Width & Height") };

        #endregion
    }
}
