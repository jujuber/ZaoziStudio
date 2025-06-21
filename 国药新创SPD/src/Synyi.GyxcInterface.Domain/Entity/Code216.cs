namespace Synyi.GyxcInterface.Domain.Entity;

/// <summary>
/// 公司(供货商)
/// </summary>
[Table("code216")]
[PrimaryKey(nameof(Rtn))]
public sealed class Code216 : EqualObject
{
    /// <summary>
    /// 获取或者设置主键
    /// </summary>
    [Required]
    [Column("rtn", Order = 100)]
    public int Rtn { get; set; }
    /// <summary>
    /// 获取或者设置公司
    /// </summary>
    [MaxLength(60)]
    [Column("company", Order = 101)]
    public string Company { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("flag", Order = 102)]
    public string Flag { get; set; }
    /// <summary>
    /// 获取或者设置gmp标志
    /// </summary>
    [MaxLength(1)]
    [Column("gmp", Order = 103)]
    public string Gmp { get; set; }
    /// <summary>
    /// 获取或者设置拼音
    /// </summary>
    [MaxLength(30)]
    [Column("py", Order = 104)]
    public string Py { get; set; }
    /// <summary>
    /// 获取或者设置适用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 105)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置联系人
    /// </summary>
    [MaxLength(30)]
    [Column("lxr", Order = 106)]
    public string Lxr { get; set; }
    /// <summary>
    /// 获取或者设置联系电话
    /// </summary>
    [MaxLength(30)]
    [Column("lxdh", Order = 107)]
    public string Lxdh { get; set; }
    /// <summary>
    /// 获取或者设置开户行
    /// </summary>
    [MaxLength(60)]
    [Column("khh", Order = 108)]
    public string Khh { get; set; }
    /// <summary>
    /// 获取或者设置账户号
    /// </summary>
    [MaxLength(60)]
    [Column("zh", Order = 109)]
    public string Zh { get; set; }
    /// <summary>
    /// 获取或者设置地址
    /// </summary>
    [MaxLength(100)]
    [Column("dz", Order = 110)]
    public string Dz { get; set; }
    /// <summary>
    /// 获取或者设置备注
    /// </summary>
    [MaxLength(100)]
    [Column("bz", Order = 111)]
    public string Bz { get; set; }
    /// <summary>
    /// 获取或者设置支付账号
    /// </summary>
    [MaxLength(5)]
    [Column("payno", Order = 112)]
    public string Payno { get; set; }
    /// <summary>
    /// 获取或者设置备注1
    /// </summary>
    [MaxLength(200)]
    [Column("remark", Order = 113)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 114)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置类别 供应商类别 1-药品 2-物资 4-资产 8-血制品 16-其他
    /// </summary>
    [Column("lb", Order = 115)]
    public int? Lb { get; set; }
    /// <summary>
    /// 获取或者设置第三方代码
    /// </summary>
    [MaxLength(32)]
    [Column("thirdid", Order = 116)]
    public string ThirdId { get; set; }
    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Rtn;
    }
}