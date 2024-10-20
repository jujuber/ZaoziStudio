using FastReport.Cloud.StorageClient.Dropbox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WxHs.DTO;
using static System.Windows.Forms.ComboBox;

namespace WxHs
{
    public partial class FrmExportExcel : Form
    {
        public FrmExportExcel()
        {
            InitializeComponent();
        }
        public List<BHInfo> querylist = new List<BHInfo>();

        public List<string> Items
        {
            set
            {
                value.ForEach(r => this.cbbGG.Items.Add(r));
            }
        }
        private void QueryData()
        {
            
            if (this.dtpStart.Value > this.dtpEnd.Value)
            {
                MessageBox.Show("开始日期不能大于结束日期");
                return;
            }
            string sqlcmd = string.Format(@"Select XH Xh,BHNO Bhno,GG Gg,RQ Rq,JLZT Jlzt,CJRY Cjry,CJRYMC Cjrymc,
                                           case when JLZT = 1 then '编辑' else '完成' end State, 
                                           case when DCBZ = 1 then '已导出' else '未导出' end Dcbz, 
                                           DCRQ Dcrq,
                                           cast( 0 as bit) IsChecked,ISNULL(ISDATA,0) Isdata
                            From WX_HSVER  where Convert(varchar(8),RQ,112) >= '{0}' and  Convert(varchar(8),RQ,112) <= '{1}'",
                            this.dtpStart.Value.ToString("yyyyMMdd"), this.dtpEnd.Value.ToString("yyyyMMdd"), GlobalFunction.Account.Id);
           
            if (!string.IsNullOrWhiteSpace(cbbGG.Text))
            {
                sqlcmd += string.Format(" and GG='{0}'", cbbGG.Text);
            }
            if (!string.IsNullOrWhiteSpace(cbbry.Text))
            {
                var ry = cbbry.Text.Split('-');
                string ysdm = ry[0];
                sqlcmd += string.Format("and CJRY = '{0}'",ysdm);   
            }
            if (!string.IsNullOrWhiteSpace(edtBh.Text))
            { 
                sqlcmd += string.Format("and BHNO = '{0}'", edtBh.Text.Trim());
            }
            sqlcmd += "order by CJRQ desc";

            var dataTable = GlobalFunction.GetDataTable(sqlcmd);
            querylist.Clear();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                querylist = GlobalFunction.DataTableToList<BHInfo>(dataTable);
            }
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = querylist;
            this.dataGridView1.Refresh();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            QueryData();
        }

        private void FrmExportExcel_Load(object sender, EventArgs e)
        {
            this.dtpStart.Value = DateTime.Now;
            this.dtpEnd.Value = DateTime.Now;
            this.dataGridView1.AutoGenerateColumns = false;
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
                cbbry.Enabled = false;
            }
            cbbry.Text = string.Format("{0}-{1}", GlobalFunction.Account.Id, GlobalFunction.Account.Name);
            QueryData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            foreach (var item in querylist)
            {
                if (item.IsChecked)
                {
                    string sqlcmd = string.Format(@"select * from WX_HSVER where XH = {0} 
                            select * from WX_HSVERMX where HSXH = {0}
                            select * from WX_HSWRITELOG where HSXH = {0} ", item.Xh);
                    DataSet dst = MySqlHelper.ExecuteDataset(GlobalFunction.ConnectionString, CommandType.Text, sqlcmd);
                    string pfile = Environment.CurrentDirectory + @"\templates\板号明细.frx";
                    if (GlobalFunction.Account.Glybz == 1)
                    {
                        GlobalFunction.Printer.Design(dst, pfile);
                    }
                    else
                    {
                        GlobalFunction.Printer.Print(dst, pfile);
                    }
                }
            }
            
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string sqlcmd = string.Empty;
            //  string currentPath = System.Environment.CurrentDirectory+"/Excels/";
            string sDic = GlobalFunction.ExcelPath + @"\" + System.DateTime.Now.ToString("yyyy-MM-dd")+ @"\未上传";
            if (!Directory.Exists(sDic))
            {
                Directory.CreateDirectory(sDic);
            }
            int icount = 0;
            foreach (var item in querylist)
            {
                if (item.IsChecked)
                {
                    string[] cr = item.Gg.Split('*');
                    int columns = Convert.ToInt32(cr[0]);
                    int rows = Convert.ToInt32(cr[1]);
                    sqlcmd = string.Format("exec usp_hsjc_exportdata {0}", item.Xh);
                    var DT = GlobalFunction.GetDataTable(sqlcmd);
                    if (DT != null && DT.Rows.Count > 0)
                    {
                        string currentFileName = Path.Combine(sDic,string.Format(@"{0}-{1}-{2}-{3}", item.Bhno, DT.Rows.Count,GlobalFunction.Account.Py, System.DateTime.Now.ToString("yyyyMMdd")));
                        GlobalFunction.DataTable2Excel(DT, new NPOI.HSSF.UserModel.HSSFWorkbook(), currentFileName);
                        sqlcmd = string.Format("update WX_HSVER set DCBZ=1,DCRQ=getdate(),DCPATH='{1}' where XH = {0}", item.Xh, currentFileName);
                        MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text, sqlcmd);
                    }
                    icount++;
                }
            }
            if (icount > 0)
            {
                MessageBox.Show("导出成功!");
                QueryData();
            }
            else
            {
                MessageBox.Show("请勾选需要导出的数据!");
            }
            
            
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            querylist.ForEach(r =>
            {
                if (r.Dcbz == "未导出" && chkAll.Checked)
                {

                    r.IsChecked = true;
                }
                else if (r.Dcbz == "已导出" && chkAll.Checked)
                {
                    r.IsChecked = false;
                }
                else
                {
                    r.IsChecked = false;
                }

            } 
            );
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // if (this.dataGridView1.CurrentCell.ColumnIndex == 0)
           // {
           //     //获取DataGridView中CheckBox的Cell
           //     var bHInfo = this.dataGridView1.CurrentRow.DataBoundItem as BHInfo;
           //     DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0]);
           //     if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == false)
           //     {
           //         if (bHInfo.Dcbz == "已导出")
           //         {
           //             if (MessageBox.Show($"该板号【{bHInfo.Bhno}】信息已经导出，确认重新导出？ 是：导出", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
           //             {
           //                 dgvCheck.Value = true;
           //                 bHInfo.IsChecked = true;
           //             }
           //             else
           //             {
           //                 dgvCheck.Value = false;
           //                 bHInfo.IsChecked = false;
           //             }
           //         }
           //         else
           //         {
           //             dgvCheck.Value = false;
           //             bHInfo.IsChecked = true;
           //         }
           //     }

           //     //若单击时，CheckBox已经被勾上
           //     else
           //     {
           //         dgvCheck.Value = false;
           //         bHInfo.IsChecked = false;
           //     }
           // }
           //// dataGridView1.RefreshEdit();
           // dataGridView1.Refresh();
           //// dataGridView1.CommitEdit(commdata.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.CurrentCell != null && this.dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                //获取DataGridView中CheckBox的Cell
                var bHInfo = this.dataGridView1.CurrentRow.DataBoundItem as BHInfo;
                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0]);
                if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == true)
                {
                    if (bHInfo.Dcbz == "已导出")
                    {
                        if (MessageBox.Show($"该板号【{bHInfo.Bhno}】信息已经导出，确认重新导出？ 是：导出", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            dgvCheck.Value = true;
                            bHInfo.IsChecked = true;
                        }
                        else
                        {
                            dgvCheck.Value = false;
                            bHInfo.IsChecked = false;
                        }
                    }
                    else
                    {
                        dgvCheck.Value = false;
                        bHInfo.IsChecked = true;
                    }
                }

                //若单击时，CheckBox已经被勾上
                else
                {
                    dgvCheck.Value = false;
                    bHInfo.IsChecked = false;
                }
            }
             dataGridView1.RefreshEdit();
            //dataGridView1.Refresh();
            // dataGridView1.CommitEdit(commdata.Commit);
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void chbRy_CheckedChanged(object sender, EventArgs e)
        {
            cbbry.Enabled = chbRy.Checked;
            cbbry.Text = "";
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= dataGridView1.Rows.Count - 1)
            {
                return;
            }
            DataGridViewRow dr = (sender as DataGridView).Rows[e.RowIndex];

            if (dr.Cells["Column9"].Value.ToString().Trim().Equals("0"))
            {
                // 设置单元格的背景色
                dr.DefaultCellStyle.BackColor = Color.Red;
                // 设置单元格的前景色
                dr.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}
