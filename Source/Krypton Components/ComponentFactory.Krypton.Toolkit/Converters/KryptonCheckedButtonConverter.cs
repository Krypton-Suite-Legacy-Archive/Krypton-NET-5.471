﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;

namespace ComponentFactory.Krypton.Toolkit
{
    internal class KryptonCheckedButtonConverter : ReferenceConverter
    {
        #region Identity
        /// <summary>
        /// Initialize a new instance of the KryptonCheckedButtonConverter class.
        /// </summary>
        public KryptonCheckedButtonConverter()
            : base(typeof(KryptonCheckButton))
        {
        }
        #endregion

        #region Protected Overrides
        /// <summary>
        /// Returns a value indicating whether a particular value can be added to the standard values collection.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that provides an additional context.</param>
        /// <param name="value">The value to check.</param>
        /// <returns></returns>
        protected override bool IsValueAllowed(ITypeDescriptorContext context, object value)
        {
            // Get access to the check set component that owns the property

            // Just in case the converter is used on a different type of component
            if (context.Instance is KryptonCheckSet checkSet)
            {
                // We only allow check buttons inside the check set definition
                return checkSet.CheckButtons.Contains(value as KryptonCheckButton);
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
