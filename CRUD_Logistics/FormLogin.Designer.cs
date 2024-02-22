namespace CRUD_Logistics
{
    partial class FormLogin
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
            button1Log = new Button();
            textBox1Log = new TextBox();
            textBox2Log = new TextBox();
            label1Log = new Label();
            label2Log = new Label();
            label3Log = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox3Log = new TextBox();
            SuspendLayout();
            // 
            // button1Log
            // 
            button1Log.Location = new Point(305, 360);
            button1Log.Name = "button1Log";
            button1Log.Size = new Size(100, 32);
            button1Log.TabIndex = 0;
            button1Log.Text = "Login";
            button1Log.UseVisualStyleBackColor = true;
            button1Log.Click += button1Log_Click;
            // 
            // textBox1Log
            // 
            textBox1Log.Location = new Point(268, 107);
            textBox1Log.Name = "textBox1Log";
            textBox1Log.Size = new Size(180, 23);
            textBox1Log.TabIndex = 1;
            // 
            // textBox2Log
            // 
            textBox2Log.Location = new Point(268, 175);
            textBox2Log.Name = "textBox2Log";
            textBox2Log.PasswordChar = '*';
            textBox2Log.Size = new Size(180, 23);
            textBox2Log.TabIndex = 2;
            // 
            // label1Log
            // 
            label1Log.AutoSize = true;
            label1Log.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1Log.Location = new Point(268, 83);
            label1Log.Name = "label1Log";
            label1Log.Size = new Size(81, 21);
            label1Log.TabIndex = 3;
            label1Log.Text = "Username";
            // 
            // label2Log
            // 
            label2Log.AutoSize = true;
            label2Log.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2Log.Location = new Point(268, 151);
            label2Log.Name = "label2Log";
            label2Log.Size = new Size(76, 21);
            label2Log.TabIndex = 4;
            label2Log.Text = "Password";
            // 
            // label3Log
            // 
            label3Log.AutoSize = true;
            label3Log.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3Log.Location = new Point(268, 281);
            label3Log.Name = "label3Log";
            label3Log.Size = new Size(45, 21);
            label3Log.TabIndex = 6;
            label3Log.Text = "Table";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(268, 213);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 8;
            label1.Text = "Database";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(268, 305);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 23);
            comboBox1.TabIndex = 10;
            // 
            // textBox3Log
            // 
            textBox3Log.Location = new Point(268, 237);
            textBox3Log.Name = "textBox3Log";
            textBox3Log.Size = new Size(180, 23);
            textBox3Log.TabIndex = 11;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 450);
            Controls.Add(textBox3Log);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(label3Log);
            Controls.Add(label2Log);
            Controls.Add(label1Log);
            Controls.Add(textBox2Log);
            Controls.Add(textBox1Log);
            Controls.Add(button1Log);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1Log;
        private TextBox textBox1Log;
        private TextBox textBox2Log;
        private Label label1Log;
        private Label label2Log;
        private Label label3Log;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox3Log;
    }
}