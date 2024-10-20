using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WxHs.DTO;

namespace WxHs
{
    public partial class FrmGmcx : Form
    {
        public FrmGmcx()
        {
            InitializeComponent();
        }
        private void InitLable(string hsxh)
        {
            string sqlcmd = $@"select BHNO,GG,RQ,CJRYMC from WX_HSVER where XH = {hsxh}";
            var dtname = GlobalFunction.GetDataTable(sqlcmd);
            if (dtname != null && dtname.Rows.Count > 0)
            {
                lblBh.Text = dtname.Rows[0]["BHNO"].ToString();
                lblGg.Text = dtname.Rows[0]["GG"].ToString();
                lblRq.Text = dtname.Rows[0]["RQ"].ToString();
                lblRy.Text = dtname.Rows[0]["CJRYMC"].ToString();
            }
        }
        List<HsRect> rectList = new List<HsRect>();

        string Bbxh = string.Empty;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.edtQueryBarno.Text))
            {
                return;
            }
            lblno.Text = this.edtQueryBarno.Text;
            string sqlcmd = string.Format("select * from WX_HSWRITELOG where BARNO = '{0}'", this.edtQueryBarno.Text);
            var dtbn = GlobalFunction.GetDataTable(sqlcmd);
            string xh = string.Empty;
            if (dtbn != null && dtbn.Rows.Count > 0)
            {
                xh = dtbn.Rows[0]["HSXH"].ToString();
                Bbxh = xh;
                var sql = $@"select BHNO,GG,RQ,CJRYMC from WX_HSVER where XH = {xh}";
                var dtname = GlobalFunction.GetDataTable(sql);
                if (dtname != null && dtname.Rows.Count > 0)
                {
                    lblBh.Text = dtname.Rows[0]["BHNO"].ToString();
                    lblGg.Text = dtname.Rows[0]["GG"].ToString();
                    lblRq.Text = dtname.Rows[0]["RQ"].ToString();
                    lblRy.Text = dtname.Rows[0]["CJRYMC"].ToString();
                }

                var smls = GlobalFunction.DataTableToList<SmInfo>(dtbn).FirstOrDefault();

                rectList.Clear();
                string[] ggs = dtname.Rows[0]["GG"].ToString().Split('*');
                int columns = Convert.ToInt32(ggs[0]);
                int rows = Convert.ToInt32(ggs[1]);
                InitDataGridView(this.dgvBarno, columns, rows);
                sqlcmd = string.Format("select * from WX_HSVERMX where HSXH = {0}", xh);
                var dtmx = GlobalFunction.GetDataTable(sqlcmd);
                rectList = GlobalFunction.DataTableToList<HsRect>(dtmx);

                this.dgvBarno.DataSource = null;
                this.dgvBarno.DataSource = rectList;
                this.dgvBarno.Refresh();

                //this.dgvBarno.CurrentCell = this.dgvBarno.Rows[smls.BarY].Cells[smls.BarX]; //没有此句
                //this.dgvBarno.CurrentCell.Style.Font = new Font(this.Font, FontStyle.Bold);
                //this.dgvBarno.CurrentCell.Style.BackColor = Color.DarkGray;
                //this.dgvBarno.CurrentCell.Style.ForeColor = Color.Yellow;

                var Cell = this.dgvBarno.Rows[smls.BarY].Cells[smls.BarX]; //没有此句
                Cell.Style.Font = new Font(this.Font.FontFamily,16F, FontStyle.Bold);
                Cell.Style.BackColor = Color.Yellow;
                Cell.Style.ForeColor = Color.Red;

                this.dgvBarno.CurrentCell = null;
                edtQueryBarno.Clear();
                edtQueryBarno.Focus();
            }
        }

        public void InitDataGridView(DataGridView dgv, int columns, int rows)
        {
            dgv.Columns.Clear();
            for (int i = 0; i < columns; i++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = "A" + i.ToString();
                column.HeaderText = (i + 1).ToString();
                column.DataPropertyName = "A" + (i + 1).ToString();
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                // column.Width = 200;

                dgv.Columns.Add(column);
            }
            dgv.AutoGenerateColumns = false;//不然this.dataGridView1.DataSource = rectList;  会增加列数
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            //dgv.Columns(0).DefaultCellStyle.WrapMode = True

            dgv.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgv.AlternatingRowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //   dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            rectList.Clear();
            for (int i = 0; i < rows; i++)
            {
                HsRect hsRect = new HsRect();
                rectList.Add(hsRect);
            }
            dgv.DataSource = null;
            dgv.DataSource = rectList;
            dgv.Refresh();
        }

        private void FrmGmcx_Load(object sender, EventArgs e)
        {
            lblBh.Text = "";
            lblGg.Text = "";
            lblRq.Text = "";
            lblRy.Text = "";
            this.ActiveControl = edtQueryBarno;
        }
        string[] abc = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };
        private void dgvBarno_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rect = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
            dgvBarno.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, abc[e.RowIndex],
            dgvBarno.RowHeadersDefaultCellStyle.Font, rect,
            dgvBarno.RowHeadersDefaultCellStyle.ForeColor,
            TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void edtQueryBarno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnSearch.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlcmd = string.Format(@"select * from WX_HSVER where XH = {0} 
                            select * from WX_HSVERMX where HSXH = {0}
                            select * from WX_HSWRITELOG where HSXH = {0} ", Bbxh);
            DataSet dst = MySqlHelper.ExecuteDataset(GlobalFunction.ConnectionString, CommandType.Text, sqlcmd);
            string pfile = Environment.CurrentDirectory + @"\templates\管码查询.frx";
            if (GlobalFunction.Account.Glybz == 1)
            {
                GlobalFunction.Printer.Design(dst, pfile);
            }
            else
            {
                GlobalFunction.Printer.Print(dst, pfile);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
