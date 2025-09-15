
using OxyPlot.Series;
using OxyPlot;

namespace GrapherAppForms;

partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        plotView = new OxyPlot.WindowsForms.PlotView();
        listBox = new ListBox();
        SuspendLayout();
        // 
        // plotView
        // 
        plotView.BackColor = SystemColors.WindowFrame;
        plotView.Dock = DockStyle.Fill;
        plotView.Location = new Point(175, 10);
        plotView.Name = "plotView";
        plotView.Padding = new Padding(150, 0, 0, 0);
        plotView.PanCursor = Cursors.Hand;
        plotView.Size = new Size(624, 415);
        plotView.TabIndex = 0;
        plotView.Text = "plotView";
        plotView.ZoomHorizontalCursor = Cursors.SizeWE;
        plotView.ZoomRectangleCursor = Cursors.SizeNWSE;
        plotView.ZoomVerticalCursor = Cursors.SizeNS;
        // 
        // listBox
        // 
        listBox.BackColor = Color.DarkSlateGray;
        listBox.BorderStyle = BorderStyle.None;
        listBox.Font = new Font("Segoe UI", 20F);
        listBox.ForeColor = Color.WhiteSmoke;
        listBox.FormattingEnabled = true;
        listBox.ItemHeight = 37;
        listBox.Location = new Point(12, 12);
        listBox.Name = "listBox";
        listBox.Size = new Size(155, 407);
        listBox.TabIndex = 1;
        listBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.DarkSlateGray;
        ClientSize = new Size(809, 435);
        Controls.Add(listBox);
        Controls.Add(plotView);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "FormMain";
        Padding = new Padding(175, 10, 10, 10);
        Text = "Grapher";
        ResumeLayout(false);
    }

    #endregion

    private OxyPlot.WindowsForms.PlotView plotView;
    private ListBox listBox;
}
