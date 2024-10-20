namespace WxHs
{
    partial class FrmDatabase
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edtDataSource = new System.Windows.Forms.TextBox();
            this.edtDataBase = new System.Windows.Forms.TextBox();
            this.edtSa = new System.Windows.Forms.TextBox();
            this.edtPwd = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sqlConnection = new System.Data.SqlClient.SqlConnection();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据库名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码";
            // 
            // edtDataSource
            // 
            this.edtDataSource.Location = new System.Drawing.Point(137, 31);
            this.edtDataSource.Name = "edtDataSource";
            this.edtDataSource.Size = new System.Drawing.Size(132, 21);
            this.edtDataSource.TabIndex = 4;
            // 
            // edtDataBase
            // 
            this.edtDataBase.Location = new System.Drawing.Point(137, 66);
            this.edtDataBase.Name = "edtDataBase";
            this.edtDataBase.Size = new System.Drawing.Size(132, 21);
            this.edtDataBase.TabIndex = 5;
            // 
            // edtSa
            // 
            this.edtSa.Location = new System.Drawing.Point(137, 110);
            this.edtSa.Name = "edtSa";
            this.edtSa.Size = new System.Drawing.Size(132, 21);
            this.edtSa.TabIndex = 6;
            // 
            // edtPwd
            // 
            this.edtPwd.Location = new System.Drawing.Point(137, 145);
            this.edtPwd.Name = "edtPwd";
            this.edtPwd.PasswordChar = '*';
            this.edtPwd.Size = new System.Drawing.Size(132, 21);
            this.edtPwd.TabIndex = 7;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(81, 196);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "测试";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sqlConnection
            // 
            this.sqlConnection.FireInfoMessageEventOnUserErrors = false;
            // 
            // FrmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 265);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.edtPwd);
            this.Controls.Add(this.edtSa);
            this.Controls.Add(this.edtDataBase);
            this.Controls.Add(this.edtDataSource);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据库配置";
            this.Load += new System.EventHandler(this.FrmDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtDataSource;
        private System.Windows.Forms.TextBox edtDataBase;
        private System.Windows.Forms.TextBox edtSa;
        private System.Windows.Forms.TextBox edtPwd;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button button2;
        private System.Data.SqlClient.SqlConnection sqlConnection;
    }
}