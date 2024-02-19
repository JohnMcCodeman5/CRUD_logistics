namespace CRUD_Logistics.UserControls.Job
{
    partial class JobUpdate
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
            label_update_name = new Label();
            label_update_id = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView_job_update = new DataGridView();
            button_change = new Button();
            button_back = new Button();
            label_update_age = new Label();
            label_update_title = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_job_update).BeginInit();
            SuspendLayout();
            // 
            // label_update_name
            // 
            label_update_name.AutoSize = true;
            label_update_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_update_name.Location = new Point(767, 197);
            label_update_name.Name = "label_update_name";
            label_update_name.Size = new Size(52, 21);
            label_update_name.TabIndex = 19;
            label_update_name.Text = "Name";
            // 
            // label_update_id
            // 
            label_update_id.AutoSize = true;
            label_update_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_update_id.Location = new Point(767, 118);
            label_update_id.Name = "label_update_id";
            label_update_id.Size = new Size(25, 21);
            label_update_id.TabIndex = 18;
            label_update_id.Text = "ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(767, 298);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(229, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(767, 221);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(767, 142);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 15;
            // 
            // dataGridView_job_update
            // 
            dataGridView_job_update.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_job_update.Location = new Point(58, 49);
            dataGridView_job_update.Name = "dataGridView_job_update";
            dataGridView_job_update.RowTemplate.Height = 25;
            dataGridView_job_update.Size = new Size(672, 503);
            dataGridView_job_update.TabIndex = 14;
            // 
            // button_change
            // 
            button_change.Location = new Point(767, 368);
            button_change.Name = "button_change";
            button_change.Size = new Size(115, 37);
            button_change.TabIndex = 21;
            button_change.Text = "Change";
            button_change.UseVisualStyleBackColor = true;
            button_change.Click += button_change_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(1142, 49);
            button_back.Name = "button_back";
            button_back.Size = new Size(100, 36);
            button_back.TabIndex = 22;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // label_update_age
            // 
            label_update_age.AutoSize = true;
            label_update_age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_update_age.Location = new Point(767, 274);
            label_update_age.Name = "label_update_age";
            label_update_age.Size = new Size(156, 21);
            label_update_age.TabIndex = 20;
            label_update_age.Text = "Numer of Employees";
            // 
            // label_update_title
            // 
            label_update_title.AutoSize = true;
            label_update_title.Font = new Font("Sitka Small", 13.5F, FontStyle.Bold, GraphicsUnit.Point);
            label_update_title.Location = new Point(754, 77);
            label_update_title.Name = "label_update_title";
            label_update_title.Size = new Size(243, 26);
            label_update_title.TabIndex = 23;
            label_update_title.Text = "Update Existing Entries";
            // 
            // JobUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_update_name);
            Controls.Add(label_update_id);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView_job_update);
            Controls.Add(button_change);
            Controls.Add(button_back);
            Controls.Add(label_update_age);
            Controls.Add(label_update_title);
            Name = "JobUpdate";
            Size = new Size(1300, 600);
            ((System.ComponentModel.ISupportInitialize)dataGridView_job_update).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_update_name;
        private Label label_update_id;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView_job_update;
        private Button button_change;
        private Button button_back;
        private Label label_update_age;
        private Label label_update_title;
    }
}
