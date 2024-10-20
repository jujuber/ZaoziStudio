using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;

namespace WxHs
{
    public partial class FrmDatabase : Form
    {
        public FrmDatabase()
        {
            InitializeComponent();
        }

        private SqlConnectionStringBuilder sqlBuilder;
        private readonly string initPath = Environment.CurrentDirectory + @"\zaozi.config";
        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FrmDatabase_Load(object sender, EventArgs e)
        {
            try
            {
                sqlBuilder = new SqlConnectionStringBuilder();
                if (!File.Exists(initPath))
                {
                    File.Create(initPath);
                }
                XElement xel = XElement.Load(initPath);
                edtDataBase.Text = CBase64.DecodeBase64(xel.Element("InitialCatalog").Value);
                edtDataSource.Text = CBase64.DecodeBase64(xel.Element("DataSource").Value);
                edtSa.Text = CBase64.DecodeBase64(xel.Element("UserID").Value);
                edtPwd.Text = CBase64.DecodeBase64(xel.Element("Password").Value);
            }
            catch (Exception)
            {  
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MyTest())
            {
                MessageBox.Show("测试连接成功", "提示", MessageBoxButtons.OK);
            }
        }

        public bool MyTest()
        {
            try
            {
                if (sqlBuilder != null)
                {
                    sqlBuilder.DataSource = edtDataSource.Text;
                    sqlBuilder.InitialCatalog = edtDataBase.Text;
                    sqlBuilder.UserID = edtSa.Text;
                    sqlBuilder.Password = edtPwd.Text;
                }
                sqlConnection.Close();
                sqlConnection.ConnectionString = sqlBuilder.ConnectionString;
                sqlConnection.Open();
                return (sqlConnection.Database.Trim() != "");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XElement xe = new XElement("Config",
                new XElement("DataSource", CBase64.EncodeBase64(sqlBuilder.DataSource)),
                new XElement("InitialCatalog",CBase64.EncodeBase64(sqlBuilder.InitialCatalog)),
                new XElement("UserID",CBase64.EncodeBase64(sqlBuilder.UserID)),
                new XElement("Password",CBase64.EncodeBase64(sqlBuilder.Password))
                );
            xe.Save(initPath);
            MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK);
        }
    }
}
