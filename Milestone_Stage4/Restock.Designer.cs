namespace Milestone_Project
{
    partial class Restock
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
            exitButton = new Button();
            restockButton = new Button();
            label1 = new Label();
            prodNumberBox = new TextBox();
            valueBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(422, 293);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 46);
            exitButton.TabIndex = 0;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // restockButton
            // 
            restockButton.Location = new Point(221, 293);
            restockButton.Name = "restockButton";
            restockButton.Size = new Size(150, 46);
            restockButton.TabIndex = 1;
            restockButton.Text = "Restock";
            restockButton.UseVisualStyleBackColor = true;
            restockButton.Click += restockButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 41);
            label1.Name = "label1";
            label1.Size = new Size(183, 32);
            label1.TabIndex = 2;
            label1.Text = "Restock an Item";
            // 
            // prodNumberBox
            // 
            prodNumberBox.Location = new Point(171, 164);
            prodNumberBox.Name = "prodNumberBox";
            prodNumberBox.Size = new Size(200, 39);
            prodNumberBox.TabIndex = 3;
            // 
            // valueBox
            // 
            valueBox.Location = new Point(422, 164);
            valueBox.Name = "valueBox";
            valueBox.Size = new Size(200, 39);
            valueBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 129);
            label2.Name = "label2";
            label2.Size = new Size(191, 32);
            label2.TabIndex = 5;
            label2.Text = "Product Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 129);
            label3.Name = "label3";
            label3.Size = new Size(100, 32);
            label3.TabIndex = 6;
            label3.Text = "Amount";
            // 
            // Restock
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(valueBox);
            Controls.Add(prodNumberBox);
            Controls.Add(label1);
            Controls.Add(restockButton);
            Controls.Add(exitButton);
            Name = "Restock";
            Text = "Restock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Button restockButton;
        private Label label1;
        private TextBox prodNumberBox;
        private TextBox valueBox;
        private Label label2;
        private Label label3;
    }
}