namespace getIntegarDialog_Development
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
            this.getIntegarButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.enteredIntegarTextBox = new System.Windows.Forms.TextBox();
            this.useCustomerPromptCheckbox = new System.Windows.Forms.CheckBox();
            this.customPromptTextbox = new System.Windows.Forms.TextBox();
            this.useMinimumValueCheckbox = new System.Windows.Forms.CheckBox();
            this.minimumValueTextBox = new System.Windows.Forms.TextBox();
            this.maximumValueTextBox = new System.Windows.Forms.TextBox();
            this.useMaximumValueCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // getIntegarButton
            // 
            this.getIntegarButton.Location = new System.Drawing.Point(34, 45);
            this.getIntegarButton.Name = "getIntegarButton";
            this.getIntegarButton.Size = new System.Drawing.Size(155, 58);
            this.getIntegarButton.TabIndex = 0;
            this.getIntegarButton.Text = "Get Integar";
            this.getIntegarButton.UseVisualStyleBackColor = true;
            this.getIntegarButton.Click += new System.EventHandler(this.getIntegarButton_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(279, 60);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(270, 31);
            this.statusTextBox.TabIndex = 1;
            // 
            // enteredIntegarTextBox
            // 
            this.enteredIntegarTextBox.Location = new System.Drawing.Point(279, 131);
            this.enteredIntegarTextBox.Name = "enteredIntegarTextBox";
            this.enteredIntegarTextBox.ReadOnly = true;
            this.enteredIntegarTextBox.Size = new System.Drawing.Size(270, 31);
            this.enteredIntegarTextBox.TabIndex = 2;
            // 
            // useCustomerPromptCheckbox
            // 
            this.useCustomerPromptCheckbox.AutoSize = true;
            this.useCustomerPromptCheckbox.Location = new System.Drawing.Point(34, 222);
            this.useCustomerPromptCheckbox.Name = "useCustomerPromptCheckbox";
            this.useCustomerPromptCheckbox.Size = new System.Drawing.Size(112, 29);
            this.useCustomerPromptCheckbox.TabIndex = 3;
            this.useCustomerPromptCheckbox.Text = "Prompt";
            this.useCustomerPromptCheckbox.UseVisualStyleBackColor = true;
            // 
            // customPromptTextbox
            // 
            this.customPromptTextbox.Location = new System.Drawing.Point(279, 219);
            this.customPromptTextbox.Name = "customPromptTextbox";
            this.customPromptTextbox.Size = new System.Drawing.Size(270, 31);
            this.customPromptTextbox.TabIndex = 4;
            // 
            // useMinimumValueCheckbox
            // 
            this.useMinimumValueCheckbox.AutoSize = true;
            this.useMinimumValueCheckbox.Location = new System.Drawing.Point(34, 285);
            this.useMinimumValueCheckbox.Name = "useMinimumValueCheckbox";
            this.useMinimumValueCheckbox.Size = new System.Drawing.Size(130, 29);
            this.useMinimumValueCheckbox.TabIndex = 5;
            this.useMinimumValueCheckbox.Text = "Minimum";
            this.useMinimumValueCheckbox.UseVisualStyleBackColor = true;
            // 
            // minimumValueTextBox
            // 
            this.minimumValueTextBox.Location = new System.Drawing.Point(279, 283);
            this.minimumValueTextBox.Name = "minimumValueTextBox";
            this.minimumValueTextBox.Size = new System.Drawing.Size(270, 31);
            this.minimumValueTextBox.TabIndex = 6;
            // 
            // maximumValueTextBox
            // 
            this.maximumValueTextBox.Location = new System.Drawing.Point(279, 338);
            this.maximumValueTextBox.Name = "maximumValueTextBox";
            this.maximumValueTextBox.Size = new System.Drawing.Size(270, 31);
            this.maximumValueTextBox.TabIndex = 8;
            // 
            // useMaximumValueCheckbox
            // 
            this.useMaximumValueCheckbox.AutoSize = true;
            this.useMaximumValueCheckbox.Location = new System.Drawing.Point(34, 340);
            this.useMaximumValueCheckbox.Name = "useMaximumValueCheckbox";
            this.useMaximumValueCheckbox.Size = new System.Drawing.Size(136, 29);
            this.useMaximumValueCheckbox.TabIndex = 7;
            this.useMaximumValueCheckbox.Text = "Maximum";
            this.useMaximumValueCheckbox.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maximumValueTextBox);
            this.Controls.Add(this.useMaximumValueCheckbox);
            this.Controls.Add(this.minimumValueTextBox);
            this.Controls.Add(this.useMinimumValueCheckbox);
            this.Controls.Add(this.customPromptTextbox);
            this.Controls.Add(this.useCustomerPromptCheckbox);
            this.Controls.Add(this.enteredIntegarTextBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.getIntegarButton);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Integar Development";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getIntegarButton;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox enteredIntegarTextBox;
        private System.Windows.Forms.CheckBox useCustomerPromptCheckbox;
        private System.Windows.Forms.TextBox customPromptTextbox;
        private System.Windows.Forms.CheckBox useMinimumValueCheckbox;
        private System.Windows.Forms.TextBox minimumValueTextBox;
        private System.Windows.Forms.TextBox maximumValueTextBox;
        private System.Windows.Forms.CheckBox useMaximumValueCheckbox;
    }
}

