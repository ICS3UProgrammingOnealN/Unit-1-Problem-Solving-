namespace PizzaCostOneal
{
    partial class PizzaCostForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            this.nudDiameter = new System.Windows.Forms.NumericUpDown();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCostAnswer = new System.Windows.Forms.Label();
            this.lblAnwer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDiameter
            // 
            this.nudDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiameter.Location = new System.Drawing.Point(526, 93);
            this.nudDiameter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDiameter.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDiameter.Name = "nudDiameter";
            this.nudDiameter.Size = new System.Drawing.Size(120, 31);
            this.nudDiameter.TabIndex = 0;
            this.nudDiameter.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameter.Location = new System.Drawing.Point(23, 95);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(411, 25);
            this.lblDiameter.TabIndex = 1;
            this.lblDiameter.Text = "Enter the diameter of the pizza (in inches)";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(23, 279);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(257, 25);
            this.lblCost.TabIndex = 2;
            this.lblCost.Text = "the cost (including tax) is ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(274, 184);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(132, 31);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Claculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // lblCostAnswer
            // 
            this.lblCostAnswer.AutoSize = true;
            this.lblCostAnswer.Location = new System.Drawing.Point(523, 291);
            this.lblCostAnswer.Name = "lblCostAnswer";
            this.lblCostAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblCostAnswer.TabIndex = 5;
            this.lblCostAnswer.Click += new System.EventHandler(this.lblCostAnswer_Click);
            // 
            // lblAnwer
            // 
            this.lblAnwer.AutoSize = true;
            this.lblAnwer.Location = new System.Drawing.Point(529, 291);
            this.lblAnwer.Name = "lblAnwer";
            this.lblAnwer.Size = new System.Drawing.Size(35, 13);
            this.lblAnwer.TabIndex = 6;
            this.lblAnwer.Text = "label2";
            // 
            // PizzaCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 380);
            this.Controls.Add(this.lblAnwer);
            this.Controls.Add(this.lblCostAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.nudDiameter);
            this.Name = "PizzaCostForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDiameter;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCostAnswer;
        private System.Windows.Forms.Label lblAnwer;
    }
}

