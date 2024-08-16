using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.FSharp.Collections;
using InterpreterLib;

public partial class Form1 : Form
{
    private double slope;
    private double intercept;
    private List<Tuple<string, double>> symbolTable = new List<Tuple<string, double>>();

    public Form1()
    {
        InitializeComponent();
    }

    private void btnEvaluate_Click(object sender, EventArgs e)
    {
        try
        {
            string expression = txtExpression.Text;
            var tokens = Interpreter.lexer(expression).ToList();

            // Convert List<Interpreter.terminal> to FSharpList<Interpreter.terminal>
            var fsharpTokens = ListModule.OfSeq(tokens);

            // Convert List<Tuple<string, double>> to FSharpList<Tuple<string, double>>
            var symbolTableFSharp = ListModule.OfSeq(symbolTable);

            // Evaluate expression
            var result = Interpreter.parseNeval(fsharpTokens, symbolTableFSharp);
            lblResult.Text = $"Result: {result.Item2}";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void btnDrawLine_Click(object sender, EventArgs e)
    {
        try
        {
            slope = double.Parse(txtSlope.Text);
            intercept = double.Parse(txtIntercept.Text);
            DrawLine(slope, intercept);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Invalid input for slope or intercept.");
        }
    }

    private void DrawLine(double slope, double intercept)
    {
        if (pictureBoxCanvas.Image == null)
        {
            pictureBoxCanvas.Image = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
        }

        using (Graphics g = Graphics.FromImage(pictureBoxCanvas.Image))
        {
            g.Clear(Color.White); // Clear previous drawings

            Pen pen = new Pen(Color.Black, 2);

            int width = pictureBoxCanvas.Width;
            int height = pictureBoxCanvas.Height;

            PointF startPoint = new PointF(0, (float)(slope * 0 + intercept));
            PointF endPoint = new PointF(width, (float)(slope * width + intercept));

            startPoint.Y = Clamp(startPoint.Y, 0, height);
            endPoint.Y = Clamp(endPoint.Y, 0, height);

            g.DrawLine(pen, startPoint, endPoint);

            pictureBoxCanvas.Refresh();
        }
    }

    private float Clamp(float value, float min, float max)
    {
        if (value < min) return min;
        if (value > max) return max;
        return value;
    }
}
