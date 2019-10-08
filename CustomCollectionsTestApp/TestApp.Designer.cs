namespace CustomCollectionsTestApp {
    partial class TestApp {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.containsBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.changeCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.rejectionFilterBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(145, 39);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(127, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(145, 68);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(127, 23);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // containsBtn
            // 
            this.containsBtn.Location = new System.Drawing.Point(145, 97);
            this.containsBtn.Name = "containsBtn";
            this.containsBtn.Size = new System.Drawing.Size(127, 23);
            this.containsBtn.TabIndex = 3;
            this.containsBtn.Text = "Contains?";
            this.containsBtn.UseVisualStyleBackColor = true;
            this.containsBtn.Click += new System.EventHandler(this.containsBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 134);
            this.listBox1.TabIndex = 4;
            // 
            // changeCheck
            // 
            this.changeCheck.AutoSize = true;
            this.changeCheck.Location = new System.Drawing.Point(12, 153);
            this.changeCheck.Name = "changeCheck";
            this.changeCheck.Size = new System.Drawing.Size(123, 17);
            this.changeCheck.TabIndex = 5;
            this.changeCheck.Text = "Apply rejection filter?";
            this.changeCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(145, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 6;
            // 
            // exceptionLabel
            // 
            this.exceptionLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.exceptionLabel.Location = new System.Drawing.Point(13, 226);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(259, 27);
            this.exceptionLabel.TabIndex = 7;
            // 
            // rejectionFilterBox
            // 
            this.rejectionFilterBox.Location = new System.Drawing.Point(13, 189);
            this.rejectionFilterBox.Multiline = true;
            this.rejectionFilterBox.Name = "rejectionFilterBox";
            this.rejectionFilterBox.Size = new System.Drawing.Size(259, 34);
            this.rejectionFilterBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filtered items are comma-separated.";
            // 
            // TestApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rejectionFilterBox);
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeCheck);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.containsBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "TestApp";
            this.Text = "Test App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button containsBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox changeCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exceptionLabel;
        private System.Windows.Forms.TextBox rejectionFilterBox;
        private System.Windows.Forms.Label label2;
    }
}

