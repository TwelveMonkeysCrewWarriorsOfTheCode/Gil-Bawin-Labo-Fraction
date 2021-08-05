using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace WinForms
{
	public partial class Form1 : Form
	{
		bool calcNum1;
		bool calcNum2;
		bool calcDen1;
		bool calcDen2;
		bool compNum1;
		bool compNum2;
		bool compDen1;
		bool compDen2;

		public Form1()
		{
			InitializeComponent();
		}

		private void CalcPCalculeButton_Click(object sender, EventArgs e)
		{
			int num1 = int.Parse(CalcPNumeratorFrac1.Text);
			int den1 = int.Parse(CalcPDenominatorFrac1.Text);
			int num2 = int.Parse(CalcPNumeratorFrac2.Text);
			int den2 = int.Parse(CalcPDenominatorFrac2.Text);
			char op = CalcPOperatorBox.Text[0];
			BLL.Fraction frac1 = new BLL.Fraction(num1, den1);
			BLL.Fraction frac2 = new BLL.Fraction(num2, den2);
			BLL.Fraction result;
            string resultMessage = $"{frac1} {op} {frac2} = ";
            switch (op)
			{
				case '+':
					result = frac1 + frac2;
					resultMessage += result.ToString();
					BLL.Fraction.SaveToFile(frac1, "+", frac2, result.ToString(), SaveType.Calculation);
					break;
				case '-':
					result = frac1 - frac2;
					resultMessage += result.ToString();
					BLL.Fraction.SaveToFile(frac1, "-", frac2, result.ToString(), SaveType.Calculation);
					break;
				case '*':
					result = frac1 * frac2;
					resultMessage += result.ToString();
					BLL.Fraction.SaveToFile(frac1, "*", frac2, result.ToString(), SaveType.Calculation);
					break;
				case '/':
					result = frac1 / frac2;
					resultMessage += result.ToString();
					BLL.Fraction.SaveToFile(frac1, "/", frac2, result.ToString(), SaveType.Calculation);
					break;
				default:
					resultMessage = "ERROR";
					break;
			}

			CalcPResultatBox.Text = resultMessage;
		}

		private void CompPSmallerButton_Click(object sender, EventArgs e)
		{
			int num1 = int.Parse(CompPNumerator1.Text);
			int den1 = int.Parse(CompPDenominator1.Text);
			int num2 = int.Parse(CompPNumerator2.Text);
			int den2 = int.Parse(CompPDenominator2.Text);
			BLL.Fraction frac1 = new BLL.Fraction(num1, den1);
			BLL.Fraction frac2 = new BLL.Fraction(num2, den2);
			string result = frac1.ToString();
			result += (frac1 < frac2) ? " est " : " n'est pas ";
			result += $"plus petit que {frac2}";

			BLL.Fraction.SaveToFile(frac1, "<", frac2, (frac1 < frac2) ? "true" : "false", SaveType.Comparison);

			CompPResultBox.Text = result;
		}

		private void CompPSmallerEqualsButton_Click(object sender, EventArgs e)
		{
			int num1 = int.Parse(CompPNumerator1.Text);
			int den1 = int.Parse(CompPDenominator1.Text);
			int num2 = int.Parse(CompPNumerator2.Text);
			int den2 = int.Parse(CompPDenominator2.Text);
			BLL.Fraction frac1 = new BLL.Fraction(num1, den1);
			BLL.Fraction frac2 = new BLL.Fraction(num2, den2);
			string result = frac1.ToString();
			result += (frac1 <= frac2) ? " est " : " n'est pas ";
			result += $"plus petit ou egal a {frac2}";

			BLL.Fraction.SaveToFile(frac1, "<=", frac2, (frac1 <= frac2) ? "true" : "false", SaveType.Comparison);

			CompPResultBox.Text = result;
		}

		private void CompPTallerButton_Click(object sender, EventArgs e)
		{
			int num1 = int.Parse(CompPNumerator1.Text);
			int den1 = int.Parse(CompPDenominator1.Text);
			int num2 = int.Parse(CompPNumerator2.Text);
			int den2 = int.Parse(CompPDenominator2.Text);
			BLL.Fraction frac1 = new BLL.Fraction(num1, den1);
			BLL.Fraction frac2 = new BLL.Fraction(num2, den2);
			string result = frac1.ToString();
			result += (frac1 > frac2) ? " est " : " n'est pas ";
			result += $"plus grand que {frac2}";

			BLL.Fraction.SaveToFile(frac1, ">", frac2, (frac1 > frac2) ? "true" : "false", SaveType.Comparison);

			CompPResultBox.Text = result;
		}

		private void CompPTallerEqualsButton_Click(object sender, EventArgs e)
		{
			int num1 = int.Parse(CompPNumerator1.Text);
			int den1 = int.Parse(CompPDenominator1.Text);
			int num2 = int.Parse(CompPNumerator2.Text);
			int den2 = int.Parse(CompPDenominator2.Text);
			BLL.Fraction frac1 = new BLL.Fraction(num1, den1);
			BLL.Fraction frac2 = new BLL.Fraction(num2, den2);
			string result = frac1.ToString();
			result += (frac1 >= frac2) ? " est " : " n'est pas ";
			result += $"plus grand ou egal a {frac2}";

			BLL.Fraction.SaveToFile(frac1, ">=", frac2, (frac1 >= frac2) ? "true" : "false", SaveType.Comparison);

			CompPResultBox.Text = result;
		}

		private void CompPEqualsButton_Click(object sender, EventArgs e)
		{
			int num1 = int.Parse(CompPNumerator1.Text);
			int den1 = int.Parse(CompPDenominator1.Text);
			int num2 = int.Parse(CompPNumerator2.Text);
			int den2 = int.Parse(CompPDenominator2.Text);
			BLL.Fraction frac1 = new BLL.Fraction(num1, den1);
			BLL.Fraction frac2 = new BLL.Fraction(num2, den2);
			string result = frac1.ToString();
			result += (frac1 == frac2) ? " est " : " n'est pas ";
			result += $"egale a {frac2}";

			BLL.Fraction.SaveToFile(frac1, "==", frac2, (frac1 == frac2) ? "true" : "false", SaveType.Comparison);

			CompPResultBox.Text = result;
		}

		private void CompPDifferentButton_Click(object sender, EventArgs e)
		{
			int num1 = int.Parse(CompPNumerator1.Text);
			int den1 = int.Parse(CompPDenominator1.Text);
			int num2 = int.Parse(CompPNumerator2.Text);
			int den2 = int.Parse(CompPDenominator2.Text);
			BLL.Fraction frac1 = new BLL.Fraction(num1, den1);
			BLL.Fraction frac2 = new BLL.Fraction(num2, den2);
			string result = frac1.ToString();
			result += (frac1 != frac2) ? " est " : " n'est pas ";
			result += $"different de {frac2}";

			BLL.Fraction.SaveToFile(frac1, "!=", frac2, (frac1 != frac2) ? "true" : "false", SaveType.Comparison);

			CompPResultBox.Text = result;
		}

		public void ValidCalcButtons()
        {
			if (calcDen1 && calcDen2 && calcNum1 && calcNum2) CalcPCalculeButton.Enabled = true;
			else CalcPCalculeButton.Enabled = false;
		}

		public void ValidCompButtons()
        {
			if (compDen1 && compDen2 && compNum1 && compNum2)
            {
				CompPDifferentButton.Enabled = true;
				CompPEqualsButton.Enabled = true;
				CompPSmallerButton.Enabled = true;
				CompPSmallerEqualsButton.Enabled = true;
                CompPTallerButton.Enabled = true;
				CompPTallerEqualsButton.Enabled = true;
			}
            else
            {
				CompPDifferentButton.Enabled = false;
				CompPEqualsButton.Enabled = false;
				CompPSmallerButton.Enabled = false;
				CompPSmallerEqualsButton.Enabled = false;
				CompPTallerButton.Enabled = false;
				CompPTallerEqualsButton.Enabled = false;
			}

		}

        private void CalcPNumeratorFrac1_ValueChanged(object sender, EventArgs e)
        {
			if (CalcPNumeratorFrac1.Value != 0) calcNum1 = true;
			else calcNum1 = false;
			ValidCalcButtons();
		}

        private void CalcPDenominatorFrac1_ValueChanged(object sender, EventArgs e)
        {
			if (CalcPDenominatorFrac1.Value > 0) calcDen1 = true;
			else calcDen1 = false;
			ValidCalcButtons();
		}

        private void CalcPNumeratorFrac2_ValueChanged(object sender, EventArgs e)
        {
			if (CalcPNumeratorFrac2.Value != 0) calcNum2 = true;
			else calcNum2 = false;
			ValidCalcButtons();
		}

        private void CalcPDenominatorFrac2_ValueChanged(object sender, EventArgs e)
        {
			if (CalcPDenominatorFrac2.Value > 0) calcDen2 = true;
			else calcDen2 = false;
			ValidCalcButtons();
		}

        private void CompPNumerator1_ValueChanged(object sender, EventArgs e)
        {
			if (CompPNumerator1.Value != 0) compNum1 = true;
			else compNum1 = false;
			ValidCompButtons();
		}

        private void CompPDenominator1_ValueChanged(object sender, EventArgs e)
        {
			if (CompPDenominator1.Value >= 0) compDen1 = true;
			else compDen1 = false;
			ValidCompButtons();
		}

        private void CompPNumerator2_ValueChanged(object sender, EventArgs e)
        {
			if (CompPNumerator2.Value != 0) compNum2 = true;
			else compNum2 = false;
			ValidCompButtons();
		}

        private void CompPDenominator2_ValueChanged(object sender, EventArgs e)
        {
			if (CompPDenominator2.Value >= 0) compDen2 = true;
			else compDen2 = false;
			ValidCompButtons();
		}
    }
}
