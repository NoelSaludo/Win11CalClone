using System;
using System.Data;

namespace Win11Calculator;

public partial class Form1 : Form
{
    // TODO use this to clear solved equations
    private bool _isSolved = false;
    
    public Form1()
    {
        InitializeComponent();
    }

    private void InputLabel_Click(object sender, EventArgs e)
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
        EquationLabel.Text += InputLabel.Text;
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
        if (int.TryParse(InputLabel.Text, out val))
        {
            if (val == 0)
            {
                InputLabel.Text = String.Empty;
            }
        }
    }

    private void NumZeroBtn_Click(object sender, EventArgs e)
    {
        InputLabel.Text += '0';
    }

    private void SetInputToZero()
    {
        InputLabel.Text = 0.ToString();
    }

    private void BtnOne_Click(object sender, EventArgs e)
    {
        CheckInputValue();
        InputLabel.Text += 1.ToString();
    }

    private void BtnTwo_Click(object sender, EventArgs e)
    {
        CheckInputValue();
        InputLabel.Text += 2.ToString();
    }

    private void BtnThree_Click(object sender, EventArgs e)
    {
        CheckInputValue();
        InputLabel.Text += 3.ToString();
    }

    private void BtnFour_Click(object sender, EventArgs e)
    {
        CheckInputValue();
        InputLabel.Text += 4.ToString();
    }

    private void BtnFive_Click(object sender, EventArgs e)
    {
        CheckInputValue();
        InputLabel.Text += 5.ToString();
    }

    private void BtnSix_Click(object sender, EventArgs e)
    {
        CheckInputValue();
        InputLabel.Text += 6.ToString();
    }

    private void BtnSeven_Click(object sender, EventArgs e)
    {
        CheckInputValue();
        InputLabel.Text += 7.ToString();
    }

    private void BtnEight_Click(object sender, EventArgs e)
    {
        CheckInputValue();
        InputLabel.Text += 8.ToString();
    }

    private void BtnNine_Click(object sender, EventArgs e)
    {
        CheckInputValue();
        InputLabel.Text += 9.ToString();
    }

    private void BtnEquals_Click(object sender, EventArgs e)
    {
        EquationLabel.Text += InputLabel.Text;
        string expression = EquationLabel.Text;
        var result = new DataTable().Compute(expression, null);
        InputLabel.Text = result.ToString();
    }

    private void BtnPoint_Click(object sender, EventArgs e)
    {
        CheckInputValue();
        InputLabel.Text += '.';
    }
}