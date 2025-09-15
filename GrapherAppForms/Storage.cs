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
    private const double N = 1000;
    private const double T = 20;
    private const double h = T/N;
    private const double k = 0.5;

     
    public static List<Function> FunctionsList =
        [
            new TrigFunction(function: Math.Sin,
                             xStart: -4*Math.PI,
                             xEnd: 4*Math.PI,
                             step: Math.PI/10,
                             title: "y = sin(x)",
                             subtitle: "subtitle"),

            new LineFunction(function: (x) => x * x,
                             title: "y = x^2",
                             subtitle: "Степенная функция"),

            new LineFunction(function: (x) => (1 - k * h) * x,
                             title: "Явная схема"),
            new LineFunction(function: (x) => x / (1 + k * h),
                             title: "Неявная схема"),
            new LineFunction(function: (x) => Math.Exp(-k * (x + h)),
                             title: "Аналитическое решение"),
        ];
}
