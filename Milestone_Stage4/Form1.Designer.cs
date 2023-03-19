namespace Milestone_Project
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
            viewButton = new Button();
            exitButton = new Button();
            editButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // viewButton
            // 
            viewButton.Location = new Point(164, 163);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(150, 46);
            viewButton.TabIndex = 0;
            viewButton.Text = "View";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += viewButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(325, 268);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 46);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(482, 163);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 46);
            editButton.TabIndex = 2;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 92);
            label1.Name = "label1";
            label1.Size = new Size(346, 32);
            label1.TabIndex = 3;
            label1.Text = "Inventory System - Main Menu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(editButton);
            Controls.Add(exitButton);
            Controls.Add(viewButton);
            Name = "Form1";
            Text = "Inventory System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button viewButton;
        private Button exitButton;
        private Button editButton;
        private Label label1;
    }
}