﻿using Audiometry.ViewModel.PureToneVM.Audiogram.Marker;
using Audiometry.ViewModel.PureToneVM.PureToneAMData;
using OxyPlot;
using OxyPlot.Series;

namespace Audiometry.ViewModel.PureToneVM.Audiogram
{
    public sealed class BoneCondUmskPlot : AudiogramPlot
    {
        protected override LineSeries AddLineSeries(EarType earType, bool isNoResponse)
        {
            LineSeries lineSeries = new LineSeries();
            SetCommonValues(earType, lineSeries);
            lineSeries.MarkerType = MarkerType.Custom;
            lineSeries.MarkerOutline = BCUmskMarker.CreateCustomMarker(earType, isNoResponse);
            lineSeries.LineStyle = isNoResponse ? LineStyle.None : LineStyle.Dash;

            return lineSeries;
        }
    }
}
