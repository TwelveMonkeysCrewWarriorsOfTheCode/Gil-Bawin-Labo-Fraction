
namespace WinForms
{
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PageControl = new System.Windows.Forms.TabControl();
            this.CalculPage = new System.Windows.Forms.TabPage();
            this.CalcPNumeratorFrac2 = new System.Windows.Forms.NumericUpDown();
            this.CalcPDenominatorFrac2 = new System.Windows.Forms.NumericUpDown();
            this.CalcPDenominatorFrac1 = new System.Windows.Forms.NumericUpDown();
            this.CalcPNumeratorFrac1 = new System.Windows.Forms.NumericUpDown();
            this.CalcPOperatorBox = new System.Windows.Forms.ComboBox();
            this.CalcPResultatBox = new System.Windows.Forms.TextBox();
            this.CalcPCalculeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CompartPage = new System.Windows.Forms.TabPage();
            this.CompPDenominator1 = new System.Windows.Forms.NumericUpDown();
            this.CompPNumerator1 = new System.Windows.Forms.NumericUpDown();
            this.CompPNumerator2 = new System.Windows.Forms.NumericUpDown();
            this.CompPDenominator2 = new System.Windows.Forms.NumericUpDown();
            this.CompPResultBox = new System.Windows.Forms.TextBox();
            this.CompPDifferentButton = new System.Windows.Forms.Button();
            this.CompPTallerEqualsButton = new System.Windows.Forms.Button();
            this.CompPSmallerEqualsButton = new System.Windows.Forms.Button();
            this.CompPEqualsButton = new System.Windows.Forms.Button();
            this.CompPTallerButton = new System.Windows.Forms.Button();
            this.CompPSmallerButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PageControl.SuspendLayout();
            this.CalculPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalcPNumeratorFrac2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcPDenominatorFrac2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcPDenominatorFrac1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcPNumeratorFrac1)).BeginInit();
            this.CompartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompPDenominator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompPNumerator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompPNumerator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompPDenominator2)).BeginInit();
            this.SuspendLayout();
            // 
            // PageControl
            // 
            this.PageControl.Controls.Add(this.CalculPage);
            this.PageControl.Controls.Add(this.CompartPage);
            this.PageControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageControl.Location = new System.Drawing.Point(0, 0);
            this.PageControl.Name = "PageControl";
            this.PageControl.SelectedIndex = 0;
            this.PageControl.Size = new System.Drawing.Size(487, 147);
            this.PageControl.TabIndex = 0;
            // 
            // CalculPage
            // 
            this.CalculPage.Controls.Add(this.CalcPNumeratorFrac2);
            this.CalculPage.Controls.Add(this.CalcPDenominatorFrac2);
            this.CalculPage.Controls.Add(this.CalcPDenominatorFrac1);
            this.CalculPage.Controls.Add(this.CalcPNumeratorFrac1);
            this.CalculPage.Controls.Add(this.CalcPOperatorBox);
            this.CalculPage.Controls.Add(this.CalcPResultatBox);
            this.CalculPage.Controls.Add(this.CalcPCalculeButton);
            this.CalculPage.Controls.Add(this.label2);
            this.CalculPage.Controls.Add(this.label1);
            this.CalculPage.Location = new System.Drawing.Point(4, 24);
            this.CalculPage.Name = "CalculPage";
            this.CalculPage.Padding = new System.Windows.Forms.Padding(3);
            this.CalculPage.Size = new System.Drawing.Size(479, 119);
            this.CalculPage.TabIndex = 0;
            this.CalculPage.Text = "Calcule";
            this.CalculPage.UseVisualStyleBackColor = true;
            // 
            // CalcPNumeratorFrac2
            // 
            this.CalcPNumeratorFrac2.Location = new System.Drawing.Point(149, 31);
            this.CalcPNumeratorFrac2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CalcPNumeratorFrac2.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.CalcPNumeratorFrac2.Name = "CalcPNumeratorFrac2";
            this.CalcPNumeratorFrac2.Size = new System.Drawing.Size(55, 23);
            this.CalcPNumeratorFrac2.TabIndex = 12;
            this.CalcPNumeratorFrac2.ValueChanged += new System.EventHandler(this.CalcPNumeratorFrac2_ValueChanged);
            // 
            // CalcPDenominatorFrac2
            // 
            this.CalcPDenominatorFrac2.Location = new System.Drawing.Point(149, 64);
            this.CalcPDenominatorFrac2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CalcPDenominatorFrac2.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.CalcPDenominatorFrac2.Name = "CalcPDenominatorFrac2";
            this.CalcPDenominatorFrac2.Size = new System.Drawing.Size(55, 23);
            this.CalcPDenominatorFrac2.TabIndex = 11;
            this.CalcPDenominatorFrac2.ValueChanged += new System.EventHandler(this.CalcPDenominatorFrac2_ValueChanged);
            // 
            // CalcPDenominatorFrac1
            // 
            this.CalcPDenominatorFrac1.Location = new System.Drawing.Point(18, 64);
            this.CalcPDenominatorFrac1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CalcPDenominatorFrac1.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.CalcPDenominatorFrac1.Name = "CalcPDenominatorFrac1";
            this.CalcPDenominatorFrac1.Size = new System.Drawing.Size(55, 23);
            this.CalcPDenominatorFrac1.TabIndex = 10;
            this.CalcPDenominatorFrac1.ValueChanged += new System.EventHandler(this.CalcPDenominatorFrac1_ValueChanged);
            // 
            // CalcPNumeratorFrac1
            // 
            this.CalcPNumeratorFrac1.Location = new System.Drawing.Point(18, 31);
            this.CalcPNumeratorFrac1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CalcPNumeratorFrac1.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.CalcPNumeratorFrac1.Name = "CalcPNumeratorFrac1";
            this.CalcPNumeratorFrac1.Size = new System.Drawing.Size(55, 23);
            this.CalcPNumeratorFrac1.TabIndex = 9;
            this.CalcPNumeratorFrac1.ValueChanged += new System.EventHandler(this.CalcPNumeratorFrac1_ValueChanged);
            // 
            // CalcPOperatorBox
            // 
            this.CalcPOperatorBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalcPOperatorBox.FormattingEnabled = true;
            this.CalcPOperatorBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.CalcPOperatorBox.Location = new System.Drawing.Point(93, 39);
            this.CalcPOperatorBox.Name = "CalcPOperatorBox";
            this.CalcPOperatorBox.Size = new System.Drawing.Size(38, 36);
            this.CalcPOperatorBox.TabIndex = 8;
            this.CalcPOperatorBox.Text = "+";
            // 
            // CalcPResultatBox
            // 
            this.CalcPResultatBox.Location = new System.Drawing.Point(356, 50);
            this.CalcPResultatBox.Name = "CalcPResultatBox";
            this.CalcPResultatBox.ReadOnly = true;
            this.CalcPResultatBox.Size = new System.Drawing.Size(100, 23);
            this.CalcPResultatBox.TabIndex = 7;
            // 
            // CalcPCalculeButton
            // 
            this.CalcPCalculeButton.Enabled = false;
            this.CalcPCalculeButton.Location = new System.Drawing.Point(240, 48);
            this.CalcPCalculeButton.Name = "CalcPCalculeButton";
            this.CalcPCalculeButton.Size = new System.Drawing.Size(75, 23);
            this.CalcPCalculeButton.TabIndex = 6;
            this.CalcPCalculeButton.Text = "Calculer";
            this.CalcPCalculeButton.UseVisualStyleBackColor = true;
            this.CalcPCalculeButton.Click += new System.EventHandler(this.CalcPCalculeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "__________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "__________";
            // 
            // CompartPage
            // 
            this.CompartPage.Controls.Add(this.CompPDenominator1);
            this.CompartPage.Controls.Add(this.CompPNumerator1);
            this.CompartPage.Controls.Add(this.CompPNumerator2);
            this.CompartPage.Controls.Add(this.CompPDenominator2);
            this.CompartPage.Controls.Add(this.CompPResultBox);
            this.CompartPage.Controls.Add(this.CompPDifferentButton);
            this.CompartPage.Controls.Add(this.CompPTallerEqualsButton);
            this.CompartPage.Controls.Add(this.CompPSmallerEqualsButton);
            this.CompartPage.Controls.Add(this.CompPEqualsButton);
            this.CompartPage.Controls.Add(this.CompPTallerButton);
            this.CompartPage.Controls.Add(this.CompPSmallerButton);
            this.CompartPage.Controls.Add(this.label6);
            this.CompartPage.Controls.Add(this.label5);
            this.CompartPage.Controls.Add(this.label4);
            this.CompartPage.Controls.Add(this.label3);
            this.CompartPage.Location = new System.Drawing.Point(4, 24);
            this.CompartPage.Name = "CompartPage";
            this.CompartPage.Padding = new System.Windows.Forms.Padding(3);
            this.CompartPage.Size = new System.Drawing.Size(479, 119);
            this.CompartPage.TabIndex = 1;
            this.CompartPage.Text = "Comparaison";
            this.CompartPage.UseVisualStyleBackColor = true;
            // 
            // CompPDenominator1
            // 
            this.CompPDenominator1.Location = new System.Drawing.Point(20, 73);
            this.CompPDenominator1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CompPDenominator1.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.CompPDenominator1.Name = "CompPDenominator1";
            this.CompPDenominator1.Size = new System.Drawing.Size(55, 23);
            this.CompPDenominator1.TabIndex = 21;
            this.CompPDenominator1.ValueChanged += new System.EventHandler(this.CompPDenominator1_ValueChanged);
            // 
            // CompPNumerator1
            // 
            this.CompPNumerator1.Location = new System.Drawing.Point(20, 41);
            this.CompPNumerator1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CompPNumerator1.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.CompPNumerator1.Name = "CompPNumerator1";
            this.CompPNumerator1.Size = new System.Drawing.Size(55, 23);
            this.CompPNumerator1.TabIndex = 20;
            this.CompPNumerator1.ValueChanged += new System.EventHandler(this.CompPNumerator1_ValueChanged);
            // 
            // CompPNumerator2
            // 
            this.CompPNumerator2.Location = new System.Drawing.Point(107, 41);
            this.CompPNumerator2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CompPNumerator2.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.CompPNumerator2.Name = "CompPNumerator2";
            this.CompPNumerator2.Size = new System.Drawing.Size(55, 23);
            this.CompPNumerator2.TabIndex = 19;
            this.CompPNumerator2.ValueChanged += new System.EventHandler(this.CompPNumerator2_ValueChanged);
            // 
            // CompPDenominator2
            // 
            this.CompPDenominator2.Location = new System.Drawing.Point(107, 73);
            this.CompPDenominator2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CompPDenominator2.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.CompPDenominator2.Name = "CompPDenominator2";
            this.CompPDenominator2.Size = new System.Drawing.Size(55, 23);
            this.CompPDenominator2.TabIndex = 18;
            this.CompPDenominator2.ValueChanged += new System.EventHandler(this.CompPDenominator2_ValueChanged);
            // 
            // CompPResultBox
            // 
            this.CompPResultBox.Location = new System.Drawing.Point(307, 53);
            this.CompPResultBox.Name = "CompPResultBox";
            this.CompPResultBox.ReadOnly = true;
            this.CompPResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CompPResultBox.Size = new System.Drawing.Size(148, 23);
            this.CompPResultBox.TabIndex = 17;
            // 
            // CompPDifferentButton
            // 
            this.CompPDifferentButton.Enabled = false;
            this.CompPDifferentButton.Location = new System.Drawing.Point(245, 81);
            this.CompPDifferentButton.Name = "CompPDifferentButton";
            this.CompPDifferentButton.Size = new System.Drawing.Size(44, 23);
            this.CompPDifferentButton.TabIndex = 16;
            this.CompPDifferentButton.Text = "!=";
            this.CompPDifferentButton.UseVisualStyleBackColor = true;
            this.CompPDifferentButton.Click += new System.EventHandler(this.CompPDifferentButton_Click);
            // 
            // CompPTallerEqualsButton
            // 
            this.CompPTallerEqualsButton.Enabled = false;
            this.CompPTallerEqualsButton.Location = new System.Drawing.Point(245, 52);
            this.CompPTallerEqualsButton.Name = "CompPTallerEqualsButton";
            this.CompPTallerEqualsButton.Size = new System.Drawing.Size(44, 23);
            this.CompPTallerEqualsButton.TabIndex = 15;
            this.CompPTallerEqualsButton.Text = ">=";
            this.CompPTallerEqualsButton.UseVisualStyleBackColor = true;
            this.CompPTallerEqualsButton.Click += new System.EventHandler(this.CompPTallerEqualsButton_Click);
            // 
            // CompPSmallerEqualsButton
            // 
            this.CompPSmallerEqualsButton.Enabled = false;
            this.CompPSmallerEqualsButton.Location = new System.Drawing.Point(245, 23);
            this.CompPSmallerEqualsButton.Name = "CompPSmallerEqualsButton";
            this.CompPSmallerEqualsButton.Size = new System.Drawing.Size(44, 23);
            this.CompPSmallerEqualsButton.TabIndex = 14;
            this.CompPSmallerEqualsButton.Text = "<=";
            this.CompPSmallerEqualsButton.UseVisualStyleBackColor = true;
            this.CompPSmallerEqualsButton.Click += new System.EventHandler(this.CompPSmallerEqualsButton_Click);
            // 
            // CompPEqualsButton
            // 
            this.CompPEqualsButton.Enabled = false;
            this.CompPEqualsButton.Location = new System.Drawing.Point(195, 81);
            this.CompPEqualsButton.Name = "CompPEqualsButton";
            this.CompPEqualsButton.Size = new System.Drawing.Size(44, 23);
            this.CompPEqualsButton.TabIndex = 13;
            this.CompPEqualsButton.Text = "=";
            this.CompPEqualsButton.UseVisualStyleBackColor = true;
            this.CompPEqualsButton.Click += new System.EventHandler(this.CompPEqualsButton_Click);
            // 
            // CompPTallerButton
            // 
            this.CompPTallerButton.Enabled = false;
            this.CompPTallerButton.Location = new System.Drawing.Point(195, 52);
            this.CompPTallerButton.Name = "CompPTallerButton";
            this.CompPTallerButton.Size = new System.Drawing.Size(44, 23);
            this.CompPTallerButton.TabIndex = 12;
            this.CompPTallerButton.Text = ">";
            this.CompPTallerButton.UseVisualStyleBackColor = true;
            this.CompPTallerButton.Click += new System.EventHandler(this.CompPTallerButton_Click);
            // 
            // CompPSmallerButton
            // 
            this.CompPSmallerButton.Enabled = false;
            this.CompPSmallerButton.Location = new System.Drawing.Point(195, 23);
            this.CompPSmallerButton.Name = "CompPSmallerButton";
            this.CompPSmallerButton.Size = new System.Drawing.Size(44, 23);
            this.CompPSmallerButton.TabIndex = 11;
            this.CompPSmallerButton.Text = "<";
            this.CompPSmallerButton.UseVisualStyleBackColor = true;
            this.CompPSmallerButton.Click += new System.EventHandler(this.CompPSmallerButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fraction 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fraction 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "__________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "__________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 147);
            this.Controls.Add(this.PageControl);
            this.Name = "Form1";
            this.Text = "Fraction";
            this.PageControl.ResumeLayout(false);
            this.CalculPage.ResumeLayout(false);
            this.CalculPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalcPNumeratorFrac2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcPDenominatorFrac2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcPDenominatorFrac1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CalcPNumeratorFrac1)).EndInit();
            this.CompartPage.ResumeLayout(false);
            this.CompartPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompPDenominator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompPNumerator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompPNumerator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompPDenominator2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PageControl;
        private System.Windows.Forms.TabPage CalculPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage CompartPage;
        private System.Windows.Forms.ComboBox CalcPOperatorBox;
        private System.Windows.Forms.TextBox CalcPResultatBox;
        private System.Windows.Forms.Button CalcPCalculeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CompPDifferentButton;
        private System.Windows.Forms.Button CompPTallerEqualsButton;
        private System.Windows.Forms.Button CompPSmallerEqualsButton;
        private System.Windows.Forms.Button CompPEqualsButton;
        private System.Windows.Forms.Button CompPTallerButton;
        private System.Windows.Forms.Button CompPSmallerButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CompPResultBox;
        private System.Windows.Forms.NumericUpDown CalcPNumeratorFrac1;
        private System.Windows.Forms.NumericUpDown CalcPNumeratorFrac2;
        private System.Windows.Forms.NumericUpDown CalcPDenominatorFrac2;
        private System.Windows.Forms.NumericUpDown CalcPDenominatorFrac1;
        private System.Windows.Forms.NumericUpDown CompPDenominator1;
        private System.Windows.Forms.NumericUpDown CompPNumerator1;
        private System.Windows.Forms.NumericUpDown CompPNumerator2;
        private System.Windows.Forms.NumericUpDown CompPDenominator2;
    }
}

