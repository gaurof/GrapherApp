using GrapherAppForms.Functions;
using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GrapherAppForms;

internal static class Storage
{
    public static List<Function> FunctionsList = 
        [
            new TrigFunction(function: Math.Sin, 
                             xStart: -4*Math.PI, 
                             xEnd: 4*Math.PI, 
                             step: Math.PI/10, 
                             title: "y = sin(x)",
                             subtitle: "subtitle"),
        ];
}
