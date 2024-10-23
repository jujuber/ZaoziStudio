using SharpCifs.Smb;
using System;
using System.Net;
using System.Text;

namespace WebPdfView;

public class PdfHelper
{
    private readonly ILogger<object> _logger;
    public PdfHelper(ILogger<object> logger)
    {
        _logger = logger;
    }

    public byte[] GetPdf(string pdfname)
    {
        //\\192.168.26.125\reportfile\reportpdf\20241019=sfdsf.pdf\
        string pdfFilePath = $@"\\192.168.101.8\test\test1.pdf"; // 替换为你的PDF文件路径 
        // http://localhost:8086/PdfViewer/20241019=CT00083421_398777
        var pdfVar = GetPdfPath(pdfname);

        var file = new SmbFile($"smb://pacs:pacs@192.168.26.125/reportfile/reportpdf/{pdfVar.date}/{pdfVar.pdfname}.pdf");
        //获取可读的流。
        var readStream = file.GetInputStream();
        //创建读取缓存
        var memStream = new MemoryStream();
        //获取 bytes.
        ((Stream)readStream).CopyTo(memStream);
        //Dispose可读的流。
        readStream.Dispose();
        Console.WriteLine(Encoding.UTF8.GetString(memStream.ToArray()));
        _logger.LogDebug($"拼接pdfurl:{pdfFilePath}"); 

        //文件夹认证 
        byte[] result = memStream.ToArray();
        memStream.Close(); 
        return result; 
    }

    private (string date,string pdfname) GetPdfPath(string pdfname)
    {
        string[] pdfnameArr = pdfname.Split("=");
        return (pdfnameArr[0], pdfnameArr[1]);
    }

    //public byte[] GetPdf(string pdfname)
    //{
    //    //\\192.168.26.125\reportfile\reportpdf\20241019\
    //    string pdfFilePath = $@"\\192.168.26.125\reportfile\reportpdf\20241019\{pdfname}.pdf"; // 替换为你的PDF文件路径    
    //    _logger.LogDebug($"拼接pdfurl:{pdfFilePath}");
    //    try
    //    {
    //        // 检查文件是否存在  
    //        if (!File.Exists(pdfFilePath))
    //        { 
    //            _logger.LogDebug($"不存在:{pdfFilePath}");
    //            throw new FileNotFoundException("The specified file was not found.", pdfFilePath);
    //        }
    //        _logger.LogDebug($"存在:{pdfFilePath}");

    //        // 使用FileStream读取文件内容到MemoryStream  
    //        using (FileStream fileStream = new FileStream(pdfFilePath, FileMode.Open, FileAccess.Read))
    //        {
    //            MemoryStream memoryStream = new MemoryStream();
    //            fileStream.CopyTo(memoryStream);
    //            memoryStream.Position = 0; // 重置位置到流的开始，以便读取   
    //            byte[] result = memoryStream.ToArray();
    //            memoryStream.Close();
    //            _logger.LogDebug($"返回成功");
    //            return result;
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        // 处理异常，例如记录日志或返回错误信息
    //        _logger.LogDebug($"返回失败"); 
    //        return null;
    //    }

    //}
}