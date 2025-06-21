namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 固定物资及材料代码
/// </summary>
[Table("assetcode")]
[PrimaryKey(nameof(Acode))]
[Index(nameof(ThirdId))]
public sealed class Assetcode : EqualObject
{
    /// <summary>
    /// 获取或者设置第三方代码
    /// </summary>
    [MaxLength(32)]
    [Column("thirdid", Order = 99)]
    public string ThirdId { get; set; }
    /// <summary>
    /// 获取或者设置规格型号
    /// </summary>
    [MaxLength(100)]
    [Column("ggxh", Order = 100)]
    public string Ggxh { get; set; }
    /// <summary>
    /// 获取或者设置代码
    /// </summary>
    [MaxLength(100)]
    [Required]
    [Column("acode", Order = 101)]
    public string Acode { get; set; }
    /// <summary>
    /// 获取或者设置名称
    /// </summary>
    [MaxLength(100)]
    [Column("ccname", Order = 102)]
    public string Ccname { get; set; }
    /// <summary>
    /// 获取或者设置规格
    /// </summary>
    [MaxLength(500)]
    [Column("ccgg", Order = 103)]
    public string Ccgg { get; set; }
    /// <summary>
    /// 获取或者设置单位
    /// </summary>
    [MaxLength(8)]
    [Column("unit", Order = 104)]
    public string Unit { get; set; }
    /// <summary>
    /// 获取或者设置拼音
    /// </summary>
    [MaxLength(300)]
    [Column("py", Order = 105)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置类型
    /// </summary>
    [MaxLength(3)]
    [Column("cctype", Order = 106)]
    public string Cctype { get; set; }
    /// <summary>
    /// 获取或者设置总分类
    /// </summary>
    [MaxLength(1)]
    [Column("tt", Order = 107)]
    public string Tt { get; set; }
    /// <summary>
    /// 获取或者设置入库价
    /// </summary>
    [Precision(19, 4)]
    [Column("inprice", Order = 108)]
    public decimal? Inprice { get; set; }
    /// <summary>
    /// 获取或者设置售价
    /// </summary>
    [Precision(19, 4)]
    [Column("outprice", Order = 109)]
    public decimal? Outprice { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 110)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置可否收费
    /// </summary>
    [MaxLength(1)]
    [Column("charge", Order = 111)]
    public string Charge { get; set; }
    /// <summary>
    /// 获取或者设置自付%
    /// </summary>
    [Precision(19, 4)]
    [Column("zf", Order = 112)]
    public decimal? Zf { get; set; }
    /// <summary>
    /// 获取或者设置可否公费
    /// </summary>
    [MaxLength(1)]
    [Column("gf", Order = 113)]
    public string Gf { get; set; }
    /// <summary>
    /// 获取或者设置包装单位
    /// </summary>
    [MaxLength(4)]
    [Column("packunit", Order = 114)]
    public string Packunit { get; set; }
    /// <summary>
    /// 获取或者设置包装规格
    /// </summary>
    [Column("pack", Order = 115)]
    public int? Pack { get; set; }
    /// <summary>
    /// 获取或者设置开放
    /// </summary>
    [MaxLength(1)]
    [Column("opendoor", Order = 116)]
    public string Opendoor { get; set; }
    /// <summary>
    /// 获取或者设置修改人
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 117)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置更新时间
    /// </summary>
    [Column("updatetime", Order = 118)]
    public DateTime? Updatetime { get; set; }
    /// <summary>
    /// 获取或者设置费用
    /// </summary>
    [Precision(16, 4)]
    [Column("mf", Order = 119)]
    public decimal? Mf { get; set; }
    /// <summary>
    /// 获取或者设置自费
    /// </summary>
    [Precision(16, 4)]
    [Column("mfz", Order = 120)]
    public decimal? Mfz { get; set; }
    /// <summary>
    /// 获取或者设置数量
    /// </summary>
    [Precision(16, 4)]
    [Column("many", Order = 121)]
    public decimal? Many { get; set; }
    /// <summary>
    /// 获取或者设置热键
    /// </summary>
    [MaxLength(10)]
    [Column("hotkey", Order = 122)]
    public string Hotkey { get; set; }
    /// <summary>
    /// 获取或者设置来源
    /// </summary>
    [MaxLength(1)]
    [Column("stay", Order = 123)]
    public string Stay { get; set; }
    /// <summary>
    /// 获取或者设置别名
    /// </summary>
    [MaxLength(30)]
    [Column("bm", Order = 124)]
    public string Bm { get; set; }
    /// <summary>
    /// 获取或者设置归类码
    /// </summary>
    [MaxLength(18)]
    [Column("gmcode", Order = 125)]
    public string Gmcode { get; set; }
    /// <summary>
    /// 获取或者设置医保码
    /// </summary>
    [MaxLength(18)]
    [Column("ainsu", Order = 126)]
    public string Ainsu { get; set; }
    /// <summary>
    /// 获取或者设置自由输入标志
    /// </summary>
    [MaxLength(1)]
    [Column("feein", Order = 127)]
    public string Feein { get; set; }
    /// <summary>
    /// 获取或者设置医保编码
    /// </summary>
    [MaxLength(18)]
    [Column("ainsucode", Order = 128)]
    public string Ainsucode { get; set; }
    /// <summary>
    /// 获取或者设置医保等级
    /// </summary>
    [MaxLength(1)]
    [Column("drtt", Order = 129)]
    public string Drtt { get; set; }
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Column("rdn", Order = 130)]
    public int? Rdn { get; set; }
    /// <summary>
    /// 获取或者设置医保码1
    /// </summary>
    [MaxLength(100)]
    [Column("insucode1", Order = 131)]
    public string Insucode1 { get; set; }
    /// <summary>
    /// 获取或者设置医保码2
    /// </summary>
    [MaxLength(100)]
    [Column("insucode2", Order = 132)]
    public string Insucode2 { get; set; }
    /// <summary>
    /// 获取或者设置匹配码
    /// </summary>
    [MaxLength(12)]
    [Column("match", Order = 133)]
    public string Match { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(1)]
    [Column("mark", Order = 134)]
    public string Mark { get; set; }
    /// <summary>
    /// 获取或者设置医保限定标志
    /// </summary>
    [MaxLength(1)]
    [Column("ybxdflag", Order = 135)]
    public string Ybxdflag { get; set; }
    /// <summary>
    /// 获取或者设置医保等级（临时）
    /// </summary>
    [MaxLength(1)]
    [Column("tempdrtt", Order = 136)]
    public string Tempdrtt { get; set; }
    /// <summary>
    /// 获取或者设置医保码（临时）
    /// </summary>
    [MaxLength(20)]
    [Column("tempinsucode", Order = 137)]
    public string Tempinsucode { get; set; }
    /// <summary>
    /// 获取或者设置自付比例（临时）
    /// </summary>
    [Precision(10, 2)]
    [Column("tempselfpaid", Order = 138)]
    public decimal? Tempselfpaid { get; set; }
    /// <summary>
    /// 获取或者设置中心名称
    /// </summary>
    [MaxLength(18)]
    [Column("centername", Order = 139)]
    public string Centername { get; set; }
    /// <summary>
    /// 获取或者设置自付比例
    /// </summary>
    [Precision(19, 4)]
    [Column("zfbl", Order = 140)]
    public decimal? Zfbl { get; set; }
    /// <summary>
    /// 获取或者设置核算类别代码
    /// </summary>
    [MaxLength(10)]
    [Column("acountcode", Order = 141)]
    public string Acountcode { get; set; }
    /// <summary>
    /// 获取或者设置医保码3
    /// </summary>
    [MaxLength(50)]
    [Column("insucode3", Order = 142)]
    public string Insucode3 { get; set; }
    /// <summary>
    /// 获取或者设置匹配码1
    /// </summary>
    [MaxLength(12)]
    [Column("match1", Order = 143)]
    public string Match1 { get; set; }
    /// <summary>
    /// 获取或者设置分类
    /// </summary>
    [MaxLength(10)]
    [Column("batype", Order = 144)]
    public string Batype { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("mzty", Order = 145)]
    public string Mzty { get; set; }
    /// <summary>
    /// 获取或者设置医保码84
    /// </summary>
    [MaxLength(100)]
    [Column("insucode84", Order = 146)]
    public string Insucode84 { get; set; }
    /// <summary>
    /// 获取或者设置医保码85
    /// </summary>
    [MaxLength(100)]
    [Column("insucode85", Order = 147)]
    public string Insucode85 { get; set; }
    /// <summary>
    /// 获取或者设置医保码86
    /// </summary>
    [MaxLength(100)]
    [Column("insucode86", Order = 148)]
    public string Insucode86 { get; set; }
    /// <summary>
    /// 获取或者设置医保码87
    /// </summary>
    [MaxLength(100)]
    [Column("insucode87", Order = 149)]
    public string Insucode87 { get; set; }
    /// <summary>
    /// 获取或者设置匹配码84
    /// </summary>
    [MaxLength(1)]
    [Column("match84", Order = 150)]
    public string Match84 { get; set; }
    /// <summary>
    /// 获取或者设置匹配码85
    /// </summary>
    [MaxLength(1)]
    [Column("match85", Order = 151)]
    public string Match85 { get; set; }
    /// <summary>
    /// 获取或者设置匹配码86
    /// </summary>
    [MaxLength(1)]
    [Column("match86", Order = 152)]
    public string Match86 { get; set; }
    /// <summary>
    /// 获取或者设置匹配码87
    /// </summary>
    [MaxLength(1)]
    [Column("match87", Order = 153)]
    public string Match87 { get; set; }
    /// <summary>
    /// 获取或者设置医保码89
    /// </summary>
    [MaxLength(30)]
    [Column("insucode89", Order = 154)]
    public string Insucode89 { get; set; }
    /// <summary>
    /// 获取或者设置匹配码89
    /// </summary>
    [MaxLength(30)]
    [Column("match89", Order = 155)]
    public string Match89 { get; set; }
    /// <summary>
    /// 获取或者设置允许更新零售价
    /// </summary>
    [MaxLength(1)]
    [Column("allowupdatenpl", Order = 156)]
    public string Allowupdatenpl { get; set; }
    /// <summary>
    /// 获取或者设置子价格
    /// </summary>
    [Precision(19, 4)]
    [Column("childprice", Order = 157)]
    public decimal? Childprice { get; set; }
    /// <summary>
    /// 获取或者设置产地码
    /// </summary>
    [MaxLength(30)]
    [Column("drmanfcode", Order = 158)]
    public string Drmanfcode { get; set; }
    /// <summary>
    /// 获取或者设置注册证号
    /// </summary>
    [MaxLength(100)]
    [Column("CertificateNo", Order = 159)]
    public string CertificateNo { get; set; }
    /// <summary>
    /// 获取或者设置高值耗材
    /// </summary>
    [MaxLength(10)]
    [Column("HighValue", Order = 160)]
    public string HighValue { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("wb", Order = 161)]
    public string Wb { get; set; }
    /// <summary>
    /// 获取或者设置控制类型
    /// </summary>
    [MaxLength(10)]
    [Column("medicontroltype", Order = 162)]
    public string Medicontroltype { get; set; }
    /// <summary>
    /// 获取或者设置控制文本
    /// </summary>
    [MaxLength(255)]
    [Column("medicontroltext", Order = 163)]
    public string Medicontroltext { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 164)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("trans_vender_id", Order = 165)]
    public string TransVenderId { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("trans_vender", Order = 166)]
    public string TransVender { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(2)]
    [Column("istest", Order = 167)]
    public string Istest { get; set; }
    /// <summary>
    /// 获取或者设置物资类别  1-耗材 2-血制品
    /// </summary>
    [Column("wzlb", Order = 168)]
    public int? Wzlb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [String32]
    [Column("bzdwid", Order = 169)]
    public string BzdwId { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [String64]
    [Column("bzdw", Order = 170)]
    public string Bzdw { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(19, 4)]
    [Column("bzxs", Order = 171)]
    public decimal? Bzxs { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [String32]
    [Column("mzdwid", Order = 172)]
    public string MzdwId { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [String64]
    [Column("mzdw", Order = 173)]
    public string Mzdw { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(19, 4)]
    [Column("mzxs", Order = 174)]
    public decimal? Mzxs { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [String32]
    [Column("zydwid", Order = 172)]
    public string ZydwId { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [String64]
    [Column("zydw", Order = 173)]
    public string Zydw { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(19, 4)]
    [Column("zyxs", Order = 174)]
    public decimal? Zyxs { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Acode;
    }
}