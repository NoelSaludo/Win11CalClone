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
        txtInput = new System.Windows.Forms.TextBox();
        lblEquation = new System.Windows.Forms.Label();
        btn0 = new System.Windows.Forms.Button();
        btn3 = new System.Windows.Forms.Button();
        btnEqual = new System.Windows.Forms.Button();
        btnAdd = new System.Windows.Forms.Button();
        btn6 = new System.Windows.Forms.Button();
        btn5 = new System.Windows.Forms.Button();
        btn4 = new System.Windows.Forms.Button();
        btnMinus = new System.Windows.Forms.Button();
        btn9 = new System.Windows.Forms.Button();
        btn8 = new System.Windows.Forms.Button();
        btn7 = new System.Windows.Forms.Button();
        btnMultiply = new System.Windows.Forms.Button();
        btn1 = new System.Windows.Forms.Button();
        btn2 = new System.Windows.Forms.Button();
        btnDivide = new System.Windows.Forms.Button();
        btnCE = new System.Windows.Forms.Button();
        btnPoint = new System.Windows.Forms.Button();
        btnNegate = new System.Windows.Forms.Button();
        btnClear = new System.Windows.Forms.Button();
        btnBack = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(txtInput);
        panel1.Controls.Add(lblEquation);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Margin = new System.Windows.Forms.Padding(6);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(751, 254);
        panel1.TabIndex = 0;
        // 
        // txtInput
        // 
        txtInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
        txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
        txtInput.Font = new System.Drawing.Font("Segoe UI", 26F);
        txtInput.Location = new System.Drawing.Point(3, 143);
        txtInput.Multiline = true;
        txtInput.Name = "txtInput";
        txtInput.ReadOnly = true;
        txtInput.Size = new System.Drawing.Size(744, 115);
        txtInput.TabIndex = 2;
        txtInput.Text = "0";
        txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        // 
        // lblEquation
        // 
        lblEquation.Dock = System.Windows.Forms.DockStyle.Top;
        lblEquation.Location = new System.Drawing.Point(0, 0);
        lblEquation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        lblEquation.Name = "lblEquation";
        lblEquation.Size = new System.Drawing.Size(751, 113);
        lblEquation.TabIndex = 0;
        lblEquation.TextAlign = System.Drawing.ContentAlignment.BottomRight;
        // 
        // btn0
        // 
        btn0.Location = new System.Drawing.Point(189, 989);
        btn0.Margin = new System.Windows.Forms.Padding(6);
        btn0.Name = "btn0";
        btn0.Size = new System.Drawing.Size(186, 192);
        btn0.TabIndex = 2;
        btn0.Text = "0";
        btn0.UseVisualStyleBackColor = true;
        btn0.Click += button_click;
        // 
        // btn3
        // 
        btn3.Location = new System.Drawing.Point(376, 797);
        btn3.Margin = new System.Windows.Forms.Padding(6);
        btn3.Name = "btn3";
        btn3.Size = new System.Drawing.Size(186, 192);
        btn3.TabIndex = 3;
        btn3.Text = "3";
        btn3.UseVisualStyleBackColor = true;
        btn3.Click += button_click;
        // 
        // btnEqual
        // 
        btnEqual.Location = new System.Drawing.Point(564, 989);
        btnEqual.Margin = new System.Windows.Forms.Padding(6);
        btnEqual.Name = "btnEqual";
        btnEqual.Size = new System.Drawing.Size(186, 192);
        btnEqual.TabIndex = 4;
        btnEqual.Text = "=";
        btnEqual.UseVisualStyleBackColor = true;
        btnEqual.Click += btnEqual_Click;
        // 
        // btnAdd
        // 
        btnAdd.Location = new System.Drawing.Point(564, 797);
        btnAdd.Margin = new System.Windows.Forms.Padding(6);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new System.Drawing.Size(186, 192);
        btnAdd.TabIndex = 8;
        btnAdd.Text = "+";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += operator_click;
        // 
        // btn6
        // 
        btn6.Location = new System.Drawing.Point(376, 603);
        btn6.Margin = new System.Windows.Forms.Padding(6);
        btn6.Name = "btn6";
        btn6.Size = new System.Drawing.Size(186, 192);
        btn6.TabIndex = 7;
        btn6.Text = "6";
        btn6.UseVisualStyleBackColor = true;
        btn6.Click += button_click;
        // 
        // btn5
        // 
        btn5.Location = new System.Drawing.Point(189, 603);
        btn5.Margin = new System.Windows.Forms.Padding(6);
        btn5.Name = "btn5";
        btn5.Size = new System.Drawing.Size(186, 192);
        btn5.TabIndex = 6;
        btn5.Text = "5";
        btn5.UseVisualStyleBackColor = true;
        btn5.Click += button_click;
        // 
        // btn4
        // 
        btn4.Location = new System.Drawing.Point(1, 603);
        btn4.Margin = new System.Windows.Forms.Padding(6);
        btn4.Name = "btn4";
        btn4.Size = new System.Drawing.Size(186, 192);
        btn4.TabIndex = 5;
        btn4.Text = "4";
        btn4.UseVisualStyleBackColor = true;
        btn4.Click += button_click;
        // 
        // btnMinus
        // 
        btnMinus.Location = new System.Drawing.Point(564, 603);
        btnMinus.Margin = new System.Windows.Forms.Padding(6);
        btnMinus.Name = "btnMinus";
        btnMinus.Size = new System.Drawing.Size(186, 192);
        btnMinus.TabIndex = 12;
        btnMinus.Text = "-";
        btnMinus.UseVisualStyleBackColor = true;
        btnMinus.Click += operator_click;
        // 
        // btn9
        // 
        btn9.Location = new System.Drawing.Point(376, 409);
        btn9.Margin = new System.Windows.Forms.Padding(6);
        btn9.Name = "btn9";
        btn9.Size = new System.Drawing.Size(186, 192);
        btn9.TabIndex = 11;
        btn9.Text = "9";
        btn9.UseVisualStyleBackColor = true;
        btn9.Click += button_click;
        // 
        // btn8
        // 
        btn8.Location = new System.Drawing.Point(189, 409);
        btn8.Margin = new System.Windows.Forms.Padding(6);
        btn8.Name = "btn8";
        btn8.Size = new System.Drawing.Size(186, 192);
        btn8.TabIndex = 10;
        btn8.Text = "8";
        btn8.UseVisualStyleBackColor = true;
        btn8.Click += button_click;
        // 
        // btn7
        // 
        btn7.Location = new System.Drawing.Point(1, 409);
        btn7.Margin = new System.Windows.Forms.Padding(6);
        btn7.Name = "btn7";
        btn7.Size = new System.Drawing.Size(186, 192);
        btn7.TabIndex = 9;
        btn7.Text = "7";
        btn7.UseVisualStyleBackColor = true;
        btn7.Click += button_click;
        // 
        // btnMultiply
        // 
        btnMultiply.Location = new System.Drawing.Point(564, 409);
        btnMultiply.Margin = new System.Windows.Forms.Padding(6);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Size = new System.Drawing.Size(186, 192);
        btnMultiply.TabIndex = 16;
        btnMultiply.Text = "*";
        btnMultiply.UseVisualStyleBackColor = true;
        btnMultiply.Click += operator_click;
        // 
        // btn1
        // 
        btn1.Location = new System.Drawing.Point(1, 797);
        btn1.Margin = new System.Windows.Forms.Padding(6);
        btn1.Name = "btn1";
        btn1.Size = new System.Drawing.Size(186, 192);
        btn1.TabIndex = 17;
        btn1.Text = "1";
        btn1.UseVisualStyleBackColor = true;
        btn1.Click += button_click;
        // 
        // btn2
        // 
        btn2.Location = new System.Drawing.Point(189, 797);
        btn2.Margin = new System.Windows.Forms.Padding(6);
        btn2.Name = "btn2";
        btn2.Size = new System.Drawing.Size(186, 192);
        btn2.TabIndex = 18;
        btn2.Text = "2";
        btn2.UseVisualStyleBackColor = true;
        btn2.Click += button_click;
        // 
        // btnDivide
        // 
        btnDivide.Location = new System.Drawing.Point(1, 215);
        btnDivide.Margin = new System.Windows.Forms.Padding(6);
        btnDivide.Name = "btnDivide";
        btnDivide.Size = new System.Drawing.Size(186, 192);
        btnDivide.TabIndex = 22;
        btnDivide.Text = "/";
        btnDivide.UseVisualStyleBackColor = true;
        btnDivide.Click += operator_click;
        // 
        // btnCE
        // 
        btnCE.Location = new System.Drawing.Point(189, 215);
        btnCE.Margin = new System.Windows.Forms.Padding(6);
        btnCE.Name = "btnCE";
        btnCE.Size = new System.Drawing.Size(186, 192);
        btnCE.TabIndex = 20;
        btnCE.Text = "CE";
        btnCE.UseVisualStyleBackColor = true;
        btnCE.Click += btnCE_Click;
        // 
        // btnPoint
        // 
        btnPoint.Location = new System.Drawing.Point(376, 989);
        btnPoint.Margin = new System.Windows.Forms.Padding(6);
        btnPoint.Name = "btnPoint";
        btnPoint.Size = new System.Drawing.Size(186, 192);
        btnPoint.TabIndex = 23;
        btnPoint.Text = ".";
        btnPoint.UseVisualStyleBackColor = true;
        btnPoint.Click += btnPoint_click;
        // 
        // btnNegate
        // 
        btnNegate.Location = new System.Drawing.Point(1, 989);
        btnNegate.Margin = new System.Windows.Forms.Padding(6);
        btnNegate.Name = "btnNegate";
        btnNegate.Size = new System.Drawing.Size(186, 192);
        btnNegate.TabIndex = 24;
        btnNegate.Text = "+/-";
        btnNegate.UseVisualStyleBackColor = true;
        btnNegate.Click += btnNegate_Click;
        // 
        // btnClear
        // 
        btnClear.Location = new System.Drawing.Point(376, 215);
        btnClear.Margin = new System.Windows.Forms.Padding(6);
        btnClear.Name = "btnClear";
        btnClear.Size = new System.Drawing.Size(186, 192);
        btnClear.TabIndex = 25;
        btnClear.Text = "C";
        btnClear.UseVisualStyleBackColor = true;
        btnClear.Click += btnClear_Click;
        // 
        // btnBack
        // 
        btnBack.Location = new System.Drawing.Point(566, 215);
        btnBack.Margin = new System.Windows.Forms.Padding(6);
        btnBack.Name = "btnBack";
        btnBack.Size = new System.Drawing.Size(186, 192);
        btnBack.TabIndex = 26;
        btnBack.Text = "<-";
        btnBack.UseVisualStyleBackColor = true;
        btnBack.Click += btnBack_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(751, 1181);
        Controls.Add(btnBack);
        Controls.Add(btnClear);
        Controls.Add(btnNegate);
        Controls.Add(btnPoint);
        Controls.Add(btnDivide);
        Controls.Add(btnCE);
        Controls.Add(btn2);
        Controls.Add(btn1);
        Controls.Add(btnMultiply);
        Controls.Add(btnMinus);
        Controls.Add(btn9);
        Controls.Add(btn8);
        Controls.Add(btn7);
        Controls.Add(btnAdd);
        Controls.Add(btn6);
        Controls.Add(btn5);
        Controls.Add(btn4);
        Controls.Add(btnEqual);
        Controls.Add(btn3);
        Controls.Add(btn0);
        Controls.Add(panel1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Location = new System.Drawing.Point(15, 15);
        Margin = new System.Windows.Forms.Padding(6);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Basic Calculator";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnBack;

    private System.Windows.Forms.Button btnClear;

    private System.Windows.Forms.Button btnPoint;
    private System.Windows.Forms.Button btnNegate;

    private System.Windows.Forms.Button btnDivide;
    private System.Windows.Forms.Button btnCE;

    private System.Windows.Forms.Button btn2;

    private System.Windows.Forms.Button btn0;
    private System.Windows.Forms.Button btn3;
    private System.Windows.Forms.Button btnEqual;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btn6;
    private System.Windows.Forms.Button btn5;
    private System.Windows.Forms.Button btn4;
    private System.Windows.Forms.Button btnMinus;
    private System.Windows.Forms.Button btn9;
    private System.Windows.Forms.Button btn8;
    private System.Windows.Forms.Button btn7;
    private System.Windows.Forms.Button btnMultiply;

    private System.Windows.Forms.Button btn1;

    private System.Windows.Forms.Label lblEquation;

    private System.Windows.Forms.Panel panel1;

    #endregion

    private TextBox txtInput;
}