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
    public partial class FrmModifyBh : Form
    {
        public FrmModifyBh()
        {
            InitializeComponent();
        }
        public string StringBh
        {
            get
            {
                return edtNewBh.Text;
            }
        }
        public string StringOldBh
        {
            get { return edtOldBh.Text; }
            set { edtOldBh.Text = value; }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(StringBh))
            {
                MessageBox.Show("新板号为空");
                edtNewBh.Focus();
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
