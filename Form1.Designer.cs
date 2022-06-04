using System.Windows.Forms;
using System.Collections.Generic;

namespace Kursova
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filterYear = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.filteringBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.fillBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.gapBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(682, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Surname";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Birth Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Company";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Company";
            // 
            // filterYear
            // 
            this.filterYear.Location = new System.Drawing.Point(442, 441);
            this.filterYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterYear.Name = "filterYear";
            this.filterYear.Size = new System.Drawing.Size(75, 29);
            this.filterYear.TabIndex = 14;
            this.filterYear.Text = "Year";
            this.filterYear.UseVisualStyleBackColor = true;
            this.filterYear.Click += new System.EventHandler(this.filterYear_Click_1);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(27, 437);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 29);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_2);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Value";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ((object)(resources.GetObject("comboBox1.Items"))),
            ((object)(resources.GetObject("comboBox1.Items1"))),
            ((object)(resources.GetObject("comboBox1.Items2")))});
            this.comboBox1.Location = new System.Drawing.Point(573, 485);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "Key";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // filteringBtn
            // 
            this.filteringBtn.Location = new System.Drawing.Point(573, 519);
            this.filteringBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filteringBtn.Name = "filteringBtn";
            this.filteringBtn.Size = new System.Drawing.Size(75, 29);
            this.filteringBtn.TabIndex = 17;
            this.filteringBtn.Text = "Filter";
            this.filteringBtn.UseVisualStyleBackColor = true;
            this.filteringBtn.Click += new System.EventHandler(this.filteringBtn_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(250, 428);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 24);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(573, 406);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(442, 406);
            this.numYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(75, 27);
            this.numYear.TabIndex = 20;
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(138, 502);
            this.numId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(75, 27);
            this.numId.TabIndex = 21;
            this.numId.ValueChanged += new System.EventHandler(this.numId_ValueChanged);
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(27, 382);
            this.fillBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(75, 29);
            this.fillBtn.TabIndex = 22;
            this.fillBtn.Text = "Fill";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(138, 382);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 29);
            this.sortBtn.TabIndex = 23;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click_1);
            // 
            // gapBtn
            // 
            this.gapBtn.Location = new System.Drawing.Point(250, 382);
            this.gapBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gapBtn.Name = "gapBtn";
            this.gapBtn.Size = new System.Drawing.Size(75, 29);
            this.gapBtn.TabIndex = 24;
            this.gapBtn.Text = "Gap";
            this.gapBtn.UseVisualStyleBackColor = true;
            this.gapBtn.Click += new System.EventHandler(this.gapBtn_Click_1);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(27, 500);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 29);
            this.deleteBtn.TabIndex = 25;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 562);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.gapBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.fillBtn);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.filteringBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.filterYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label1;
        private Label label2;
        private Button filterYear;
        private Button addBtn;
        private ComboBox comboBox1;
        private Button filteringBtn;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private NumericUpDown numYear;
        private NumericUpDown numId;
        private Button fillBtn;
        private Button sortBtn;
        private Button gapBtn;
        private Button deleteBtn;
    }
}

