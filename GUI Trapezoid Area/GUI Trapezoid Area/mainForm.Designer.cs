namespace GUI_Trapezoid_Area
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
            this.parellelSide1textBox = new System.Windows.Forms.TextBox();
            this.parellelSide2textBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.parellelSide1Label = new System.Windows.Forms.Label();
            this.parellelSide2Label = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.unitLabel1 = new System.Windows.Forms.Label();
            this.unitLabel3 = new System.Windows.Forms.Label();
            this.unitLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // parellelSide1textBox
            // 
            this.parellelSide1textBox.Location = new System.Drawing.Point(282, 30);
            this.parellelSide1textBox.Name = "parellelSide1textBox";
            this.parellelSide1textBox.Size = new System.Drawing.Size(100, 31);
            this.parellelSide1textBox.TabIndex = 0;
            // 
            // parellelSide2textBox
            // 
            this.parellelSide2textBox.Location = new System.Drawing.Point(282, 91);
            this.parellelSide2textBox.Name = "parellelSide2textBox";
            this.parellelSide2textBox.Size = new System.Drawing.Size(100, 31);
            this.parellelSide2textBox.TabIndex = 1;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(282, 155);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 31);
            this.heightTextBox.TabIndex = 2;
            // 
            // parellelSide1Label
            // 
            this.parellelSide1Label.AutoSize = true;
            this.parellelSide1Label.Location = new System.Drawing.Point(12, 30);
            this.parellelSide1Label.Name = "parellelSide1Label";
            this.parellelSide1Label.Size = new System.Drawing.Size(253, 25);
            this.parellelSide1Label.TabIndex = 3;
            this.parellelSide1Label.Text = "Length of Parallel Side 1:";
            // 
            // parellelSide2Label
            // 
            this.parellelSide2Label.AutoSize = true;
            this.parellelSide2Label.Location = new System.Drawing.Point(12, 91);
            this.parellelSide2Label.Name = "parellelSide2Label";
            this.parellelSide2Label.Size = new System.Drawing.Size(253, 25);
            this.parellelSide2Label.TabIndex = 4;
            this.parellelSide2Label.Text = "Length of Parallel Side 2:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(89, 155);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(176, 25);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Length of Height:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(159, 209);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 25);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(17, 209);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(118, 48);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(17, 274);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(118, 48);
            this.quitButton.TabIndex = 8;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // unitLabel1
            // 
            this.unitLabel1.AutoSize = true;
            this.unitLabel1.Location = new System.Drawing.Point(388, 36);
            this.unitLabel1.Name = "unitLabel1";
            this.unitLabel1.Size = new System.Drawing.Size(29, 25);
            this.unitLabel1.TabIndex = 9;
            this.unitLabel1.Text = "m";
            // 
            // unitLabel3
            // 
            this.unitLabel3.AutoSize = true;
            this.unitLabel3.Location = new System.Drawing.Point(388, 161);
            this.unitLabel3.Name = "unitLabel3";
            this.unitLabel3.Size = new System.Drawing.Size(29, 25);
            this.unitLabel3.TabIndex = 10;
            this.unitLabel3.Text = "m";
            // 
            // unitLabel2
            // 
            this.unitLabel2.AutoSize = true;
            this.unitLabel2.Location = new System.Drawing.Point(388, 97);
            this.unitLabel2.Name = "unitLabel2";
            this.unitLabel2.Size = new System.Drawing.Size(29, 25);
            this.unitLabel2.TabIndex = 11;
            this.unitLabel2.Text = "m";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.unitLabel2);
            this.Controls.Add(this.unitLabel3);
            this.Controls.Add(this.unitLabel1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.parellelSide2Label);
            this.Controls.Add(this.parellelSide1Label);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.parellelSide2textBox);
            this.Controls.Add(this.parellelSide1textBox);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trapezoid Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox parellelSide1textBox;
        private System.Windows.Forms.TextBox parellelSide2textBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label parellelSide1Label;
        private System.Windows.Forms.Label parellelSide2Label;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label unitLabel1;
        private System.Windows.Forms.Label unitLabel3;
        private System.Windows.Forms.Label unitLabel2;
    }
}

