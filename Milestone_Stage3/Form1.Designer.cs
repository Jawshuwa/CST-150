namespace InventorySystem
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
            addButton = new Button();
            quantityOnHandText = new TextBox();
            quantityOrderedText = new TextBox();
            productNumberText = new TextBox();
            productNameText = new TextBox();
            purchasePriceText = new TextBox();
            sellPriceText = new TextBox();
            removeProductNumberText = new TextBox();
            removeButton = new Button();
            restockAmountText = new TextBox();
            Restock = new Button();
            inventoryListBox = new ListBox();
            viewButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            restockProdNumText = new TextBox();
            label9 = new Label();
            prodNameRadio = new RadioButton();
            prodNumberRadio = new RadioButton();
            label10 = new Label();
            searchTerm = new TextBox();
            label11 = new Label();
            searchButton = new Button();
            searchItemsListBox = new ListBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(773, 123);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 46);
            addButton.TabIndex = 0;
            addButton.Text = "Add Inventory Object";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button1_Click;
            // 
            // quantityOnHandText
            // 
            quantityOnHandText.Location = new Point(38, 86);
            quantityOnHandText.Name = "quantityOnHandText";
            quantityOnHandText.Size = new Size(200, 39);
            quantityOnHandText.TabIndex = 1;
            // 
            // quantityOrderedText
            // 
            quantityOrderedText.Location = new Point(298, 83);
            quantityOrderedText.Name = "quantityOrderedText";
            quantityOrderedText.Size = new Size(200, 39);
            quantityOrderedText.TabIndex = 2;
            // 
            // productNumberText
            // 
            productNumberText.Location = new Point(553, 83);
            productNumberText.Name = "productNumberText";
            productNumberText.Size = new Size(200, 39);
            productNumberText.TabIndex = 3;
            // 
            // productNameText
            // 
            productNameText.Location = new Point(38, 165);
            productNameText.Name = "productNameText";
            productNameText.Size = new Size(200, 39);
            productNameText.TabIndex = 4;
            // 
            // purchasePriceText
            // 
            purchasePriceText.Location = new Point(298, 165);
            purchasePriceText.Name = "purchasePriceText";
            purchasePriceText.Size = new Size(200, 39);
            purchasePriceText.TabIndex = 5;
            // 
            // sellPriceText
            // 
            sellPriceText.Location = new Point(553, 165);
            sellPriceText.Name = "sellPriceText";
            sellPriceText.Size = new Size(200, 39);
            sellPriceText.TabIndex = 6;
            // 
            // removeProductNumberText
            // 
            removeProductNumberText.Location = new Point(553, 319);
            removeProductNumberText.Name = "removeProductNumberText";
            removeProductNumberText.Size = new Size(200, 39);
            removeProductNumberText.TabIndex = 7;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(773, 315);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(150, 46);
            removeButton.TabIndex = 8;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // restockAmountText
            // 
            restockAmountText.Location = new Point(553, 435);
            restockAmountText.Name = "restockAmountText";
            restockAmountText.Size = new Size(200, 39);
            restockAmountText.TabIndex = 9;
            // 
            // Restock
            // 
            Restock.Location = new Point(773, 431);
            Restock.Name = "Restock";
            Restock.Size = new Size(150, 46);
            Restock.TabIndex = 10;
            Restock.Text = "Restock";
            Restock.UseVisualStyleBackColor = true;
            Restock.Click += Restock_Click;
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.HorizontalScrollbar = true;
            inventoryListBox.ItemHeight = 32;
            inventoryListBox.Location = new Point(38, 587);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(802, 292);
            inventoryListBox.TabIndex = 11;
            // 
            // viewButton
            // 
            viewButton.Location = new Point(907, 719);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(150, 46);
            viewButton.TabIndex = 12;
            viewButton.Text = "View";
            viewButton.UseVisualStyleBackColor = true;
            viewButton.Click += viewButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 51);
            label1.Name = "label1";
            label1.Size = new Size(133, 32);
            label1.TabIndex = 13;
            label1.Text = "quantHand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 48);
            label2.Name = "label2";
            label2.Size = new Size(164, 32);
            label2.TabIndex = 14;
            label2.Text = "quantOrdered";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(575, 51);
            label3.Name = "label3";
            label3.Size = new Size(152, 32);
            label3.TabIndex = 15;
            label3.Text = "prodNumber";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 130);
            label4.Name = "label4";
            label4.Size = new Size(128, 32);
            label4.TabIndex = 16;
            label4.Text = "prodName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 132);
            label5.Name = "label5";
            label5.Size = new Size(126, 32);
            label5.TabIndex = 17;
            label5.Text = "purchPrice";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(595, 132);
            label6.Name = "label6";
            label6.Size = new Size(100, 32);
            label6.TabIndex = 18;
            label6.Text = "sellPrice";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(581, 284);
            label7.Name = "label7";
            label7.Size = new Size(152, 32);
            label7.TabIndex = 19;
            label7.Text = "prodNumber";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(603, 400);
            label8.Name = "label8";
            label8.Size = new Size(100, 32);
            label8.TabIndex = 20;
            label8.Text = "Amount";
            // 
            // restockProdNumText
            // 
            restockProdNumText.Location = new Point(315, 435);
            restockProdNumText.Name = "restockProdNumText";
            restockProdNumText.Size = new Size(200, 39);
            restockProdNumText.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(334, 400);
            label9.Name = "label9";
            label9.Size = new Size(152, 32);
            label9.TabIndex = 22;
            label9.Text = "prodNumber";
            // 
            // prodNameRadio
            // 
            prodNameRadio.AutoSize = true;
            prodNameRadio.Location = new Point(38, 987);
            prodNameRadio.Name = "prodNameRadio";
            prodNameRadio.Size = new Size(198, 36);
            prodNameRadio.TabIndex = 23;
            prodNameRadio.TabStop = true;
            prodNameRadio.Text = "Product Name";
            prodNameRadio.UseVisualStyleBackColor = true;
            // 
            // prodNumberRadio
            // 
            prodNumberRadio.AutoSize = true;
            prodNumberRadio.Location = new Point(38, 1029);
            prodNumberRadio.Name = "prodNumberRadio";
            prodNumberRadio.Size = new Size(222, 36);
            prodNumberRadio.TabIndex = 24;
            prodNumberRadio.TabStop = true;
            prodNumberRadio.Text = "Product Number";
            prodNumberRadio.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(68, 952);
            label10.Name = "label10";
            label10.Size = new Size(123, 32);
            label10.TabIndex = 25;
            label10.Text = "Search by:";
            // 
            // searchTerm
            // 
            searchTerm.Location = new Point(368, 1012);
            searchTerm.Name = "searchTerm";
            searchTerm.Size = new Size(217, 39);
            searchTerm.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(368, 977);
            label11.Name = "label11";
            label11.Size = new Size(217, 32);
            label11.TabIndex = 27;
            label11.Text = "Search Term/Value:";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(672, 1008);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(150, 46);
            searchButton.TabIndex = 28;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += button1_Click_1;
            // 
            // searchItemsListBox
            // 
            searchItemsListBox.FormattingEnabled = true;
            searchItemsListBox.HorizontalScrollbar = true;
            searchItemsListBox.ItemHeight = 32;
            searchItemsListBox.Location = new Point(38, 1100);
            searchItemsListBox.Name = "searchItemsListBox";
            searchItemsListBox.Size = new Size(802, 164);
            searchItemsListBox.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(0, 235);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1101, 2);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(0, 539);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1101, 2);
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaptionText;
            pictureBox3.Location = new Point(-10, 909);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1101, 2);
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 1276);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(searchItemsListBox);
            Controls.Add(searchButton);
            Controls.Add(label11);
            Controls.Add(searchTerm);
            Controls.Add(label10);
            Controls.Add(prodNumberRadio);
            Controls.Add(prodNameRadio);
            Controls.Add(label9);
            Controls.Add(restockProdNumText);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(viewButton);
            Controls.Add(inventoryListBox);
            Controls.Add(Restock);
            Controls.Add(restockAmountText);
            Controls.Add(removeButton);
            Controls.Add(removeProductNumberText);
            Controls.Add(sellPriceText);
            Controls.Add(purchasePriceText);
            Controls.Add(productNameText);
            Controls.Add(productNumberText);
            Controls.Add(quantityOrderedText);
            Controls.Add(quantityOnHandText);
            Controls.Add(addButton);
            Name = "Form1";
            Text = "Inventory Manager Test";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private TextBox quantityOnHandText;
        private TextBox quantityOrderedText;
        private TextBox productNumberText;
        private TextBox productNameText;
        private TextBox purchasePriceText;
        private TextBox sellPriceText;
        private TextBox removeProductNumberText;
        private Button removeButton;
        private TextBox restockAmountText;
        private Button Restock;
        private ListBox inventoryListBox;
        private Button viewButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox restockProdNumText;
        private Label label9;
        private RadioButton prodNameRadio;
        private RadioButton prodNumberRadio;
        private Label label10;
        private TextBox searchTerm;
        private Label label11;
        private Button searchButton;
        private ListBox searchItemsListBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}