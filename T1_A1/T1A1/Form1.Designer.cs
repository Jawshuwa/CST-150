namespace T1A1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hiddenText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(265, 269);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(150, 46);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Topic 1 Activity 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "There is some hidden text below me!";
            // 
            // hiddenText
            // 
            this.hiddenText.AutoSize = true;
            this.hiddenText.Location = new System.Drawing.Point(260, 193);
            this.hiddenText.Name = "hiddenText";
            this.hiddenText.Size = new System.Drawing.Size(155, 32);
            this.hiddenText.TabIndex = 4;
            this.hiddenText.Text = "I was hidden!";
            this.hiddenText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 354);
            this.Controls.Add(this.hiddenText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button showButton;
        private Label label1;
        private Label label2;
        private Label hiddenText;
    }
}