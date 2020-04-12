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
            this.mouseEnterCountLabel = new System.Windows.Forms.Label();
            this.mouseEnterOutput = new System.Windows.Forms.Label();
            this.mouseUpCountLabel = new System.Windows.Forms.Label();
            this.mouseLeaveCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mouseHoverCountLabel = new System.Windows.Forms.Label();
            this.mouseMoveCountLabel = new System.Windows.Forms.Label();
            this.mouseHoverOutput = new System.Windows.Forms.Label();
            this.mouseMoveOutput = new System.Windows.Forms.Label();
            this.mouseUpOutput = new System.Windows.Forms.Label();
            this.mouseLeaveOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pushMeButton
            // 
            this.pushMeButton.Location = new System.Drawing.Point(192, 39);
            this.pushMeButton.Name = "pushMeButton";
            this.pushMeButton.Size = new System.Drawing.Size(177, 77);
            this.pushMeButton.TabIndex = 0;
            this.pushMeButton.Text = "Push Me!";
            this.pushMeButton.UseVisualStyleBackColor = true;
            this.pushMeButton.Click += new System.EventHandler(this.pushMeButton_Click);
            this.pushMeButton.MouseEnter += new System.EventHandler(this.pushMeButton_MouseEnter);
            this.pushMeButton.MouseLeave += new System.EventHandler(this.pushMeButton_MouseLeave);
            this.pushMeButton.MouseHover += new System.EventHandler(this.pushMeButton_MouseHover);
            this.pushMeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pushMeButton_MouseUp);
            // 
            // buttonClickCountLabel
            // 
            this.buttonClickCountLabel.AutoSize = true;
            this.buttonClickCountLabel.Location = new System.Drawing.Point(187, 157);
            this.buttonClickCountLabel.Name = "buttonClickCountLabel";
            this.buttonClickCountLabel.Size = new System.Drawing.Size(190, 25);
            this.buttonClickCountLabel.TabIndex = 1;
            this.buttonClickCountLabel.Text = "Button Click Count";
            this.buttonClickCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClickOutput
            // 
            this.buttonClickOutput.AutoSize = true;
            this.buttonClickOutput.Location = new System.Drawing.Point(917, 157);
            this.buttonClickOutput.Name = "buttonClickOutput";
            this.buttonClickOutput.Size = new System.Drawing.Size(24, 25);
            this.buttonClickOutput.TabIndex = 2;
            this.buttonClickOutput.Text = "0";
            // 
            // mouseEnterCountLabel
            // 
            this.mouseEnterCountLabel.AutoSize = true;
            this.mouseEnterCountLabel.Location = new System.Drawing.Point(187, 209);
            this.mouseEnterCountLabel.Name = "mouseEnterCountLabel";
            this.mouseEnterCountLabel.Size = new System.Drawing.Size(197, 25);
            this.mouseEnterCountLabel.TabIndex = 1;
            this.mouseEnterCountLabel.Text = "Mouse Enter Count";
            this.mouseEnterCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mouseEnterOutput
            // 
            this.mouseEnterOutput.AutoSize = true;
            this.mouseEnterOutput.Location = new System.Drawing.Point(917, 209);
            this.mouseEnterOutput.Name = "mouseEnterOutput";
            this.mouseEnterOutput.Size = new System.Drawing.Size(24, 25);
            this.mouseEnterOutput.TabIndex = 2;
            this.mouseEnterOutput.Text = "0";
            // 
            // mouseUpCountLabel
            // 
            this.mouseUpCountLabel.AutoSize = true;
            this.mouseUpCountLabel.Location = new System.Drawing.Point(187, 269);
            this.mouseUpCountLabel.Name = "mouseUpCountLabel";
            this.mouseUpCountLabel.Size = new System.Drawing.Size(173, 25);
            this.mouseUpCountLabel.TabIndex = 1;
            this.mouseUpCountLabel.Text = "Mouse Up Count";
            this.mouseUpCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mouseLeaveCountLabel
            // 
            this.mouseLeaveCountLabel.AutoSize = true;
            this.mouseLeaveCountLabel.Location = new System.Drawing.Point(187, 334);
            this.mouseLeaveCountLabel.Name = "mouseLeaveCountLabel";
            this.mouseLeaveCountLabel.Size = new System.Drawing.Size(205, 25);
            this.mouseLeaveCountLabel.TabIndex = 1;
            this.mouseLeaveCountLabel.Text = "Mouse Leave Count";
            this.mouseLeaveCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mouse Enter Count";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mouseHoverCountLabel
            // 
            this.mouseHoverCountLabel.AutoSize = true;
            this.mouseHoverCountLabel.Location = new System.Drawing.Point(187, 394);
            this.mouseHoverCountLabel.Name = "mouseHoverCountLabel";
            this.mouseHoverCountLabel.Size = new System.Drawing.Size(203, 25);
            this.mouseHoverCountLabel.TabIndex = 1;
            this.mouseHoverCountLabel.Text = "Mouse Hover Count";
            this.mouseHoverCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mouseMoveCountLabel
            // 
            this.mouseMoveCountLabel.AutoSize = true;
            this.mouseMoveCountLabel.Location = new System.Drawing.Point(187, 444);
            this.mouseMoveCountLabel.Name = "mouseMoveCountLabel";
            this.mouseMoveCountLabel.Size = new System.Drawing.Size(199, 25);
            this.mouseMoveCountLabel.TabIndex = 1;
            this.mouseMoveCountLabel.Text = "Mouse Move Count";
            this.mouseMoveCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mouseHoverOutput
            // 
            this.mouseHoverOutput.AutoSize = true;
            this.mouseHoverOutput.Location = new System.Drawing.Point(917, 394);
            this.mouseHoverOutput.Name = "mouseHoverOutput";
            this.mouseHoverOutput.Size = new System.Drawing.Size(24, 25);
            this.mouseHoverOutput.TabIndex = 2;
            this.mouseHoverOutput.Text = "0";
            // 
            // mouseMoveOutput
            // 
            this.mouseMoveOutput.AutoSize = true;
            this.mouseMoveOutput.Location = new System.Drawing.Point(917, 444);
            this.mouseMoveOutput.Name = "mouseMoveOutput";
            this.mouseMoveOutput.Size = new System.Drawing.Size(24, 25);
            this.mouseMoveOutput.TabIndex = 2;
            this.mouseMoveOutput.Text = "0";
            // 
            // mouseUpOutput
            // 
            this.mouseUpOutput.AutoSize = true;
            this.mouseUpOutput.Location = new System.Drawing.Point(917, 269);
            this.mouseUpOutput.Name = "mouseUpOutput";
            this.mouseUpOutput.Size = new System.Drawing.Size(24, 25);
            this.mouseUpOutput.TabIndex = 2;
            this.mouseUpOutput.Text = "0";
            // 
            // mouseLeaveOutput
            // 
            this.mouseLeaveOutput.AutoSize = true;
            this.mouseLeaveOutput.Location = new System.Drawing.Point(917, 334);
            this.mouseLeaveOutput.Name = "mouseLeaveOutput";
            this.mouseLeaveOutput.Size = new System.Drawing.Size(24, 25);
            this.mouseLeaveOutput.TabIndex = 2;
            this.mouseLeaveOutput.Text = "0";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 494);
            this.Controls.Add(this.mouseMoveOutput);
            this.Controls.Add(this.mouseHoverOutput);
            this.Controls.Add(this.mouseLeaveOutput);
            this.Controls.Add(this.mouseUpOutput);
            this.Controls.Add(this.mouseEnterOutput);
            this.Controls.Add(this.buttonClickOutput);
            this.Controls.Add(this.mouseMoveCountLabel);
            this.Controls.Add(this.mouseHoverCountLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mouseLeaveCountLabel);
            this.Controls.Add(this.mouseUpCountLabel);
            this.Controls.Add(this.mouseEnterCountLabel);
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
        private System.Windows.Forms.Label mouseEnterCountLabel;
        private System.Windows.Forms.Label mouseEnterOutput;
        private System.Windows.Forms.Label mouseUpCountLabel;
        private System.Windows.Forms.Label mouseLeaveCountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mouseHoverCountLabel;
        private System.Windows.Forms.Label mouseMoveCountLabel;
        private System.Windows.Forms.Label mouseHoverOutput;
        private System.Windows.Forms.Label mouseMoveOutput;
        private System.Windows.Forms.Label mouseUpOutput;
        private System.Windows.Forms.Label mouseLeaveOutput;
    }
}

