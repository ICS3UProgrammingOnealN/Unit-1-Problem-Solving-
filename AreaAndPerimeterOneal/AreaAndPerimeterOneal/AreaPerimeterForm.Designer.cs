namespace AreaAndPerimeterOneal
{
    partial class frmAreaPerimeter
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
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnCaculate = new System.Windows.Forms.Button();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAnswerPerimeter = new System.Windows.Forms.Label();
            this.lblAnswerArea = new System.Windows.Forms.Label();
            this.mnuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(399, 24);
            this.mnuFile.TabIndex = 1;
            this.mnuFile.Text = "menuStrip2";
            this.mnuFile.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuFile_ItemClicked);
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(92, 22);
            this.mniExit.Text = "Exit";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(12, 39);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(115, 37);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "Length";
            this.lblLength.Click += new System.EventHandler(this.lblLength_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(12, 142);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(100, 37);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Width";
            this.lblWidth.Click += new System.EventHandler(this.lblWidth_Click);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(163, 54);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 4;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(163, 159);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 5;
            // 
            // btnCaculate
            // 
            this.btnCaculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaculate.Location = new System.Drawing.Point(217, 101);
            this.btnCaculate.Name = "btnCaculate";
            this.btnCaculate.Size = new System.Drawing.Size(182, 31);
            this.btnCaculate.TabIndex = 6;
            this.btnCaculate.Text = "Caculate";
            this.btnCaculate.UseVisualStyleBackColor = true;
            this.btnCaculate.Click += new System.EventHandler(this.btnCaculate_Click);
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(16, 215);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(148, 24);
            this.lblPerimeter.TabIndex = 7;
            this.lblPerimeter.Text = "The Perimeter is";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(26, 276);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(107, 24);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "The Area is";
            // 
            // lblAnswerPerimeter
            // 
            this.lblAnswerPerimeter.AutoSize = true;
            this.lblAnswerPerimeter.Location = new System.Drawing.Point(239, 226);
            this.lblAnswerPerimeter.Name = "lblAnswerPerimeter";
            this.lblAnswerPerimeter.Size = new System.Drawing.Size(35, 13);
            this.lblAnswerPerimeter.TabIndex = 9;
            this.lblAnswerPerimeter.Text = "label1";
            // 
            // lblAnswerArea
            // 
            this.lblAnswerArea.AutoSize = true;
            this.lblAnswerArea.Location = new System.Drawing.Point(239, 284);
            this.lblAnswerArea.Name = "lblAnswerArea";
            this.lblAnswerArea.Size = new System.Drawing.Size(35, 13);
            this.lblAnswerArea.TabIndex = 10;
            this.lblAnswerArea.Text = "label2";
            // 
            // frmAreaPerimeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 354);
            this.Controls.Add(this.lblAnswerArea);
            this.Controls.Add(this.lblAnswerPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.btnCaculate);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.mnuFile);
            this.Name = "frmAreaPerimeter";
            this.Text = "AreaAndPerimeterOneal";
            this.Load += new System.EventHandler(this.frmAreaPerimeter_Load);
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnCaculate;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblAnswerPerimeter;
        private System.Windows.Forms.Label lblAnswerArea;
    }
}

