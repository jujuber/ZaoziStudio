using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WxHs
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private bool CheckPassword()
        {
            if (string.IsNullOrWhiteSpace(this.txtUserName.Text))
            {
                MessageBox.Show("用户不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = this.txtUserName;
                return false;
            }
            string outpvalue = string.Empty;
            if(!GlobalFunction.ConnectState(ref outpvalue))
            {
                MessageBox.Show(outpvalue, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string sqlcmd = string.Format("SELECT NAME,PY,PASSWORD,isnull(GLYBZ,0) FROM WX_RYXX where JLZT=1 and ID = '{0}'", this.txtUserName.Text.Trim());
            var user = GlobalFunction.GetDataTable(sqlcmd);
            if (user == null || user.Rows.Count == 0)
            {
                MessageBox.Show("用户名不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = this.txtUserName;
                return false;
            }
            string password = user.Rows[0][2].ToString();
            if (password != GlobalFunction.GetMd5FromString(this.txtPassword.Text))
            {
                MessageBox.Show("密码不正确！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.ActiveControl = this.txtPassword;
                return false;
            }
            if (GlobalFunction.Account == null)
            {
                GlobalFunction.Account = new DTO.User();
            }
            GlobalFunction.Account.Id = this.txtUserName.Text.Trim();
            GlobalFunction.Account.Name = user.Rows[0][0].ToString();
            GlobalFunction.Account.Py = user.Rows[0][1].ToString();
            GlobalFunction.Account.Glybz = Convert.ToInt32(user.Rows[0][3].ToString());
            return true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (!CheckPassword())
            {
                return;
            }
            Form1 frmMain = new Form1();
            frmMain.Show();
            this.Hide();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = this.txtPassword;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = this.btnLogin;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            new FrmSysConfig().ShowDialog();
        }

        private void groupBoxLogin_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxBrackgroundImage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GlobalFunction.GetMd5FromString("1234"));
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new FrmDatabase().ShowDialog();
        }
    }
}
