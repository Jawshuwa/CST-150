namespace Milestone_Project
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
            productName = new RadioButton();
            productNumber = new RadioButton();
            label1 = new Label();
            searchParameter = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            searchButton = new Button();
            searchListBox = new ListBox();
            label3 = new Label();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // productName
            // 
            productName.AutoSize = true;
            productName.Location = new Point(52, 132);
            productName.Name = "productName";
            productName.Size = new Size(198, 36);
            productName.TabIndex = 0;
            productName.TabStop = true;
            productName.Text = "Product Name";
            productName.UseVisualStyleBackColor = true;
            // 
            // productNumber
            // 
            productNumber.AutoSize = true;
            productNumber.Location = new Point(52, 174);
            productNumber.Name = "productNumber";
            productNumber.Size = new Size(222, 36);
            productNumber.TabIndex = 1;
            productNumber.TabStop = true;
            productNumber.Text = "Product Number";
            productNumber.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 74);
            label1.Name = "label1";
            label1.Size = new Size(176, 32);
            label1.TabIndex = 2;
            label1.Text = "Search Options";
            // 
            // searchParameter
            // 
            searchParameter.Location = new Point(392, 158);
            searchParameter.Name = "searchParameter";
            searchParameter.Size = new Size(318, 39);
            searchParameter.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 79);
            label2.Name = "label2";
            label2.Size = new Size(164, 32);
            label2.TabIndex = 4;
            label2.Text = "Search Details";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(-26, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(880, 2);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(318, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2, 125);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaptionText;
            pictureBox3.Location = new Point(-7, 233);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(880, 2);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(318, 399);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(150, 46);
            searchButton.TabIndex = 8;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchListBox
            // 
            searchListBox.FormattingEnabled = true;
            searchListBox.HorizontalScrollbar = true;
            searchListBox.ItemHeight = 32;
            searchListBox.Location = new Point(2, 300);
            searchListBox.Name = "searchListBox";
            searchListBox.Size = new Size(791, 68);
            searchListBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 250);
            label3.Name = "label3";
            label3.Size = new Size(93, 32);
            label3.TabIndex = 10;
            label3.Text = "Results:";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(318, 466);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 46);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 524);
            Controls.Add(exitButton);
            Controls.Add(label3);
            Controls.Add(searchListBox);
            Controls.Add(searchButton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(searchParameter);
            Controls.Add(label1);
            Controls.Add(productNumber);
            Controls.Add(productName);
            Name = "Search";
            Text = "Search";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton productName;
        private RadioButton productNumber;
        private Label label1;
        private TextBox searchParameter;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button searchButton;
        private ListBox searchListBox;
        private Label label3;
        private Button exitButton;
    }
}