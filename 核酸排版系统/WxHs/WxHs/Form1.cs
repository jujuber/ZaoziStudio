using NPOI.HSSF.UserModel;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using WxHs.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using HorizontalAlignment = NPOI.SS.UserModel.HorizontalAlignment;

namespace WxHs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int isSave { get; set; }
        public bool SelectNextCell()
        {
            int column = this.dgvGrid.CurrentCell.ColumnIndex;
            int row = this.dgvGrid.CurrentCell.RowIndex;
            DataGridViewCell cell = dgvGrid.CurrentCell;
            do
            {
                column++;
                if (column == this.dgvGrid.Columns.Count)
                {
                    column = 0;
                    row++;
                }
                if (row == this.dgvGrid.Rows.Count)
                    row = 0;
            } while (this.dgvGrid[column, row].ReadOnly == true && this.dgvGrid[column, row] != cell);

            if (this.dgvGrid[column, row] == cell)
                return false;
            this.dgvGrid.CurrentCell = this.dgvGrid[column, row];
            return true;
        }

        public bool SelectNextCellEx()
        {
            int column = this.dgvGrid.CurrentCell.ColumnIndex;
            int row = this.dgvGrid.CurrentCell.RowIndex;
            DataGridViewCell cell = dgvGrid.CurrentCell;
            do
            {
                row++;
                if (row == this.dgvGrid.Rows.Count)
                {
                    row = 0;
                    column++;
                }
                if (column == this.dgvGrid.Columns.Count)
                    column = 0;
            } while (this.dgvGrid[column, row] == cell);

            if (this.dgvGrid[column, row] == cell)
                return false;
            this.dgvGrid.CurrentCell = this.dgvGrid[column, row];
            return true;
        }
        string[] abc = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };
        private bool isAdd;
        private string[,] HsRect;
        private List<string> HsList;
        private Dictionary<int,string> HsDict;
        private List<SmInfo> Sminfos = new List<SmInfo>();
        List<HsRect> rectList = new List<HsRect>();


        List<BHInfo> BHSource = new List<BHInfo>();
        /// <summary>
        /// 初始化ListView的方法
        /// </summary>
        /// <param name="lv"></param>
        public void InitDataGridView(DataGridView dgv,int columns,int rows)
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

        public string CurrentBhno
        {
            get
            {
                if (this.dgvBh.CurrentRow != null)
                {
                    var bhinfo = this.dgvBh.CurrentRow.DataBoundItem as BHInfo;
                    if (bhinfo != null)
                    {
                        return bhinfo.Bhno;
                    }
                }
                return string.Empty;
            }
        }
        public int CurrentXh
        {
            get
            {
                if (this.dgvBh.CurrentRow != null)
                {
                    var bhinfo = this.dgvBh.CurrentRow.DataBoundItem as BHInfo;
                    if (bhinfo != null)
                    {
                        return bhinfo.Xh;
                    }
                }
                return -1;
            }
        }
        public void InitData()
        {
            string sql = "select NAME from WX_ZDXX where FLDM = 1 order by PXXH";
            DataTable dt = GlobalFunction.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                cbbGG.Items.Clear();
                //  cbbGG.Items.AddRange(dt.Rows.Cast<DataRow>().Select(r => r["NAME"].ToString()).ToArray());
                dt.Rows.Cast<DataRow>().ToList().ForEach(r => cbbGG.Items.Add(r["NAME"].ToString()));
                cbbGG.SelectedIndex = 0;
            }
            
            
        }

        public void AddHh()
        {
            edtVersionH.Clear();
            edtBarNo.Clear();
            dtpDate.Value = System.DateTime.Now;
            this.btnSave.Enabled = true;
            this.ActiveControl = edtVersionH;
        }

        public void InitHsDict(int column, int row)
        {
            HsDict.Clear();
            int iTotal = 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    HsDict.Add(iTotal, string.Format("{0},{1}", i, j+1));
                    iTotal++;
                }
            }
        }

        private bool CheckWrite()
        {
            if (string.IsNullOrWhiteSpace(edtBarNo.Text))
            {
                edtBarNo.Focus();
                return false;
            }
            if (dgvBh.CurrentRow == null)
            {
                MessageBox.Show("没有对应的版号信息，不能进行条码录入");
                return false;
            }
            UseConfig useConfig = null;
            useConfig = GlobalFunction.GetConfig("1");
            if (useConfig != null)//长度控制
            {
                if (!string.IsNullOrWhiteSpace(useConfig.Value))
                {
                    try
                    {
                        int length = Convert.ToInt32(useConfig.Value);
                        if (useConfig.Kzfs == 1 && edtBarNo.Text.Length != length)
                        {
                            MessageBox.Show(String.Format("扫码长度不是【{0}】位，请核对是否正确?",length));
                            edtBarNo.Clear();
                            edtBarNo.Focus();
                            return false;
                        }
                        else if (useConfig.Kzfs == 0 && edtBarNo.Text.Length != length)
                        {
                            if (MessageBox.Show(String.Format("扫码长度不是【{0}】位，请核对是否正确？是：继续，否：不继续", length), "提示", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                            {
                                edtBarNo.Clear();
                                edtBarNo.Focus();
                                return false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("参数1设置有误："+ex.Message); 
                    }
                }
            }
            useConfig = GlobalFunction.GetConfig("2");
            if (useConfig != null)
            {
                if (!string.IsNullOrWhiteSpace(useConfig.Value) && useConfig.Value.Trim() == "是")
                {
                    if (GlobalFunction.IsNumber(edtBarNo.Text) == false)
                    {
                        if (useConfig.Kzfs == 1 )
                        {
                            MessageBox.Show("扫码信息中包含非数字，请确认");
                            edtBarNo.Clear();
                            edtBarNo.Focus();
                            return false;
                        }
                        else if (useConfig.Kzfs == 0)
                        {
                            if (MessageBox.Show("扫码信息中包含非数字，是否继续？是：继续", "提示", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                            {
                                edtBarNo.Clear();
                                edtBarNo.Focus();
                                return false;
                            }
                        }
                    }
                }
            }

            useConfig = GlobalFunction.GetConfig("3");
            if (useConfig != null)
            {
                if (!string.IsNullOrWhiteSpace(useConfig.Value))
                {
                    string[] startChars = useConfig.Value.Split(',');
                    string schar = edtBarNo.Text.Substring(0, 1);
                    if (startChars.Contains(schar))
                    {
                        if (useConfig.Kzfs == 1)
                        {
                            MessageBox.Show(string.Format("当前录入以【{0}】开头的管码信息无效,无法录入",schar));
                            edtBarNo.Clear();
                            edtBarNo.Focus();
                            return false;
                        }
                        else if (useConfig.Kzfs == 0)
                        {
                            if (MessageBox.Show(string.Format("当前录入以【{0}】开头的管码信息不符合要求，是否继续？是：继续", schar), "提示", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                            {
                                edtBarNo.Clear();
                                edtBarNo.Focus();
                                return false;
                            }
                        }
                    }
                }
            }

            if (dgvGrid.CurrentCell.Value != null && !string.IsNullOrWhiteSpace(dgvGrid.CurrentCell.Value.ToString()))
            {
                MessageBox.Show("当前位置已经存在有效的管码号，不能重复！可以点清空操作在录入");
                edtBarNo.Clear();
                edtBarNo.Focus();
                return false;
            }
            string sqlcmd = "";
            useConfig = GlobalFunction.GetConfig("5");
            if (useConfig != null)
            {
                if (useConfig.Value == "1")//1：本院存在的管码
                {
                    sqlcmd = string.Format(@"if(exists(select 1 from WX_HSWRITELOG with(nolock) where BARNO='{0}'))
                             select 1 else select 0", edtBarNo.Text.Trim());
                    string isc = MySqlHelper.ExecuteScalar(GlobalFunction.ConnectionString, CommandType.Text, sqlcmd).ToString();
                    if (useConfig.Kzfs == 1 && isc == "1")
                    {
                        MessageBox.Show("该条码已经存在，不能重复！");
                        edtBarNo.Clear();
                        edtBarNo.Focus();
                        return false;
                    }
                    else if (useConfig.Kzfs == 0 && isc == "1")
                    {
                        if (MessageBox.Show("该条码已经存在,是否继续？是：继续", "提示", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        {
                            edtBarNo.Clear();
                            edtBarNo.Focus();
                            return false;
                        }
                    }
                }
                else if (useConfig.Value == "2")
                {
                    sqlcmd = string.Format(@"if(exists(select 1 from WX_HSWRITELOG with(nolock) where CONVERT(varchar(8),getdate(),112) = SUBSTRING(SMRQ,1,8) and BARNO='{0}'))
                             select 1 else select 0", edtBarNo.Text.Trim());
                    string isc = MySqlHelper.ExecuteScalar(GlobalFunction.ConnectionString, CommandType.Text, sqlcmd).ToString();
                    if (useConfig.Kzfs == 1 && isc == "1")
                    {
                        MessageBox.Show("该条码今天已经录过，不能重复！");
                        edtBarNo.Clear();
                        edtBarNo.Focus();
                        return false;
                    }
                    else if (useConfig.Kzfs == 0 && isc == "1")
                    {
                        if (MessageBox.Show("该条码今天已经录过,是否继续？是：继续", "提示", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                        {
                            edtBarNo.Clear();
                            edtBarNo.Focus();
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public void WriteHsNo()
        {
            //if (string.IsNullOrWhiteSpace(edtBarNo.Text))
            //{
            //    edtBarNo.Focus(); 
            //    return;
            //}
            //if (dgvBh.CurrentRow == null)
            //{
            //    MessageBox.Show("没有对应的版号信息，不能进行条码录入");
            //    return;
            //}
            //if (GlobalFunction.IsNumber(edtBarNo.Text) == false)
            //{
            //    MessageBox.Show("扫码信息包含非常数字，请确认");
            //    return;
            //}
            //if (edtBarNo.Text.Length != 12)
            //{
            //    MessageBox.Show("扫码长度不是【12】位，请核对是否正确?");
            //    edtBarNo.Clear();
            //    edtBarNo.Focus();
            //    return;
            //    //if (MessageBox.Show("扫码长度不是12位，请核对是否正确？是：继续，否：不继续", "提示", MessageBoxButtons.YesNo,
            //    //    MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2) != DialogResult.Yes)
            //    //{
            //    //    edtBarNo.Clear();
            //    //    edtBarNo.Focus();
            //    //    return;
            //    //}      
            //}
            //if (edtBarNo.Text.Substring(0,1) == "4")
            //{
            //    MessageBox.Show("当前录入以【4】开头的管码信息无效");
            //    edtBarNo.Clear();
            //    edtBarNo.Focus();
            //    return;
            //}

            if (!CheckWrite()) return;

            var dgvr = dgvBh.CurrentRow.DataBoundItem as BHInfo;
            if (Sminfos.Exists(r=>r.BarNo == edtBarNo.Text))
            {
                MessageBox.Show("该条码已经存在，不能重复");
                edtBarNo.Clear();
                return;
            }
            var smi = Sminfos.Find(r => r.BarX == this.dgvGrid.CurrentCell.ColumnIndex && r.BarY == this.dgvGrid.CurrentCell.RowIndex);
            if (smi != null) Sminfos.Remove(smi);

            dgvGrid.CurrentCell.Value = edtBarNo.Text;
            dgvGrid.CurrentCell.Style.BackColor = Color.DarkGray;
            Sminfos.Add(new SmInfo
            {
                Bhno = dgvr.Bhno,
                BarNo = edtBarNo.Text.Trim(),
                BarX = this.dgvGrid.CurrentCell.ColumnIndex,
                BarY = this.dgvGrid.CurrentCell.RowIndex,
                Smry = GlobalFunction.Account.Id,
                Smrymc = GlobalFunction.Account.Name,
                Smrq = System.DateTime.Now.ToString("yyyyMMddHH:mm:ss:fff")
            });
            isSave++;
            /*
              int column = this.dgvGrid.CurrentCell.ColumnIndex;
            int row = this.dgvGrid.CurrentCell.RowIndex;
             */
            if (this.dgvGrid.CurrentCell.RowIndex == this.dgvGrid.RowCount - 1 && this.dgvGrid.CurrentCell.ColumnIndex == this.dgvGrid.ColumnCount -1)
            {
                //进入这里程序认为已经结束了，需要执行保存
                
                SaveBarInfo(dgvr);
                edtBarNo.Clear();
                btnAdd.Focus();
                return;
            }
            SelectNextCellEx();

            
            edtBarNo.Clear();
            edtBarNo.Focus();

        }

        public bool SaveBarInfo(BHInfo bHInfo)
        {
            //b
            string sqlColumns = string.Empty;
            if (dgvBh.CurrentRow == null) return false;
            //var selectItem = dgvBh.CurrentRow.DataBoundItem as BHInfo;
            string[] ggs = bHInfo.Gg.Split('*');
            int columns = Convert.ToInt32(ggs[0]);
            for (int i = 0; i < columns; i++)
            {
                if (string.IsNullOrWhiteSpace(sqlColumns))
                {
                    sqlColumns = string.Format("A{0}", i + 1);
                }
                else
                {

                    sqlColumns += string.Format(",A{0}", i + 1);
                }
            }
            string sqlcmd = string.Empty;
            for (int i = 0; i < rectList.Count; i++)
            {
                var rect = rectList[i];
                if (string.IsNullOrWhiteSpace(sqlcmd))
                {
                    sqlcmd = string.Format("insert into WX_HSVERMX(BHNO,ROWNAME,{0},BHRQ,LRRQ,HSXH)values('{1}','{2}',{3},'{4}',GETDATE(),{5})", 
                        sqlColumns, bHInfo.Bhno, abc[i], GetInsertItem(rect, columns), bHInfo.Rq.ToString("yyyyMMdd"),bHInfo.Xh);
                }
                else
                {
                    sqlcmd += Environment.NewLine + string.Format("insert into WX_HSVERMX(BHNO,ROWNAME,{0},BHRQ,LRRQ,HSXH)values('{1}','{2}',{3},'{4}',GETDATE(),{5})", 
                        sqlColumns, bHInfo.Bhno, abc[i], GetInsertItem(rect, columns), bHInfo.Rq.ToString("yyyyMMdd"), bHInfo.Xh);
                }
            }

            string sqlls = string.Empty;
            //组织流水
            foreach (var item in Sminfos)
            {
                if (string.IsNullOrWhiteSpace(sqlls))
                {
                    sqlls = string.Format("INSERT INTO WX_HSWRITELOG(BHNO,BARNO,BARX,BARY,SMRQ,SMRY,SMRYMC,BHRQ,HSXH)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8})",
                        item.Bhno, item.BarNo,item.BarX,item.BarY, item.Smrq, item.Smry, item.Smrymc, bHInfo.Rq.ToString("yyyyMMdd"), bHInfo.Xh);
                }
                else
                {
                    sqlls += Environment.NewLine + string.Format("INSERT INTO WX_HSWRITELOG(BHNO,BARNO,BARX,BARY,SMRQ,SMRY,SMRYMC,BHRQ,HSXH)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8})",
                        item.Bhno, item.BarNo,item.BarX,item.BarY, item.Smrq, item.Smry, item.Smrymc, bHInfo.Rq.ToString("yyyyMMdd"), bHInfo.Xh);
                }
            }
            var oldcount = MySqlHelper.ExecuteScalar(GlobalFunction.ConnectionString, CommandType.Text, string.Format("select count(1) from WX_HSWRITELOG where HSXH = {0}", bHInfo.Xh));
            var dcflg = MySqlHelper.ExecuteScalar(GlobalFunction.ConnectionString, CommandType.Text, string.Format("select ISNULL(DCBZ,0) from WX_HSVER where XH = {0}", bHInfo.Xh));
            
            if (oldcount != null && Convert.ToInt32(oldcount) > 0) //该板号已经录入了信息
            {

                if (Convert.ToInt32(dcflg) == 1 && string.IsNullOrWhiteSpace(sqlls))
                {
                    GlobalFunction.InsertCzls("执行【保存】动作！", string.Format("板号：{0} 已导出当前保存有可能会清空历史数据", bHInfo.Bhno), CurrentXh);
                    if (MessageBox.Show("重要提醒：当前板号以导出，此操作将会清空历史扫码数据，是否继续？", "提示", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    {
                        return true;
                    }
                }
                if (string.IsNullOrWhiteSpace(sqlls))
                {
                    GlobalFunction.InsertCzls("执行【保存】动作！", string.Format("板号：{0} 当前保存有可能会清空历史数据", bHInfo.Bhno), CurrentXh);
                    if (MessageBox.Show("重要提醒：当前操作将会清空历史扫码数据，是否继续", "提示", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                    {
                        return true;
                    }
                }
            }

            try
            {
                MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text,
                    string.Format("delete WX_HSVERMX where HSXH = {0}", bHInfo.Xh));
                MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text,
                    string.Format("delete WX_HSWRITELOG where HSXH = {0}", bHInfo.Xh));

                MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text, sqlcmd);
                MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text, sqlls);

                MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text,
                    string.Format("update WX_HSVER set JLZT=2,XGRQ=GETDATE(),ISDATA={1} where XH = {0}", bHInfo.Xh, Sminfos.Count > 0 ? 1 : 0));
                bHInfo.Jlzt = 2;
                bHInfo.State = "完成";
                this.dgvBh.Refresh();
                this.dgvGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                GlobalFunction.InsertCzls("【保存】失败", ex.Message, CurrentXh);
                GlobalFunction.InsertCzls("【保存】失败", sqlcmd, CurrentXh);
                GlobalFunction.InsertCzls("【保存】失败", sqlls, CurrentXh);
                return false;
            }

            return true;
        }

        public string GetInsertItem(HsRect hs,int columns)
        {
            PropertyInfo[] properties = hs.GetType().GetProperties();
            string result = string.Empty;
            int icolumn = 1;
            foreach (PropertyInfo pi in properties)
            {
                if (icolumn > columns)
                {
                    break;
                }
                if (string.IsNullOrWhiteSpace(result))
                {
                    result = string.Format("'{0}'", pi.GetValue(hs,null));
                }
                else
                {
                    result += string.Format(",'{0}'", pi.GetValue(hs, null));
                }
                icolumn++;
            }
            return result;
        }

        public void LoadVersionBh(string bh = "")
        {
            string sSql = string.Format(@"Select XH Xh,BHNO Bhno,GG Gg,RQ Rq,JLZT Jlzt,ISNULL(ISDATA,0) Isdata,
                            CJRY Cjry,CJRYMC Cjrymc,case when a.JLZT = 1 then '编辑' else '完成' end State
                            From WX_HSVER a Where convert(varchar(8),a.RQ,112)='{0}' and CJRY='{1}' ", this.dtpDate.Value.ToString("yyyyMMdd"),GlobalFunction.Account.Id);
            if (checkBox1.Checked == false && !string.IsNullOrWhiteSpace(this.cbbGG.Text))
            {
                sSql += string.Format(" and a.GG='{0}'", this.cbbGG.Text);
            }
            if (!string.IsNullOrWhiteSpace(bh))
            {
                sSql += string.Format(" and a.BHNO='{0}'", bh);
            }
            sSql += "order by a.CJRQ desc";
            var dataTable = GlobalFunction.GetDataTable(sSql);
            
            BHSource.Clear();
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
               BHSource = GlobalFunction.DataTableToList<BHInfo>(dataTable);
            }
            
            this.dgvBh.DataSource = null;
            this.dgvBh.DataSource = BHSource;
            this.dgvBh.Refresh();
            if (BHSource.Count == 0)
            {
                //  this.dgvBh.DataSource = BHSource;
                //  this.dgvBh.Refresh();
                this.dgvGrid.DataSource = null;
                this.dgvGrid.Refresh();
                // return;
            }
        }

        public void LoadSminfo(BHInfo rect)
        {
            Sminfos.Clear();
            rectList.Clear();
            string[] ggs = rect.Gg.Split('*');
            int columns = Convert.ToInt32(ggs[0]);
            int rows = Convert.ToInt32(ggs[1]);
            InitDataGridView(this.dgvGrid, columns, rows);
            string sqlcmd = string.Format("select * from WX_HSVERMX where HSXH = {0}", rect.Xh);
            var dtmx = GlobalFunction.GetDataTable(sqlcmd);
            rectList = GlobalFunction.DataTableToList<HsRect>(dtmx);

            this.dgvGrid.DataSource = null;
            this.dgvGrid.DataSource = rectList;
            this.dgvGrid.Refresh();

            sqlcmd = string.Format("select * from WX_HSWRITELOG where HSXH = {0}", rect.Xh);
            var dtls = GlobalFunction.GetDataTable(sqlcmd);
            if (dtls != null && dtls.Rows.Count >0)
            {
                Sminfos = GlobalFunction.DataTableToList<SmInfo>(dtls);
            }
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadVersionBh(this.edtVersionH.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void InitExcelPath()
        {
            string sIniFileName = Environment.CurrentDirectory + @"\system.ini";
            IniFile ini = new IniFile(sIniFileName, false);
            if (ini.SectionExists("config"))
            {
                GlobalFunction.ExcelPath = ini.ReadString("config", "excelpath", "");
            }
            if (string.IsNullOrWhiteSpace(GlobalFunction.ExcelPath))
            {
                GlobalFunction.ExcelPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // listView1.HoverSelection = true;  //当鼠标停留数秒后自动选择
            toolStripStatusLabel2.Text = String.Format("工号：{0} 姓名：{1}", GlobalFunction.Account.Id, GlobalFunction.Account.Name);
            cbbGG.SelectedIndex = 0;
            isSave = 0;
            if (BHSource == null)
            {
                BHSource = new List<BHInfo>();
            }
            BHSource.Clear();
            dgvBh.AutoGenerateColumns = false;//不然this.dataGridView1.DataSource = rectList;  会增加列数
            HsDict = new Dictionary<int, string>();
            HsList = new List<string>();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            InitExcelPath();
            InitData();
            LoadVersionBh();
            if (GlobalFunction.Account.Id == "1" || GlobalFunction.Account.Id == "66")
            {
                this.btnPrintBarno.Visible = true;
            }
            else
            {
                this.btnPrintBarno.Visible = false;
            }
            this.btnSave.Enabled = false;
            if (GlobalFunction.Account == null)
            {
                GlobalFunction.Account = new User() { Id = "121", Name = "whj" };
            }
            this.ActiveControl = btnAdd;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isSave > 0)
            {
                btnSaveBarxx.PerformClick();
            }
            isAdd = true;
            AddHh();
            this.btnAdd.Enabled = false;
            this.btnSave.Enabled = true;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            var bHInfo = this.dgvBh.CurrentRow.DataBoundItem as BHInfo;
            if (bHInfo != null)
            {
                if (MessageBox.Show($"是否确认删除【{bHInfo.Bhno}】？ 是：删除", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text,
                        string.Format("delete WX_HSVERMX where HSXH = {0} ", bHInfo.Xh));
                    MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text,
                        string.Format("delete WX_HSWRITELOG where HSXH = {0}", bHInfo.Xh));
                    MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text,
                        string.Format("delete WX_HSVER where XH = {0}", bHInfo.Xh));

                }
                LoadVersionBh();
            }
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.edtVersionH.Text))
            {
                MessageBox.Show("板号为空，无法修改");
                this.ActiveControl = edtVersionH;
                return;
            }
            var bHInfo = this.dgvBh.CurrentRow.DataBoundItem as BHInfo;
            if (bHInfo != null)
            {
                string sqlcmd = $@"if(exists(select 1 from WX_HSVER with(nolock) where BHNO = '{edtVersionH.Text}'  AND  CONVERT(varchar(100), RQ, 112) = '{GlobalFunction.GetServerDate()}'))
                                SELECT 1 ELSE SELECT 0";
                if (MySqlHelper.ExecuteScalar(GlobalFunction.ConnectionString, CommandType.Text, sqlcmd).ToString() == "1")
                {
                    MessageBox.Show("当天版号已经存在，不能修改！");
                    this.ActiveControl = edtVersionH;
                    return;
                }
                if (MessageBox.Show($"确认将板号【{bHInfo.Bhno}】修改为【{this.edtVersionH.Text}】？ 是：修改", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text,
                        string.Format("update WX_HSVER set BHNO = '{0}' where XH = {1}", this.edtVersionH.Text, bHInfo.Xh));
                    MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text,
                        string.Format("update WX_HSWRITELOG set BHNO = '{0}' where HSXH = {1}", this.edtVersionH.Text, bHInfo.Xh));
                    MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text,
                        string.Format("update WX_HSVERMX set BHNO = '{0}' where HSXH = {1}", this.edtVersionH.Text, bHInfo.Xh));

                }
                LoadVersionBh();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAdd == false)
            {
                MessageBox.Show("请先点击新增");
                this.ActiveControl = btnAdd;
                return;
            }
            if (string.IsNullOrWhiteSpace(edtVersionH.Text))
            {
                MessageBox.Show("请输入版号！");
                this.ActiveControl = edtVersionH;
                return;
            }
            string sqlcmd = $@"select CJRYMC,Convert(varchar(8),RQ,8) from WX_HSVER with(nolock) where BHNO = '{edtVersionH.Text}'  AND  CONVERT(varchar(100), RQ, 112) = '{GlobalFunction.GetServerDate()}'";
            var tabBm = GlobalFunction.GetDataTable(sqlcmd);
            if (tabBm != null && tabBm.Rows.Count > 0)
            {
                MessageBox.Show($"当天版号【{edtVersionH.Text}】已经存在，不能再次新增！创建者：【{tabBm.Rows[0][0].ToString()}】创建时间：【{tabBm.Rows[0][1].ToString()}】");
                this.ActiveControl = edtVersionH;
                return;
            }
            //if (MySqlHelper.ExecuteScalar(GlobalFunction.ConnectionString, CommandType.Text, sqlcmd).ToString() == "1")
            //{
            //    MessageBox.Show("当天版号已经存在，不能再次新增！");
            //    this.ActiveControl = edtVersionH;
            //    return;
            //}
            string bh = edtVersionH.Text.Trim();
            sqlcmd = $@"Insert Into WX_HSVER(BHNO,GG,RQ,JLZT,CJRY,CJRYMC,CJRQ,XGRY,XGRYMC,XGRQ,ISDATA)
                              Values('{edtVersionH.Text.Trim()}','{cbbGG.Text}',GETDATE(),1,
                              '{GlobalFunction.Account.Id}','{GlobalFunction.Account.Name}',GETDATE(),
                              '{GlobalFunction.Account.Id}','{GlobalFunction.Account.Name}',GETDATE(),0)
                         select @@identity 
                         ";
            object isok = MySqlHelper.ExecuteScalar(GlobalFunction.ConnectionString, CommandType.Text, sqlcmd);
            if (isok != null)
            {
                this.dgvBh.SelectionChanged -= dgvBh_SelectionChanged;
                isAdd = false;
                LoadVersionBh();
                //SetFocusBhRow(isok.ToString());
                string[] cr = cbbGG.Text.Split('*');
                int columns = Convert.ToInt32(cr[0]);
                int rows = Convert.ToInt32(cr[1]);
                HsRect = new string[columns, rows];
                InitHsDict(columns, rows);
                HsList.Clear();
                Sminfos.Clear();
                InitDataGridView(this.dgvGrid, columns, rows);
                //btnSaveBarxx.PerformClick();
                btnSaveBarxxEx();
                btnEdit.PerformClick();
                this.ActiveControl = edtBarNo;
                this.dgvGrid.CurrentCell = dgvGrid.Rows[0].Cells[0];
                this.dgvBh.SelectionChanged += dgvBh_SelectionChanged;
            }
            this.edtVersionH.Text = string.Empty;
            this.btnSave.Enabled = false;
            this.btnAdd.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count <= 0)
            //{
            //    return;
            //}
            //MessageBox.Show(listView1.SelectedItems[0].SubItems.Count.ToString());
            //listView1.SelectedItems[0].SubItems[8].Text = "ddd";
            new FrmDatabase().ShowDialog();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            WriteHsNo();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        DateTime dt = new DateTime();
        private void edtNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                WriteHsNo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvBh.CurrentRow == null) return;
            var dgvr = dgvBh.CurrentRow.DataBoundItem as BHInfo;
            MessageBox.Show(dgvr.Bhno);

        }
        private void dgvBh_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void dgvBh_SelectionChanged(object sender, EventArgs e)
        {
            isAdd = false;
            this.btnAdd.Enabled = true;
            this.btnSave.Enabled = false;
            if (this.dgvBh.CurrentRow != null && this.dgvBh.SelectedRows.Count > 0)
            {
                var selItem = this.dgvBh.CurrentRow.DataBoundItem as BHInfo;
                LoadSminfo(selItem);
                if (selItem.Jlzt == 2)
                {
                    this.dgvGrid.Enabled = false;
                    this.btnSaveBarxx.Enabled = false;
                    this.edtBarNo.Enabled = false;
                }
                else if (selItem.Jlzt == 1)
                {
                    this.dgvGrid.Enabled = true;
                    this.btnSaveBarxx.Enabled = true;
                    this.edtBarNo.Enabled = true;
                }
            }
        }
        private void dgvBh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= dgvBh.Rows.Count - 1)
            {
                return;
            }
            DataGridViewRow dr = (sender as DataGridView).Rows[e.RowIndex];

            if (dr.Cells["Column6"].Value.ToString().Trim().Equals("0"))
            {
                // 设置单元格的背景色
                dr.DefaultCellStyle.BackColor = Color.Red;
                // 设置单元格的前景色
                dr.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rect = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
            dgvGrid.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, abc[e.RowIndex],
            dgvGrid.RowHeadersDefaultCellStyle.Font, rect,
            dgvGrid.RowHeadersDefaultCellStyle.ForeColor,
            TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string SQL = "SELECT BARNO FROM WX_HSWRITELOG WHERE BHNO = 'C919'";
            var DT = GlobalFunction.GetDataTable(SQL);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出至Excel";
            saveFileDialog.Filter = "Excel文件(*.xls)|*.xls";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            { 
                if (GridToExcelByNPOI(DT, saveFileDialog.FileName))
                    MessageBox.Show("导出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private Boolean GridToExcelByNPOI(DataTable dt, string strExcelFileName)
        {
            NPOI.HSSF.UserModel.HSSFWorkbook workbook;
            try
            {
                workbook = new NPOI.HSSF.UserModel.HSSFWorkbook();
                NPOI.SS.UserModel.ISheet sheet = workbook.CreateSheet("Sheet1");

                NPOI.SS.UserModel.ICellStyle HeadercellStyle = workbook.CreateCellStyle();
                HeadercellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                HeadercellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                //字体
                NPOI.SS.UserModel.IFont headerfont = workbook.CreateFont();
                headerfont.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Bold;
                HeadercellStyle.SetFont(headerfont);

                //用column name 作为列名
                int icolIndex = 0;
                NPOI.SS.UserModel.IRow headerRow = sheet.CreateRow(0);
                //string[] colunmName = new string[PatientDetailView.VisibleColumns.Count];
                //foreach (DevExpress.XtraGrid.Columns.GridColumn item in PatientDetailView.VisibleColumns)
                //{
                //    NPOI.SS.UserModel.ICell cell = headerRow.CreateCell(icolIndex);
                //    cell.SetCellValue(item.FieldName);
                //    colunmName[icolIndex] = item.FieldName;
                //    cell.CellStyle = HeadercellStyle;
                //    icolIndex++;
                //}
                NPOI.SS.UserModel.ICellStyle cellStyle = workbook.CreateCellStyle();

                //为避免日期格式被Excel自动替换，所以设定 format 为 『@』 表示一率当成text來看
                cellStyle.DataFormat = NPOI.HSSF.UserModel.HSSFDataFormat.GetBuiltinFormat("@");
                cellStyle.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                cellStyle.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                cellStyle.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                cellStyle.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;

                NPOI.SS.UserModel.IFont cellfont = workbook.CreateFont();
                cellfont.Boldweight = (short)NPOI.SS.UserModel.FontBoldWeight.Normal;
                cellStyle.SetFont(cellfont);

                //建立内容行
                int iRowIndex = 1;
                int iCellIndex = 0;
                foreach (DataRow Rowitem in dt.Rows)
                {
                    NPOI.SS.UserModel.IRow DataRow = sheet.CreateRow(iRowIndex);
                    foreach (DataColumn Colitem in dt.Columns)
                    {
                        NPOI.SS.UserModel.ICell cell = DataRow.CreateCell(iCellIndex);
                        cell.SetCellValue(Rowitem[Colitem].ToString());
                        cell.CellStyle = cellStyle;
                        iCellIndex++;
                    }
                    //for (int i = 0; i <= colunmName.Count() - 1; i++)
                    //{
                    //    foreach (DataColumn Colitem in dt.Columns)
                    //    {
                    //        if (colunmName[i] == Colitem.Caption)
                    //        {
                    //            NPOI.SS.UserModel.ICell cell = DataRow.CreateCell(iCellIndex);
                    //            cell.SetCellValue(Rowitem[Colitem].ToString());
                    //            cell.CellStyle = cellStyle;
                    //            iCellIndex++;
                    //        }
                    //    }
                    //}
                    iCellIndex = 0;
                    iRowIndex++;
                }
                //自适应列宽度
                for (int i = 0; i < icolIndex; i++)
                {
                    sheet.AutoSizeColumn(i);
                }

                //写Excel
                FileStream file = new FileStream(strExcelFileName, FileMode.OpenOrCreate);
                workbook.Write(file);
                file.Flush();
                file.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                workbook = null;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            var frm = new FrmExportExcel();
            List<string> strings = new List<string>();
            foreach (var item in this.cbbGG.Items)
            {
                strings.Add(item.ToString());
            }
            frm.Items = strings;
            frm.ShowDialog();
            return;  
        }
        public void SetFocusBhRow(string xh)
        {
            dgvBh.SelectionChanged -= dgvBh_SelectionChanged;
            dgvBh.ClearSelection();
            //使用for循环
            for (int i = 0; i < this.dgvBh.Rows.Count; i++)
            {
                //获取第i行，列名是列名A的单元格的值
                string a = dgvBh.Rows[i].Cells["Column4"].Value.ToString();
                if (a == xh)
                {
                    //dgvBh.Rows[i].Selected = true;

                    dgvBh.CurrentCell = dgvBh.Rows[i].Cells[0];//没有此句不行
                    dgvBh.CurrentRow.Selected = true;
                    break;
                    //DataGridViewRow dgvr = dgvBh.Rows[i];//获取选中行的上一行
                }
            }
            dgvBh.SelectionChanged += dgvBh_SelectionChanged;

            dgvBh_SelectionChanged(null, null);
        }
        private void btnQueryBarno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.edtQueryBarno.Text))
            {
                return;
            }
            string sqlcmd = string.Format("select * from WX_HSWRITELOG where BARNO = '{0}'", this.edtQueryBarno.Text);
            var dtbn = GlobalFunction.GetDataTable(sqlcmd);
            string Bhinfos = string.Empty;
            if (dtbn != null && dtbn.Rows.Count > 0)
            {
                dgvBh.SelectionChanged -= dgvBh_SelectionChanged;
                Bhinfos = dtbn.Rows[0][0].ToString();
                var smls = GlobalFunction.DataTableToList<SmInfo>(dtbn).FirstOrDefault();
                dgvBh.ClearSelection();
                //使用for循环
                for (int i = 0; i < this.dgvBh.Rows.Count; i++)
                {
                    //获取第i行，列名是列名A的单元格的值
                    string a = dgvBh.Rows[i].Cells["Column1"].Value.ToString();
                    if (a == smls.Bhno)
                    {
                        //dgvBh.Rows[i].Selected = true;
                        
                        dgvBh.CurrentCell = dgvBh.Rows[i].Cells[1];//没有此句不行
                        dgvBh.CurrentRow.Selected = true;
                        //DataGridViewRow dgvr = dgvBh.Rows[i];//获取选中行的上一行
                    }
                }
                var dgvr = dgvBh.CurrentRow.DataBoundItem as BHInfo;
                LoadSminfo(dgvr);
                this.dgvGrid.CurrentCell = this.dgvGrid.Rows[smls.BarY].Cells[smls.BarX]; //没有此句
                dgvBh.SelectionChanged += dgvBh_SelectionChanged;
            }

        }

        private void edtBarNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveBarxx_Click(object sender, EventArgs e)
        {
            btnSaveBarxxEx();
            SetdgvGridCellBackColor();
        }
        private void btnSaveBarxxEx()
        {
            if (dgvBh.CurrentRow == null)
            {
                MessageBox.Show("没有对应的版号信息，不能进行条码录入");
                return;
            }
            var dgvr = dgvBh.CurrentRow.DataBoundItem as BHInfo;
            if (SaveBarInfo(dgvr))
            {
                this.dgvGrid.Enabled = false;
                this.btnSaveBarxx.Enabled = false;
                this.edtBarNo.Enabled = false;
                isSave = 0;
            }
            
        }

        private void dgvGrid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //if (e.RowIndex >= this.dgvGrid.Rows.Count - 1)
            //{
            //    return;
            //}
            //DataGridViewRow dr = (sender as DataGridView).Rows[e.RowIndex];

            //if (dr.Cells["项目代码"].Value.ToString().Trim().Equals("ACAC0001"))
            //{
            //    // 设置单元格的背景色
            //    dr.DefaultCellStyle.BackColor = Color.Yellow;
            //    // 设置单元格的前景色
            //    dr.DefaultCellStyle.ForeColor = Color.Black;
            //}
            //else
            //{
            //    dr.DefaultCellStyle.BackColor = Color.Blue;
            //    dr.DefaultCellStyle.ForeColor = Color.White;
            //}
        }

        private void dgvGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
           
            if (e.Value != null)
            {
                if (string.IsNullOrWhiteSpace(e.Value.ToString()))
                {
                    e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (BHSource.Count == 0)
            {
                MessageBox.Show("没有有效的板号信息，不能编辑");
                return;
            }
            var dgvr = dgvBh.CurrentRow.DataBoundItem as BHInfo;
            var useConfig = GlobalFunction.GetConfig("4");
            if (useConfig != null)
            {
                if (!string.IsNullOrWhiteSpace(useConfig.Value) && useConfig.Value.Trim() == "否")
                {
                    var dcdt = GlobalFunction.GetDataTable(string.Format("select ISNULL(DCBZ,0) from WX_HSVER where XH = {0}", dgvr.Xh));
                    int idcbz = 0;
                    if (dcdt != null && dcdt.Rows.Count > 0)
                    {
                        idcbz = Convert.ToInt32(dcdt.Rows[0][0].ToString());
                    }
                    if (idcbz == 1) //已经导出
                    {
                        if (useConfig.Kzfs == 1)
                        {
                            MessageBox.Show(string.Format("板号【{0}】已经导出，不允许编辑修改",dgvr.Bhno));
                            return ;
                        }
                        else if (useConfig.Kzfs == 0)
                        {
                            if (MessageBox.Show(string.Format("板号【{0}】已经导出，是否编辑修改？是：可以编辑",dgvr.Bhno), "提示", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                            {
                                return;
                            }
                        }
                    }
                }
            }

            this.dgvGrid.Enabled = true;
            this.btnSaveBarxx.Enabled = true;
            this.edtBarNo.Enabled = true;
            this.ActiveControl = edtBarNo;

            //var bHInfo = this.dgvBh.CurrentRow.DataBoundItem as BHInfo;
            //bHInfo.Jlzt = 1;
            //bHInfo.State = "编辑";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
            var bHInfo = this.dgvBh.CurrentRow.DataBoundItem as BHInfo;
            string sqlcmd = string.Format(@"select * from WX_HSVER where BHNO = '{0}' and Convert(varchar(8),RQ,112)='{1}' 
                            select * from WX_HSVERMX where BHNO = '{0}' and Convert(varchar(8),BHRQ,112)='{1}' 
                            select * from WX_HSWRITELOG where BHNO = '{0}' and Convert(varchar(8),BHRQ,112)='{1}' ",bHInfo.Bhno,bHInfo.Rq.ToString("yyyyMMdd"));
            DataSet dst  = MySqlHelper.ExecuteDataset(GlobalFunction.ConnectionString, CommandType.Text, sqlcmd);
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isSave > 0)
            {
                MessageBox.Show("存在需要保存的数据");
            }
            var resultfrm = MessageBox.Show("是否确认退出系统？", "提示", MessageBoxButtons.YesNo);
            if (resultfrm == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {

                e.Cancel = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadVersionBh(this.edtVersionH.Text);
            isAdd = false;
            this.btnAdd.Enabled = true;
            this.btnSave.Enabled = false;
        }

        private void edtQueryBarno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnQueryBarno.PerformClick();
            }
        }
        private void NextCell()
        {
            if (this.dgvGrid.Enabled == true && this.dgvGrid.CurrentCell != null)
            {
                SelectNextCellEx();
                this.ActiveControl = this.edtBarNo;
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            NextCell();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 || e.KeyCode == Keys.Space)
            {
                NextCell();
            }
            else if (e.KeyCode == Keys.F2)
            {
                CellClear();
            }
            else if (e.Modifiers == (Keys.Control|Keys.Shift) && e.KeyCode == Keys.D)
            {
                ClearData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FrmPwd().ShowDialog();
        }

        private void SetdgvGridCellBackColor()
        {
            for (int i = 0; i < this.dgvGrid.RowCount; i++)
            {
                for (int j = 0; j < this.dgvGrid.ColumnCount; j++)
                {
                    var cellobj = this.dgvGrid.Rows[i].Cells[j].Value;
                    if (cellobj == null || string.IsNullOrWhiteSpace(cellobj.ToString()))
                    {
                        this.dgvGrid.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        this.dgvGrid.Rows[i].Cells[j].Style.BackColor = Color.DarkGray;
                    }
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvGrid.RowCount; i++)
            {
                for (int j = 0; j < this.dgvGrid.ColumnCount; j++)
                {
                    var cellobj = this.dgvGrid.Rows[i].Cells[j].Value;
                    if (cellobj == null || string.IsNullOrWhiteSpace(cellobj.ToString()))
                    {
                        this.dgvGrid.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
                    else
                    {
                        this.dgvGrid.Rows[i].Cells[j].Style.BackColor = Color.DarkGray;
                    }

                }
            }
        }
        private void CellClear()
        {
            if (this.dgvGrid.Enabled == false)
            {
                return;
            }
            if (Sminfos != null && Sminfos.Count >= 0)
            {
                var smi = Sminfos.Find(r => r.BarX == this.dgvGrid.CurrentCell.ColumnIndex && r.BarY == this.dgvGrid.CurrentCell.RowIndex);
                if (smi != null) Sminfos.Remove(smi);
            }
            if (dgvGrid.CurrentCell != null)
            {
                dgvGrid.CurrentCell.Value = "";
            }   
            this.ActiveControl = edtBarNo;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            CellClear();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            new FrmUsp().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FrmGmcx().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetFocusBhRow("25");
        }

        private void dgvBh_MouseDown(object sender, MouseEventArgs e)
        {
            if (isSave > 0)
            {
                btnSaveBarxx.PerformClick();
            }
        }

        private void 修改板号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bHInfo = this.dgvBh.CurrentRow.DataBoundItem as BHInfo;
            if (bHInfo == null)
            {
                return;
            }
            FrmModifyBh frmModify = new FrmModifyBh();
            frmModify.StringOldBh = bHInfo.Bhno;
            if (frmModify.ShowDialog() == DialogResult.OK)
            {
                MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text,
                         string.Format("update WX_HSVER set BHNO = '{0}' where XH = {1}", frmModify.StringBh, bHInfo.Xh));
                MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text,
                    string.Format("update WX_HSWRITELOG set BHNO = '{0}' where HSXH = {1}", frmModify.StringBh, bHInfo.Xh));
                MySqlHelper.ExecuteNonQuery(GlobalFunction.ConnectionString, CommandType.Text,
                    string.Format("update WX_HSVERMX set BHNO = '{0}' where HSXH = {1}", frmModify.StringBh, bHInfo.Xh));
                bHInfo.Bhno = frmModify.StringBh;
                GlobalFunction.InsertCzls("执行【修改板号】动作！",
                    string.Format("序号：{0}；修改前板号：【{1}】,修改后：【{2}】",bHInfo.Xh, bHInfo.Bhno, frmModify.StringBh),
                    bHInfo.Xh);
                this.dgvBh.Refresh();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new FrmPrintBarno().ShowDialog();
        }
        private void ClearData()
        {
            if (this.btnSaveBarxx.Enabled == false)
            {
                return;
            }
            var bHInfo = this.dgvBh.CurrentRow.DataBoundItem as BHInfo;
            if (bHInfo == null)
            {
                return;
            }
            if (MessageBox.Show($"是否全部清除管码信息？ 是：全清", "提示", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Sminfos.Clear();
                for (int i = 0; i < dgvGrid.RowCount; i++)
                {
                    for (int j = 0; j < dgvGrid.ColumnCount; j++)
                    {
                        dgvGrid.Rows[i].Cells[j].Value = string.Empty;
                    }
                }
                if (dgvGrid.RowCount > 0)
                {
                    dgvGrid.CurrentCell = dgvGrid.Rows[0].Cells[0];
                }

                GlobalFunction.InsertCzls("执行【全清】动作！", string.Format("板号：{0}", bHInfo.Bhno), CurrentXh);
            }
            edtBarNo.Focus();
        }

        private void RefreshToolLbl()
        {
            if (this.btnSaveBarxx.Enabled == false)
            {
                return;
            }

            int total = dgvGrid.RowCount * dgvGrid.ColumnCount;
            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < dgvGrid.RowCount; i++)
            {
                for (int j = 0; j < dgvGrid.ColumnCount; j++)
                {
                    if (string.IsNullOrWhiteSpace(dgvGrid.Rows[i].Cells[j].Value.ToString()))
                        num2++;
                    else
                        num1++;
                }
            }

        }
        private void btnGridClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
