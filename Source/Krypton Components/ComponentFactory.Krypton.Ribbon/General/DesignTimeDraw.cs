﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd, modifications by Peter Wagner (aka Wagnerp) & Simon Coghlan (aka Smurf-IV) 2010 - 2018. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-4.7)
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.7.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
    internal class DesignTimeDraw
    {
        #region Statis Fields

        private const int DESIGN_FLAP_WIDTH = 12;
        private const int DESIGN_SEP_WIDTH = 6;

        #endregion

        #region FlapWidth
        /// <summary>
        /// Gets the width of the design time flap.
        /// </summary>
        public static int FlapWidth => DESIGN_FLAP_WIDTH;

        #endregion

        #region SepWidth
        /// <summary>
        /// Gets the width of the design time separation.
        /// </summary>
        public static int SepWidth => DESIGN_SEP_WIDTH;

        #endregion

        #region DrawArea
        /// <summary>
        /// Draw a design area with a flap on the left hand edge.
        /// </summary>
        /// <param name="ribbon">Reference to owning ribbon control.</param>
        /// <param name="context">Rendering context.</param>
        /// <param name="clientRect">Client rectangle of the source view.</param>
        /// <param name="state">State of element.</param>
        public static void DrawArea(KryptonRibbon ribbon,
                                    RenderContext context,
                                    Rectangle clientRect,
                                    PaletteState state)
        {
            Color c;

            if (state == PaletteState.Normal)
            {
                c = ribbon.StateCommon.RibbonGeneral.GetRibbonGroupSeparatorDark(PaletteState.Normal);
            }
            else
            {
                c = ribbon.StateCommon.RibbonGroupButton.Back.GetBackColor1(PaletteState.Tracking);
            }

            // Draw entire area in color
            using (SolidBrush darkBrush = new SolidBrush(c))
            {
                context.Graphics.FillRectangle(darkBrush, clientRect);
            }
        }
        #endregion
 
        #region DrawFlapArea
        /// <summary>
        /// Draw a design area with a flap on the left hand edge.
        /// </summary>
        /// <param name="ribbon">Reference to owning ribbon control.</param>
        /// <param name="context">Rendering context.</param>
        /// <param name="clientRect">Client rectangle of the source view.</param>
        /// <param name="state">State of element.</param>
        public static void DrawFlapArea(KryptonRibbon ribbon,
                                        RenderContext context,
                                        Rectangle clientRect,
                                        PaletteState state)
        {
            Color c;

            if (state == PaletteState.Normal)
            {
                c = ControlPaint.Dark(ribbon.StateCommon.RibbonGeneral.GetRibbonGroupSeparatorDark(PaletteState.Normal));
            }
            else
            {
                c = ribbon.StateCommon.RibbonGroupButton.Back.GetBackColor1(PaletteState.Tracking);
            }

            // Draw border around entire area
            Rectangle drawRect = clientRect;
            drawRect.Width -= DESIGN_SEP_WIDTH;
            drawRect.Height--;
            drawRect.X++;
            using (Pen darkPen = new Pen(c))
            {
                context.Graphics.DrawRectangle(darkPen, drawRect);
            }

            // Draw the flap in the dark color
            drawRect.Width = DESIGN_FLAP_WIDTH - 2;
            using (SolidBrush darkBrush = new SolidBrush(c))
            {
                context.Graphics.FillRectangle(darkBrush, drawRect);
            }
        }
        #endregion
    }
}