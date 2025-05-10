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
        button2 = new System.Windows.Forms.Button();
        button1 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(txtInput);
        panel1.Controls.Add(lblEquation);
        panel1.Dock = System.Windows.Forms.DockStyle.Top;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(452, 186);
        panel1.TabIndex = 0;
        // 
        // txtInput
        // 
        txtInput.BackColor = System.Drawing.Color.GhostWhite;
        txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
        txtInput.Dock = System.Windows.Forms.DockStyle.Bottom;
        txtInput.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtInput.ForeColor = System.Drawing.Color.Indigo;
        txtInput.Location = new System.Drawing.Point(0, 45);
        txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        txtInput.Multiline = true;
        txtInput.Name = "txtInput";
        txtInput.ReadOnly = true;
        txtInput.Size = new System.Drawing.Size(452, 141);
        txtInput.TabIndex = 2;
        txtInput.Text = "0";
        txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        txtInput.TextChanged += txtInput_TextChanged_1;
        // 
        // lblEquation
        // 
        lblEquation.BackColor = System.Drawing.Color.GhostWhite;
        lblEquation.Dock = System.Windows.Forms.DockStyle.Top;
        lblEquation.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblEquation.Location = new System.Drawing.Point(0, 0);
        lblEquation.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
        lblEquation.Name = "lblEquation";
        lblEquation.Size = new System.Drawing.Size(452, 48);
        lblEquation.TabIndex = 0;
        lblEquation.TextAlign = System.Drawing.ContentAlignment.BottomRight;
        lblEquation.Click += lblEquation_Click_1;
        // 
        // btn0
        // 
        btn0.Location = new System.Drawing.Point(270, 1648);
        btn0.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btn0.Name = "btn0";
        btn0.Size = new System.Drawing.Size(266, 320);
        btn0.TabIndex = 2;
        btn0.Text = "0";
        btn0.UseVisualStyleBackColor = true;
        btn0.Click += button_click;
        // 
        // btn3
        // 
        btn3.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)221)), ((int)((byte)244)));
        btn3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btn3.ForeColor = System.Drawing.Color.Indigo;
        btn3.Location = new System.Drawing.Point(228, 510);
        btn3.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btn3.Name = "btn3";
        btn3.Size = new System.Drawing.Size(101, 101);
        btn3.TabIndex = 3;
        btn3.Text = "3";
        btn3.UseVisualStyleBackColor = false;
        btn3.Click += button_click;
        // 
        // btnEqual
        // 
        btnEqual.Location = new System.Drawing.Point(806, 1648);
        btnEqual.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btnEqual.Name = "btnEqual";
        btnEqual.Size = new System.Drawing.Size(266, 320);
        btnEqual.TabIndex = 4;
        btnEqual.Text = "=";
        btnEqual.UseVisualStyleBackColor = true;
        btnEqual.Click += btnEqual_Click;
        // 
        // btnAdd
        // 
        btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)((byte)208)), ((int)((byte)231)), ((int)((byte)255)));
        btnAdd.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btnAdd.ForeColor = System.Drawing.Color.Indigo;
        btnAdd.Location = new System.Drawing.Point(335, 510);
        btnAdd.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new System.Drawing.Size(101, 205);
        btnAdd.TabIndex = 8;
        btnAdd.Text = "+";
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += operator_click;
        // 
        // btn6
        // 
        btn6.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)221)), ((int)((byte)244)));
        btn6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btn6.ForeColor = System.Drawing.Color.Indigo;
        btn6.Location = new System.Drawing.Point(228, 406);
        btn6.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btn6.Name = "btn6";
        btn6.Size = new System.Drawing.Size(101, 101);
        btn6.TabIndex = 7;
        btn6.Text = "6";
        btn6.UseVisualStyleBackColor = false;
        btn6.Click += button_click;
        // 
        // btn5
        // 
        btn5.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)221)), ((int)((byte)244)));
        btn5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btn5.ForeColor = System.Drawing.Color.Indigo;
        btn5.Location = new System.Drawing.Point(122, 406);
        btn5.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btn5.Name = "btn5";
        btn5.Size = new System.Drawing.Size(101, 101);
        btn5.TabIndex = 6;
        btn5.Text = "5";
        btn5.UseVisualStyleBackColor = false;
        btn5.Click += button_click;
        // 
        // btn4
        // 
        btn4.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)221)), ((int)((byte)244)));
        btn4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btn4.ForeColor = System.Drawing.Color.Indigo;
        btn4.Location = new System.Drawing.Point(16, 406);
        btn4.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btn4.Name = "btn4";
        btn4.Size = new System.Drawing.Size(101, 101);
        btn4.TabIndex = 5;
        btn4.Text = "4";
        btn4.UseVisualStyleBackColor = false;
        btn4.Click += button_click;
        // 
        // btnMinus
        // 
        btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)((byte)208)), ((int)((byte)231)), ((int)((byte)255)));
        btnMinus.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btnMinus.ForeColor = System.Drawing.Color.Indigo;
        btnMinus.Location = new System.Drawing.Point(335, 406);
        btnMinus.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btnMinus.Name = "btnMinus";
        btnMinus.Size = new System.Drawing.Size(101, 101);
        btnMinus.TabIndex = 12;
        btnMinus.Text = "-";
        btnMinus.UseVisualStyleBackColor = false;
        btnMinus.Click += operator_click;
        // 
        // btn9
        // 
        btn9.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)221)), ((int)((byte)244)));
        btn9.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btn9.ForeColor = System.Drawing.Color.Indigo;
        btn9.Location = new System.Drawing.Point(228, 300);
        btn9.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btn9.Name = "btn9";
        btn9.Size = new System.Drawing.Size(101, 101);
        btn9.TabIndex = 11;
        btn9.Text = "9";
        btn9.UseVisualStyleBackColor = false;
        btn9.Click += button_click;
        // 
        // btn8
        // 
        btn8.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)221)), ((int)((byte)244)));
        btn8.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btn8.ForeColor = System.Drawing.Color.Indigo;
        btn8.Location = new System.Drawing.Point(122, 300);
        btn8.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btn8.Name = "btn8";
        btn8.Size = new System.Drawing.Size(101, 101);
        btn8.TabIndex = 10;
        btn8.Text = "8";
        btn8.UseVisualStyleBackColor = false;
        btn8.Click += button_click;
        // 
        // btn7
        // 
        btn7.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)221)), ((int)((byte)244)));
        btn7.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btn7.ForeColor = System.Drawing.Color.Indigo;
        btn7.Location = new System.Drawing.Point(16, 300);
        btn7.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btn7.Name = "btn7";
        btn7.Size = new System.Drawing.Size(101, 101);
        btn7.TabIndex = 9;
        btn7.Text = "7";
        btn7.UseVisualStyleBackColor = false;
        btn7.Click += button_click;
        // 
        // btnMultiply
        // 
        btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)((byte)208)), ((int)((byte)231)), ((int)((byte)255)));
        btnMultiply.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btnMultiply.ForeColor = System.Drawing.Color.Indigo;
        btnMultiply.Location = new System.Drawing.Point(335, 300);
        btnMultiply.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Size = new System.Drawing.Size(101, 101);
        btnMultiply.TabIndex = 16;
        btnMultiply.Text = "*";
        btnMultiply.UseVisualStyleBackColor = false;
        btnMultiply.Click += operator_click;
        // 
        // btn1
        // 
        btn1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)221)), ((int)((byte)244)));
        btn1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btn1.ForeColor = System.Drawing.Color.Indigo;
        btn1.Location = new System.Drawing.Point(16, 510);
        btn1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btn1.Name = "btn1";
        btn1.Size = new System.Drawing.Size(101, 101);
        btn1.TabIndex = 17;
        btn1.Text = "1";
        btn1.UseVisualStyleBackColor = false;
        btn1.Click += button_click;
        // 
        // btn2
        // 
        btn2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)221)), ((int)((byte)244)));
        btn2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btn2.ForeColor = System.Drawing.Color.Indigo;
        btn2.Location = new System.Drawing.Point(122, 510);
        btn2.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btn2.Name = "btn2";
        btn2.Size = new System.Drawing.Size(101, 101);
        btn2.TabIndex = 18;
        btn2.Text = "2";
        btn2.UseVisualStyleBackColor = false;
        btn2.Click += button_click;
        // 
        // btnDivide
        // 
        btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)((byte)208)), ((int)((byte)231)), ((int)((byte)255)));
        btnDivide.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btnDivide.ForeColor = System.Drawing.Color.Indigo;
        btnDivide.Location = new System.Drawing.Point(335, 194);
        btnDivide.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btnDivide.Name = "btnDivide";
        btnDivide.Size = new System.Drawing.Size(101, 101);
        btnDivide.TabIndex = 22;
        btnDivide.Text = "/";
        btnDivide.UseVisualStyleBackColor = false;
        btnDivide.Click += operator_click;
        // 
        // btnCE
        // 
        btnCE.BackColor = System.Drawing.Color.FromArgb(((int)((byte)208)), ((int)((byte)231)), ((int)((byte)255)));
        btnCE.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btnCE.ForeColor = System.Drawing.Color.Indigo;
        btnCE.Location = new System.Drawing.Point(16, 194);
        btnCE.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btnCE.Name = "btnCE";
        btnCE.Size = new System.Drawing.Size(207, 101);
        btnCE.TabIndex = 20;
        btnCE.Text = "CE";
        btnCE.UseVisualStyleBackColor = false;
        btnCE.Click += btnCE_Click;
        // 
        // btnPoint
        // 
        btnPoint.Location = new System.Drawing.Point(537, 1648);
        btnPoint.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btnPoint.Name = "btnPoint";
        btnPoint.Size = new System.Drawing.Size(266, 320);
        btnPoint.TabIndex = 23;
        btnPoint.Text = ".";
        btnPoint.UseVisualStyleBackColor = true;
        btnPoint.Click += btnPoint_click;
        // 
        // btnNegate
        // 
        btnNegate.Location = new System.Drawing.Point(1, 1648);
        btnNegate.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btnNegate.Name = "btnNegate";
        btnNegate.Size = new System.Drawing.Size(266, 320);
        btnNegate.TabIndex = 24;
        btnNegate.Text = "+/-";
        btnNegate.UseVisualStyleBackColor = true;
        btnNegate.Click += btnNegate_Click;
        // 
        // btnClear
        // 
        btnClear.BackColor = System.Drawing.Color.FromArgb(((int)((byte)208)), ((int)((byte)231)), ((int)((byte)255)));
        btnClear.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        btnClear.ForeColor = System.Drawing.Color.Indigo;
        btnClear.Location = new System.Drawing.Point(228, 194);
        btnClear.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        btnClear.Name = "btnClear";
        btnClear.Size = new System.Drawing.Size(101, 101);
        btnClear.TabIndex = 25;
        btnClear.Text = "C";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)221)), ((int)((byte)244)));
        button2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        button2.ForeColor = System.Drawing.Color.Indigo;
        button2.Location = new System.Drawing.Point(16, 614);
        button2.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(101, 101);
        button2.TabIndex = 28;
        button2.Text = "0";
        button2.UseVisualStyleBackColor = false;
        button2.Click += button_click;
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)208)), ((int)((byte)231)), ((int)((byte)255)));
        button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        button1.ForeColor = System.Drawing.Color.Indigo;
        button1.Location = new System.Drawing.Point(228, 614);
        button1.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(101, 101);
        button1.TabIndex = 27;
        button1.Text = "=";
        button1.UseVisualStyleBackColor = false;
        button1.Click += btnEqual_Click;
        // 
        // button3
        // 
        button3.BackColor = System.Drawing.Color.FromArgb(((int)((byte)208)), ((int)((byte)231)), ((int)((byte)255)));
        button3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        button3.ForeColor = System.Drawing.Color.Indigo;
        button3.Location = new System.Drawing.Point(122, 614);
        button3.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(101, 101);
        button3.TabIndex = 29;
        button3.Text = ".";
        button3.UseVisualStyleBackColor = false;
        button3.Click += btnPoint_click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.AliceBlue;
        ClientSize = new System.Drawing.Size(452, 729);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(btnNegate);
        Controls.Add(btnClear);
        Controls.Add(btnPoint);
        Controls.Add(btnDivide);
        Controls.Add(btnEqual);
        Controls.Add(btnCE);
        Controls.Add(btn0);
        Controls.Add(btn3);
        Controls.Add(panel1);
        Controls.Add(btn2);
        Controls.Add(btn6);
        Controls.Add(btn4);
        Controls.Add(btn8);
        Controls.Add(btn1);
        Controls.Add(btn7);
        Controls.Add(btn5);
        Controls.Add(btn9);
        Controls.Add(btnMultiply);
        Controls.Add(btnAdd);
        Controls.Add(btnMinus);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        Location = new System.Drawing.Point(15, 15);
        Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Basic Calculator";
        Load += Form1_Load_2;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

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

    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button3;
}