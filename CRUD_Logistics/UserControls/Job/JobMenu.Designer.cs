﻿namespace CRUD_Logistics.UserControls.Job
{
    partial class JobMenu
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
            richTextBox2 = new RichTextBox();
            button_logout = new Button();
            richTextBox1 = new RichTextBox();
            button_menu_add = new Button();
            button_menu_delete = new Button();
            button_menu_update = new Button();
            button_menu_list = new Button();
            SuspendLayout();
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.Menu;
            richTextBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox2.Location = new Point(434, 139);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(582, 366);
            richTextBox2.TabIndex = 13;
            richTextBox2.Text = "";
            // 
            // button_logout
            // 
            button_logout.Location = new Point(915, 50);
            button_logout.Name = "button_logout";
            button_logout.Size = new Size(101, 39);
            button_logout.TabIndex = 12;
            button_logout.Text = "Logout";
            button_logout.UseVisualStyleBackColor = true;
            button_logout.Click += button_logout_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Menu;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(434, 50);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(417, 43);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // button_menu_add
            // 
            button_menu_add.Location = new Point(132, 239);
            button_menu_add.Name = "button_menu_add";
            button_menu_add.Size = new Size(158, 50);
            button_menu_add.TabIndex = 10;
            button_menu_add.Text = "Add";
            button_menu_add.UseVisualStyleBackColor = true;
            button_menu_add.Click += button_menu_add_Click;
            button_menu_add.MouseLeave += reset_description;
            button_menu_add.MouseHover += button_menu_add_Hover;
            // 
            // button_menu_delete
            // 
            button_menu_delete.Location = new Point(132, 455);
            button_menu_delete.Name = "button_menu_delete";
            button_menu_delete.Size = new Size(158, 50);
            button_menu_delete.TabIndex = 9;
            button_menu_delete.Text = "Delete";
            button_menu_delete.UseVisualStyleBackColor = true;
            button_menu_delete.Click += button_menu_delete_Click;
            button_menu_delete.MouseLeave += reset_description;
            button_menu_delete.MouseHover += button_menu_delete_Hover;
            // 
            // button_menu_update
            // 
            button_menu_update.Location = new Point(132, 345);
            button_menu_update.Name = "button_menu_update";
            button_menu_update.Size = new Size(158, 50);
            button_menu_update.TabIndex = 8;
            button_menu_update.Text = "Update";
            button_menu_update.UseVisualStyleBackColor = true;
            button_menu_update.Click += button_menu_update_Click;
            button_menu_update.MouseLeave += reset_description;
            button_menu_update.MouseHover += button_menu_update_Hover;
            // 
            // button_menu_list
            // 
            button_menu_list.Location = new Point(132, 139);
            button_menu_list.Name = "button_menu_list";
            button_menu_list.Size = new Size(158, 50);
            button_menu_list.TabIndex = 7;
            button_menu_list.Text = "List";
            button_menu_list.UseVisualStyleBackColor = true;
            button_menu_list.Click += button_menu_list_Click;
            button_menu_list.MouseLeave += reset_description;
            button_menu_list.MouseHover += button_menu_list_Hover;
            // 
            // JobMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBox2);
            Controls.Add(button_logout);
            Controls.Add(richTextBox1);
            Controls.Add(button_menu_add);
            Controls.Add(button_menu_delete);
            Controls.Add(button_menu_update);
            Controls.Add(button_menu_list);
            Name = "JobMenu";
            Size = new Size(1300, 600);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox2;
        private Button button_logout;
        private RichTextBox richTextBox1;
        private Button button_menu_add;
        private Button button_menu_delete;
        private Button button_menu_update;
        private Button button_menu_list;
    }
}
