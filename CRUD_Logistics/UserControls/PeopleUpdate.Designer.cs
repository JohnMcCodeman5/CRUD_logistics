namespace CRUD_Logistics.UserControls
{
    partial class PeopleUpdate
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
            panel_update = new Panel();
            textBox5 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            label_update_job = new Label();
            label_update_name = new Label();
            label_update_id = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView_people_update = new DataGridView();
            button_change = new Button();
            button_back = new Button();
            label_update_age = new Label();
            label_update_title = new Label();
            panel_update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_people_update).BeginInit();
            SuspendLayout();
            // 
            // panel_update
            // 
            panel_update.Controls.Add(textBox5);
            panel_update.Controls.Add(label1);
            panel_update.Controls.Add(textBox4);
            panel_update.Controls.Add(label_update_job);
            panel_update.Controls.Add(label_update_name);
            panel_update.Controls.Add(label_update_id);
            panel_update.Controls.Add(textBox3);
            panel_update.Controls.Add(textBox2);
            panel_update.Controls.Add(textBox1);
            panel_update.Controls.Add(dataGridView_people_update);
            panel_update.Controls.Add(button_change);
            panel_update.Controls.Add(button_back);
            panel_update.Controls.Add(label_update_age);
            panel_update.Controls.Add(label_update_title);
            panel_update.Location = new Point(32, 22);
            panel_update.Name = "panel_update";
            panel_update.Size = new Size(1226, 547);
            panel_update.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(740, 430);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(229, 23);
            textBox5.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(740, 406);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 13;
            label1.Text = "Job ID";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(739, 344);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(229, 23);
            textBox4.TabIndex = 10;
            // 
            // label_update_job
            // 
            label_update_job.AutoSize = true;
            label_update_job.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_update_job.Location = new Point(739, 320);
            label_update_job.Name = "label_update_job";
            label_update_job.Size = new Size(67, 21);
            label_update_job.TabIndex = 11;
            label_update_job.Text = "Job Title";
            // 
            // label_update_name
            // 
            label_update_name.AutoSize = true;
            label_update_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_update_name.Location = new Point(739, 165);
            label_update_name.Name = "label_update_name";
            label_update_name.Size = new Size(52, 21);
            label_update_name.TabIndex = 5;
            label_update_name.Text = "Name";
            // 
            // label_update_id
            // 
            label_update_id.AutoSize = true;
            label_update_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_update_id.Location = new Point(739, 86);
            label_update_id.Name = "label_update_id";
            label_update_id.Size = new Size(25, 21);
            label_update_id.TabIndex = 4;
            label_update_id.Text = "ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(739, 266);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(229, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(739, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(739, 110);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView_people_update
            // 
            dataGridView_people_update.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_people_update.Location = new Point(30, 17);
            dataGridView_people_update.Name = "dataGridView_people_update";
            dataGridView_people_update.RowTemplate.Height = 25;
            dataGridView_people_update.Size = new Size(672, 503);
            dataGridView_people_update.TabIndex = 0;
            // 
            // button_change
            // 
            button_change.Location = new Point(739, 483);
            button_change.Name = "button_change";
            button_change.Size = new Size(115, 37);
            button_change.TabIndex = 7;
            button_change.Text = "Change";
            button_change.UseVisualStyleBackColor = true;
            button_change.Click += button_change_Click;
            // 
            // button_back
            // 
            button_back.Location = new Point(1114, 17);
            button_back.Name = "button_back";
            button_back.Size = new Size(100, 36);
            button_back.TabIndex = 8;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // label_update_age
            // 
            label_update_age.AutoSize = true;
            label_update_age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_update_age.Location = new Point(739, 242);
            label_update_age.Name = "label_update_age";
            label_update_age.Size = new Size(37, 21);
            label_update_age.TabIndex = 6;
            label_update_age.Text = "Age";
            // 
            // label_update_title
            // 
            label_update_title.AutoSize = true;
            label_update_title.Font = new Font("Sitka Small", 13.5F, FontStyle.Bold, GraphicsUnit.Point);
            label_update_title.Location = new Point(726, 45);
            label_update_title.Name = "label_update_title";
            label_update_title.Size = new Size(243, 26);
            label_update_title.TabIndex = 9;
            label_update_title.Text = "Update Existing Entries";
            // 
            // PeopleUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_update);
            Name = "PeopleUpdate";
            Size = new Size(1300, 600);
            panel_update.ResumeLayout(false);
            panel_update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_people_update).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_update;
        private TextBox textBox5;
        private Label label1;
        private TextBox textBox4;
        private Label label_update_job;
        private Label label_update_name;
        private Label label_update_id;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView_people_update;
        private Button button_change;
        private Button button_back;
        private Label label_update_age;
        private Label label_update_title;
    }
}
