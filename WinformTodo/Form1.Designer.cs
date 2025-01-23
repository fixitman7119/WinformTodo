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
            textBox1 = new TextBox();
            label1 = new Label();
            lblTaskBoxLable = new Label();
            txtTaskDiscription = new TextBox();
            Gbtasklist = new GroupBox();
            lvTasksList = new ListView();
            groupBox1.SuspendLayout();
            Gbtasklist.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblTaskBoxLable);
            groupBox1.Controls.Add(txtTaskDiscription);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(337, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Form";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(68, 109);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 31);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(184, 109);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Todo";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 64);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "2025-01-20";
            textBox1.Size = new Size(219, 31);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 70);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 2;
            label1.Text = "Due Date";
            // 
            // lblTaskBoxLable
            // 
            lblTaskBoxLable.AutoSize = true;
            lblTaskBoxLable.Location = new Point(21, 33);
            lblTaskBoxLable.Name = "lblTaskBoxLable";
            lblTaskBoxLable.Size = new Size(45, 25);
            lblTaskBoxLable.TabIndex = 1;
            lblTaskBoxLable.Text = "Task";
            // 
            // txtTaskDiscription
            // 
            txtTaskDiscription.Location = new Point(113, 30);
            txtTaskDiscription.Name = "txtTaskDiscription";
            txtTaskDiscription.Size = new Size(218, 31);
            txtTaskDiscription.TabIndex = 0;
            // 
            // Gbtasklist
            // 
            Gbtasklist.Controls.Add(lvTasksList);
            Gbtasklist.Location = new Point(12, 185);
            Gbtasklist.Name = "Gbtasklist";
            Gbtasklist.Size = new Size(337, 295);
            Gbtasklist.TabIndex = 1;
            Gbtasklist.TabStop = false;
            Gbtasklist.Text = "Task List";
            // 
            // lvTasksList
            // 
            lvTasksList.Location = new Point(0, 30);
            lvTasksList.Name = "lvTasksList";
            lvTasksList.Size = new Size(337, 365);
            lvTasksList.TabIndex = 0;
            lvTasksList.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 592);
            Controls.Add(Gbtasklist);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Gbtasklist.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblTaskBoxLable;
        private TextBox txtTaskDiscription;
        private TextBox textBox1;
        private Label label1;
        private Button btnAdd;
        private Button btnClear;
        private GroupBox Gbtasklist;
        private ListView lvTasksList;
    }
}
