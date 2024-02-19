namespace CRUD_Logistics.UserControls.Job
{
    partial class JobAdd
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
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button_add = new Button();
            dataGridView_job_add = new DataGridView();
            button_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_job_add).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(348, 187);
            label3.Name = "label3";
            label3.Size = new Size(186, 28);
            label3.TabIndex = 32;
            label3.Text = "Add A New Entry";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(301, 239);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 27;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 263);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(301, 321);
            label2.Name = "label2";
            label2.Size = new Size(156, 21);
            label2.TabIndex = 28;
            label2.Text = "Number of Emplyees";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(301, 345);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(286, 23);
            textBox2.TabIndex = 26;
            // 
            // button_add
            // 
            button_add.Location = new Point(301, 423);
            button_add.Name = "button_add";
            button_add.Size = new Size(286, 23);
            button_add.TabIndex = 29;
            button_add.Text = "Add Job";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // dataGridView_job_add
            // 
            dataGridView_job_add.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_job_add.Location = new Point(653, 133);
            dataGridView_job_add.Name = "dataGridView_job_add";
            dataGridView_job_add.RowTemplate.Height = 25;
            dataGridView_job_add.Size = new Size(608, 416);
            dataGridView_job_add.TabIndex = 30;
            // 
            // button_back
            // 
            button_back.Location = new Point(39, 51);
            button_back.Name = "button_back";
            button_back.Size = new Size(87, 33);
            button_back.TabIndex = 31;
            button_back.Text = "Back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // JobAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button_add);
            Controls.Add(dataGridView_job_add);
            Controls.Add(button_back);
            Name = "JobAdd";
            Size = new Size(1300, 600);
            ((System.ComponentModel.ISupportInitialize)dataGridView_job_add).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button_add;
        private DataGridView dataGridView_job_add;
        private Button button_back;
    }
}
