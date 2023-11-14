namespace WinFormUI
{
    partial class Dashboard
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            ResultsTextBox = new TextBox();
            label2 = new Label();
            SecondNumberTextBox = new TextBox();
            label1 = new Label();
            FirstNumberTextBox = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            label5 = new Label();
            LastNameTextBox = new TextBox();
            label6 = new Label();
            FirsrtNameTextBox = new TextBox();
            label4 = new Label();
            UsersComboBox = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(ResultsTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(SecondNumberTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FirstNumberTextBox);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(7, 10);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(350, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Calculate Section";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 163);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "Results";
            // 
            // ResultsTextBox
            // 
            ResultsTextBox.Location = new Point(235, 180);
            ResultsTextBox.Margin = new Padding(3, 2, 3, 2);
            ResultsTextBox.Name = "ResultsTextBox";
            ResultsTextBox.Size = new Size(110, 23);
            ResultsTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 56);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 4;
            label2.Text = "Second Number";
            // 
            // SecondNumberTextBox
            // 
            SecondNumberTextBox.Location = new Point(144, 50);
            SecondNumberTextBox.Margin = new Padding(3, 2, 3, 2);
            SecondNumberTextBox.Name = "SecondNumberTextBox";
            SecondNumberTextBox.Size = new Size(110, 23);
            SecondNumberTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "First Number";
            // 
            // FirstNumberTextBox
            // 
            FirstNumberTextBox.Location = new Point(144, 20);
            FirstNumberTextBox.Margin = new Padding(3, 2, 3, 2);
            FirstNumberTextBox.Name = "FirstNumberTextBox";
            FirstNumberTextBox.Size = new Size(110, 23);
            FirstNumberTextBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(5, 121);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(LastNameTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(FirsrtNameTextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(UsersComboBox);
            groupBox2.Location = new Point(366, 9);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(324, 367);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Database Section";
            // 
            // button2
            // 
            button2.Location = new Point(9, 142);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 10;
            button2.Text = "Add Person";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 106);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 8;
            label5.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(131, 100);
            LastNameTextBox.Margin = new Padding(3, 2, 3, 2);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(110, 23);
            LastNameTextBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 73);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 6;
            label6.Text = "First Name";
            // 
            // FirsrtNameTextBox
            // 
            FirsrtNameTextBox.Location = new Point(131, 70);
            FirsrtNameTextBox.Margin = new Padding(3, 2, 3, 2);
            FirsrtNameTextBox.Name = "FirsrtNameTextBox";
            FirsrtNameTextBox.Size = new Size(110, 23);
            FirsrtNameTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 27);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "Users";
            // 
            // UsersComboBox
            // 
            UsersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            UsersComboBox.FormattingEnabled = true;
            UsersComboBox.Location = new Point(49, 24);
            UsersComboBox.Margin = new Padding(3, 2, 3, 2);
            UsersComboBox.Name = "UsersComboBox";
            UsersComboBox.Size = new Size(270, 23);
            UsersComboBox.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 385);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox FirstNumberTextBox;
        private Button button1;
        private Label label3;
        private TextBox ResultsTextBox;
        private Label label2;
        private TextBox SecondNumberTextBox;
        private Label label4;
        private ComboBox UsersComboBox;
        private Button button2;
        private Label label5;
        private TextBox LastNameTextBox;
        private Label label6;
        private TextBox FirsrtNameTextBox;
    }
}