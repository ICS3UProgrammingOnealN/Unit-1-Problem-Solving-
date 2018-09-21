namespace SchoolMascotOneal
{
    partial class SchoolMascotForm
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
            this.mnuTeams = new System.Windows.Forms.MenuStrip();
            this.mniTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.mniManCity = new System.Windows.Forms.ToolStripMenuItem();
            this.mniBarcelona = new System.Windows.Forms.ToolStripMenuItem();
            this.mniWolvesFc = new System.Windows.Forms.ToolStripMenuItem();
            this.mniArsenal = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuTeams.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuTeams
            // 
            this.mnuTeams.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTeams});
            this.mnuTeams.Location = new System.Drawing.Point(0, 0);
            this.mnuTeams.Name = "mnuTeams";
            this.mnuTeams.Size = new System.Drawing.Size(284, 24);
            this.mnuTeams.TabIndex = 0;
            this.mnuTeams.Text = "menuStrip1";
            // 
            // mniTeams
            // 
            this.mniTeams.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniManCity,
            this.mniBarcelona,
            this.mniWolvesFc,
            this.mniArsenal});
            this.mniTeams.Name = "mniTeams";
            this.mniTeams.Size = new System.Drawing.Size(53, 20);
            this.mniTeams.Text = "Teams";
            // 
            // mniManCity
            // 
            this.mniManCity.Name = "mniManCity";
            this.mniManCity.Size = new System.Drawing.Size(152, 22);
            this.mniManCity.Text = "Man City";
            // 
            // mniBarcelona
            // 
            this.mniBarcelona.Name = "mniBarcelona";
            this.mniBarcelona.Size = new System.Drawing.Size(152, 22);
            this.mniBarcelona.Text = "Barcelona";
            // 
            // mniWolvesFc
            // 
            this.mniWolvesFc.Name = "mniWolvesFc";
            this.mniWolvesFc.Size = new System.Drawing.Size(152, 22);
            this.mniWolvesFc.Text = "Wolves fc";
            // 
            // mniArsenal
            // 
            this.mniArsenal.Name = "mniArsenal";
            this.mniArsenal.Size = new System.Drawing.Size(152, 22);
            this.mniArsenal.Text = "Arsenal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Man City";
            // 
            // SchoolMascotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuTeams);
            this.Name = "SchoolMascotForm";
            this.Text = "Man City";
            this.mnuTeams.ResumeLayout(false);
            this.mnuTeams.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuTeams;
        private System.Windows.Forms.ToolStripMenuItem mniTeams;
        private System.Windows.Forms.ToolStripMenuItem mniManCity;
        private System.Windows.Forms.ToolStripMenuItem mniBarcelona;
        private System.Windows.Forms.ToolStripMenuItem mniWolvesFc;
        private System.Windows.Forms.ToolStripMenuItem mniArsenal;
        private System.Windows.Forms.Label label1;
    }
}

