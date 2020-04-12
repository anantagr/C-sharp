namespace button
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
            this.pushMeButton = new System.Windows.Forms.Button();
            this.buttonClickCountLabel = new System.Windows.Forms.Label();
            this.buttonClickOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pushMeButton
            // 
            this.pushMeButton.Location = new System.Drawing.Point(180, 130);
            this.pushMeButton.Name = "pushMeButton";
            this.pushMeButton.Size = new System.Drawing.Size(177, 77);
            this.pushMeButton.TabIndex = 0;
            this.pushMeButton.Text = "Push Me!";
            this.pushMeButton.UseVisualStyleBackColor = true;
            this.pushMeButton.Click += new System.EventHandler(this.pushMeButton_Click);
            // 
            // buttonClickCountLabel
            // 
            this.buttonClickCountLabel.AutoSize = true;
            this.buttonClickCountLabel.Location = new System.Drawing.Point(201, 311);
            this.buttonClickCountLabel.Name = "buttonClickCountLabel";
            this.buttonClickCountLabel.Size = new System.Drawing.Size(190, 25);
            this.buttonClickCountLabel.TabIndex = 1;
            this.buttonClickCountLabel.Text = "Button Click Count";
            this.buttonClickCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClickOutput
            // 
            this.buttonClickOutput.AutoSize = true;
            this.buttonClickOutput.Location = new System.Drawing.Point(931, 311);
            this.buttonClickOutput.Name = "buttonClickOutput";
            this.buttonClickOutput.Size = new System.Drawing.Size(24, 25);
            this.buttonClickOutput.TabIndex = 2;
            this.buttonClickOutput.Text = "0";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 494);
            this.Controls.Add(this.buttonClickOutput);
            this.Controls.Add(this.buttonClickCountLabel);
            this.Controls.Add(this.pushMeButton);
            this.Name = "mainForm";
            this.Text = "lable & button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pushMeButton;
        private System.Windows.Forms.Label buttonClickCountLabel;
        private System.Windows.Forms.Label buttonClickOutput;
    }
}

