namespace WxHs
{
    partial class FrmGmcx
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBarno = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblno = new System.Windows.Forms.Label();
            this.edtQueryBarno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRy = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRq = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarno)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBarno
            // 
            this.dgvBarno.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBarno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBarno.Location = new System.Drawing.Point(0, 169);
            this.dgvBarno.MultiSelect = false;
            this.dgvBarno.Name = "dgvBarno";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarno.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBarno.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvBarno.RowTemplate.Height = 60;
            this.dgvBarno.RowTemplate.ReadOnly = true;
            this.dgvBarno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBarno.Size = new System.Drawing.Size(1350, 490);
            this.dgvBarno.TabIndex = 4;
            this.dgvBarno.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvBarno_RowPostPaint);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(442, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(243, 44);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "输入管码查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblno);
            this.panel1.Controls.Add(this.edtQueryBarno);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 67);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(691, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "打印布板图";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblno.ForeColor = System.Drawing.Color.Red;
            this.lblno.Location = new System.Drawing.Point(910, 18);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(47, 33);
            this.lblno.TabIndex = 9;
            this.lblno.Text = "00";
            // 
            // edtQueryBarno
            // 
            this.edtQueryBarno.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.edtQueryBarno.Location = new System.Drawing.Point(12, 12);
            this.edtQueryBarno.Name = "edtQueryBarno";
            this.edtQueryBarno.Size = new System.Drawing.Size(403, 44);
            this.edtQueryBarno.TabIndex = 8;
            this.edtQueryBarno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtQueryBarno_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRy);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblRq);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblGg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblBh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1350, 107);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "版号信息";
            // 
            // lblRy
            // 
            this.lblRy.AutoSize = true;
            this.lblRy.ForeColor = System.Drawing.Color.Blue;
            this.lblRy.Location = new System.Drawing.Point(1125, 40);
            this.lblRy.Name = "lblRy";
            this.lblRy.Size = new System.Drawing.Size(111, 33);
            this.lblRy.TabIndex = 7;
            this.lblRy.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(988, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 33);
            this.label8.TabIndex = 6;
            this.label8.Text = "操作员：";
            // 
            // lblRq
            // 
            this.lblRq.AutoSize = true;
            this.lblRq.ForeColor = System.Drawing.Color.Blue;
            this.lblRq.Location = new System.Drawing.Point(637, 40);
            this.lblRq.Name = "lblRq";
            this.lblRq.Size = new System.Drawing.Size(111, 33);
            this.lblRq.TabIndex = 5;
            this.lblRq.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "录入日期：";
            // 
            // lblGg
            // 
            this.lblGg.AutoSize = true;
            this.lblGg.ForeColor = System.Drawing.Color.Blue;
            this.lblGg.Location = new System.Drawing.Point(350, 40);
            this.lblGg.Name = "lblGg";
            this.lblGg.Size = new System.Drawing.Size(111, 33);
            this.lblGg.TabIndex = 3;
            this.lblGg.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "规格：";
            // 
            // lblBh
            // 
            this.lblBh.AutoSize = true;
            this.lblBh.ForeColor = System.Drawing.Color.Blue;
            this.lblBh.Location = new System.Drawing.Point(115, 40);
            this.lblBh.Name = "lblBh";
            this.lblBh.Size = new System.Drawing.Size(111, 33);
            this.lblBh.TabIndex = 1;
            this.lblBh.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "板号：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 169);
            this.panel2.TabIndex = 10;
            // 
            // FrmGmcx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 659);
            this.Controls.Add(this.dgvBarno);
            this.Controls.Add(this.panel2);
            this.Name = "FrmGmcx";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管码定位查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGmcx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarno)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBarno;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox edtQueryBarno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.Button button1;
    }
}