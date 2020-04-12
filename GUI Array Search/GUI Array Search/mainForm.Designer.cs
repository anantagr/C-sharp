namespace GUI_Array_Search
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
            this.randomNumberListTextBox = new System.Windows.Forms.TextBox();
            this.randomNumberListLabel = new System.Windows.Forms.Label();
            this.indexNumberLabel = new System.Windows.Forms.Label();
            this.indexNumberTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // randomNumberListTextBox
            // 
            this.randomNumberListTextBox.Location = new System.Drawing.Point(230, 26);
            this.randomNumberListTextBox.Name = "randomNumberListTextBox";
            this.randomNumberListTextBox.ReadOnly = true;
            this.randomNumberListTextBox.Size = new System.Drawing.Size(747, 31);
            this.randomNumberListTextBox.TabIndex = 0;
            // 
            // randomNumberListLabel
            // 
            this.randomNumberListLabel.AutoSize = true;
            this.randomNumberListLabel.Location = new System.Drawing.Point(12, 26);
            this.randomNumberListLabel.Name = "randomNumberListLabel";
            this.randomNumberListLabel.Size = new System.Drawing.Size(212, 25);
            this.randomNumberListLabel.TabIndex = 1;
            this.randomNumberListLabel.Text = "Random Number list:";
            // 
            // indexNumberLabel
            // 
            this.indexNumberLabel.AutoSize = true;
            this.indexNumberLabel.Location = new System.Drawing.Point(12, 146);
            this.indexNumberLabel.Name = "indexNumberLabel";
            this.indexNumberLabel.Size = new System.Drawing.Size(202, 25);
            this.indexNumberLabel.TabIndex = 2;
            this.indexNumberLabel.Text = "Value to Search for:";
            // 
            // indexNumberTextBox
            // 
            this.indexNumberTextBox.Location = new System.Drawing.Point(230, 140);
            this.indexNumberTextBox.Name = "indexNumberTextBox";
            this.indexNumberTextBox.Size = new System.Drawing.Size(142, 31);
            this.indexNumberTextBox.TabIndex = 3;
            this.indexNumberTextBox.TextChanged += new System.EventHandler(this.indexNumberTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(404, 131);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(135, 48);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(562, 154);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(329, 25);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "result1111111111111111111111";
            this.resultLabel.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 227);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.indexNumberTextBox);
            this.Controls.Add(this.indexNumberLabel);
            this.Controls.Add(this.randomNumberListLabel);
            this.Controls.Add(this.randomNumberListTextBox);
            this.Name = "mainForm";
            this.Text = "Searching Array GUI Application ";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox randomNumberListTextBox;
        private System.Windows.Forms.Label randomNumberListLabel;
        private System.Windows.Forms.Label indexNumberLabel;
        private System.Windows.Forms.TextBox indexNumberTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

