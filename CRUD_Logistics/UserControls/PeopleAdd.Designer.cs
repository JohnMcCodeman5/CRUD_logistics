namespace CRUD_Logistics.UserControls
{
    partial class PeopleAdd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox3 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button_add = new Button();
            dataGridView_people_add = new DataGridView();
            button_back = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_people_add).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(289, 341);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(286, 23);
            textBox3.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(336, 102);
            label3.Name = "label3";
            label3.Size = new Size(186, 28);
            label3.TabIndex = 19;
            label3.Text = "Add A New Entry";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(289, 154);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(289, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(289, 236);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 15;
            label2.Text = "Age";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(289, 260);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 23);
            textBox2.TabIndex = 13;
            // 
            // button_add
            // 
            button_add.Location = new Point(289, 495);
            button_add.Name = "button_add";
            button_add.Size = new Size(286, 23);
            button_add.TabIndex = 16;
            button_add.Text = "Add Person";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // dataGridView_people_add
            // 
            dataGridView_people_add.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_people_add.Location = new Point(641, 102);
            dataGridView_people_add.Name = "dataGridView_people_add";
            dataGridView_people_add.RowTemplate.Height = 25;
            dataGridView_people_add.Size = new Size(608, 416);
            dataGridView_people_add.TabIndex = 17;
            // 
            // button_back
            // 
            button_back.Location = new Point(27, 20);
            button_back.Name = "button_back";
            button_back.Size = new Size(87, 33);
            button_back.TabIndex = 18;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(289, 317);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 21;
            label4.Text = "Job Title";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(289, 418);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(286, 23);
            textBox4.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(289, 394);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 23;
            label5.Text = "Job ID";
            // 
            // PeopleAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button_add);
            Controls.Add(dataGridView_people_add);
            Controls.Add(button_back);
            Controls.Add(label4);
            Name = "PeopleAdd";
            Size = new Size(1300, 600);
            ((System.ComponentModel.ISupportInitialize)dataGridView_people_add).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label3;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button_add;
        private DataGridView dataGridView_people_add;
        private Button button_back;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
    }
}
