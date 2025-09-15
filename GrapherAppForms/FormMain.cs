using GrapherAppForms.Functions;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace GrapherAppForms
{
    public partial class FormMain : Form
    {
        private readonly PlotModel model = new();
        public FormMain()
        {
            InitializeComponent();

            plotView.Model = model;
            PopulateFunctionsList();
            ChangeModelStyle();

            DisplayDefaultFunction();

            Controls.Add(plotView);
        }



        private void PopulateFunctionsList()
        {
            foreach (var function in Storage.FunctionsList)
                listBox.Items.Add(function.Title);
        }
        private void ChangeModelStyle()
        {
            model.Background = OxyColors.DarkSlateGray;
            model.PlotAreaBackground = OxyColors.DarkSlateGray;
            model.PlotAreaBorderColor = OxyColors.White;
            model.SelectionColor = OxyColors.White;
            model.TitleColor = OxyColors.White;
            model.SubtitleColor = OxyColors.White;
            model.PlotAreaBorderThickness = new OxyThickness(1);
            model.TextColor = OxyColors.WhiteSmoke;
        }
        private void DisplayDefaultFunction()
        {
            var defaultFunction = (Storage.FunctionsList[0]);
            DisplayFunction(defaultFunction);
        }

        private void DisplayFunction(Function function)
        {
            TryEnsureFunctionIsValid(function);
            ClearModel();

            foreach (var axis in function.Axes)
                model.Axes.Add(axis);

            foreach (var annotation in function.Annotations)
                model.Annotations.Add(annotation);

            model.Series.Add(((LineFunction)function).LineSeries);

            model.InvalidatePlot(true);
        }
        private static void TryEnsureFunctionIsValid(Function function)
        {
            try
            {
                EnsureFunctionIsValid(function);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        private static void EnsureFunctionIsValid(Function function)
        {
            if (function is null)
                throw new NullReferenceException();
            if (function is not LineFunction)
                throw new ArgumentException("Tried displaying a function of unknown type", nameof(function));
        }
        private void ClearModel()
        {
            model.Axes.Clear();
            model.Annotations.Clear();
            model.Series.Clear();
        }


        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = listBox.SelectedIndex;
            var selectedFunction = Storage.FunctionsList[selectedIndex];
            DisplayFunction(selectedFunction);
        }
    }
}
