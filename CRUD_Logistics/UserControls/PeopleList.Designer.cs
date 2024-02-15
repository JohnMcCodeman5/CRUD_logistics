namespace CRUD_Logistics.UserControls
{
    partial class PeopleList
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
            dataGridView_people_list = new DataGridView();
            button_list_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_people_list).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_people_list
            // 
            dataGridView_people_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_people_list.Location = new Point(34, 39);
            dataGridView_people_list.Name = "dataGridView_people_list";
            dataGridView_people_list.RowTemplate.Height = 25;
            dataGridView_people_list.Size = new Size(1109, 506);
            dataGridView_people_list.TabIndex = 0;
            // 
            // button_list_back
            // 
            button_list_back.Location = new Point(1172, 39);
            button_list_back.Name = "button_list_back";
            button_list_back.Size = new Size(107, 38);
            button_list_back.TabIndex = 1;
            button_list_back.Text = "Back";
            button_list_back.UseVisualStyleBackColor = true;
            button_list_back.Click += button_list_back_Click;
            // 
            // PeopleList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_list_back);
            Controls.Add(dataGridView_people_list);
            Name = "PeopleList";
            Size = new Size(1300, 600);
            ((System.ComponentModel.ISupportInitialize)dataGridView_people_list).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_people_list;
        private Button button_list_back;
    }
}
