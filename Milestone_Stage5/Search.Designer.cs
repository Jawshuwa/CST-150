namespace Milestone_v1._5
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            prodNameButton = new RadioButton();
            prodNumButton = new RadioButton();
            searchTermBox = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            searchListBox = new ListBox();
            searchButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // prodNameButton
            // 
            prodNameButton.AutoSize = true;
            prodNameButton.Location = new Point(29, 117);
            prodNameButton.Name = "prodNameButton";
            prodNameButton.Size = new Size(198, 36);
            prodNameButton.TabIndex = 0;
            prodNameButton.TabStop = true;
            prodNameButton.Text = "Product Name";
            prodNameButton.UseVisualStyleBackColor = true;
            // 
            // prodNumButton
            // 
            prodNumButton.AutoSize = true;
            prodNumButton.Location = new Point(29, 159);
            prodNumButton.Name = "prodNumButton";
            prodNumButton.Size = new Size(222, 36);
            prodNumButton.TabIndex = 1;
            prodNumButton.TabStop = true;
            prodNumButton.Text = "Product Number";
            prodNumButton.UseVisualStyleBackColor = true;
            // 
            // searchTermBox
            // 
            searchTermBox.Location = new Point(418, 133);
            searchTermBox.Name = "searchTermBox";
            searchTermBox.Size = new Size(281, 39);
            searchTermBox.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaptionText;
            pictureBox3.Location = new Point(-18, 219);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(880, 2);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(307, 96);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2, 125);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(-37, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(880, 2);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(447, 49);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 11;
            label1.Text = "Search Term/Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 49);
            label2.Name = "label2";
            label2.Size = new Size(176, 32);
            label2.TabIndex = 12;
            label2.Text = "Search Options";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 230);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 13;
            label3.Text = "Results";
            // 
            // searchListBox
            // 
            searchListBox.FormattingEnabled = true;
            searchListBox.HorizontalScrollbar = true;
            searchListBox.ItemHeight = 32;
            searchListBox.Location = new Point(-2, 265);
            searchListBox.Name = "searchListBox";
            searchListBox.Size = new Size(800, 164);
            searchListBox.TabIndex = 14;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(159, 491);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(150, 46);
            searchButton.TabIndex = 15;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(497, 491);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 46);
            exitButton.TabIndex = 16;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 595);
            Controls.Add(exitButton);
            Controls.Add(searchButton);
            Controls.Add(searchListBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(searchTermBox);
            Controls.Add(prodNumButton);
            Controls.Add(prodNameButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Search";
            Text = "Search Inventory";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton prodNameButton;
        private RadioButton prodNumButton;
        private TextBox searchTermBox;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox searchListBox;
        private Button searchButton;
        private Button exitButton;
    }
}