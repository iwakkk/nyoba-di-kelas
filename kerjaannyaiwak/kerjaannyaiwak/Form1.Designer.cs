namespace kerjaannyaiwak
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addYhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editYhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteYhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_team = new System.Windows.Forms.TextBox();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.cmb_nat = new System.Windows.Forms.ComboBox();
            this.cmb_tea = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_submit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addYhToolStripMenuItem,
            this.editYhToolStripMenuItem,
            this.deleteYhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addYhToolStripMenuItem
            // 
            this.addYhToolStripMenuItem.Name = "addYhToolStripMenuItem";
            this.addYhToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.addYhToolStripMenuItem.Text = "add yh";
            // 
            // editYhToolStripMenuItem
            // 
            this.editYhToolStripMenuItem.Name = "editYhToolStripMenuItem";
            this.editYhToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.editYhToolStripMenuItem.Text = "edit yh";
            // 
            // deleteYhToolStripMenuItem
            // 
            this.deleteYhToolStripMenuItem.Name = "deleteYhToolStripMenuItem";
            this.deleteYhToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.deleteYhToolStripMenuItem.Text = "delete yh";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(265, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 302);
            this.dataGridView1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Team_Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nationality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Height";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Birthdate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Team Name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(92, 11);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 9;
            // 
            // txt_team
            // 
            this.txt_team.Location = new System.Drawing.Point(92, 41);
            this.txt_team.Name = "txt_team";
            this.txt_team.Size = new System.Drawing.Size(100, 20);
            this.txt_team.TabIndex = 10;
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(92, 95);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(100, 20);
            this.txt_position.TabIndex = 11;
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(92, 154);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(100, 20);
            this.txt_weight.TabIndex = 12;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(92, 121);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(100, 20);
            this.txt_height.TabIndex = 14;
            // 
            // cmb_nat
            // 
            this.cmb_nat.FormattingEnabled = true;
            this.cmb_nat.Location = new System.Drawing.Point(92, 67);
            this.cmb_nat.Name = "cmb_nat";
            this.cmb_nat.Size = new System.Drawing.Size(121, 21);
            this.cmb_nat.TabIndex = 15;
            // 
            // cmb_tea
            // 
            this.cmb_tea.FormattingEnabled = true;
            this.cmb_tea.Location = new System.Drawing.Point(92, 217);
            this.cmb_tea.Name = "cmb_tea";
            this.cmb_tea.Size = new System.Drawing.Size(121, 21);
            this.cmb_tea.TabIndex = 16;
            this.cmb_tea.SelectedIndexChanged += new System.EventHandler(this.cmb_tea_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(92, 256);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(135, 23);
            this.btn_submit.TabIndex = 18;
            this.btn_submit.Text = "SUBMIT BANG";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_submit);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.cmb_tea);
            this.panel1.Controls.Add(this.cmb_nat);
            this.panel1.Controls.Add(this.txt_height);
            this.panel1.Controls.Add(this.txt_weight);
            this.panel1.Controls.Add(this.txt_position);
            this.panel1.Controls.Add(this.txt_team);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 302);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(10, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 235);
            this.panel2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addYhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editYhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteYhToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_team;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.ComboBox cmb_nat;
        private System.Windows.Forms.ComboBox cmb_tea;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
    }
}

