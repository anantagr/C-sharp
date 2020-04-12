namespace GUIFileOperations
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
            System.Windows.Forms.Label sumLabel;
            System.Windows.Forms.Label averageLabel;
            System.Windows.Forms.Label minimumLabel;
            System.Windows.Forms.Label maximumLabel;
            System.Windows.Forms.FlowLayoutPanel statsFlowPanel;
            this.sumTextbox = new System.Windows.Forms.TextBox();
            this.averageTextbox = new System.Windows.Forms.TextBox();
            this.minimumTextbox = new System.Windows.Forms.TextBox();
            this.maximumTextbox = new System.Windows.Forms.TextBox();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.filePathTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.writeResultButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            sumLabel = new System.Windows.Forms.Label();
            averageLabel = new System.Windows.Forms.Label();
            minimumLabel = new System.Windows.Forms.Label();
            maximumLabel = new System.Windows.Forms.Label();
            statsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            statsFlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sumLabel
            // 
            sumLabel.Location = new System.Drawing.Point(6, 0);
            sumLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new System.Drawing.Size(124, 44);
            sumLabel.TabIndex = 4;
            sumLabel.Text = "Sum: ";
            sumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // averageLabel
            // 
            averageLabel.Location = new System.Drawing.Point(6, 44);
            averageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new System.Drawing.Size(124, 44);
            averageLabel.TabIndex = 4;
            averageLabel.Text = "Average: ";
            averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minimumLabel
            // 
            minimumLabel.Location = new System.Drawing.Point(6, 88);
            minimumLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            minimumLabel.Name = "minimumLabel";
            minimumLabel.Size = new System.Drawing.Size(124, 44);
            minimumLabel.TabIndex = 4;
            minimumLabel.Text = "Minimum: ";
            minimumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maximumLabel
            // 
            maximumLabel.Location = new System.Drawing.Point(6, 132);
            maximumLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            maximumLabel.Name = "maximumLabel";
            maximumLabel.Size = new System.Drawing.Size(124, 44);
            maximumLabel.TabIndex = 4;
            maximumLabel.Text = "Maximum: ";
            maximumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statsFlowPanel
            // 
            statsFlowPanel.Controls.Add(sumLabel);
            statsFlowPanel.Controls.Add(this.sumTextbox);
            statsFlowPanel.Controls.Add(averageLabel);
            statsFlowPanel.Controls.Add(this.averageTextbox);
            statsFlowPanel.Controls.Add(minimumLabel);
            statsFlowPanel.Controls.Add(this.minimumTextbox);
            statsFlowPanel.Controls.Add(maximumLabel);
            statsFlowPanel.Controls.Add(this.maximumTextbox);
            statsFlowPanel.Location = new System.Drawing.Point(210, 79);
            statsFlowPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            statsFlowPanel.Name = "statsFlowPanel";
            statsFlowPanel.Size = new System.Drawing.Size(364, 213);
            statsFlowPanel.TabIndex = 6;
            // 
            // sumTextbox
            // 
            this.sumTextbox.Location = new System.Drawing.Point(142, 6);
            this.sumTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sumTextbox.Name = "sumTextbox";
            this.sumTextbox.ReadOnly = true;
            this.sumTextbox.Size = new System.Drawing.Size(156, 31);
            this.sumTextbox.TabIndex = 5;
            // 
            // averageTextbox
            // 
            this.averageTextbox.Location = new System.Drawing.Point(142, 50);
            this.averageTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.averageTextbox.Name = "averageTextbox";
            this.averageTextbox.ReadOnly = true;
            this.averageTextbox.Size = new System.Drawing.Size(156, 31);
            this.averageTextbox.TabIndex = 5;
            // 
            // minimumTextbox
            // 
            this.minimumTextbox.Location = new System.Drawing.Point(142, 94);
            this.minimumTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.minimumTextbox.Name = "minimumTextbox";
            this.minimumTextbox.ReadOnly = true;
            this.minimumTextbox.Size = new System.Drawing.Size(156, 31);
            this.minimumTextbox.TabIndex = 5;
            // 
            // maximumTextbox
            // 
            this.maximumTextbox.Location = new System.Drawing.Point(142, 138);
            this.maximumTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.maximumTextbox.Name = "maximumTextbox";
            this.maximumTextbox.ReadOnly = true;
            this.maximumTextbox.Size = new System.Drawing.Size(156, 31);
            this.maximumTextbox.TabIndex = 5;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(42, 29);
            this.selectFileButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(150, 44);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // filePathTextbox
            // 
            this.filePathTextbox.Location = new System.Drawing.Point(212, 29);
            this.filePathTextbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.filePathTextbox.Name = "filePathTextbox";
            this.filePathTextbox.Size = new System.Drawing.Size(566, 31);
            this.filePathTextbox.TabIndex = 1;
            this.filePathTextbox.TextChanged += new System.EventHandler(this.filePathTextbox_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(42, 135);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(150, 44);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // writeResultButton
            // 
            this.writeResultButton.Enabled = false;
            this.writeResultButton.Location = new System.Drawing.Point(42, 248);
            this.writeResultButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.writeResultButton.Name = "writeResultButton";
            this.writeResultButton.Size = new System.Drawing.Size(150, 44);
            this.writeResultButton.TabIndex = 3;
            this.writeResultButton.Text = "Write Result";
            this.writeResultButton.UseVisualStyleBackColor = true;
            this.writeResultButton.Click += new System.EventHandler(this.writeResultButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(632, 248);
            this.quitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(150, 44);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 317);
            this.Controls.Add(statsFlowPanel);
            this.Controls.Add(this.filePathTextbox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.writeResultButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.selectFileButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read Numbers from File and Calulate Statistics";
            statsFlowPanel.ResumeLayout(false);
            statsFlowPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.TextBox filePathTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox sumTextbox;
        private System.Windows.Forms.Button writeResultButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.TextBox averageTextbox;
        private System.Windows.Forms.TextBox minimumTextbox;
        private System.Windows.Forms.TextBox maximumTextbox;
    }
}

