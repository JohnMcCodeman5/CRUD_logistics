namespace CRUD_Logistics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel_menu = new Panel();
            menu_list_button = new Button();
            menu_button_delete = new Button();
            menu_button_update = new Button();
            menu_add_button = new Button();
            panel_list = new Panel();
            list_button_back = new Button();
            dataGridViewList = new DataGridView();
            panel_update = new Panel();
            label_update_name = new Label();
            label_update_id = new Label();
            textBox_update_age = new TextBox();
            textBox_update_name = new TextBox();
            textBox_update_id = new TextBox();
            dataGridViewUpdate = new DataGridView();
            button_update_change = new Button();
            button_update_back = new Button();
            label_update_age = new Label();
            label_update_title = new Label();
            add_button_back = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_menu.SuspendLayout();
            panel_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).BeginInit();
            panel_update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdate).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(246, 98);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(246, 187);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 3;
            label2.Text = "Age";
            // 
            // button1
            // 
            button1.Location = new Point(246, 277);
            button1.Name = "button1";
            button1.Size = new Size(286, 23);
            button1.TabIndex = 4;
            button1.Text = "Add Person";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(705, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(450, 327);
            dataGridView1.TabIndex = 5;
            // 
            // panel_menu
            // 
            panel_menu.Controls.Add(menu_list_button);
            panel_menu.Controls.Add(menu_button_delete);
            panel_menu.Controls.Add(menu_button_update);
            panel_menu.Controls.Add(menu_add_button);
            panel_menu.Location = new Point(27, 12);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(1197, 482);
            panel_menu.TabIndex = 6;
            // 
            // menu_list_button
            // 
            menu_list_button.Location = new Point(518, 45);
            menu_list_button.Name = "menu_list_button";
            menu_list_button.Size = new Size(177, 47);
            menu_list_button.TabIndex = 3;
            menu_list_button.Text = "List";
            menu_list_button.UseVisualStyleBackColor = true;
            menu_list_button.Click += menu_list_button_Click;
            // 
            // menu_button_delete
            // 
            menu_button_delete.Location = new Point(518, 331);
            menu_button_delete.Name = "menu_button_delete";
            menu_button_delete.Size = new Size(177, 47);
            menu_button_delete.TabIndex = 2;
            menu_button_delete.Text = "Delete";
            menu_button_delete.UseVisualStyleBackColor = true;
            // 
            // menu_button_update
            // 
            menu_button_update.Location = new Point(518, 231);
            menu_button_update.Name = "menu_button_update";
            menu_button_update.Size = new Size(177, 47);
            menu_button_update.TabIndex = 1;
            menu_button_update.Text = "Update";
            menu_button_update.UseVisualStyleBackColor = true;
            menu_button_update.Click += menu_button_update_Click;
            // 
            // menu_add_button
            // 
            menu_add_button.Location = new Point(518, 139);
            menu_add_button.Name = "menu_add_button";
            menu_add_button.Size = new Size(177, 47);
            menu_add_button.TabIndex = 0;
            menu_add_button.Text = "Add";
            menu_add_button.UseVisualStyleBackColor = true;
            menu_add_button.Click += menu_add_button_Click;
            // 
            // panel_list
            // 
            panel_list.Controls.Add(list_button_back);
            panel_list.Controls.Add(dataGridViewList);
            panel_list.Location = new Point(24, 9);
            panel_list.Name = "panel_list";
            panel_list.Size = new Size(1207, 485);
            panel_list.TabIndex = 4;
            // 
            // list_button_back
            // 
            list_button_back.Location = new Point(1095, 12);
            list_button_back.Name = "list_button_back";
            list_button_back.Size = new Size(89, 31);
            list_button_back.TabIndex = 1;
            list_button_back.Text = "Back";
            list_button_back.UseVisualStyleBackColor = true;
            list_button_back.Click += list_button_back_Click;
            // 
            // dataGridViewList
            // 
            dataGridViewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewList.Location = new Point(21, 22);
            dataGridViewList.Name = "dataGridViewList";
            dataGridViewList.RowTemplate.Height = 25;
            dataGridViewList.Size = new Size(674, 442);
            dataGridViewList.TabIndex = 0;
            // 
            // panel_update
            // 
            panel_update.Controls.Add(label_update_name);
            panel_update.Controls.Add(label_update_id);
            panel_update.Controls.Add(textBox_update_age);
            panel_update.Controls.Add(textBox_update_name);
            panel_update.Controls.Add(textBox_update_id);
            panel_update.Controls.Add(dataGridViewUpdate);
            panel_update.Controls.Add(button_update_change);
            panel_update.Controls.Add(button_update_back);
            panel_update.Controls.Add(label_update_age);
            panel_update.Controls.Add(label_update_title);
            panel_update.Location = new Point(27, 12);
            panel_update.Name = "panel_update";
            panel_update.Size = new Size(1207, 485);
            panel_update.TabIndex = 2;
            // 
            // label_update_name
            // 
            label_update_name.AutoSize = true;
            label_update_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_update_name.Location = new Point(739, 184);
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
            // textBox_update_age
            // 
            textBox_update_age.Location = new Point(739, 306);
            textBox_update_age.Name = "textBox_update_age";
            textBox_update_age.Size = new Size(229, 23);
            textBox_update_age.TabIndex = 3;
            // 
            // textBox_update_name
            // 
            textBox_update_name.Location = new Point(739, 208);
            textBox_update_name.Name = "textBox_update_name";
            textBox_update_name.Size = new Size(229, 23);
            textBox_update_name.TabIndex = 2;
            // 
            // textBox_update_id
            // 
            textBox_update_id.Location = new Point(739, 110);
            textBox_update_id.Name = "textBox_update_id";
            textBox_update_id.ReadOnly = true;
            textBox_update_id.Size = new Size(229, 23);
            textBox_update_id.TabIndex = 1;
            // 
            // dataGridViewUpdate
            // 
            dataGridViewUpdate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUpdate.Location = new Point(30, 15);
            dataGridViewUpdate.Name = "dataGridViewUpdate";
            dataGridViewUpdate.RowTemplate.Height = 25;
            dataGridViewUpdate.Size = new Size(655, 449);
            dataGridViewUpdate.TabIndex = 0;
            // 
            // button_update_change
            // 
            button_update_change.Location = new Point(739, 364);
            button_update_change.Name = "button_update_change";
            button_update_change.Size = new Size(115, 37);
            button_update_change.TabIndex = 7;
            button_update_change.Text = "Change";
            button_update_change.UseVisualStyleBackColor = true;
            button_update_change.Click += button_update_change_Click;
            // 
            // button_update_back
            // 
            button_update_back.Location = new Point(1095, 17);
            button_update_back.Name = "button_update_back";
            button_update_back.Size = new Size(89, 26);
            button_update_back.TabIndex = 8;
            button_update_back.Text = "Back";
            button_update_back.UseVisualStyleBackColor = true;
            button_update_back.Click += button_update_back_Click;
            // 
            // label_update_age
            // 
            label_update_age.AutoSize = true;
            label_update_age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_update_age.Location = new Point(739, 282);
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
            // add_button_back
            // 
            add_button_back.Location = new Point(27, 12);
            add_button_back.Name = "add_button_back";
            add_button_back.Size = new Size(87, 33);
            add_button_back.TabIndex = 7;
            add_button_back.Text = "Back";
            add_button_back.UseVisualStyleBackColor = true;
            add_button_back.Click += add_button_back_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(293, 46);
            label3.Name = "label3";
            label3.Size = new Size(186, 28);
            label3.TabIndex = 8;
            label3.Text = "Add A New Entry";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1286, 555);
            Controls.Add(panel_list);
            Controls.Add(panel_update);
            Controls.Add(panel_menu);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(add_button_back);
            Controls.Add(label3);
            Name = "Form1";
            Text = "Logistics";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_menu.ResumeLayout(false);
            panel_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).EndInit();
            panel_update.ResumeLayout(false);
            panel_update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUpdate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel_menu;
        private Button menu_list_button;
        private Button menu_button_delete;
        private Button menu_button_update;
        private Button menu_add_button;
        private Button add_button_back;
        private Label label3;
        private Panel panel_list;
        private DataGridView dataGridViewList;
        private Button list_button_back;
        private Panel panel1;
        private Panel panel_update;
        private DataGridView dataGridViewUpdate;
        private Label label_update_id;
        private TextBox textBox_update_age;
        private TextBox textBox_update_name;
        private TextBox textBox_update_id;
        private Button button_update_change;
        private Label label_update_age;
        private Label label_update_name;
        private Button button_update_back;
        private Label label_update_title;
    }
}