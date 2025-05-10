using System;
using System.Data;

namespace Win11Calculator;

public partial class Form1 : Form
{
    // TODO use this to clear solved equations

    String operation = "";
    String result;
    bool isResult = false;

    public Form1()
    {
        InitializeComponent();
    }

    private void txtInput_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void MoveInputToEq()
    {
        lblEquation.Text += txtInput.Text;
        txtInput.Text = "0";
    }

    private void CheckInputValue()
    {
        int val;
        if (int.TryParse(txtInput.Text, out val))
        {
            if (val == 0)
            {
                txtInput.Text = String.Empty;
            }
        }
    }

    private void btnEqual_Click(object sender, EventArgs e)
    {
        lblEquation.Text += txtInput.Text;
        string expression = lblEquation.Text;
        var result = new DataTable().Compute(expression, null);
        txtInput.Text = result.ToString();
        isResult = true;
    }

    private void button_click(object sender, EventArgs e)
    {
        CheckInputValue();
        Button button = (Button)sender;
        if (isResult)
        {
            lblEquation.Text = String.Empty;
            txtInput.Text = String.Empty;
            isResult = false;
        }

        txtInput.Text += button.Text;
    }

    private void operator_click(object sender, EventArgs e)
    {
        Button button = (Button)sender;

        if (isResult)
        {
            lblEquation.Text = "";
            MoveInputToEq();
            isResult = false;
            lblEquation.Text += button.Text;
        }
        else
        {
            txtInput.Text += button.Text;
            MoveInputToEq();
        }

    }

    private void btnCE_Click(object sender, EventArgs e)
    {
        txtInput.Text = "0";
    }

    private void btnPoint_click(object sender, EventArgs e)
    {
        if (!txtInput.Text.Contains('.'))
        {
            txtInput.Text += '.';
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        txtInput.Text = "0";
        lblEquation.Text = "";
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        string text = txtInput.Text;

        text = text.Substring(0, text.Length - 1);
        if (text.Length <= 0) text = "0";

        txtInput.Text = text;

    }

    private void btnNegate_Click(object sender, EventArgs e)
    {
        string text = txtInput.Text;

        if (double.Parse(text) != 0)
        {
            if (text[0] == '-')
            {
                text = text.Remove(0, 1);
            }

            else
            {
                text = "-" + text;
            }
        }

        txtInput.Text = text;
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void panel1_Paint_1(object sender, PaintEventArgs e)
    {

    }

    private void lblEquation_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load_1(object sender, EventArgs e)
    {

    }

    private void txtInput_TextChanged(object sender, EventArgs e)
    {

    }

    private void lblEquation_Click_1(object sender, EventArgs e)
    {

    }

    private void Form1_Load_2(object sender, EventArgs e)
    {

    }

    private void txtInput_TextChanged_1(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
}