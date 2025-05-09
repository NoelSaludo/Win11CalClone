namespace Win11Calculator;

partial class Form1
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        panel1 = new System.Windows.Forms.Panel();
        InputLabel = new System.Windows.Forms.Label();
        EquationLabel = new System.Windows.Forms.Label();
        BtnZero = new System.Windows.Forms.Button();
        BtnThree = new System.Windows.Forms.Button();
        BtnEquals = new System.Windows.Forms.Button();
        BtnAdd = new System.Windows.Forms.Button();
        BtnSix = new System.Windows.Forms.Button();
        BtnFive = new System.Windows.Forms.Button();
        BtnFour = new System.Windows.Forms.Button();
        BtnMinus = new System.Windows.Forms.Button();
        BtnNine = new System.Windows.Forms.Button();
        BtnEight = new System.Windows.Forms.Button();
        BtnSeven = new System.Windows.Forms.Button();
        BtnMultiply = new System.Windows.Forms.Button();
        Btn1 = new System.Windows.Forms.Button();
        BtnTwo = new System.Windows.Forms.Button();
        BtnDivide = new System.Windows.Forms.Button();
        BtnCE = new System.Windows.Forms.Button();
        BtnPoint = new System.Windows.Forms.Button();
        BtnNegate = new System.Windows.Forms.Button();
        BtnClear = new System.Windows.Forms.Button();
        BtnBack = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(InputLabel);
        panel1.Controls.Add(EquationLabel);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(404, 119);
        panel1.TabIndex = 0;
        // 
        // InputLabel
        // 
        InputLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
        InputLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
        InputLabel.Location = new System.Drawing.Point(0, 53);
        InputLabel.Name = "InputLabel";
        InputLabel.Size = new System.Drawing.Size(404, 66);
        InputLabel.TabIndex = 1;
        InputLabel.Text = "0";
        InputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        InputLabel.Click += InputLabel_Click;
        // 
        // EquationLabel
        // 
        EquationLabel.Dock = System.Windows.Forms.DockStyle.Top;
        EquationLabel.Location = new System.Drawing.Point(0, 0);
        EquationLabel.Name = "EquationLabel";
        EquationLabel.Size = new System.Drawing.Size(404, 53);
        EquationLabel.TabIndex = 0;
        EquationLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
        // 
        // BtnZero
        // 
        BtnZero.Location = new System.Drawing.Point(101, 488);
        BtnZero.Name = "BtnZero";
        BtnZero.Size = new System.Drawing.Size(100, 90);
        BtnZero.TabIndex = 2;
        BtnZero.Text = "0";
        BtnZero.UseVisualStyleBackColor = true;
        BtnZero.Click += NumZeroBtn_Click;
        // 
        // BtnThree
        // 
        BtnThree.Location = new System.Drawing.Point(202, 398);
        BtnThree.Name = "BtnThree";
        BtnThree.Size = new System.Drawing.Size(100, 90);
        BtnThree.TabIndex = 3;
        BtnThree.Text = "3";
        BtnThree.UseVisualStyleBackColor = true;
        BtnThree.Click += BtnThree_Click;
        // 
        // BtnEquals
        // 
        BtnEquals.Location = new System.Drawing.Point(303, 488);
        BtnEquals.Name = "BtnEquals";
        BtnEquals.Size = new System.Drawing.Size(100, 90);
        BtnEquals.TabIndex = 4;
        BtnEquals.Text = "=";
        BtnEquals.UseVisualStyleBackColor = true;
        BtnEquals.Click += BtnEquals_Click;
        // 
        // BtnAdd
        // 
        BtnAdd.Location = new System.Drawing.Point(303, 398);
        BtnAdd.Name = "BtnAdd";
        BtnAdd.Size = new System.Drawing.Size(100, 90);
        BtnAdd.TabIndex = 8;
        BtnAdd.Text = "+";
        BtnAdd.UseVisualStyleBackColor = true;
        BtnAdd.Click += BtnAdd_Click;
        // 
        // BtnSix
        // 
        BtnSix.Location = new System.Drawing.Point(202, 307);
        BtnSix.Name = "BtnSix";
        BtnSix.Size = new System.Drawing.Size(100, 90);
        BtnSix.TabIndex = 7;
        BtnSix.Text = "6";
        BtnSix.UseVisualStyleBackColor = true;
        BtnSix.Click += BtnSix_Click;
        // 
        // BtnFive
        // 
        BtnFive.Location = new System.Drawing.Point(101, 307);
        BtnFive.Name = "BtnFive";
        BtnFive.Size = new System.Drawing.Size(100, 90);
        BtnFive.TabIndex = 6;
        BtnFive.Text = "5";
        BtnFive.UseVisualStyleBackColor = true;
        BtnFive.Click += BtnFive_Click;
        // 
        // BtnFour
        // 
        BtnFour.Location = new System.Drawing.Point(0, 307);
        BtnFour.Name = "BtnFour";
        BtnFour.Size = new System.Drawing.Size(100, 90);
        BtnFour.TabIndex = 5;
        BtnFour.Text = "4";
        BtnFour.UseVisualStyleBackColor = true;
        BtnFour.Click += BtnFour_Click;
        // 
        // BtnMinus
        // 
        BtnMinus.Location = new System.Drawing.Point(303, 307);
        BtnMinus.Name = "BtnMinus";
        BtnMinus.Size = new System.Drawing.Size(100, 90);
        BtnMinus.TabIndex = 12;
        BtnMinus.Text = "-";
        BtnMinus.UseVisualStyleBackColor = true;
        BtnMinus.Click += BtnMinus_Click;
        // 
        // BtnNine
        // 
        BtnNine.Location = new System.Drawing.Point(202, 216);
        BtnNine.Name = "BtnNine";
        BtnNine.Size = new System.Drawing.Size(100, 90);
        BtnNine.TabIndex = 11;
        BtnNine.Text = "9";
        BtnNine.UseVisualStyleBackColor = true;
        BtnNine.Click += BtnNine_Click;
        // 
        // BtnEight
        // 
        BtnEight.Location = new System.Drawing.Point(101, 216);
        BtnEight.Name = "BtnEight";
        BtnEight.Size = new System.Drawing.Size(100, 90);
        BtnEight.TabIndex = 10;
        BtnEight.Text = "8";
        BtnEight.UseVisualStyleBackColor = true;
        BtnEight.Click += BtnEight_Click;
        // 
        // BtnSeven
        // 
        BtnSeven.Location = new System.Drawing.Point(0, 216);
        BtnSeven.Name = "BtnSeven";
        BtnSeven.Size = new System.Drawing.Size(100, 90);
        BtnSeven.TabIndex = 9;
        BtnSeven.Text = "7";
        BtnSeven.UseVisualStyleBackColor = true;
        BtnSeven.Click += BtnSeven_Click;
        // 
        // BtnMultiply
        // 
        BtnMultiply.Location = new System.Drawing.Point(303, 216);
        BtnMultiply.Name = "BtnMultiply";
        BtnMultiply.Size = new System.Drawing.Size(100, 90);
        BtnMultiply.TabIndex = 16;
        BtnMultiply.Text = "*";
        BtnMultiply.UseVisualStyleBackColor = true;
        BtnMultiply.Click += BtnMultiply_Click;
        // 
        // Btn1
        // 
        Btn1.Location = new System.Drawing.Point(0, 398);
        Btn1.Name = "Btn1";
        Btn1.Size = new System.Drawing.Size(100, 90);
        Btn1.TabIndex = 17;
        Btn1.Text = "1";
        Btn1.UseVisualStyleBackColor = true;
        Btn1.Click += BtnOne_Click;
        // 
        // BtnTwo
        // 
        BtnTwo.Location = new System.Drawing.Point(101, 398);
        BtnTwo.Name = "BtnTwo";
        BtnTwo.Size = new System.Drawing.Size(100, 90);
        BtnTwo.TabIndex = 18;
        BtnTwo.Text = "2";
        BtnTwo.UseVisualStyleBackColor = true;
        BtnTwo.Click += BtnTwo_Click;
        // 
        // BtnDivide
        // 
        BtnDivide.Location = new System.Drawing.Point(0, 125);
        BtnDivide.Name = "BtnDivide";
        BtnDivide.Size = new System.Drawing.Size(100, 90);
        BtnDivide.TabIndex = 22;
        BtnDivide.Text = "/";
        BtnDivide.UseVisualStyleBackColor = true;
        BtnDivide.Click += DivideBtn_Click;
        // 
        // BtnCE
        // 
        BtnCE.Location = new System.Drawing.Point(101, 125);
        BtnCE.Name = "BtnCE";
        BtnCE.Size = new System.Drawing.Size(100, 90);
        BtnCE.TabIndex = 20;
        BtnCE.Text = "CE";
        BtnCE.UseVisualStyleBackColor = true;
        BtnCE.Click += BtnCE_Click;
        // 
        // BtnPoint
        // 
        BtnPoint.Location = new System.Drawing.Point(202, 488);
        BtnPoint.Name = "BtnPoint";
        BtnPoint.Size = new System.Drawing.Size(100, 90);
        BtnPoint.TabIndex = 23;
        BtnPoint.Text = ".";
        BtnPoint.UseVisualStyleBackColor = true;
        BtnPoint.Click += BtnPoint_Click;
        // 
        // BtnNegate
        // 
        BtnNegate.Location = new System.Drawing.Point(0, 488);
        BtnNegate.Name = "BtnNegate";
        BtnNegate.Size = new System.Drawing.Size(100, 90);
        BtnNegate.TabIndex = 24;
        BtnNegate.Text = "+/-";
        BtnNegate.UseVisualStyleBackColor = true;
        // 
        // BtnClear
        // 
        BtnClear.Location = new System.Drawing.Point(202, 125);
        BtnClear.Name = "BtnClear";
        BtnClear.Size = new System.Drawing.Size(100, 90);
        BtnClear.TabIndex = 25;
        BtnClear.Text = "C";
        BtnClear.UseVisualStyleBackColor = true;
        // 
        // BtnBack
        // 
        BtnBack.Location = new System.Drawing.Point(304, 125);
        BtnBack.Name = "BtnBack";
        BtnBack.Size = new System.Drawing.Size(100, 90);
        BtnBack.TabIndex = 26;
        BtnBack.Text = "<-";
        BtnBack.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(404, 581);
        Controls.Add(BtnBack);
        Controls.Add(BtnClear);
        Controls.Add(BtnNegate);
        Controls.Add(BtnPoint);
        Controls.Add(BtnDivide);
        Controls.Add(BtnCE);
        Controls.Add(BtnTwo);
        Controls.Add(Btn1);
        Controls.Add(BtnMultiply);
        Controls.Add(BtnMinus);
        Controls.Add(BtnNine);
        Controls.Add(BtnEight);
        Controls.Add(BtnSeven);
        Controls.Add(BtnAdd);
        Controls.Add(BtnSix);
        Controls.Add(BtnFive);
        Controls.Add(BtnFour);
        Controls.Add(BtnEquals);
        Controls.Add(BtnThree);
        Controls.Add(BtnZero);
        Controls.Add(panel1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Location = new System.Drawing.Point(15, 15);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Basic Calculator";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button BtnBack;

    private System.Windows.Forms.Button BtnClear;

    private System.Windows.Forms.Button BtnPoint;
    private System.Windows.Forms.Button BtnNegate;

    private System.Windows.Forms.Button BtnDivide;
    private System.Windows.Forms.Button BtnCE;

    private System.Windows.Forms.Button BtnTwo;

    private System.Windows.Forms.Button BtnZero;
    private System.Windows.Forms.Button BtnThree;
    private System.Windows.Forms.Button BtnEquals;
    private System.Windows.Forms.Button BtnAdd;
    private System.Windows.Forms.Button BtnSix;
    private System.Windows.Forms.Button BtnFive;
    private System.Windows.Forms.Button BtnFour;
    private System.Windows.Forms.Button BtnMinus;
    private System.Windows.Forms.Button BtnNine;
    private System.Windows.Forms.Button BtnEight;
    private System.Windows.Forms.Button BtnSeven;
    private System.Windows.Forms.Button BtnMultiply;

    private System.Windows.Forms.Button Btn1;

    private System.Windows.Forms.Label InputLabel;

    private System.Windows.Forms.Label EquationLabel;

    private System.Windows.Forms.Panel panel1;

    #endregion
}