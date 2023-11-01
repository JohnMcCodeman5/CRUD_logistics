namespace CRUD_Logistics
{
    partial class Form2
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
            SuspendLayout();
            // 
            // button1Log
            // 
            button1Log.Location = new Point(298, 291);
            button1Log.Name = "button1Log";
            button1Log.Size = new Size(100, 32);
            button1Log.TabIndex = 0;
            button1Log.Text = "Login";
            button1Log.UseVisualStyleBackColor = true;
            button1Log.Click += button1Log_Click;
            // 
            // textBox1Log
            // 
            textBox1Log.Location = new Point(260, 117);
            textBox1Log.Name = "textBox1Log";
            textBox1Log.Size = new Size(180, 23);
            textBox1Log.TabIndex = 1;
            // 
            // textBox2Log
            // 
            textBox2Log.Location = new Point(260, 222);
            textBox2Log.Name = "textBox2Log";
            textBox2Log.PasswordChar = '*';
            textBox2Log.Size = new Size(180, 23);
            textBox2Log.TabIndex = 2;
            // 
            // label1Log
            // 
            label1Log.AutoSize = true;
            label1Log.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1Log.Location = new Point(260, 93);
            label1Log.Name = "label1Log";
            label1Log.Size = new Size(81, 21);
            label1Log.TabIndex = 3;
            label1Log.Text = "Username";
            // 
            // label2Log
            // 
            label2Log.AutoSize = true;
            label2Log.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2Log.Location = new Point(260, 198);
            label2Log.Name = "label2Log";
            label2Log.Size = new Size(76, 21);
            label2Log.TabIndex = 4;
            label2Log.Text = "Password";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 450);
            Controls.Add(label2Log);
            Controls.Add(label1Log);
            Controls.Add(textBox2Log);
            Controls.Add(textBox1Log);
            Controls.Add(button1Log);
            Name = "Form2";
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
    }
}