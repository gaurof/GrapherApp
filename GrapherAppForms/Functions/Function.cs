using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Reflection;

namespace GrapherAppForms.Functions;

public abstract class Function(string title = "", string subtitle = "")
{

    public string Title { get; init; } = title;
    public string Subtitle { get; init; } = subtitle;
    public virtual List<Axis> Axes { get; init; } = 
    [
        new LinearAxis
        {
            Position = AxisPosition.Bottom,
            Title = "X Axis",
            MajorStep = 1,
            MajorGridlineStyle = LineStyle.Automatic,
            AxislineColor = OxyColors.White,
            AxislineStyle = LineStyle.Solid

        },
        new LinearAxis
        {
            Position = AxisPosition.Right,
            Title = "Y Axis",
            MajorStep = 1,
            MajorGridlineStyle = LineStyle.Automatic,
            AxislineColor = OxyColors.White,
            AxislineStyle = LineStyle.Solid
        }
    ];
    public virtual List<Annotation> Annotations { get; set; } = 
    [
        new LineAnnotation()
        {
            Type = LineAnnotationType.Horizontal,
            Y = 0,
            Color = OxyColors.OrangeRed,
            Text = "X Axis"

        },
        new LineAnnotation()
        {
            Type = LineAnnotationType.Vertical,
            X = 0,
            Color = OxyColors.DarkOliveGreen,
            Text = "Y Axis"
        }
    ];

}
