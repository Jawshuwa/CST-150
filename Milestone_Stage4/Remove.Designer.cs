namespace Milestone_Project
{
    partial class Remove
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
            removeButton = new Button();
            productNumber = new TextBox();
            label1 = new Label();
            label2 = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // removeButton
            // 
            removeButton.Location = new Point(258, 226);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(278, 46);
            removeButton.TabIndex = 0;
            removeButton.Text = "Confirm Removal";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += button1_Click;
            // 
            // productNumber
            // 
            productNumber.Location = new Point(404, 147);
            productNumber.Name = "productNumber";
            productNumber.Size = new Size(200, 39);
            productNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 150);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 2;
            label1.Text = "Product Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 71);
            label2.Name = "label2";
            label2.Size = new Size(170, 32);
            label2.TabIndex = 3;
            label2.Text = "Remove Menu";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(332, 288);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 46);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Remove
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 370);
            Controls.Add(exitButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(productNumber);
            Controls.Add(removeButton);
            Name = "Remove";
            Text = "Remove";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button removeButton;
        private TextBox productNumber;
        private Label label1;
        private Label label2;
        private Button exitButton;
    }
}