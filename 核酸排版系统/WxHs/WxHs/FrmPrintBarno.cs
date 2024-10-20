using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WxHs
{
    public partial class FrmPrintBarno : Form
    {
        public FrmPrintBarno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                return;
            }
            System.Data.DataTable table = new DataTable("BarTable");
            // Declare variables for DataColumn and DataRow objects.
            DataColumn column;
            DataRow row;

            // Create second column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Barno";
            column.AutoIncrement = false;
            column.Caption = "条码";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            table.Columns.Add(column);

            row = table.NewRow();
            row["Barno"] = textBox1.Text;
            table.Rows.Add(row);

            // Instantiate the DataSet variable.
            DataSet dataSet = new DataSet();
            // Add the new DataTable to the DataSet.
            dataSet.Tables.Add(table);
            string pfile = Environment.CurrentDirectory + @"\templates\管码打印.frx";
            GlobalFunction.Printer.Design(dataSet, pfile);
        }
    }
}
