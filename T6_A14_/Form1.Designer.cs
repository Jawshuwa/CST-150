namespace T6_A14
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
            fontChoiceBox = new ListBox();
            generateButton = new Button();
            exitButton = new Button();
            label1 = new Label();
            Date = new CheckBox();
            Time = new CheckBox();
            label2 = new Label();
            fontSize2 = new RadioButton();
            fontSize1 = new RadioButton();
            label3 = new Label();
            quoteBox = new TextBox();
            SuspendLayout();
            // 
            // fontChoiceBox
            // 
            fontChoiceBox.FormattingEnabled = true;
            fontChoiceBox.ItemHeight = 32;
            fontChoiceBox.Items.AddRange(new object[] { "Times New Roman", "Papyrus", "Verdana", "Helvetica" });
            fontChoiceBox.Location = new Point(76, 86);
            fontChoiceBox.Name = "fontChoiceBox";
            fontChoiceBox.Size = new Size(213, 132);
            fontChoiceBox.TabIndex = 0;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(526, 456);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(150, 46);
            generateButton.TabIndex = 7;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(721, 456);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(150, 46);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 51);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 9;
            label1.Text = "Font Choices:";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(76, 402);
            Date.Name = "Date";
            Date.Size = new Size(96, 36);
            Date.TabIndex = 10;
            Date.Text = "Date";
            Date.UseVisualStyleBackColor = true;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Location = new Point(73, 444);
            Time.Name = "Time";
            Time.Size = new Size(99, 36);
            Time.TabIndex = 11;
            Time.Text = "Time";
            Time.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 367);
            label2.Name = "label2";
            label2.Size = new Size(147, 32);
            label2.TabIndex = 12;
            label2.Text = "Misc Details:";
            // 
            // fontSize2
            // 
            fontSize2.AutoSize = true;
            fontSize2.Location = new Point(76, 319);
            fontSize2.Name = "fontSize2";
            fontSize2.Size = new Size(134, 36);
            fontSize2.TabIndex = 13;
            fontSize2.TabStop = true;
            fontSize2.Text = "16 point";
            fontSize2.UseVisualStyleBackColor = true;
            // 
            // fontSize1
            // 
            fontSize1.AutoSize = true;
            fontSize1.Location = new Point(76, 277);
            fontSize1.Name = "fontSize1";
            fontSize1.Size = new Size(134, 36);
            fontSize1.TabIndex = 14;
            fontSize1.TabStop = true;
            fontSize1.Text = "12 point";
            fontSize1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 242);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 15;
            label3.Text = "Font Size:";
            // 
            // quoteBox
            // 
            quoteBox.Location = new Point(398, 51);
            quoteBox.Multiline = true;
            quoteBox.Name = "quoteBox";
            quoteBox.ReadOnly = true;
            quoteBox.Size = new Size(622, 387);
            quoteBox.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 526);
            Controls.Add(quoteBox);
            Controls.Add(label3);
            Controls.Add(fontSize1);
            Controls.Add(fontSize2);
            Controls.Add(label2);
            Controls.Add(Time);
            Controls.Add(Date);
            Controls.Add(label1);
            Controls.Add(exitButton);
            Controls.Add(generateButton);
            Controls.Add(fontChoiceBox);
            Name = "Form1";
            Text = "Shakespeare Quotes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox fontChoiceBox;
        private Button generateButton;
        private Button exitButton;
        private Label label1;
        private CheckBox Date;
        private CheckBox Time;
        private Label label2;
        private RadioButton fontSize2;
        private RadioButton fontSize1;
        private Label label3;
        private TextBox quoteBox;
    }
}