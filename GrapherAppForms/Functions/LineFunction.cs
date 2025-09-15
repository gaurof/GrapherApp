using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrapherAppForms.Functions;

public class LineFunction : Function
{
    public FunctionSeries LineSeries { get; set; }

    public LineFunction(Func<double, double> function,
                        double xStart = -10,
                        double xEnd = 10,
                        double step = 0.1,
                        string title = "", 
                        string subtitle = "") 
        : base(title, subtitle)
    {

        LineSeries = new(f: function,
                         x0: xStart,
                         x1: xEnd,
                         dx: step);
    }
}
