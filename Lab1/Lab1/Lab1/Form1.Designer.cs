﻿namespace Lab1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_age = new System.Windows.Forms.Label();
            this.b_delate = new System.Windows.Forms.Button();
            this.b_edit = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.p_add = new System.Windows.Forms.Button();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.e_nazwisko = new System.Windows.Forms.Label();
            this.e_imie = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_age);
            this.groupBox1.Controls.Add(this.b_delate);
            this.groupBox1.Controls.Add(this.b_edit);
            this.groupBox1.Controls.Add(this.num);
            this.groupBox1.Controls.Add(this.p_add);
            this.groupBox1.Controls.Add(this.tb_surname);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.e_nazwisko);
            this.groupBox1.Controls.Add(this.e_imie);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User";
            // 
            // l_age
            // 
            this.l_age.AutoSize = true;
            this.l_age.Location = new System.Drawing.Point(12, 87);
            this.l_age.Name = "l_age";
            this.l_age.Size = new System.Drawing.Size(37, 17);
            this.l_age.TabIndex = 6;
            this.l_age.Text = "Age:";
            // 
            // b_delate
            // 
            this.b_delate.Enabled = false;
            this.b_delate.Location = new System.Drawing.Point(7, 220);
            this.b_delate.Name = "b_delate";
            this.b_delate.Size = new System.Drawing.Size(100, 30);
            this.b_delate.TabIndex = 5;
            this.b_delate.Text = "Delate";
            this.b_delate.UseVisualStyleBackColor = true;
            this.b_delate.Click += new System.EventHandler(this.b_delate_Click);
            // 
            // b_edit
            // 
            this.b_edit.Enabled = false;
            this.b_edit.Location = new System.Drawing.Point(7, 185);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(100, 29);
            this.b_edit.TabIndex = 4;
            this.b_edit.Text = "Edit";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(97, 87);
            this.num.Margin = new System.Windows.Forms.Padding(4);
            this.num.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(56, 22);
            this.num.TabIndex = 2;
            this.num.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_KeyPress);
            // 
            // p_add
            // 
            this.p_add.Location = new System.Drawing.Point(7, 150);
            this.p_add.Margin = new System.Windows.Forms.Padding(4);
            this.p_add.Name = "p_add";
            this.p_add.Size = new System.Drawing.Size(100, 28);
            this.p_add.TabIndex = 3;
            this.p_add.Text = "Add";
            this.p_add.UseVisualStyleBackColor = true;
            this.p_add.Click += new System.EventHandler(this.p_dodaj_Click);
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(97, 57);
            this.tb_surname.Margin = new System.Windows.Forms.Padding(4);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(132, 22);
            this.tb_surname.TabIndex = 1;
            this.tb_surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_surname_KeyPress);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(97, 21);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(132, 22);
            this.tb_name.TabIndex = 0;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_name_KeyPress);
            // 
            // e_nazwisko
            // 
            this.e_nazwisko.AutoSize = true;
            this.e_nazwisko.Location = new System.Drawing.Point(9, 60);
            this.e_nazwisko.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.e_nazwisko.Name = "e_nazwisko";
            this.e_nazwisko.Size = new System.Drawing.Size(73, 17);
            this.e_nazwisko.TabIndex = 0;
            this.e_nazwisko.Text = "Surname: ";
            // 
            // e_imie
            // 
            this.e_imie.AutoSize = true;
            this.e_imie.Location = new System.Drawing.Point(9, 25);
            this.e_imie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.e_imie.Name = "e_imie";
            this.e_imie.Size = new System.Drawing.Size(53, 17);
            this.e_imie.TabIndex = 0;
            this.e_imie.Text = "Name: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(308, 13);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(425, 260);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 288);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kamil Błoński - project 1.";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Button p_add;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label e_nazwisko;
        private System.Windows.Forms.Label e_imie;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label l_age;
        private System.Windows.Forms.Button b_delate;
        private System.Windows.Forms.Button b_edit;
    }
}

