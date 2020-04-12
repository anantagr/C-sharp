namespace gui_hello_world
{
    partial class MainForm
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
            this.helloWorldLable = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.changeLanguageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // helloWorldLable
            // 
            this.helloWorldLable.AutoSize = true;
            this.helloWorldLable.Font = new System.Drawing.Font("Comic Sans MS", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloWorldLable.Location = new System.Drawing.Point(57, 9);
            this.helloWorldLable.Name = "helloWorldLable";
            this.helloWorldLable.Size = new System.Drawing.Size(338, 74);
            this.helloWorldLable.TabIndex = 0;
            this.helloWorldLable.Text = "Hello World";
            this.helloWorldLable.Click += new System.EventHandler(this.helloWorldLable_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(326, 308);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(108, 42);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // changeLanguageButton
            // 
            this.changeLanguageButton.Location = new System.Drawing.Point(256, 223);
            this.changeLanguageButton.Name = "changeLanguageButton";
            this.changeLanguageButton.Size = new System.Drawing.Size(251, 37);
            this.changeLanguageButton.TabIndex = 2;
            this.changeLanguageButton.Text = "en français";
            this.changeLanguageButton.UseVisualStyleBackColor = true;
            this.changeLanguageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(851, 410);
            this.Controls.Add(this.changeLanguageButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.helloWorldLable);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My first GUI Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloWorldLable;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button changeLanguageButton;
    }
}

