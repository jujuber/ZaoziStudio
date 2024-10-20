using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastReport;
using FastReport.Preview;
using FastReport.Utils;
using System.IO;
using FastReport.Export.Pdf;
using FastReport.Export.Html;
using FastReport.Export.Image;
using System.Collections;

namespace WxHs
{
    /// <summary>
    /// 报表打印服务
    /// </summary>
    public class FastReportPrintService
    {
        /// <summary>
        /// 报表打印服务
        /// </summary>
        public FastReportPrintService()
        {
            Config.UseOffice2007Form = true;
            Config.UIStyle = UIStyle.Office2007Blue;
            Config.DesignerSettings.Text = "Winning.FrameWork报表设计界面-";
        }

        /// <summary>
        /// 打印报表
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        public void Print(DataSet dataSource, string reportFileName)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.PrintSettings.ShowDialog = false;
                report.Print();
            }
        }
        /// <summary>
        /// 打印报表
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        public void Print(IEnumerable dataSource, string reportFileName)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Print();
            }
        }
        /// <summary>
        /// 报表设计
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        public void Design(DataSet dataSource, string reportFileName)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Design();
            }
        }
        /// <summary>
        /// 报表设计
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        public void Design(IEnumerable dataSource, string reportFileName)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Design();
            }
        }
        /// <summary>
        /// 报表预览
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        public void Preview(DataSet dataSource, string reportFileName)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Show();
            }
        }
        /// <summary>
        /// 报表预览
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        public void Preview(IEnumerable dataSource, string reportFileName)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Show();
            }
        }
        /// <summary>
        /// 报表预览
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="previewControl">显示预览的控件</param>
        public void Preview(DataSet dataSource, string reportFileName, object previewControl)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Preview = previewControl as PreviewControl;
                report.Show();
            }
        }
        /// <summary>
        /// 报表预览
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="previewControl">显示预览的控件</param>
        public void Preview(IEnumerable dataSource, string reportFileName, object previewControl)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Preview = previewControl as PreviewControl;
                report.Show();
            }
        }
        /// <summary>
        /// 报表导出为HTML
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="exportFileName">导出的文件名</param>
        public void ExportHtml(DataSet dataSource, string reportFileName, string exportFileName)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Prepare();
                report.Export(new HTMLExport(), exportFileName);
            }
        }
        /// <summary>
        /// 报表导出为HTML
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="exportFileName">导出的文件名</param>
        public void ExportHtml(IEnumerable dataSource, string reportFileName, string exportFileName)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Prepare();
                report.Export(new HTMLExport(), exportFileName);
            }
        }
        /// <summary>
        /// 报表导出为PDF
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="stream">导出的流</param>
        public void ExportHtml(DataSet dataSource, string reportFileName, Stream stream)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Prepare();
                report.Export(new HTMLExport(), stream);

            }
        }
        /// <summary>
        /// 报表导出为PDF
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="stream">导出的流</param>
        public void ExportHtml(IEnumerable dataSource, string reportFileName, Stream stream)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Prepare();
                report.Export(new HTMLExport(), stream);

            }
        }
        /// <summary>
        /// 报表导出为PDF
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="exportFileName">导出的文件名</param>
        public void ExportPdf(DataSet dataSource, string reportFileName, string exportFileName)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Prepare();
                report.Export(new PDFExport(), exportFileName);
            }
        }
        /// <summary>
        /// 报表导出为PDF
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="exportFileName">导出的文件名</param>
        public void ExportPdf(IEnumerable dataSource, string reportFileName, string exportFileName)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Prepare();
                report.Export(new PDFExport(), exportFileName);
            }
        }
        /// <summary>
        /// 报表导出为PDF
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="stream">导出的流</param>
        public void ExportPdf(DataSet dataSource, string reportFileName, Stream stream)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Prepare();
                report.Export(new PDFExport(), stream);

            }
        }
        /// <summary>
        /// 报表导出为PDF
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="stream">导出的流</param>
        public void ExportPdf(IEnumerable dataSource, string reportFileName, Stream stream)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Prepare();
                report.Export(new PDFExport(), stream);

            }
        }
        /// <summary>
        /// 报表导出为图片
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="exportFileName">导出的文件名</param>
        public void ExportImage(DataSet dataSource, string reportFileName, string exportFileName)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Prepare();
                report.Export(new ImageExport(), exportFileName);
            }
        }
        /// <summary>
        /// 报表导出为图片
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="exportFileName">导出的文件名</param>
        public void ExportImage(IEnumerable dataSource, string reportFileName, string exportFileName)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Prepare();
                report.Export(new ImageExport(), exportFileName);
            }
        }
        /// <summary>
        /// 报表导出为图片
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="stream">导出的流</param>
        public void ExportImage(DataSet dataSource, string reportFileName, Stream stream)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Prepare();
                report.Export(new ImageExport(), stream);

            }
        }
        /// <summary>
        /// 报表导出为图片
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="stream">导出的流</param>
        public void ExportImage(IEnumerable dataSource, string reportFileName, Stream stream)
        {
            PrintSettingsInfo printSettings = this.GetPrintSettings(reportFileName);

            if (printSettings == null || printSettings.IsPrint)
            {
                Report report = this.CreateReport(dataSource, reportFileName, printSettings);
                report.Prepare();
                report.Export(new ImageExport(), stream);

            }
        }

        /// <summary>
        /// 获取打印设置信息
        /// </summary>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <returns>返回打印设置信息，否则返回null</returns>
        private PrintSettingsInfo GetPrintSettings(string reportFileName)
        {
         //   IClientEnvironment client = ServiceLocator.Current.GetInstance<IClientEnvironment>();
          //  IComputerFunction computerService = ServiceLocator.Current.GetInstance<IComputerFunction>();
            PrintSettingsInfo printSettings = new PrintSettingsInfo { IsPrint = true };

            return printSettings;
        }
        /// <summary>
        /// 创建打印报表
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="printSettings">打印设置信息</param>
        /// <returns>返回打印报表</returns>
        private Report CreateReport(DataSet dataSource, string reportFileName, PrintSettingsInfo printSettings)
        {
            DataTable reportMasterInfo = new DataTable();
            reportMasterInfo.TableName = "ReportMasterInfo";
            reportMasterInfo.Columns.Add("医院名称", typeof(string));
            reportMasterInfo.Columns.Add("系统名称", typeof(string));
            reportMasterInfo.Columns.Add("科室名称", typeof(string));
            reportMasterInfo.Columns.Add("病区名称", typeof(string));
            reportMasterInfo.Columns.Add("职工姓名", typeof(string));
            DataRow row = reportMasterInfo.NewRow();
            row["医院名称"] = "";
            row["系统名称"] = "";// SystemFacade.Strategy.Copyright.SystemName;
            row["科室名称"] = "";// ClientFacade.Department == null ? null : ClientFacade.Department.Name;
            row["病区名称"] = "";//ClientFacade.Ward == null ? null : ClientFacade.Ward.Name;
            row["职工姓名"] = "";//ClientFacade.Account == null ? null : ClientFacade.Account.Name;
            reportMasterInfo.Rows.Add(row);

            if (!dataSource.Tables.Contains(reportMasterInfo.TableName))
            {
                dataSource.Tables.Add(reportMasterInfo);
            }

            Report result = new Report();
            result.RegisterData(dataSource, "报表数据");

            string realReportFileName = reportFileName;
            if (printSettings != null)
            {
                if (!string.IsNullOrWhiteSpace(printSettings.ReportFileName))
                {
                    realReportFileName = printSettings.ReportFileName;
                }
                if (!string.IsNullOrWhiteSpace(printSettings.PrintDevice))
                {
                    result.PrintSettings.Printer = printSettings.PrintDevice;
                }
            }

            if (!File.Exists(reportFileName))
            {
                string directory = new FileInfo(reportFileName).DirectoryName;
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                if (result.Pages.Count == 0)
                {
                    result.Pages.Add(this.CreateDefaultReportPage());
                }
                result.Save(reportFileName);
            }
            result.Load(reportFileName);
            if (result.Pages.Count == 0)
            {
                result.Pages.Add(this.CreateDefaultReportPage());
            }

            return result;
        }
        /// <summary>
        /// 创建打印报表
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <param name="printSettings">打印设置信息</param>
        /// <returns>返回打印报表</returns>
        private Report CreateReport(IEnumerable dataSource, string reportFileName, PrintSettingsInfo printSettings)
        {
            ReportMasterInfo reportMasterInfo = new ReportMasterInfo
            {
                医院名称 = "",//SystemFacade.Strategy.Copyright.CustomerName,
                系统名称 = "",//SystemFacade.Strategy.Copyright.SystemName,
                科室名称 = "",//ClientFacade.Department == null ? null : ClientFacade.Department.Name,
                病区名称 = "",//ClientFacade.Ward == null ? null : ClientFacade.Ward.Name,
                职工姓名 = ""//ClientFacade.Account == null ? null : ClientFacade.Account.Name,
            };

            List<object> data = new List<object>();
            data.Add(reportMasterInfo);
            foreach (var item in dataSource)
            {
                data.Add(item);
            }

            Report result = new Report();
            result.RegisterData(data, "报表数据");

            string realReportFileName = reportFileName;
            if (printSettings != null)
            {
                if (!string.IsNullOrWhiteSpace(printSettings.ReportFileName))
                {
                    realReportFileName = printSettings.ReportFileName;
                }
                if (!string.IsNullOrWhiteSpace(printSettings.PrintDevice))
                {
                    result.PrintSettings.Printer = printSettings.PrintDevice;
                }
            }

            if (!File.Exists(reportFileName))
            {
                string directory = new FileInfo(reportFileName).DirectoryName;
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                result.Save(reportFileName);
            }
            result.Load(reportFileName);

            return result;
        }

        /// <summary>
        /// 获取指定科室、指定计算机的打印设置信息
        /// </summary>
        /// <param name="departmentId">科室代码</param>
        /// <param name="netAddress">计算网卡地址</param>
        /// <param name="reportFileName">报表模板文件完整限制名</param>
        /// <returns>返回该科室、该计算机的打印设置信息</returns>
        private PrintSettingsInfo GetPrintSettings(string departmentId, string netAddress, string reportFileName)
        {
            //IEntityContext entityContext = ServiceLocator.Current.GetInstance<IDataFactory>().CreateEntityContext(SystemType.H0);

            //PrintSettingsInfo result = null;

            //var reportPrints = entityContext.QueryObject<SYS_REPORTPRINT>(p => p.KSDM.Trim() == departmentId || p.WKDZ.Trim() == netAddress)
            //    .ToList();

            //if (reportPrints.Count > 0)
            //{
            //    SYS_REPORTPRINT personalReport = reportPrints.FirstOrDefault(p => p.WKDZ.Trim() == netAddress && reportFileName.IndexOf(p.REPORT_FILE.Trim()) >= 0);
            //    SYS_REPORTPRINT departmentReport = reportPrints.FirstOrDefault(p => p.KSDM.Trim() == departmentId && reportFileName.IndexOf(p.REPORT_FILE.Trim()) >= 0);

            //    if (personalReport != null || departmentReport != null)
            //    {
            //        result = new PrintSettingsInfo();
            //    }

            //    //计算机设置
            //    if (personalReport != null)
            //    {
            //        result.IsPrint = personalReport.ISDY ?? false;
            //        if (!string.IsNullOrWhiteSpace(personalReport.PRINT_XH))
            //        {
            //            result.PrintDevice = entityContext.QueryObject<SYS_PRINT>(p => p.XH == personalReport.PRINT_XH)
            //                .Select(p => p.PRINT_INFO).FirstOrDefault();
            //        }

            //        result.ReportFileName = reportFileName;
            //        if (!string.IsNullOrWhiteSpace(personalReport.PRINT_FILE))
            //        {
            //            FileInfo file = new FileInfo(result.ReportFileName);
            //            result.ReportFileName = result.ReportFileName.Replace(file.Name, personalReport.PRINT_FILE.Trim());
            //        }
            //    }

            //    //科室设置
            //    if (departmentReport != null)
            //    {
            //        result.IsPrint = departmentReport.ISDY ?? false;
            //        result.ReportFileName = reportFileName;
            //        if (!string.IsNullOrWhiteSpace(departmentReport.PRINT_FILE))
            //        {
            //            FileInfo file = new FileInfo(result.ReportFileName);
            //            result.ReportFileName = result.ReportFileName.Replace(file.Name, departmentReport.PRINT_FILE.Trim());
            //        }

            //    }
            //}

            return new PrintSettingsInfo();
        }
        /// <summary>
        /// 当打印报表中不包含任何页面的话，默认创建一个
        /// </summary>
        /// <returns></returns>
        private ReportPage CreateDefaultReportPage()
        {
            ReportPage page = new ReportPage();
            page.Name = "Page1";
            page.Bands.Add(new ReportTitleBand
            {
                Name = "ReportTitle1",
                Width = 718.2f,
                Height = 37.8f,
            });
            page.Bands.Add(new PageHeaderBand
            {
                Name = "PageHeader1",
                Top = 41.8f,
                Width = 718.2f,
                Height = 28.35f,
            });
            page.Bands.Add(new DataBand
            {
                Name = "Data1",
                Top = 74.15f,
                Width = 718.2f,
                Height = 75.6f,
            });
            page.Bands.Add(new PageFooterBand
            {
                Name = "PageFooter1",
                Top = 153.75f,
                Width = 718.2f,
                Height = 151.2f,
            });

            return page;
        }
    }
}
