using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebPdfView.Controllers;
[Route("[controller]")]
[ApiController]
public class PdfViewerController : ControllerBase
{
    private readonly ILogger<PdfViewerController> _logger;
    public PdfViewerController(ILogger<PdfViewerController> logger)
    {
        _logger = logger;
    }
    [HttpGet("{PdfName}")]
    public IActionResult DownloadPdf(string PdfName)
    {
        _logger.LogDebug($"进入控制器，入参为：{PdfName}");
        
        PdfHelper pdf = new PdfHelper(_logger);
        var fileByte = pdf.GetPdf(PdfName);
        return File(fileByte, "application/pdf");
    } 
}
