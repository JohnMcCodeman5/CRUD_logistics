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
            add_button_back = new Button();
            label3 = new Label();
            panel_list = new Panel();
            dataGridViewList = new DataGridView();
            list_button_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_menu.SuspendLayout();
            panel_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList).BeginInit();
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
            // panel_list
            // 
            panel_list.Controls.Add(list_button_back);
            panel_list.Controls.Add(dataGridViewList);
            panel_list.Location = new Point(27, 12);
            panel_list.Name = "panel_list";
            panel_list.Size = new Size(1197, 482);
            panel_list.TabIndex = 4;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1260, 506);
            Controls.Add(panel_list);
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
    }
}