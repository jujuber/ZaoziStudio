namespace WxHs
{
    partial class FrmModifyBh
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
            this.edtOldBh = new System.Windows.Forms.TextBox();
            this.lblOld = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.edtNewBh = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edtOldBh
            // 
            this.edtOldBh.Location = new System.Drawing.Point(138, 20);
            this.edtOldBh.Name = "edtOldBh";
            this.edtOldBh.ReadOnly = true;
            this.edtOldBh.Size = new System.Drawing.Size(208, 44);
            this.edtOldBh.TabIndex = 2;
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.lblOld.Location = new System.Drawing.Point(12, 23);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(111, 33);
            this.lblOld.TabIndex = 1;
            this.lblOld.Text = "旧板号";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(12, 82);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(111, 33);
            this.lblNew.TabIndex = 3;
            this.lblNew.Text = "新板号";
            // 
            // edtNewBh
            // 
            this.edtNewBh.Location = new System.Drawing.Point(138, 79);
            this.edtNewBh.Name = "edtNewBh";
            this.edtNewBh.Size = new System.Drawing.Size(208, 44);
            this.edtNewBh.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(59, 148);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(129, 53);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "确 定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCanel
            // 
            this.btnCanel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCanel.Location = new System.Drawing.Point(231, 148);
            this.btnCanel.Name = "btnCanel";
            this.btnCanel.Size = new System.Drawing.Size(129, 53);
            this.btnCanel.TabIndex = 2;
            this.btnCanel.Text = "取 消";
            this.btnCanel.UseVisualStyleBackColor = true;
            // 
            // FrmModifyBh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 213);
            this.Controls.Add(this.btnCanel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.edtNewBh);
            this.Controls.Add(this.lblOld);
            this.Controls.Add(this.edtOldBh);
            this.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModifyBh";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改板号";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edtOldBh;
        private System.Windows.Forms.Label lblOld;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.TextBox edtNewBh;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCanel;
    }
}