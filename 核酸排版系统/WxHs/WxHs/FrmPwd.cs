using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WxHs
{
    public partial class FrmPwd : Form
    {
        public FrmPwd()
        {
            InitializeComponent();
        }

        //
        private bool checkPwd()
        {
            string sqlcmd = string.Format("SELECT NAME,PY,PASSWORD FROM WX_RYXX where ID = '{0}'", GlobalFunction.Account.Id);
            var user = GlobalFunction.GetDataTable(sqlcmd);
            if (user == null || user.Rows.Count == 0)
            {
                MessageBox.Show("用户名不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = this.textBox1;
                return false;
            }
            string password = user.Rows[0][2].ToString();
            if (password != GlobalFunction.GetMd5FromString(this.textBox1.Text))
            {
                MessageBox.Show("旧密码不正确！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = this.textBox1;
                return false;
            }

            if (this.textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("新密码两次不相同！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkPwd())
            {
                string sqlcmd = $"update WX_RYXX set PASSWORD = '{GlobalFunction.GetMd5FromString(textBox3.Text)}' where ID = '{GlobalFunction.Account.Id}'";
                MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text, sqlcmd);
                MessageBox.Show("修改完成，请重新登录");
            }
        }
    }
}
