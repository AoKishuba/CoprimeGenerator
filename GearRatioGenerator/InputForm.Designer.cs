namespace GearRatioGenerator
{
    partial class InputForm
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
            components = new System.ComponentModel.Container();
            MinTeethUD = new NumericUpDown();
            toolTip1 = new ToolTip(components);
            MaxTeethUD = new NumericUpDown();
            RatioNumeratorUD = new NumericUpDown();
            RatioDenominatorUD = new NumericUpDown();
            MinTeethLabel = new Label();
            MaxTeethLabel = new Label();
            DesiredRatioLabel = new Label();
            ColonLabel = new Label();
            CalculateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MinTeethUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxTeethUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RatioNumeratorUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RatioDenominatorUD).BeginInit();
            SuspendLayout();
            // 
            // MinTeethUD
            // 
            MinTeethUD.Location = new Point(99, 12);
            MinTeethUD.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            MinTeethUD.Name = "MinTeethUD";
            MinTeethUD.Size = new Size(50, 23);
            MinTeethUD.TabIndex = 0;
            MinTeethUD.TextAlign = HorizontalAlignment.Right;
            toolTip1.SetToolTip(MinTeethUD, "Minimum number of teeth on smallest gear");
            MinTeethUD.Value = new decimal(new int[] { 2, 0, 0, 0 });
            MinTeethUD.ValueChanged += MinTeethUD_ValueChanged;
            // 
            // MaxTeethUD
            // 
            MaxTeethUD.Location = new Point(99, 41);
            MaxTeethUD.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            MaxTeethUD.Name = "MaxTeethUD";
            MaxTeethUD.Size = new Size(50, 23);
            MaxTeethUD.TabIndex = 2;
            MaxTeethUD.TextAlign = HorizontalAlignment.Right;
            toolTip1.SetToolTip(MaxTeethUD, "Maximum number of teeth on largest gear");
            MaxTeethUD.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // RatioNumeratorUD
            // 
            RatioNumeratorUD.DecimalPlaces = 1;
            RatioNumeratorUD.Location = new Point(12, 99);
            RatioNumeratorUD.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            RatioNumeratorUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            RatioNumeratorUD.Name = "RatioNumeratorUD";
            RatioNumeratorUD.Size = new Size(50, 23);
            RatioNumeratorUD.TabIndex = 4;
            RatioNumeratorUD.TextAlign = HorizontalAlignment.Right;
            toolTip1.SetToolTip(RatioNumeratorUD, "Numerator of desired ratio");
            RatioNumeratorUD.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // RatioDenominatorUD
            // 
            RatioDenominatorUD.DecimalPlaces = 1;
            RatioDenominatorUD.Location = new Point(99, 99);
            RatioDenominatorUD.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            RatioDenominatorUD.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            RatioDenominatorUD.Name = "RatioDenominatorUD";
            RatioDenominatorUD.Size = new Size(50, 23);
            RatioDenominatorUD.TabIndex = 5;
            RatioDenominatorUD.TextAlign = HorizontalAlignment.Right;
            toolTip1.SetToolTip(RatioDenominatorUD, "Denominator of desired ratio");
            RatioDenominatorUD.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // MinTeethLabel
            // 
            MinTeethLabel.AutoSize = true;
            MinTeethLabel.Location = new Point(12, 16);
            MinTeethLabel.Name = "MinTeethLabel";
            MinTeethLabel.Size = new Size(58, 15);
            MinTeethLabel.TabIndex = 1;
            MinTeethLabel.Text = "Min teeth";
            // 
            // MaxTeethLabel
            // 
            MaxTeethLabel.AutoSize = true;
            MaxTeethLabel.Location = new Point(12, 45);
            MaxTeethLabel.Name = "MaxTeethLabel";
            MaxTeethLabel.Size = new Size(60, 15);
            MaxTeethLabel.TabIndex = 3;
            MaxTeethLabel.Text = "Max teeth";
            // 
            // DesiredRatioLabel
            // 
            DesiredRatioLabel.AutoSize = true;
            DesiredRatioLabel.Location = new Point(42, 73);
            DesiredRatioLabel.Name = "DesiredRatioLabel";
            DesiredRatioLabel.Size = new Size(73, 15);
            DesiredRatioLabel.TabIndex = 6;
            DesiredRatioLabel.Text = "Desired ratio";
            DesiredRatioLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ColonLabel
            // 
            ColonLabel.AutoSize = true;
            ColonLabel.Location = new Point(75, 102);
            ColonLabel.Name = "ColonLabel";
            ColonLabel.Size = new Size(10, 15);
            ColonLabel.TabIndex = 7;
            ColonLabel.Text = ":";
            ColonLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(43, 128);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(75, 23);
            CalculateButton.TabIndex = 8;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(167, 165);
            Controls.Add(CalculateButton);
            Controls.Add(ColonLabel);
            Controls.Add(DesiredRatioLabel);
            Controls.Add(RatioDenominatorUD);
            Controls.Add(RatioNumeratorUD);
            Controls.Add(MaxTeethLabel);
            Controls.Add(MaxTeethUD);
            Controls.Add(MinTeethLabel);
            Controls.Add(MinTeethUD);
            Name = "InputForm";
            Text = "GearRatioGenerator";
            ((System.ComponentModel.ISupportInitialize)MinTeethUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxTeethUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)RatioNumeratorUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)RatioDenominatorUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown MinTeethUD;
        private ToolTip toolTip1;
        private Label MinTeethLabel;
        private Label MaxTeethLabel;
        private NumericUpDown MaxTeethUD;
        private NumericUpDown RatioNumeratorUD;
        private NumericUpDown RatioDenominatorUD;
        private Label DesiredRatioLabel;
        private Label ColonLabel;
        private Button CalculateButton;
    }
}
