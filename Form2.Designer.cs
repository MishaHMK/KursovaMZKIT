using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.surBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(58, 63);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(191, 27);
            this.idBox.TabIndex = 1;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(58, 141);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(191, 27);
            this.nameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // surBox
            // 
            this.surBox.Location = new System.Drawing.Point(58, 223);
            this.surBox.Name = "surBox";
            this.surBox.Size = new System.Drawing.Size(191, 27);
            this.surBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "BirthDate";
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(58, 376);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(191, 27);
            this.cBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Company";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(286, 202);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(110, 69);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // datePick
            // 
            this.datePick.Location = new System.Drawing.Point(58, 299);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(191, 27);
            this.datePick.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.surBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DateTimePicker datePick;
    }
}