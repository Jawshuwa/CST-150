namespace Milestone_Project
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            inventoryListBox = new ListBox();
            viewInventoryButton = new Button();
            editMenuButton = new Button();
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            searchButton = new Button();
            label2 = new Label();
            reorderProdName = new Button();
            reorderProdNum = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.HorizontalScrollbar = true;
            inventoryListBox.ItemHeight = 32;
            inventoryListBox.Location = new Point(278, 61);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(631, 612);
            inventoryListBox.TabIndex = 0;
            // 
            // viewInventoryButton
            // 
            viewInventoryButton.Location = new Point(44, 76);
            viewInventoryButton.Name = "viewInventoryButton";
            viewInventoryButton.Size = new Size(202, 46);
            viewInventoryButton.TabIndex = 1;
            viewInventoryButton.Text = "Refresh";
            viewInventoryButton.UseVisualStyleBackColor = true;
            viewInventoryButton.Click += viewInventoryButton_Click;
            // 
            // editMenuButton
            // 
            editMenuButton.Location = new Point(47, 376);
            editMenuButton.Name = "editMenuButton";
            editMenuButton.Size = new Size(202, 46);
            editMenuButton.TabIndex = 2;
            editMenuButton.Text = "Open Edit Menu";
            editMenuButton.UseVisualStyleBackColor = true;
            editMenuButton.Click += editMenuButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(44, 559);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(202, 46);
            exitButton.TabIndex = 4;
            exitButton.Text = "Close Inventory";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(280, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(635, 2);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(278, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2, 680);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(522, 15);
            label1.Name = "label1";
            label1.Size = new Size(115, 32);
            label1.TabIndex = 7;
            label1.Text = "Inventory";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(47, 448);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(202, 46);
            searchButton.TabIndex = 8;
            searchButton.Text = "Search Product";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 145);
            label2.Name = "label2";
            label2.Size = new Size(205, 32);
            label2.TabIndex = 9;
            label2.Text = "Reorder Inventory";
            // 
            // reorderProdName
            // 
            reorderProdName.Location = new Point(47, 180);
            reorderProdName.Name = "reorderProdName";
            reorderProdName.Size = new Size(202, 46);
            reorderProdName.TabIndex = 10;
            reorderProdName.Text = "Product Name";
            reorderProdName.UseVisualStyleBackColor = true;
            reorderProdName.Click += reorderProdName_Click;
            // 
            // reorderProdNum
            // 
            reorderProdNum.Location = new Point(44, 250);
            reorderProdNum.Name = "reorderProdNum";
            reorderProdNum.Size = new Size(205, 46);
            reorderProdNum.TabIndex = 11;
            reorderProdNum.Text = "Product Number";
            reorderProdNum.UseVisualStyleBackColor = true;
            reorderProdNum.Click += reorderProdNum_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 341);
            label3.Name = "label3";
            label3.Size = new Size(252, 32);
            label3.TabIndex = 12;
            label3.Text = "Alter/Search Inventory";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 676);
            Controls.Add(label3);
            Controls.Add(reorderProdNum);
            Controls.Add(reorderProdName);
            Controls.Add(label2);
            Controls.Add(searchButton);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(exitButton);
            Controls.Add(editMenuButton);
            Controls.Add(viewInventoryButton);
            Controls.Add(inventoryListBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            Text = "Inventory Main Menu";
            FormClosed += MainMenu_FormClosed;
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox inventoryListBox;
        private Button editMenuButton;
        private Button exitButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button viewInventoryButton;
        private Button searchButton;
        private Label label2;
        private Button reorderProdName;
        private Button reorderProdNum;
        private Label label3;
    }
}