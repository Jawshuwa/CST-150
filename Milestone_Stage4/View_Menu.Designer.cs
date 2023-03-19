namespace Milestone_Project
{
    partial class View_Menu
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
            searchButton = new Button();
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            viewButton = new Button();
            inventoryListBox = new ListBox();
            reorderProdName = new Button();
            reorderProdNum = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Location = new Point(24, 370);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(192, 46);
            searchButton.TabIndex = 0;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(24, 468);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(192, 46);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(256, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2, 666);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(256, 63);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(670, 2);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(526, 28);
            label1.Name = "label1";
            label1.Size = new Size(115, 32);
            label1.TabIndex = 5;
            label1.Text = "Inventory";
            // 
            // viewButton
            // 
            viewButton.Location = new Point(24, 86);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(192, 46);
            viewButton.TabIndex = 6;
            viewButton.Text = "View/Update";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += viewButton_Click;
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.HorizontalScrollbar = true;
            inventoryListBox.ItemHeight = 32;
            inventoryListBox.Location = new Point(258, 65);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(649, 580);
            inventoryListBox.TabIndex = 7;
            // 
            // reorderProdName
            // 
            reorderProdName.Location = new Point(24, 206);
            reorderProdName.Name = "reorderProdName";
            reorderProdName.Size = new Size(192, 46);
            reorderProdName.TabIndex = 8;
            reorderProdName.Text = "Product Name";
            reorderProdName.UseVisualStyleBackColor = true;
            reorderProdName.Click += reorderProdName_Click;
            // 
            // reorderProdNum
            // 
            reorderProdNum.Location = new Point(24, 258);
            reorderProdNum.Name = "reorderProdNum";
            reorderProdNum.Size = new Size(192, 46);
            reorderProdNum.TabIndex = 9;
            reorderProdNum.Text = "Product #";
            reorderProdNum.UseVisualStyleBackColor = true;
            reorderProdNum.Click += reorderProdNum_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 171);
            label2.Name = "label2";
            label2.Size = new Size(205, 32);
            label2.TabIndex = 10;
            label2.Text = "Reorder Inventory";
            // 
            // View_Menu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 640);
            Controls.Add(label2);
            Controls.Add(reorderProdNum);
            Controls.Add(reorderProdName);
            Controls.Add(inventoryListBox);
            Controls.Add(viewButton);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(exitButton);
            Controls.Add(searchButton);
            Name = "View_Menu";
            Text = "View_Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private Button exitButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button viewButton;
        private ListBox inventoryListBox;
        private Button reorderProdName;
        private Button reorderProdNum;
        private Label label2;
    }
}