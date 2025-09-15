using OxyPlot.Axes;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapherAppForms.Functions;

public class TrigFunction(Func<double, double> function,
                   double xStart = -10,
                   double xEnd = 10,
                   double step = 0.1,
                   string title = "",
                   string subtitle = "")
    : LineFunction(function, xStart, xEnd, step, title, subtitle)
{
    public override List<Axis> Axes { get; init; } =
    [
        new LinearAxis
        {
            Position = AxisPosition.Bottom,
            Title = "X Axis",
            MajorStep = Math.PI,
            FractionUnit = Math.PI,
            FractionUnitSymbol = "π",
            MajorGridlineStyle = LineStyle.Automatic,
            AxislineColor = OxyColors.White,
            AxislineStyle = LineStyle.Solid

        },
        new LinearAxis
        {
            Position = AxisPosition.Right,
            Title = "Y Axis",
            MajorGridlineStyle = LineStyle.Automatic,
            AxislineColor = OxyColors.White,
            AxislineStyle = LineStyle.Solid
        }
    ];
}
