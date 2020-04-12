namespace DictionaryDemo
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
            System.Windows.Forms.Label keyLabel;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label label1;
            this.addGroupbox = new System.Windows.Forms.GroupBox();
            this.lookupButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.valueTextbox = new System.Windows.Forms.TextBox();
            this.keyTextbox = new System.Windows.Forms.TextBox();
            this.displayGroupbox = new System.Windows.Forms.GroupBox();
            this.displayDictionaryButton = new System.Windows.Forms.Button();
            this.dictionaryDisplayTextbox = new System.Windows.Forms.TextBox();
            this.removeKeyButton = new System.Windows.Forms.Button();
            this.clearDictionaryButton = new System.Windows.Forms.Button();
            keyLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.addGroupbox.SuspendLayout();
            this.displayGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyLabel
            // 
            keyLabel.Location = new System.Drawing.Point(7, 20);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new System.Drawing.Size(55, 23);
            keyLabel.TabIndex = 0;
            keyLabel.Text = "Key:";
            keyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valueLabel
            // 
            valueLabel.Location = new System.Drawing.Point(6, 43);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(55, 23);
            valueLabel.TabIndex = 0;
            valueLabel.Text = "Value:";
            valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(6, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 23);
            label1.TabIndex = 0;
            label1.Text = "Value:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addGroupbox
            // 
            this.addGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addGroupbox.Controls.Add(this.clearDictionaryButton);
            this.addGroupbox.Controls.Add(this.removeKeyButton);
            this.addGroupbox.Controls.Add(this.lookupButton);
            this.addGroupbox.Controls.Add(this.addButton);
            this.addGroupbox.Controls.Add(this.valueTextbox);
            this.addGroupbox.Controls.Add(this.keyTextbox);
            this.addGroupbox.Controls.Add(label1);
            this.addGroupbox.Controls.Add(valueLabel);
            this.addGroupbox.Controls.Add(keyLabel);
            this.addGroupbox.Location = new System.Drawing.Point(13, 13);
            this.addGroupbox.Name = "addGroupbox";
            this.addGroupbox.Size = new System.Drawing.Size(458, 112);
            this.addGroupbox.TabIndex = 0;
            this.addGroupbox.TabStop = false;
            this.addGroupbox.Text = "Add";
            // 
            // lookupButton
            // 
            this.lookupButton.Location = new System.Drawing.Point(295, 76);
            this.lookupButton.Name = "lookupButton";
            this.lookupButton.Size = new System.Drawing.Size(75, 23);
            this.lookupButton.TabIndex = 3;
            this.lookupButton.Text = "Lookup Key";
            this.lookupButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(376, 76);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Pair";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // valueTextbox
            // 
            this.valueTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueTextbox.Location = new System.Drawing.Point(68, 49);
            this.valueTextbox.Name = "valueTextbox";
            this.valueTextbox.Size = new System.Drawing.Size(384, 20);
            this.valueTextbox.TabIndex = 1;
            // 
            // keyTextbox
            // 
            this.keyTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTextbox.Location = new System.Drawing.Point(68, 23);
            this.keyTextbox.Name = "keyTextbox";
            this.keyTextbox.Size = new System.Drawing.Size(384, 20);
            this.keyTextbox.TabIndex = 1;
            // 
            // displayGroupbox
            // 
            this.displayGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayGroupbox.Controls.Add(this.displayDictionaryButton);
            this.displayGroupbox.Controls.Add(this.dictionaryDisplayTextbox);
            this.displayGroupbox.Location = new System.Drawing.Point(13, 132);
            this.displayGroupbox.Name = "displayGroupbox";
            this.displayGroupbox.Size = new System.Drawing.Size(458, 218);
            this.displayGroupbox.TabIndex = 1;
            this.displayGroupbox.TabStop = false;
            this.displayGroupbox.Text = "Display of Dictionary";
            // 
            // displayDictionaryButton
            // 
            this.displayDictionaryButton.Location = new System.Drawing.Point(10, 20);
            this.displayDictionaryButton.Name = "displayDictionaryButton";
            this.displayDictionaryButton.Size = new System.Drawing.Size(105, 23);
            this.displayDictionaryButton.TabIndex = 1;
            this.displayDictionaryButton.Text = "Display Contents";
            this.displayDictionaryButton.UseVisualStyleBackColor = true;
            // 
            // dictionaryDisplayTextbox
            // 
            this.dictionaryDisplayTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dictionaryDisplayTextbox.Location = new System.Drawing.Point(10, 58);
            this.dictionaryDisplayTextbox.Multiline = true;
            this.dictionaryDisplayTextbox.Name = "dictionaryDisplayTextbox";
            this.dictionaryDisplayTextbox.ReadOnly = true;
            this.dictionaryDisplayTextbox.Size = new System.Drawing.Size(441, 154);
            this.dictionaryDisplayTextbox.TabIndex = 0;
            // 
            // removeKeyButton
            // 
            this.removeKeyButton.Location = new System.Drawing.Point(202, 76);
            this.removeKeyButton.Name = "removeKeyButton";
            this.removeKeyButton.Size = new System.Drawing.Size(87, 23);
            this.removeKeyButton.TabIndex = 4;
            this.removeKeyButton.Text = "Remove Key";
            this.removeKeyButton.UseVisualStyleBackColor = true;
            // 
            // clearDictionaryButton
            // 
            this.clearDictionaryButton.Location = new System.Drawing.Point(114, 76);
            this.clearDictionaryButton.Name = "clearDictionaryButton";
            this.clearDictionaryButton.Size = new System.Drawing.Size(82, 23);
            this.clearDictionaryButton.TabIndex = 5;
            this.clearDictionaryButton.Text = "Clear";
            this.clearDictionaryButton.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 360);
            this.Controls.Add(this.displayGroupbox);
            this.Controls.Add(this.addGroupbox);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary Demonstartion";
            this.addGroupbox.ResumeLayout(false);
            this.addGroupbox.PerformLayout();
            this.displayGroupbox.ResumeLayout(false);
            this.displayGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addGroupbox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox valueTextbox;
        private System.Windows.Forms.TextBox keyTextbox;
        private System.Windows.Forms.GroupBox displayGroupbox;
        private System.Windows.Forms.Button displayDictionaryButton;
        private System.Windows.Forms.TextBox dictionaryDisplayTextbox;
        private System.Windows.Forms.Button lookupButton;
        private System.Windows.Forms.Button clearDictionaryButton;
        private System.Windows.Forms.Button removeKeyButton;
    }
}

