namespace GUI_Technical_Support
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
            this.computerBeepCheckBox = new System.Windows.Forms.CheckBox();
            this.DiscdriveSpinsCheckBox = new System.Windows.Forms.CheckBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // computerBeepCheckBox
            // 
            this.computerBeepCheckBox.AutoSize = true;
            this.computerBeepCheckBox.Location = new System.Drawing.Point(135, 44);
            this.computerBeepCheckBox.Name = "computerBeepCheckBox";
            this.computerBeepCheckBox.Size = new System.Drawing.Size(204, 29);
            this.computerBeepCheckBox.TabIndex = 0;
            this.computerBeepCheckBox.Text = "Computer Beeps";
            this.computerBeepCheckBox.UseVisualStyleBackColor = true;
            this.computerBeepCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            // 
            // DiscdriveSpinsCheckBox
            // 
            this.DiscdriveSpinsCheckBox.AutoSize = true;
            this.DiscdriveSpinsCheckBox.Location = new System.Drawing.Point(135, 93);
            this.DiscdriveSpinsCheckBox.Name = "DiscdriveSpinsCheckBox";
            this.DiscdriveSpinsCheckBox.Size = new System.Drawing.Size(193, 29);
            this.DiscdriveSpinsCheckBox.TabIndex = 1;
            this.DiscdriveSpinsCheckBox.Text = "Discdrive Spins";
            this.DiscdriveSpinsCheckBox.UseVisualStyleBackColor = true;
            this.DiscdriveSpinsCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(121, 145);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(218, 48);
            this.outputButton.TabIndex = 2;
            this.outputButton.Text = "What should I do?";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(164, 338);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(110, 41);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.ForeColor = System.Drawing.Color.Red;
            this.resultTextBox.Location = new System.Drawing.Point(36, 228);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(391, 92);
            this.resultTextBox.TabIndex = 4;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.DiscdriveSpinsCheckBox);
            this.Controls.Add(this.computerBeepCheckBox);
            this.Name = "mainForm";
            this.Text = "Technical Support";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox computerBeepCheckBox;
        private System.Windows.Forms.CheckBox DiscdriveSpinsCheckBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

