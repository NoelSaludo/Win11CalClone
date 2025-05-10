using System;
using System.Data;

namespace Win11Calculator;

public partial class Form1 : Form
{
    // TODO use this to clear solved equations
    private bool _isPerformed = false;
    String _operation = "";
    String result;

    public Form1()
    {
        InitializeComponent();
    }

    private void txtInput_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }


    private void BtnAdd_Click(object sender, EventArgs e)
    {
        MoveInputToEq();
        EquationLabel.Text += " + ";
    }

    private void DivideBtn_Click(object sender, EventArgs e)
    {
        MoveInputToEq();
        EquationLabel.Text += " / ";
    }

    private void BtnMinus_Click(object sender, EventArgs e)
    {
        MoveInputToEq();
        EquationLabel.Text += " - ";
    }

    private void BtnMultiply_Click(object sender, EventArgs e)
    {
        MoveInputToEq();
        EquationLabel.Text += " * ";
    }

    private void MoveInputToEq()
    {
        EquationLabel.Text += txtInput.Text;
        SetInputToZero();
    }

    private void BtnCE_Click(object sender, EventArgs e)
    {
        EquationLabel.Text = "";
        SetInputToZero();
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

    private void NumZeroBtn_Click(object sender, EventArgs e)
    {
        txtInput.Text += '0';
    }

    private void SetInputToZero()
    {
        txtInput.Text = 0.ToString();
    }

    //private void BtnEquals_Click(object sender, EventArgs e)
    //{
    //    EquationLabel.Text += txtInput.Text;
    //    string expression = EquationLabel.Text;
    //    var result = new DataTable().Compute(expression, null);
    //    txtInput.Text = result.ToString();
    //}

    private void BtnPoint_Click(object sender, EventArgs e)
    {
        CheckInputValue();
        txtInput.Text += '.';
    }

    private void button_click(object sender, EventArgs e)
    {
        CheckInputValue();
        Button button = (Button)sender;
        txtInput.Text += button.Text;
    }

    private void operator_click (object sender, EventArgs e)
    {
        Button button = (Button)sender;
        if (result != "")
        {
            btnEqual.PerformClick();
            operation = button.Text;
            isPerformed = true;
        }
        else
        {
            operation = button.Text;
            result = txtInput.Text;
            isPerformed = true;
        }
    }
}