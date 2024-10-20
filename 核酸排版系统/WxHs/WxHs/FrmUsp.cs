using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WxHs.DTO;

namespace WxHs
{
    public partial class FrmUsp : Form
    {
        public FrmUsp()
        {
            InitializeComponent();
        }
        private void FrmUsp_Load(object sender, EventArgs e)
        {
            this.dtpStart.Value = DateTime.Now;
            this.dtpEnd.Value = DateTime.Now;
            //this.dataGridView1.AutoGenerateColumns = false;
            cbbry.Enabled = false;
            if (GlobalFunction.Account.Glybz == 1)
            {
                string sqlcmd = "select ID+'-'+NAME A1 from WX_RYXX where JLZT=1";
                DataTable dt = GlobalFunction.GetDataTable(sqlcmd);
                if (dt != null && dt.Rows.Count > 0)
                {
                    cbbry.Items.Clear();
                    dt.Rows.Cast<DataRow>().ToList().ForEach(r => cbbry.Items.Add(r["A1"].ToString()));
                }
            }
            else
            {
                this.chbRy.Visible = false;
                cbbry.Text = string.Format("{0}-{1}",GlobalFunction.Account.Id,GlobalFunction.Account.Name);
                cbbry.Enabled = false;
            }
            
        }

        private string FromatTime(string times)
        {
            if (times.Length == 7)
            {
                return string.Format("0{0}",times);
            }
            return times;
        }
        private void QueryData()
        {

            if (this.dtpStart.Value > this.dtpEnd.Value)
            {
                MessageBox.Show("开始日期不能大于结束日期");
                return;
            }


            string sqlcmd = string.Format(@"exec usp_hsjc_querydata '{0}','{1}','{2}'",
                            this.dtpStart.Value.ToString("yyyyMMdd")+ FromatTime(this.dateTimePicker1.Text), 
                            this.dtpEnd.Value.ToString("yyyyMMdd") + FromatTime(this.dateTimePicker2.Text),
                            cbbry.Text
                            );

            var dataTable = GlobalFunction.GetDataTable(sqlcmd);
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = dataTable;
            this.dataGridView1.Refresh();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            QueryData();
        }

        private void chbRy_CheckedChanged(object sender, EventArgs e)
        {
            cbbry.Enabled = chbRy.Checked;
            cbbry.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            if (this.dataGridView1.DataSource == null)
            {
                MessageBox.Show("请先查询数据");
                return;
            }
            DataSet dst = new DataSet();
            var dt = this.dataGridView1.DataSource as DataTable;
            dst.Tables.Add(dt.Copy());
            string pfile = Environment.CurrentDirectory + @"\templates\查询统计.frx";
            if (GlobalFunction.Account.Id == "1")
            {
                GlobalFunction.Printer.Design(dst, pfile);
            }
            else
            {
                GlobalFunction.Printer.Print(dst, pfile);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.DataSource == null)
            {
                MessageBox.Show("请先查询数据");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出至Excel";
            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                var dt = this.dataGridView1.DataSource as DataTable;
                if(GlobalFunction.DataTable2Excel(dt, new NPOI.HSSF.UserModel.HSSFWorkbook(), saveFileDialog.FileName))
                    MessageBox.Show("导出成功");
            }
        }
    }
}
