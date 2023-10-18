namespace FormEadProject
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(301, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 31);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 63);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 3;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 116);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 4;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 176);
            label3.Name = "label3";
            label3.Size = new Size(123, 25);
            label3.TabIndex = 5;
            label3.Text = "Enter Subjects";
            label3.Click += label3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(301, 351);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(199, 29);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Pre Requisites Clear?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(301, 397);
            button1.Name = "button1";
            button1.Size = new Size(182, 38);
            button1.TabIndex = 7;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(591, 63);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 10;
            label5.Text = "First Name";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(593, 122);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 11;
            label4.Text = "Last Name";
            label4.Click += label4_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(593, 176);
            label6.Name = "label6";
            label6.Size = new Size(149, 25);
            label6.TabIndex = 12;
            label6.Text = "Selected Subjects";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(593, 352);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 13;
            label7.Text = "Status";
            label7.Click += label7_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(301, 176);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 155);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 476);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
    }
}