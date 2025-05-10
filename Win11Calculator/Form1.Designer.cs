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
        panel1 = new Panel();
        txtInput = new TextBox();
        EquationLabel = new Label();
        BtnZero = new Button();
        BtnThree = new Button();
        BtnEquals = new Button();
        BtnAdd = new Button();
        BtnSix = new Button();
        BtnFive = new Button();
        BtnFour = new Button();
        BtnMinus = new Button();
        BtnNine = new Button();
        BtnEight = new Button();
        BtnSeven = new Button();
        BtnMultiply = new Button();
        Btn1 = new Button();
        BtnTwo = new Button();
        BtnDivide = new Button();
        BtnCE = new Button();
        BtnPoint = new Button();
        BtnNegate = new Button();
        BtnClear = new Button();
        BtnBack = new Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(txtInput);
        panel1.Controls.Add(EquationLabel);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Margin = new Padding(6);
        panel1.Name = "panel1";
        panel1.Size = new Size(750, 254);
        panel1.TabIndex = 0;
        // 
        // txtInput
        // 
        txtInput.BackColor = SystemColors.ControlLightLight;
        txtInput.BorderStyle = BorderStyle.None;
        txtInput.Font = new Font("Segoe UI", 26F);
        txtInput.Location = new Point(3, 143);
        txtInput.Multiline = true;
        txtInput.Name = "txtInput";
        txtInput.ReadOnly = true;
        txtInput.Size = new Size(744, 115);
        txtInput.TabIndex = 2;
        txtInput.Text = "0";
        txtInput.TextAlign = HorizontalAlignment.Right;
        // 
        // EquationLabel
        // 
        EquationLabel.Dock = DockStyle.Top;
        EquationLabel.Location = new Point(0, 0);
        EquationLabel.Margin = new Padding(6, 0, 6, 0);
        EquationLabel.Name = "EquationLabel";
        EquationLabel.Size = new Size(750, 113);
        EquationLabel.TabIndex = 0;
        EquationLabel.TextAlign = ContentAlignment.BottomRight;
        // 
        // BtnZero
        // 
        BtnZero.Location = new Point(188, 1041);
        BtnZero.Margin = new Padding(6);
        BtnZero.Name = "BtnZero";
        BtnZero.Size = new Size(186, 192);
        BtnZero.TabIndex = 2;
        BtnZero.Text = "0";
        BtnZero.UseVisualStyleBackColor = true;
        BtnZero.Click += NumZeroBtn_Click;
        // 
        // BtnThree
        // 
        BtnThree.Location = new Point(375, 849);
        BtnThree.Margin = new Padding(6);
        BtnThree.Name = "BtnThree";
        BtnThree.Size = new Size(186, 192);
        BtnThree.TabIndex = 3;
        BtnThree.Text = "3";
        BtnThree.UseVisualStyleBackColor = true;
        BtnThree.Click += button_click;
        // 
        // BtnEquals
        // 
        BtnEquals.Location = new Point(563, 1041);
        BtnEquals.Margin = new Padding(6);
        BtnEquals.Name = "BtnEquals";
        BtnEquals.Size = new Size(186, 192);
        BtnEquals.TabIndex = 4;
        BtnEquals.Text = "=";
        BtnEquals.UseVisualStyleBackColor = true;
        BtnEquals.Click += BtnEquals_Click;
        // 
        // BtnAdd
        // 
        BtnAdd.Location = new Point(563, 849);
        BtnAdd.Margin = new Padding(6);
        BtnAdd.Name = "BtnAdd";
        BtnAdd.Size = new Size(186, 192);
        BtnAdd.TabIndex = 8;
        BtnAdd.Text = "+";
        BtnAdd.UseVisualStyleBackColor = true;
        BtnAdd.Click += BtnAdd_Click;
        // 
        // BtnSix
        // 
        BtnSix.Location = new Point(375, 655);
        BtnSix.Margin = new Padding(6);
        BtnSix.Name = "BtnSix";
        BtnSix.Size = new Size(186, 192);
        BtnSix.TabIndex = 7;
        BtnSix.Text = "6";
        BtnSix.UseVisualStyleBackColor = true;
        BtnSix.Click += button_click;
        // 
        // BtnFive
        // 
        BtnFive.Location = new Point(188, 655);
        BtnFive.Margin = new Padding(6);
        BtnFive.Name = "BtnFive";
        BtnFive.Size = new Size(186, 192);
        BtnFive.TabIndex = 6;
        BtnFive.Text = "5";
        BtnFive.UseVisualStyleBackColor = true;
        BtnFive.Click += button_click;
        // 
        // BtnFour
        // 
        BtnFour.Location = new Point(0, 655);
        BtnFour.Margin = new Padding(6);
        BtnFour.Name = "BtnFour";
        BtnFour.Size = new Size(186, 192);
        BtnFour.TabIndex = 5;
        BtnFour.Text = "4";
        BtnFour.UseVisualStyleBackColor = true;
        BtnFour.Click += button_click;
        // 
        // BtnMinus
        // 
        BtnMinus.Location = new Point(563, 655);
        BtnMinus.Margin = new Padding(6);
        BtnMinus.Name = "BtnMinus";
        BtnMinus.Size = new Size(186, 192);
        BtnMinus.TabIndex = 12;
        BtnMinus.Text = "-";
        BtnMinus.UseVisualStyleBackColor = true;
        BtnMinus.Click += BtnMinus_Click;
        // 
        // BtnNine
        // 
        BtnNine.Location = new Point(375, 461);
        BtnNine.Margin = new Padding(6);
        BtnNine.Name = "BtnNine";
        BtnNine.Size = new Size(186, 192);
        BtnNine.TabIndex = 11;
        BtnNine.Text = "9";
        BtnNine.UseVisualStyleBackColor = true;
        BtnNine.Click += button_click;
        // 
        // BtnEight
        // 
        BtnEight.Location = new Point(188, 461);
        BtnEight.Margin = new Padding(6);
        BtnEight.Name = "BtnEight";
        BtnEight.Size = new Size(186, 192);
        BtnEight.TabIndex = 10;
        BtnEight.Text = "8";
        BtnEight.UseVisualStyleBackColor = true;
        BtnEight.Click += button_click;
        // 
        // BtnSeven
        // 
        BtnSeven.Location = new Point(0, 461);
        BtnSeven.Margin = new Padding(6);
        BtnSeven.Name = "BtnSeven";
        BtnSeven.Size = new Size(186, 192);
        BtnSeven.TabIndex = 9;
        BtnSeven.Text = "7";
        BtnSeven.UseVisualStyleBackColor = true;
        BtnSeven.Click += button_click;
        // 
        // BtnMultiply
        // 
        BtnMultiply.Location = new Point(563, 461);
        BtnMultiply.Margin = new Padding(6);
        BtnMultiply.Name = "BtnMultiply";
        BtnMultiply.Size = new Size(186, 192);
        BtnMultiply.TabIndex = 16;
        BtnMultiply.Text = "*";
        BtnMultiply.UseVisualStyleBackColor = true;
        BtnMultiply.Click += BtnMultiply_Click;
        // 
        // Btn1
        // 
        Btn1.Location = new Point(0, 849);
        Btn1.Margin = new Padding(6);
        Btn1.Name = "Btn1";
        Btn1.Size = new Size(186, 192);
        Btn1.TabIndex = 17;
        Btn1.Text = "1";
        Btn1.UseVisualStyleBackColor = true;
        Btn1.Click += button_click;
        // 
        // BtnTwo
        // 
        BtnTwo.Location = new Point(188, 849);
        BtnTwo.Margin = new Padding(6);
        BtnTwo.Name = "BtnTwo";
        BtnTwo.Size = new Size(186, 192);
        BtnTwo.TabIndex = 18;
        BtnTwo.Text = "2";
        BtnTwo.UseVisualStyleBackColor = true;
        BtnTwo.Click += button_click;
        // 
        // BtnDivide
        // 
        BtnDivide.Location = new Point(0, 267);
        BtnDivide.Margin = new Padding(6);
        BtnDivide.Name = "BtnDivide";
        BtnDivide.Size = new Size(186, 192);
        BtnDivide.TabIndex = 22;
        BtnDivide.Text = "/";
        BtnDivide.UseVisualStyleBackColor = true;
        BtnDivide.Click += DivideBtn_Click;
        // 
        // BtnCE
        // 
        BtnCE.Location = new Point(188, 267);
        BtnCE.Margin = new Padding(6);
        BtnCE.Name = "BtnCE";
        BtnCE.Size = new Size(186, 192);
        BtnCE.TabIndex = 20;
        BtnCE.Text = "CE";
        BtnCE.UseVisualStyleBackColor = true;
        BtnCE.Click += BtnCE_Click;
        // 
        // BtnPoint
        // 
        BtnPoint.Location = new Point(375, 1041);
        BtnPoint.Margin = new Padding(6);
        BtnPoint.Name = "BtnPoint";
        BtnPoint.Size = new Size(186, 192);
        BtnPoint.TabIndex = 23;
        BtnPoint.Text = ".";
        BtnPoint.UseVisualStyleBackColor = true;
        BtnPoint.Click += BtnPoint_Click;
        // 
        // BtnNegate
        // 
        BtnNegate.Location = new Point(0, 1041);
        BtnNegate.Margin = new Padding(6);
        BtnNegate.Name = "BtnNegate";
        BtnNegate.Size = new Size(186, 192);
        BtnNegate.TabIndex = 24;
        BtnNegate.Text = "+/-";
        BtnNegate.UseVisualStyleBackColor = true;
        // 
        // BtnClear
        // 
        BtnClear.Location = new Point(375, 267);
        BtnClear.Margin = new Padding(6);
        BtnClear.Name = "BtnClear";
        BtnClear.Size = new Size(186, 192);
        BtnClear.TabIndex = 25;
        BtnClear.Text = "C";
        BtnClear.UseVisualStyleBackColor = true;
        // 
        // BtnBack
        // 
        BtnBack.Location = new Point(565, 267);
        BtnBack.Margin = new Padding(6);
        BtnBack.Name = "BtnBack";
        BtnBack.Size = new Size(186, 192);
        BtnBack.TabIndex = 26;
        BtnBack.Text = "<-";
        BtnBack.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(750, 1239);
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
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Location = new Point(15, 15);
        Margin = new Padding(6);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Basic Calculator";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
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

    private System.Windows.Forms.Label EquationLabel;

    private System.Windows.Forms.Panel panel1;

    #endregion

    private TextBox txtInput;
}