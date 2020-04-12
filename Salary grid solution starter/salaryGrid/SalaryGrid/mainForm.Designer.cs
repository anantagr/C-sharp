namespace SalaryGrid
{
    partial class mainForm
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
            System.Windows.Forms.Panel inputPanel;
            this.educationUpdown = new System.Windows.Forms.NumericUpDown();
            this.experienceUpdown = new System.Windows.Forms.NumericUpDown();
            this.educationLabel = new System.Windows.Forms.Label();
            this.experienceLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.salaryTextbox = new System.Windows.Forms.TextBox();
            inputPanel = new System.Windows.Forms.Panel();
            inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.educationUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // inputPanel
            // 
            inputPanel.AutoSize = true;
            inputPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            inputPanel.Controls.Add(this.educationUpdown);
            inputPanel.Controls.Add(this.experienceUpdown);
            inputPanel.Controls.Add(this.educationLabel);
            inputPanel.Controls.Add(this.experienceLabel);
            inputPanel.Location = new System.Drawing.Point(24, 23);
            inputPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            inputPanel.Name = "inputPanel";
            inputPanel.Size = new System.Drawing.Size(380, 112);
            inputPanel.TabIndex = 0;
            // 
            // educationUpdown
            // 
            this.educationUpdown.Location = new System.Drawing.Point(278, 73);
            this.educationUpdown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.educationUpdown.Name = "educationUpdown";
            this.educationUpdown.Size = new System.Drawing.Size(94, 31);
            this.educationUpdown.TabIndex = 1;
            this.educationUpdown.ValueChanged += new System.EventHandler(this.educationUpdown_ValueChanged);
            // 
            // experienceUpdown
            // 
            this.experienceUpdown.Location = new System.Drawing.Point(278, 25);
            this.experienceUpdown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.experienceUpdown.Name = "experienceUpdown";
            this.experienceUpdown.Size = new System.Drawing.Size(94, 31);
            this.experienceUpdown.TabIndex = 1;
            this.experienceUpdown.ValueChanged += new System.EventHandler(this.experienceUpdown_ValueChanged);
            // 
            // educationLabel
            // 
            this.educationLabel.Location = new System.Drawing.Point(26, 63);
            this.educationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.educationLabel.Name = "educationLabel";
            this.educationLabel.Size = new System.Drawing.Size(240, 44);
            this.educationLabel.TabIndex = 0;
            this.educationLabel.Text = "Years of Education: ";
            this.educationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // experienceLabel
            // 
            this.experienceLabel.Location = new System.Drawing.Point(6, 19);
            this.experienceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.experienceLabel.Name = "experienceLabel";
            this.experienceLabel.Size = new System.Drawing.Size(240, 44);
            this.experienceLabel.TabIndex = 0;
            this.experienceLabel.Text = "Years of Experience: ";
            this.experienceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salaryLabel
            // 
            this.salaryLabel.Location = new System.Drawing.Point(120, 150);
            this.salaryLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(108, 44);
            this.salaryLabel.TabIndex = 1;
            this.salaryLabel.Text = "Salary:";
            this.salaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salaryTextbox
            // 
            this.salaryTextbox.Location = new System.Drawing.Point(240, 156);
            this.salaryTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.salaryTextbox.Name = "salaryTextbox";
            this.salaryTextbox.ReadOnly = true;
            this.salaryTextbox.Size = new System.Drawing.Size(162, 31);
            this.salaryTextbox.TabIndex = 2;
            this.salaryTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 219);
            this.Controls.Add(this.salaryTextbox);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(inputPanel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Grid";
            inputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.educationUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceUpdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown educationUpdown;
        private System.Windows.Forms.NumericUpDown experienceUpdown;
        private System.Windows.Forms.Label educationLabel;
        private System.Windows.Forms.Label experienceLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox salaryTextbox;
    }
}