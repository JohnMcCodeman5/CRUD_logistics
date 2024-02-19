namespace CRUD_Logistics.UserControls
{
    partial class JobList
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
            button_list_back = new Button();
            dataGridView_job_list = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_job_list).BeginInit();
            SuspendLayout();
            // 
            // button_list_back
            // 
            button_list_back.Location = new Point(1166, 47);
            button_list_back.Name = "button_list_back";
            button_list_back.Size = new Size(107, 38);
            button_list_back.TabIndex = 3;
            button_list_back.Text = "Back";
            button_list_back.UseVisualStyleBackColor = true;
            button_list_back.Click += button_list_back_Click;
            // 
            // dataGridView_job_list
            // 
            dataGridView_job_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_job_list.Location = new Point(49, 47);
            dataGridView_job_list.Name = "dataGridView_job_list";
            dataGridView_job_list.RowTemplate.Height = 25;
            dataGridView_job_list.Size = new Size(1013, 512);
            dataGridView_job_list.TabIndex = 4;
            // 
            // JobList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView_job_list);
            Controls.Add(button_list_back);
            Name = "JobList";
            Size = new Size(1300, 600);
            ((System.ComponentModel.ISupportInitialize)dataGridView_job_list).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_list_back;
        private DataGridView dataGridView_job_list;
    }
}
