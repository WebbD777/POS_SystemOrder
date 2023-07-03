namespace POS_SystemOrder
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
            TextBox postText;
            panel1 = new Panel();
            cusRefText = new TextBox();
            sexText = new ComboBox();
            celltext = new TextBox();
            addText = new TextBox();
            emailText = new TextBox();
            surText = new TextBox();
            nameText = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            greenCount = new NumericUpDown();
            yellowCount = new NumericUpDown();
            blueCount = new NumericUpDown();
            redCount = new NumericUpDown();
            netLab = new Label();
            subLab = new Label();
            taxLab = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            nScentButton = new RadioButton();
            scentButton = new RadioButton();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            panel3 = new Panel();
            postText = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)greenCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yellowCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)redCount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveBorder;
            panel1.Controls.Add(cusRefText);
            panel1.Controls.Add(sexText);
            panel1.Controls.Add(celltext);
            panel1.Controls.Add(postText);
            panel1.Controls.Add(addText);
            panel1.Controls.Add(emailText);
            panel1.Controls.Add(surText);
            panel1.Controls.Add(nameText);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 535);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // cusRefText
            // 
            cusRefText.Location = new Point(157, 19);
            cusRefText.Name = "cusRefText";
            cusRefText.ReadOnly = true;
            cusRefText.Size = new Size(125, 27);
            cusRefText.TabIndex = 8;
            // 
            // sexText
            // 
            sexText.FormattingEnabled = true;
            sexText.Items.AddRange(new object[] { "Male", "Female" });
            sexText.Location = new Point(131, 261);
            sexText.Name = "sexText";
            sexText.Size = new Size(151, 28);
            sexText.TabIndex = 1;
            sexText.Text = "Select Gender";
            // 
            // celltext
            // 
            celltext.Location = new Point(157, 190);
            celltext.Name = "celltext";
            celltext.Size = new Size(125, 27);
            celltext.TabIndex = 7;
            // 
            // postText
            // 
            postText.Location = new Point(157, 155);
            postText.Name = "postText";
            postText.Size = new Size(125, 27);
            postText.TabIndex = 6;
            // 
            // addText
            // 
            addText.Location = new Point(157, 121);
            addText.Name = "addText";
            addText.Size = new Size(125, 27);
            addText.TabIndex = 5;
            // 
            // emailText
            // 
            emailText.Location = new Point(157, 227);
            emailText.Name = "emailText";
            emailText.Size = new Size(125, 27);
            emailText.TabIndex = 4;
            // 
            // surText
            // 
            surText.Location = new Point(157, 88);
            surText.Name = "surText";
            surText.Size = new Size(125, 27);
            surText.TabIndex = 3;
            // 
            // nameText
            // 
            nameText.Location = new Point(157, 55);
            nameText.Name = "nameText";
            nameText.Size = new Size(125, 27);
            nameText.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 269);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 2;
            label8.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 227);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 2;
            label7.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 193);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 2;
            label6.Text = "Cell Num:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 155);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 2;
            label5.Text = "Postal Code:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 119);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 2;
            label4.Text = "Address:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 88);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Surname:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Customer_Num:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveBorder;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(greenCount);
            panel2.Controls.Add(yellowCount);
            panel2.Controls.Add(blueCount);
            panel2.Controls.Add(redCount);
            panel2.Controls.Add(netLab);
            panel2.Controls.Add(subLab);
            panel2.Controls.Add(taxLab);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(nScentButton);
            panel2.Controls.Add(scentButton);
            panel2.Controls.Add(checkBox4);
            panel2.Controls.Add(checkBox3);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Location = new Point(321, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(306, 535);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(59, 449);
            button1.Name = "button1";
            button1.Size = new Size(177, 66);
            button1.TabIndex = 18;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // greenCount
            // 
            greenCount.Location = new Point(216, 123);
            greenCount.Name = "greenCount";
            greenCount.Size = new Size(74, 27);
            greenCount.TabIndex = 17;
            // 
            // yellowCount
            // 
            yellowCount.Location = new Point(216, 90);
            yellowCount.Name = "yellowCount";
            yellowCount.Size = new Size(74, 27);
            yellowCount.TabIndex = 16;
            // 
            // blueCount
            // 
            blueCount.Location = new Point(216, 56);
            blueCount.Name = "blueCount";
            blueCount.Size = new Size(74, 27);
            blueCount.TabIndex = 15;
            // 
            // redCount
            // 
            redCount.Location = new Point(216, 21);
            redCount.Name = "redCount";
            redCount.Size = new Size(74, 27);
            redCount.TabIndex = 14;
            redCount.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // netLab
            // 
            netLab.AutoSize = true;
            netLab.Location = new Point(221, 400);
            netLab.Name = "netLab";
            netLab.Size = new Size(45, 20);
            netLab.TabIndex = 13;
            netLab.Text = "R0.00";
            // 
            // subLab
            // 
            subLab.AutoSize = true;
            subLab.Location = new Point(221, 359);
            subLab.Name = "subLab";
            subLab.Size = new Size(45, 20);
            subLab.TabIndex = 12;
            subLab.Text = "R0.00";
            // 
            // taxLab
            // 
            taxLab.AutoSize = true;
            taxLab.Location = new Point(221, 323);
            taxLab.Name = "taxLab";
            taxLab.Size = new Size(45, 20);
            taxLab.TabIndex = 11;
            taxLab.Text = "R0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 400);
            label11.Name = "label11";
            label11.Size = new Size(73, 20);
            label11.TabIndex = 10;
            label11.Text = "Net Total:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 359);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 1;
            label10.Text = "Sub Amount:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 320);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 9;
            label9.Text = "Tax Amount:";
            // 
            // nScentButton
            // 
            nScentButton.AutoSize = true;
            nScentButton.Location = new Point(144, 202);
            nScentButton.Name = "nScentButton";
            nScentButton.Size = new Size(117, 24);
            nScentButton.TabIndex = 5;
            nScentButton.TabStop = true;
            nScentButton.Text = "Non-Scented";
            nScentButton.UseVisualStyleBackColor = true;
            // 
            // scentButton
            // 
            scentButton.AutoSize = true;
            scentButton.Location = new Point(25, 202);
            scentButton.Name = "scentButton";
            scentButton.Size = new Size(83, 24);
            scentButton.TabIndex = 4;
            scentButton.TabStop = true;
            scentButton.Text = "Scented";
            scentButton.UseVisualStyleBackColor = true;
            scentButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(3, 123);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(118, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Green candle";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(3, 90);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(122, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Yellow candle";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(3, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(108, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Blue candle";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 21);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Red candle";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveBorder;
            panel3.Location = new Point(633, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(351, 535);
            panel3.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 559);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Order System";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)greenCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)yellowCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)redCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
        private TextBox celltext;
        private TextBox postText;
        private TextBox addText;
        private TextBox emailText;
        private TextBox surText;
        private TextBox nameText;
        private TextBox cusRefText;
        private ComboBox sexText;
        private Panel panel2;
        private Panel panel3;
        private RadioButton scentButton;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private RadioButton nScentButton;
        private Label netLab;
        private Label subLab;
        private Label taxLab;
        private NumericUpDown redCount;
        private NumericUpDown greenCount;
        private NumericUpDown yellowCount;
        private NumericUpDown blueCount;
        private Button button1;
    }
}