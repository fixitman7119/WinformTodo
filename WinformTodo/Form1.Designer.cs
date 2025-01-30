namespace WinformTodo
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
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnAdd = new Button();
            txtDueDate = new TextBox();
            ddb = new Label();
            lblTaskBoxLable = new Label();
            txtTaskDiscription = new TextBox();
            Gbtasklist = new GroupBox();
            lbTaskList = new ListBox();
            lvTasksList = new ListView();
            groupBox1.SuspendLayout();
            Gbtasklist.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtDueDate);
            groupBox1.Controls.Add(ddb);
            groupBox1.Controls.Add(lblTaskBoxLable);
            groupBox1.Controls.Add(txtTaskDiscription);
            groupBox1.Location = new Point(8, 7);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(236, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Form";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(48, 65);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(77, 31);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(129, 65);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 31);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Todo";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(79, 42);
            txtDueDate.Margin = new Padding(2);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.PlaceholderText = "2025-01-20";
            txtDueDate.Size = new Size(154, 23);
            txtDueDate.TabIndex = 3;
            // 
            // ddb
            // 
            ddb.AutoSize = true;
            ddb.Location = new Point(15, 42);
            ddb.Margin = new Padding(2, 0, 2, 0);
            ddb.Name = "ddb";
            ddb.Size = new Size(55, 15);
            ddb.TabIndex = 2;
            ddb.Text = "Due Date";
            // 
            // lblTaskBoxLable
            // 
            lblTaskBoxLable.AutoSize = true;
            lblTaskBoxLable.Location = new Point(15, 20);
            lblTaskBoxLable.Margin = new Padding(2, 0, 2, 0);
            lblTaskBoxLable.Name = "lblTaskBoxLable";
            lblTaskBoxLable.Size = new Size(29, 15);
            lblTaskBoxLable.TabIndex = 1;
            lblTaskBoxLable.Text = "Task";
            // 
            // txtTaskDiscription
            // 
            txtTaskDiscription.Location = new Point(79, 18);
            txtTaskDiscription.Margin = new Padding(2);
            txtTaskDiscription.Name = "txtTaskDiscription";
            txtTaskDiscription.Size = new Size(154, 23);
            txtTaskDiscription.TabIndex = 0;
            // 
            // Gbtasklist
            // 
            Gbtasklist.Controls.Add(lbTaskList);
            Gbtasklist.Controls.Add(lvTasksList);
            Gbtasklist.Location = new Point(8, 111);
            Gbtasklist.Margin = new Padding(2);
            Gbtasklist.Name = "Gbtasklist";
            Gbtasklist.Padding = new Padding(2);
            Gbtasklist.Size = new Size(236, 177);
            Gbtasklist.TabIndex = 1;
            Gbtasklist.TabStop = false;
            Gbtasklist.Text = "Task List";
            // 
            // lbTaskList
            // 
            lbTaskList.FormattingEnabled = true;
            lbTaskList.ItemHeight = 15;
            lbTaskList.Location = new Point(5, 21);
            lbTaskList.Name = "lbTaskList";
            lbTaskList.Size = new Size(231, 229);
            lbTaskList.TabIndex = 1;
            // 
            // lvTasksList
            // 
            lvTasksList.Location = new Point(0, 18);
            lvTasksList.Margin = new Padding(2);
            lvTasksList.Name = "lvTasksList";
            lvTasksList.Size = new Size(0, 0);
            lvTasksList.TabIndex = 0;
            lvTasksList.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 376);
            Controls.Add(Gbtasklist);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Todo app";
            KeyPress += Form1_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Gbtasklist.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblTaskBoxLable;
        private TextBox txtTaskDiscription;
        private TextBox txtDueDate;
        private Label ddb;
        private Button btnAdd;
        private Button btnClear;
        private GroupBox Gbtasklist;
        private ListView lvTasksList;
        private ListBox lbTaskList;
    }
}
