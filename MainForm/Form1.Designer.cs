using System.Windows.Forms;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private TextBox txtExpression;
    private Button btnEvaluate;
    private Label lblResult;
    private PictureBox pictureBoxCanvas;
    private TextBox txtSlope;
    private TextBox txtIntercept;
    private Button btnDrawLine;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.txtExpression = new System.Windows.Forms.TextBox();
        this.btnEvaluate = new System.Windows.Forms.Button();
        this.lblResult = new System.Windows.Forms.Label();
        this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
        this.txtSlope = new System.Windows.Forms.TextBox();
        this.txtIntercept = new System.Windows.Forms.TextBox();
        this.btnDrawLine = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
        this.SuspendLayout();

        // 
        // txtExpression
        // 
        this.txtExpression.Location = new System.Drawing.Point(12, 12);
        this.txtExpression.Name = "txtExpression";
        this.txtExpression.Size = new System.Drawing.Size(200, 20);
        this.txtExpression.TabIndex = 0;

        // 
        // btnEvaluate
        // 
        this.btnEvaluate.Location = new System.Drawing.Point(218, 10);
        this.btnEvaluate.Name = "btnEvaluate";
        this.btnEvaluate.Size = new System.Drawing.Size(75, 23);
        this.btnEvaluate.TabIndex = 1;
        this.btnEvaluate.Text = "Evaluate";
        this.btnEvaluate.UseVisualStyleBackColor = true;
        this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);

        // 
        // lblResult
        // 
        this.lblResult.AutoSize = true;
        this.lblResult.Location = new System.Drawing.Point(299, 15);
        this.lblResult.Name = "lblResult";
        this.lblResult.Size = new System.Drawing.Size(37, 13);
        this.lblResult.TabIndex = 2;
        this.lblResult.Text = "Result:";

        // 
        // pictureBoxCanvas
        // 
        this.pictureBoxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pictureBoxCanvas.Location = new System.Drawing.Point(12, 50);
        this.pictureBoxCanvas.Name = "pictureBoxCanvas";
        this.pictureBoxCanvas.Size = new System.Drawing.Size(400, 300);
        this.pictureBoxCanvas.TabIndex = 3;
        this.pictureBoxCanvas.TabStop = false;

        // 
        // txtSlope
        // 
        this.txtSlope.Location = new System.Drawing.Point(12, 360);
        this.txtSlope.Name = "txtSlope";
        this.txtSlope.Size = new System.Drawing.Size(100, 20);
        this.txtSlope.TabIndex = 4;

        // 
        // txtIntercept
        // 
        this.txtIntercept.Location = new System.Drawing.Point(118, 360);
        this.txtIntercept.Name = "txtIntercept";
        this.txtIntercept.Size = new System.Drawing.Size(100, 20);
        this.txtIntercept.TabIndex = 5;

        // btnDrawLine
        this.btnDrawLine.Location = new System.Drawing.Point(224, 358);
        this.btnDrawLine.Name = "btnDrawLine";
        this.btnDrawLine.Size = new System.Drawing.Size(75, 23);
        this.btnDrawLine.TabIndex = 6;
        this.btnDrawLine.Text = "Draw Line";
        this.btnDrawLine.UseVisualStyleBackColor = true;
        this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);

        // Form1 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(424, 391);
        this.Controls.Add(this.btnDrawLine);
        this.Controls.Add(this.txtIntercept);
        this.Controls.Add(this.txtSlope);
        this.Controls.Add(this.pictureBoxCanvas);
        this.Controls.Add(this.lblResult);
        this.Controls.Add(this.btnEvaluate);
        this.Controls.Add(this.txtExpression);
        this.Name = "Form1";
        this.Text = "Math Expression Evaluator";
        ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
