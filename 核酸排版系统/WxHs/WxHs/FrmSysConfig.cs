using NPOI.POIFS.FileSystem;
using NPOI.SS.Formula.Functions;
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
    public partial class FrmSysConfig : Form
    {
        public FrmSysConfig()
        {
            InitializeComponent();
        }
        private IniFile ini;
        private void button1_Click(object sender, EventArgs e)
        {
            ini.WriteString("config", "excelpath", edtExcelpath.Text.Trim());
            MessageBox.Show("成功");
        }

        private void FrmSysConfig_Load(object sender, EventArgs e)
        {
            string sIniFileName = Environment.CurrentDirectory + @"\system.ini";
            ini = new IniFile(sIniFileName, false);
            if (ini.SectionExists("config"))
            {
                edtExcelpath.Text = ini.ReadString("config", "excelpath", "");
            }
        }
    }
}
