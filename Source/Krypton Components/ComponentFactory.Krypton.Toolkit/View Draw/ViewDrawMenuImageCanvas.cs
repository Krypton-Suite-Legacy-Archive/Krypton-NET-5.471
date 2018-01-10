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
using System.Drawing;
using System.Diagnostics;

namespace ComponentFactory.Krypton.Toolkit
{
    internal class ViewDrawMenuImageCanvas : ViewDrawCanvas, IContextMenuItemColumn
	{
		#region Instance Fields

	    private int _overridePreferredWidth;
        private readonly bool _zeroHeight;
        #endregion

		#region Identity
        /// <summary>
        /// Initialize a new instance of the ViewDrawMenuImageCanvas class.
		/// </summary>
		/// <param name="paletteBack">Palette source for the background.</param>		
		/// <param name="paletteBorder">Palette source for the border.</param>
        /// <param name="columnIndex">Menu item column index.</param>
        /// <param name="zeroHeight">Should the height be forced to zero.</param>
        public ViewDrawMenuImageCanvas(IPaletteBack paletteBack,
							           IPaletteBorder paletteBorder,
                                       int columnIndex,
                                       bool zeroHeight)
            : base(paletteBack, paletteBorder, VisualOrientation.Top)
		{
            ColumnIndex = columnIndex;
            _overridePreferredWidth = 0;
            _zeroHeight = zeroHeight;
        }

		/// <summary>
		/// Obtains the String representation of this instance.
		/// </summary>
		/// <returns>User readable name of the instance.</returns>
		public override string ToString()
		{
			// Return the class name and instance identifier
			return "ViewDrawMenuCanvas:" + Id;
		}
        #endregion

		#region Layout
        /// <summary>
        /// Discover the preferred size of the element.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override Size GetPreferredSize(ViewLayoutContext context)
        {
            Debug.Assert(context != null);

            Size preferredSize = base.GetPreferredSize(context);

            if (_overridePreferredWidth != 0)
            {
                preferredSize.Width = _overridePreferredWidth;
            }
            else
            {
                LastPreferredSize = base.GetPreferredSize(context);
            }

            if (_zeroHeight)
            {
                preferredSize.Height = 0;
            }

            return preferredSize;
        }
        #endregion

        #region IContextMenuItemColumn
        /// <summary>
        /// Gets the index of the column within the menu item.
        /// </summary>
        public int ColumnIndex { get; }

	    /// <summary>
        /// Gets the last calculated preferred size value.
        /// </summary>
        public Size LastPreferredSize { get; private set; }

	    /// <summary>
        /// Sets the preferred width value to use until further notice.
        /// </summary>
        public int OverridePreferredWidth
        {
            set => _overridePreferredWidth = value;
	    }
        #endregion

        #region Layout
        /// <summary>
        /// Perform a layout of the elements.
        /// </summary>
        /// <param name="context">Layout context.</param>
        public override void Layout(ViewLayoutContext context)
        {
            Debug.Assert(context != null);

            // Validate incoming reference
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            base.Layout(context);
        }
        #endregion

        #region Paint
        /// <summary>
        /// Perform rendering before child elements are rendered.
        /// </summary>
        /// <param name="context">Rendering context.</param>
        public override void RenderBefore(RenderContext context)
        {
            Debug.Assert(context != null);

            // Validate incoming reference
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            base.RenderBefore(context);
        }
        #endregion

	}
}