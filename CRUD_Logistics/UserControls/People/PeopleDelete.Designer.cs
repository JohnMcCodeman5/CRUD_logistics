namespace CRUD_Logistics.UserControls
{
    partial class PeopleDelete
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
            panel_delete = new Panel();
            label1 = new Label();
            textBox5 = new TextBox();
            label_delete_job = new Label();
            textBox4 = new TextBox();
            label_delete_title = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label_delete_name = new Label();
            label_delete_age = new Label();
            label_delete_id = new Label();
            dataGridView_people_delete = new DataGridView();
            button_delete = new Button();
            button_back = new Button();
            panel_delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_people_delete).BeginInit();
            SuspendLayout();
            // 
            // panel_delete
            // 
            panel_delete.Controls.Add(label1);
            panel_delete.Controls.Add(textBox5);
            panel_delete.Controls.Add(label_delete_job);
            panel_delete.Controls.Add(textBox4);
            panel_delete.Controls.Add(label_delete_title);
            panel_delete.Controls.Add(textBox3);
            panel_delete.Controls.Add(textBox2);
            panel_delete.Controls.Add(textBox1);
            panel_delete.Controls.Add(label_delete_name);
            panel_delete.Controls.Add(label_delete_age);
            panel_delete.Controls.Add(label_delete_id);
            panel_delete.Controls.Add(dataGridView_people_delete);
            panel_delete.Controls.Add(button_delete);
            panel_delete.Controls.Add(button_back);
            panel_delete.Location = new Point(35, 28);
            panel_delete.Name = "panel_delete";
            panel_delete.Size = new Size(1235, 553);
            panel_delete.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(695, 386);
            label1.Name = "label1";
            label1.Size = new Size(34, 21);
            label1.TabIndex = 13;
            label1.Text = "Job";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(695, 413);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(224, 23);
            textBox5.TabIndex = 12;
            // 
            // label_delete_job
            // 
            label_delete_job.AutoSize = true;
            label_delete_job.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_delete_job.Location = new Point(695, 304);
            label_delete_job.Name = "label_delete_job";
            label_delete_job.Size = new Size(67, 21);
            label_delete_job.TabIndex = 11;
            label_delete_job.Text = "Job Title";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(695, 331);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(224, 23);
            textBox4.TabIndex = 10;
            // 
            // label_delete_title
            // 
            label_delete_title.AutoSize = true;
            label_delete_title.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_delete_title.Location = new Point(683, 29);
            label_delete_title.Name = "label_delete_title";
            label_delete_title.Size = new Size(173, 28);
            label_delete_title.TabIndex = 9;
            label_delete_title.Text = "Delete An Entry";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(691, 255);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(228, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(693, 179);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(226, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(693, 99);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 4;
            // 
            // label_delete_name
            // 
            label_delete_name.AutoSize = true;
            label_delete_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_delete_name.Location = new Point(689, 231);
            label_delete_name.Name = "label_delete_name";
            label_delete_name.Size = new Size(52, 21);
            label_delete_name.TabIndex = 3;
            label_delete_name.Text = "Name";
            // 
            // label_delete_age
            // 
            label_delete_age.AutoSize = true;
            label_delete_age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_delete_age.Location = new Point(693, 155);
            label_delete_age.Name = "label_delete_age";
            label_delete_age.Size = new Size(37, 21);
            label_delete_age.TabIndex = 2;
            label_delete_age.Text = "Age";
            // 
            // label_delete_id
            // 
            label_delete_id.AutoSize = true;
            label_delete_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_delete_id.Location = new Point(693, 75);
            label_delete_id.Name = "label_delete_id";
            label_delete_id.Size = new Size(25, 21);
            label_delete_id.TabIndex = 1;
            label_delete_id.Text = "ID";
            // 
            // dataGridView_people_delete
            // 
            dataGridView_people_delete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_people_delete.Location = new Point(32, 34);
            dataGridView_people_delete.Name = "dataGridView_people_delete";
            dataGridView_people_delete.RowTemplate.Height = 25;
            dataGridView_people_delete.Size = new Size(631, 488);
            dataGridView_people_delete.TabIndex = 0;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(691, 491);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(117, 31);
            button_delete.TabIndex = 8;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(1118, 11);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 32);
            button_back.TabIndex = 7;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // PeopleDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_delete);
            Name = "PeopleDelete";
            Size = new Size(1300, 600);
            panel_delete.ResumeLayout(false);
            panel_delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_people_delete).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_delete;
        private Label label_delete_job;
        private TextBox textBox4;
        private Label label_delete_title;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label_delete_name;
        private Label label_delete_age;
        private Label label_delete_id;
        private DataGridView dataGridView_people_delete;
        private Button button_delete;
        private Button button_back;
        private Label label1;
        private TextBox textBox5;
    }
}
