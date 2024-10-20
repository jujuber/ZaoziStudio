using NPOI.HSSF.Record.Cont;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using WxHs.DTO;
using HorizontalAlignment = NPOI.SS.UserModel.HorizontalAlignment;

namespace WxHs
{
    public class GlobalFunction
    {
        public static readonly string ConfigPath = Environment.CurrentDirectory + @"\zaozi.config";
        private static string _constr;

        public static bool ConnectState(ref string outstring)
        {
            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                outstring = "数据库连接没有配置！";
                return false;
            }
            string sqlcmd = "select 1";
            var result = MySqlHelper.ExecuteScalar(ConnectionString, CommandType.Text, sqlcmd);
            if (result != null && result.ToString() == "1")
            {
                return true;
            }
            outstring = "数据库连接配置不正确！";
            return false; 
        }
        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_constr))
                {
                    if (File.Exists(ConfigPath))
                    {
                        var myXml = XElement.Load(ConfigPath);
                        if (!string.IsNullOrWhiteSpace(myXml.Element("DataSource").Value))
                        {
                            _constr = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};Password={3}",
                             CBase64.DecodeBase64(myXml.Element("DataSource").Value),
                             CBase64.DecodeBase64(myXml.Element("InitialCatalog").Value),
                             CBase64.DecodeBase64(myXml.Element("UserID").Value),
                             CBase64.DecodeBase64(myXml.Element("Password").Value));
                        }
                    }
                }
                return _constr;
            }
        }
        public static User Account;
        public static string ExcelPath { get; set; }
        public static FastReportPrintService Printer = new FastReportPrintService();
        public static string GetServerDate()
        {
            if (!string.IsNullOrWhiteSpace(ConnectionString))
            {
                string sqlcmd = "Select CONVERT(varchar(100), GETDATE(), 112) ";
                var obj= MySqlHelper.ExecuteScalar(ConnectionString, CommandType.Text, sqlcmd);
                if (obj != null)
                {
                    return obj.ToString();
                }
            }
            return System.DateTime.Now.ToString("yyyyMMdd");
        }
        /// <summary>
        /// DataTable数据导出为Excel
        /// </summary>
        /// <param name="dt">source</param>
        /// <param name="workbook">new HSSFWorkbook()</param>
        /// <param name="FilePath">存放路径</param>
        public static bool DataTable2Excel(DataTable dt, HSSFWorkbook workbook, string FilePath)
        {
            try
            {
                //创建sheet
                ISheet sheet = workbook.CreateSheet("sheet1");

                //设置header字体
                HSSFCellStyle styleHeader = (HSSFCellStyle)workbook.CreateCellStyle();
                styleHeader.Alignment = HorizontalAlignment.Center;
                IFont font = workbook.CreateFont();
                font.Boldweight = (short)FontBoldWeight.Bold;
                styleHeader.SetFont(font);

                HSSFCellStyle style = (HSSFCellStyle)workbook.CreateCellStyle();
                style.Alignment = HorizontalAlignment.Center;

                using (FileStream fs = new FileStream(FilePath + @".xls", FileMode.Create))
                {
                    IRow rowHeader = sheet.CreateRow(0);
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        ICell cellHeader = rowHeader.CreateCell(col);
                        cellHeader.SetCellValue(dt.Columns[col].ColumnName);
                        sheet.SetColumnWidth(col, 30 * 256);
                        cellHeader.CellStyle = styleHeader;
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        IRow row = sheet.CreateRow(i + 1);
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            ICell cell = row.CreateCell(j);
                            cell.SetCellValue(dt.Rows[i][j].ToString());
                            cell.CellStyle = style;
                        }
                    }
                    workbook.Write(fs);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public static DataTable GetDataTable(string sqlcmd)
        {
            DataSet dataset = MySqlHelper.ExecuteDataset(ConnectionString, CommandType.Text, sqlcmd);
            return dataset.Tables[0];
        }
        public static void InsertCzls(string czsm,string memo = "",int hsxh = -1)
        {
            string sqlcmd = string.Format(@"insert into WX_CZLS(HSXH,CZRY,CZRYMC,CZSM,MEMO,LRRQ)
                VALUES({0},'{1}','{2}','{3}','{4}',GETDATE())",
                hsxh,
                Account.Id,
                Account.Name,
                czsm,
                memo
                );
            try
            {
                MySqlHelper.ExecuteNonQuery(ConnectionString, CommandType.Text, sqlcmd);
            }
            catch
            { 
            }
        }
        public static UseConfig GetConfig(string id)
        {
            var convalue = GetDataTable(string.Format("select ID Id,VALUE Value,KZFS Kzfs from WX_XRGZ where ID='{0}'",id));
            if (convalue != null)
            {
                var datas = DataTableToList<UseConfig>(convalue);
                if (datas != null)
                {
                    return datas.FirstOrDefault();
                }
            }
            return null;
        }

        public static List<T> DataTableToList<T>(DataTable dt) where T:class ,new()
        {
            List<T> ts = new List<T>();
            string tempName = string.Empty;
            foreach (DataRow dr in dt.Rows)
            {
                T t = new T();
                PropertyInfo[] properties = t.GetType().GetProperties();
                foreach (PropertyInfo pi in properties)
                {
                    tempName = pi.Name;
                    if (dt.Columns.Contains(tempName))
                    {
                        object value = dr[tempName];
                        if (value != DBNull.Value)
                        {
                            pi.SetValue(t, value, null);
                        }
                    }
                }
                ts.Add(t);
            }
            return ts;
        }

        /// <summary>
        /// 生成字符串的MD5码
        /// </summary>
        /// <param name="sInput"></param>
        /// <returns></returns>
        public static string GetMd5FromString(string sInput)
        {
            var lstData = Encoding.GetEncoding("utf-8").GetBytes(sInput);
            var lstHash = new MD5CryptoServiceProvider().ComputeHash(lstData);
            var result = new StringBuilder(32);
            for (int i = 0; i < lstHash.Length; i++)
            {
                result.Append(lstHash[i].ToString("x2").ToUpper());
            }
            return result.ToString();
        }
        public static bool IsNumber(String str)
        {
            bool result = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsNumber(str, i))
                {
                    return true;
                }
            }
            return result;
        }
        public static bool isLetter(string str)
        {
            return Regex.Matches(str, "[a-zA-Z]").Count > 0;
        }
    }
}
