namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 诊疗费用目录
/// </summary>
[Table("fitem")]
[PrimaryKey(nameof(Fcode))]
public sealed class Fitem : EqualObject
{
    /// <summary>
    /// 获取或者设置代码
    /// </summary>
    [MaxLength(18)]
    [Required]
    [Column("fcode", Order = 100)]
    public string Fcode { get; set; }
    /// <summary>
    /// 获取或者设置项目
    /// </summary>
    [MaxLength(200)]
    [Column("item", Order = 101)]
    public string Item { get; set; }
    /// <summary>
    /// 获取或者设置单位
    /// </summary>
    [MaxLength(50)]
    [Column("unit", Order = 102)]
    public string Unit { get; set; }
    /// <summary>
    /// 获取或者设置费用类别
    /// </summary>
    [MaxLength(20)]
    [Column("ftype", Order = 103)]
    public string Ftype { get; set; }
    /// <summary>
    /// 获取或者设置金额
    /// </summary>
    [Precision(19, 4)]
    [Column("fprice", Order = 104)]
    public decimal? Fprice { get; set; }
    /// <summary>
    /// 获取或者设置自费金额
    /// </summary>
    [Precision(19, 4)]
    [Column("fpricez", Order = 105)]
    public decimal? Fpricez { get; set; }
    /// <summary>
    /// 获取或者设置拼音
    /// </summary>
    [MaxLength(50)]
    [Column("py", Order = 106)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置费用大类
    /// </summary>
    [MaxLength(2)]
    [Column("fkind", Order = 107)]
    public string Fkind { get; set; }
    /// <summary>
    /// 获取或者设置公费标志
    /// </summary>
    [MaxLength(1)]
    [Column("gfflag", Order = 108)]
    public string Gfflag { get; set; }
    /// <summary>
    /// 获取或者设置自费标志
    /// </summary>
    [Precision(16, 4)]
    [Column("selfpaid", Order = 109)]
    public decimal? Selfpaid { get; set; }
    /// <summary>
    /// 获取或者设置医保标志
    /// </summary>
    [MaxLength(1)]
    [Column("insuflag", Order = 110)]
    public string Insuflag { get; set; }
    /// <summary>
    /// 获取或者设置医保支付
    /// </summary>
    [Precision(16, 4)]
    [Column("insupaid", Order = 111)]
    public decimal? Insupaid { get; set; }
    /// <summary>
    /// 获取或者设置材料
    /// </summary>
    [MaxLength(1)]
    [Column("material", Order = 112)]
    public string Material { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 113)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(300)]
    [Column("remark", Order = 114)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置数量
    /// </summary>
    [Precision(16, 4)]
    [Column("many", Order = 115)]
    public decimal? Many { get; set; }
    /// <summary>
    /// 获取或者设置执行次数
    /// </summary>
    [Precision(16, 4)]
    [Column("fdo", Order = 116)]
    public decimal? Fdo { get; set; }
    /// <summary>
    /// 获取或者设置特殊码
    /// </summary>
    [MaxLength(2)]
    [Column("special", Order = 117)]
    public string Special { get; set; }
    /// <summary>
    /// 获取或者设置经办
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 118)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置更新时间
    /// </summary>
    [Column("updatetime", Order = 119)]
    public DateTime? Updatetime { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("fdoz", Order = 120)]
    public decimal? Fdoz { get; set; }
    /// <summary>
    /// 获取或者设置默认科室
    /// </summary>
    [MaxLength(20)]
    [Column("defultdept", Order = 121)]
    public string Defultdept { get; set; }
    /// <summary>
    /// 获取或者设置热键
    /// </summary>
    [MaxLength(15)]
    [Column("hotkey", Order = 122)]
    public string Hotkey { get; set; }
    /// <summary>
    /// 获取或者设置医保码
    /// </summary>
    [MaxLength(20)]
    [Column("finsucode", Order = 123)]
    public string Finsucode { get; set; }
    /// <summary>
    /// 获取或者设置别名
    /// </summary>
    [MaxLength(40)]
    [Column("bm", Order = 124)]
    public string Bm { get; set; }
    /// <summary>
    /// 获取或者设置自由收费
    /// </summary>
    [MaxLength(1)]
    [Column("feein", Order = 125)]
    public string Feein { get; set; }
    /// <summary>
    /// 获取或者设置组代码
    /// </summary>
    [MaxLength(20)]
    [Column("gcode", Order = 126)]
    public string Gcode { get; set; }
    /// <summary>
    /// 获取或者设置收费项目
    /// </summary>
    [MaxLength(1)]
    [Column("fitem", Order = 127)]
    public string FItem { get; set; }
    /// <summary>
    /// 获取或者设置核算类别（住院）
    /// </summary>
    [MaxLength(18)]
    [Column("accountcodezy", Order = 128)]
    public string Accountcodezy { get; set; }
    /// <summary>
    /// 获取或者设置核算类别
    /// </summary>
    [MaxLength(18)]
    [Column("accountcode", Order = 129)]
    public string Accountcode { get; set; }
    /// <summary>
    /// 获取或者设置强制指定部门有效
    /// </summary>
    [MaxLength(1)]
    [Column("sd", Order = 130)]
    public string Sd { get; set; }
    /// <summary>
    /// 获取或者设置医保等级
    /// </summary>
    [MaxLength(1)]
    [Column("drtt", Order = 131)]
    public string Drtt { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("sslb", Order = 132)]
    public string Sslb { get; set; }
    /// <summary>
    /// 获取或者设置医保码1
    /// </summary>
    [MaxLength(100)]
    [Column("insucode1", Order = 133)]
    public string Insucode1 { get; set; }
    /// <summary>
    /// 获取或者设置医保码2
    /// </summary>
    [MaxLength(20)]
    [Column("insucode2", Order = 134)]
    public string Insucode2 { get; set; }
    /// <summary>
    /// 获取或者设置匹配码
    /// </summary>
    [MaxLength(12)]
    [Column("match", Order = 135)]
    public string Match { get; set; }
    /// <summary>
    /// 获取或者设置新备注
    /// </summary>
    [MaxLength(16)]
    [Column("newmark", Order = 136)]
    public string Newmark { get; set; }
    /// <summary>
    /// 获取或者设置收费控制
    /// </summary>
    [MaxLength(1)]
    [Column("medicontroltype", Order = 137)]
    public string Medicontroltype { get; set; }
    /// <summary>
    /// 获取或者设置控制数量
    /// </summary>
    [Precision(10, 2)]
    [Column("medicontrolmax", Order = 138)]
    public decimal? Medicontrolmax { get; set; }
    /// <summary>
    /// 获取或者设置医保限定标志
    /// </summary>
    [MaxLength(1)]
    [Column("YBXDflag", Order = 139)]
    public string YBXDflag { get; set; }
    /// <summary>
    /// 获取或者设置医保限定备注
    /// </summary>
    [MaxLength(255)]
    [Column("YBXDmark", Order = 140)]
    public string YBXDmark { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("YBXCflag", Order = 141)]
    public string YBXCflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(10, 2)]
    [Column("YBXCdays", Order = 142)]
    public decimal? YBXCdays { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(10, 2)]
    [Column("YBXCmany", Order = 143)]
    public decimal? YBXCmany { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("tempgfflag", Order = 144)]
    public string Tempgfflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("tempfinsucode", Order = 145)]
    public string Tempfinsucode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(10, 2)]
    [Column("temppselfpaid", Order = 146)]
    public decimal? Temppselfpaid { get; set; }
    /// <summary>
    /// 获取或者设置医保码3
    /// </summary>
    [MaxLength(50)]
    [Column("insucode3", Order = 147)]
    public string Insucode3 { get; set; }
    /// <summary>
    /// 获取或者设置机构代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 148)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置同步日期
    /// </summary>
    [Column("hostrandt", Order = 149)]
    public DateTime? Hostrandt { get; set; }
    /// <summary>
    /// 获取或者设置同步标志
    /// </summary>
    [MaxLength(1)]
    [Column("hostranflag", Order = 150)]
    public string Hostranflag { get; set; }
    /// <summary>
    /// 获取或者设置审批标志
    /// </summary>
    [MaxLength(50)]
    [Column("spbz", Order = 151)]
    public string Spbz { get; set; }
    /// <summary>
    /// 获取或者设置是否匹配成功标志
    /// </summary>
    [MaxLength(12)]
    [Column("match1", Order = 152)]
    public string Match1 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("batype", Order = 153)]
    public string Batype { get; set; }
    /// <summary>
    /// 获取或者设置医保码84
    /// </summary>
    [MaxLength(30)]
    [Column("insucode84", Order = 154)]
    public string Insucode84 { get; set; }
    /// <summary>
    /// 获取或者设置医保码85
    /// </summary>
    [MaxLength(30)]
    [Column("insucode85", Order = 155)]
    public string Insucode85 { get; set; }
    /// <summary>
    /// 获取或者设置医保码86
    /// </summary>
    [MaxLength(30)]
    [Column("insucode86", Order = 156)]
    public string Insucode86 { get; set; }
    /// <summary>
    /// 获取或者设置医保码87
    /// </summary>
    [MaxLength(30)]
    [Column("insucode87", Order = 157)]
    public string Insucode87 { get; set; }
    /// <summary>
    /// 获取或者设置允许更新零售价
    /// </summary>
    [MaxLength(1)]
    [Column("allowupdatenpl", Order = 158)]
    public string Allowupdatenpl { get; set; }
    /// <summary>
    /// 获取或者设置子零售价
    /// </summary>
    [Precision(18, 4)]
    [Column("childnpl", Order = 159)]
    public decimal? Childnpl { get; set; }
    /// <summary>
    /// 获取或者设置进价
    /// </summary>
    [Precision(18, 4)]
    [Column("punits", Order = 160)]
    public decimal? Punits { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("wb", Order = 161)]
    public string Wb { get; set; }
    /// <summary>
    /// 获取或者设置医保控制内容
    /// </summary>
    [MaxLength(400)]
    [Column("medicontroltext", Order = 162)]
    public string Medicontroltext { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(30)]
    [Column("freecode", Order = 163)]
    public string Freecode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("treatmenttype", Order = 164)]
    public string Treatmenttype { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(500)]
    [Column("itemconnotation", Order = 165)]
    public string Itemconnotation { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Fcode;
    }
}