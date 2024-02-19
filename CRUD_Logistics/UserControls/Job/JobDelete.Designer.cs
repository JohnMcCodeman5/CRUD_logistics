namespace CRUD_Logistics.UserControls.Job
{
    partial class JobDelete
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
            label_delete_title = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label_delete_name = new Label();
            label_delete_age = new Label();
            label_delete_id = new Label();
            dataGridView_job_delete = new DataGridView();
            button_delete = new Button();
            button_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_job_delete).BeginInit();
            SuspendLayout();
            // 
            // label_delete_title
            // 
            label_delete_title.AutoSize = true;
            label_delete_title.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_delete_title.Location = new Point(738, 147);
            label_delete_title.Name = "label_delete_title";
            label_delete_title.Size = new Size(173, 28);
            label_delete_title.TabIndex = 23;
            label_delete_title.Text = "Delete An Entry";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(746, 373);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(228, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(748, 297);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(226, 23);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(748, 217);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 18;
            // 
            // label_delete_name
            // 
            label_delete_name.AutoSize = true;
            label_delete_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_delete_name.Location = new Point(744, 349);
            label_delete_name.Name = "label_delete_name";
            label_delete_name.Size = new Size(165, 21);
            label_delete_name.TabIndex = 17;
            label_delete_name.Text = "Number of Employees";
            // 
            // label_delete_age
            // 
            label_delete_age.AutoSize = true;
            label_delete_age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_delete_age.Location = new Point(748, 273);
            label_delete_age.Name = "label_delete_age";
            label_delete_age.Size = new Size(52, 21);
            label_delete_age.TabIndex = 16;
            label_delete_age.Text = "Name";
            // 
            // label_delete_id
            // 
            label_delete_id.AutoSize = true;
            label_delete_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_delete_id.Location = new Point(748, 193);
            label_delete_id.Name = "label_delete_id";
            label_delete_id.Size = new Size(25, 21);
            label_delete_id.TabIndex = 15;
            label_delete_id.Text = "ID";
            // 
            // dataGridView_job_delete
            // 
            dataGridView_job_delete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_job_delete.Location = new Point(70, 68);
            dataGridView_job_delete.Name = "dataGridView_job_delete";
            dataGridView_job_delete.RowTemplate.Height = 25;
            dataGridView_job_delete.Size = new Size(631, 488);
            dataGridView_job_delete.TabIndex = 14;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(744, 446);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(117, 31);
            button_delete.TabIndex = 22;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(1177, 68);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 32);
            button_back.TabIndex = 21;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // JobDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_delete_title);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label_delete_name);
            Controls.Add(label_delete_age);
            Controls.Add(label_delete_id);
            Controls.Add(dataGridView_job_delete);
            Controls.Add(button_delete);
            Controls.Add(button_back);
            Name = "JobDelete";
            Size = new Size(1300, 600);
            ((System.ComponentModel.ISupportInitialize)dataGridView_job_delete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_delete_title;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label_delete_name;
        private Label label_delete_age;
        private Label label_delete_id;
        private DataGridView dataGridView_job_delete;
        private Button button_delete;
        private Button button_back;
    }
}
