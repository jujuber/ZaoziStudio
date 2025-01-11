namespace Synyi.ThirdHis.Application.WebHospital.YBMobilePayment.DTO;
/// <summary>
/// 表 342	输出 –支付下单（节点标识：data）
/// </summary>
public class Trade6202_Out
{
    /// <summary>
    /// 支付下单出参
    /// </summary>
    public Trade6202OutData data { get; set; }
}
/// <summary>
/// 支付下单出参
/// </summary>
public class Trade6202OutData
{
    /// <summary>
    /// 1.支付订单号
    /// </summary>
    public string payOrdId { get; set; }
    /// <summary>
    /// 2.订单状态 见订单状态字典
    /// </summary>
    public string ordStas { get; set; }
    /// <summary>
    /// 3.费用总额
    /// </summary>
    public decimal feeSumamt { get; set; }
    /// <summary>
    /// 4.现金支付 
    /// </summary>
    public decimal ownPayAmt { get; set; }
    /// <summary>
    /// 5.个人账户支出
    /// </summary>
    public decimal psnAcctPay { get; set; }
    /// <summary>
    /// 6.医保基金支付  
    /// </summary>
    public decimal fundPay { get; set; }
    /// <summary>
    /// 7.住院押金  根据下单传入计算，最大值不超过自费现金需要支付金额
    /// </summary>
    public decimal deposit { get; set; }
    /// <summary>
    /// 8.扩展数据yeshi
    /// </summary>
    public extData6202 extData { get; set; }

    public decimal acctMulaidPay { get; set; }
    public decimal hospPartAmt { get; set; }
    public decimal othFeeAmt { get; set; }
    public decimal selfAcctPay { get; set; }
}

public class extData6202
{
    public preSetl6202 preSetl { get; set; }
}
public class preSetl6202
{
    public decimal acct_mulaid_pay { get; set; }
    public decimal acct_pay { get; set; }
    public decimal act_pay_dedc { get; set; }
    public string age { get; set; }
    public decimal balc { get; set; }
    public string brdy { get; set; }
    public string certno { get; set; }
    public string clr_type { get; set; }
    public string cvlserv_flag { get; set; }
    public int cvlserv_pay { get; set; }
    public object exp_content { get; set; }
    public decimal fulamt_ownpay_amt { get; set; }
    public decimal fund_pay_sumamt { get; set; }
    public string gend { get; set; }
    public decimal hifdm_pay { get; set; }
    public decimal hifes_pay { get; set; }
    public decimal hifmi_pay { get; set; }
    public decimal hifob_pay { get; set; }
    public decimal hifp_pay { get; set; }
    public decimal hosp_part_amt { get; set; }
    public decimal inscp_scp_amt { get; set; }
    public string insutype { get; set; }
    public decimal maf_pay { get; set; }
    public string mdtrt_cert_type { get; set; }
    public string mdtrt_id { get; set; }
    public string med_type { get; set; }
    public decimal medfee_sumamt { get; set; }
    public string medins_setl_id { get; set; }
    public string naty { get; set; }
    public decimal oth_pay { get; set; }
    public decimal overlmt_selfpay { get; set; }
    public decimal pool_prop_selfpay { get; set; }
    public decimal preselfpay_amt { get; set; }
    public decimal psn_cash_pay { get; set; }
    public string psn_cert_type { get; set; }
    public string psn_name { get; set; }
    public string psn_no { get; set; }
    public decimal psn_part_amt { get; set; }
    public string psn_type { get; set; }
    public string setl_time { get; set; }
}