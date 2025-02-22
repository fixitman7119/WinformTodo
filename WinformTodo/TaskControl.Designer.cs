namespace WinformTodo
{
    partial class TaskControl
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
            btnComplete = new Button();
            label1 = new Label();
            label2 = new Label();
            lblDueDate = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // btnComplete
            // 
            btnComplete.AutoSize = true;
            btnComplete.Location = new Point(191, 7);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(99, 25);
            btnComplete.TabIndex = 0;
            btnComplete.Text = "Mark Complete";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Due Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 32);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(89, 7);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(65, 15);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "2025-02-16";
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(14, 61);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(359, 89);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "This is a discription of some task that needs to be done.";
            // 
            // TaskControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(lblDescription);
            Controls.Add(lblDueDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnComplete);
            Name = "TaskControl";
            Size = new Size(376, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComplete;
        private Label label1;
        private Label label2;
        private Label lblDueDate;
        private Label lblDescription;
    }
}
