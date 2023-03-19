namespace Milestone_Project
{
    partial class EditMenu
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
            addButton = new Button();
            removeButton = new Button();
            editButton = new Button();
            exitButton = new Button();
            label1 = new Label();
            restockButton = new Button();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(116, 91);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 46);
            addButton.TabIndex = 0;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(116, 181);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(150, 46);
            removeButton.TabIndex = 1;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(116, 265);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 46);
            editButton.TabIndex = 2;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(116, 476);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 46);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 24);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 4;
            label1.Text = "Edit Menu";
            // 
            // restockButton
            // 
            restockButton.Location = new Point(116, 346);
            restockButton.Name = "restockButton";
            restockButton.Size = new Size(150, 46);
            restockButton.TabIndex = 5;
            restockButton.Text = "Restock";
            restockButton.UseVisualStyleBackColor = true;
            restockButton.Click += restockButton_Click;
            // 
            // EditMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 622);
            Controls.Add(restockButton);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(editButton);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Name = "EditMenu";
            Text = "Edit Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button removeButton;
        private Button editButton;
        private Button exitButton;
        private Label label1;
        private Button restockButton;
    }
}