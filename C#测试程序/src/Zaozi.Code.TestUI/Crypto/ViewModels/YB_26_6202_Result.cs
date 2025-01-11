using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.ThirdHis.Application.WebHospital.YBMobilePayment.DTO;
public class YB_26_6202_Result
{
    public int ID { get; set; }
    public int YB_26_6202_ID { get; set; }
    public string payAuthNo { get; set; }
    public string payOrdId { get; set; }
    public string payToken { get; set; }
    public string ordStas { get; set; }
    public decimal feeSumamt { get; set; }
    public decimal ownPayAmt { get; set; }
    public decimal psnAcctPay { get; set; }
    public decimal fundPay { get; set; }
    public decimal deposit { get; set; }
    public string extData { get; set; }
    public decimal acctMulaidPay { get; set; }
    public decimal hospPartAmt { get; set; }
    public decimal othFeeAmt { get; set; }
    public decimal selfAcctPay { get; set; }
    public int accessid { get; set; }
    public int datasource { get; set; }
    public DateTime createdate { get; set; }
}
