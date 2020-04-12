namespace EvenOddDemo
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
            this.dataDisplayTextbox = new System.Windows.Forms.TextBox();
            this.radioButtonGroupbox = new System.Windows.Forms.GroupBox();
            this.oddRadioButton = new System.Windows.Forms.RadioButton();
            this.evenRadioButton = new System.Windows.Forms.RadioButton();
            this.processButton = new System.Windows.Forms.Button();
            this.resultTextbox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.radioButtonGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataDisplayTextbox
            // 
            this.dataDisplayTextbox.Location = new System.Drawing.Point(32, 36);
            this.dataDisplayTextbox.Multiline = true;
            this.dataDisplayTextbox.Name = "dataDisplayTextbox";
            this.dataDisplayTextbox.ReadOnly = true;
            this.dataDisplayTextbox.Size = new System.Drawing.Size(142, 618);
            this.dataDisplayTextbox.TabIndex = 0;
            // 
            // radioButtonGroupbox
            // 
            this.radioButtonGroupbox.Controls.Add(this.oddRadioButton);
            this.radioButtonGroupbox.Controls.Add(this.evenRadioButton);
            this.radioButtonGroupbox.Location = new System.Drawing.Point(227, 36);
            this.radioButtonGroupbox.Name = "radioButtonGroupbox";
            this.radioButtonGroupbox.Size = new System.Drawing.Size(224, 141);
            this.radioButtonGroupbox.TabIndex = 1;
            this.radioButtonGroupbox.TabStop = false;
            this.radioButtonGroupbox.Text = "Select Even or Odd";
            // 
            // oddRadioButton
            // 
            this.oddRadioButton.AutoSize = true;
            this.oddRadioButton.Location = new System.Drawing.Point(17, 90);
            this.oddRadioButton.Name = "oddRadioButton";
            this.oddRadioButton.Size = new System.Drawing.Size(83, 29);
            this.oddRadioButton.TabIndex = 1;
            this.oddRadioButton.Text = "Odd";
            this.oddRadioButton.UseVisualStyleBackColor = true;
            // 
            // evenRadioButton
            // 
            this.evenRadioButton.AutoSize = true;
            this.evenRadioButton.Checked = true;
            this.evenRadioButton.Location = new System.Drawing.Point(17, 44);
            this.evenRadioButton.Name = "evenRadioButton";
            this.evenRadioButton.Size = new System.Drawing.Size(92, 29);
            this.evenRadioButton.TabIndex = 0;
            this.evenRadioButton.TabStop = true;
            this.evenRadioButton.Text = "Even";
            this.evenRadioButton.UseVisualStyleBackColor = true;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(227, 261);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(129, 42);
            this.processButton.TabIndex = 2;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // resultTextbox
            // 
            this.resultTextbox.Location = new System.Drawing.Point(483, 36);
            this.resultTextbox.Multiline = true;
            this.resultTextbox.Name = "resultTextbox";
            this.resultTextbox.ReadOnly = true;
            this.resultTextbox.Size = new System.Drawing.Size(163, 618);
            this.resultTextbox.TabIndex = 3;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(227, 192);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(129, 46);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(230, 316);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(126, 42);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 666);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.resultTextbox);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.radioButtonGroupbox);
            this.Controls.Add(this.dataDisplayTextbox);
            this.Name = "mainForm";
            this.Text = "Main form";
            this.radioButtonGroupbox.ResumeLayout(false);
            this.radioButtonGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dataDisplayTextbox;
        private System.Windows.Forms.GroupBox radioButtonGroupbox;
        private System.Windows.Forms.RadioButton oddRadioButton;
        private System.Windows.Forms.RadioButton evenRadioButton;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.TextBox resultTextbox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button quitButton;
    }
}

