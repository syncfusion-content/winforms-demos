#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        { 
            #region ApplyCustomPalette
            chart.Skins = Skins.Metro;
            #endregion

            #region Chart Appearance Customization

           chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes Customization
           chart.PrimaryXAxis.DrawGrid = false;
           chart.ChartArea.AxisSpacing = new SizeF(20, 20);

            chart.PrimaryXAxis.IntervalType = ChartDateTimeIntervalType.Days;
            chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;            
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 600, 100);

            chart.PrimaryXAxis.DateTimeFormat = "dd-MMM-yy";
            chart.Text = "Product Manufactured by Work Shift";
            chart.PrimaryYAxis.Title = "Total Products";

            #endregion

            #region Legend Customization
            for (int i = 0; i < chart.Legend.Items.Length; i++)
            {
                chart.Legend.Items[i].Spacing = 2;
                chart.Legend.ItemsSize = new Size(13, 13);
                chart.Legend.Items[i].TextAligment = VerticalAlignment.Bottom;
                chart.Legend.BackColor = Color.Transparent;
                chart.LegendsPlacement = ChartPlacement.Outside;
                chart.LegendAlignment = ChartAlignment.Center;
                chart.LegendPosition = ChartDock.Bottom;
                chart.Legend.Font = new Font("Segoe UI", 10.25f);
            }
            #endregion
        }
    }
}