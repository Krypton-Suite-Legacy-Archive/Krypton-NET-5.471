﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.ComponentModel.Design;

namespace ComponentFactory.Krypton.Ribbon
{
	internal class KryptonRibbonRecentDocCollectionEditor : CollectionEditor
	{
		/// <summary>
        /// Initialize a new instance of the KryptonRibbonRecentDocCollectionEditor class.
		/// </summary>
        public KryptonRibbonRecentDocCollectionEditor()
            : base(typeof(KryptonRibbonRecentDocCollection))
		{
		}

		/// <summary>
		/// Gets the data types that this collection editor can contain. 
		/// </summary>
		/// <returns>An array of data types that this collection can contain.</returns>
		protected override Type[] CreateNewItemTypes()
		{
            return new Type[] { typeof(KryptonRibbonRecentDoc) };
		}
	}
}