namespace CRUD_Logistics
{
    partial class PeopleMenu
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
            button_menu_list = new Button();
            button_menu_update = new Button();
            button_menu_delete = new Button();
            button_menu_add = new Button();
            SuspendLayout();
            // 
            // button_menu_list
            // 
            button_menu_list.Location = new Point(552, 99);
            button_menu_list.Name = "button_menu_list";
            button_menu_list.Size = new Size(158, 50);
            button_menu_list.TabIndex = 0;
            button_menu_list.Text = "List";
            button_menu_list.UseVisualStyleBackColor = true;
            button_menu_list.Click += button_menu_list_Click;
            // 
            // button_menu_update
            // 
            button_menu_update.Location = new Point(552, 305);
            button_menu_update.Name = "button_menu_update";
            button_menu_update.Size = new Size(158, 50);
            button_menu_update.TabIndex = 1;
            button_menu_update.Text = "Update";
            button_menu_update.UseVisualStyleBackColor = true;
            button_menu_update.Click += button_menu_update_Click;
            // 
            // button_menu_delete
            // 
            button_menu_delete.Location = new Point(552, 415);
            button_menu_delete.Name = "button_menu_delete";
            button_menu_delete.Size = new Size(158, 50);
            button_menu_delete.TabIndex = 2;
            button_menu_delete.Text = "Delete";
            button_menu_delete.UseVisualStyleBackColor = true;
            button_menu_delete.Click += button_menu_delete_Click;
            // 
            // button_menu_add
            // 
            button_menu_add.Location = new Point(552, 199);
            button_menu_add.Name = "button_menu_add";
            button_menu_add.Size = new Size(158, 50);
            button_menu_add.TabIndex = 3;
            button_menu_add.Text = "Add";
            button_menu_add.UseVisualStyleBackColor = true;
            button_menu_add.Click += button_menu_add_Click;
            // 
            // PeopleMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_menu_add);
            Controls.Add(button_menu_delete);
            Controls.Add(button_menu_update);
            Controls.Add(button_menu_list);
            Name = "PeopleMenu";
            Size = new Size(1300, 600);
            ResumeLayout(false);
        }

        #endregion

        private Button button_menu_list;
        private Button button_menu_update;
        private Button button_menu_delete;
        private Button button_menu_add;
    }
}
