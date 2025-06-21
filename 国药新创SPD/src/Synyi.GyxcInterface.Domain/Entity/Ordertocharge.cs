namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 医嘱关联收费表
/// </summary>
[Table("ordertocharge")]
//[Keyless]
[PrimaryKey(nameof(Id))]
public sealed class Ordertocharge
{
    /// <summary>
    /// 获取或者设置标识
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id", Order = 99)]
    public long Id { get; set; }
    /// <summary>
    /// 获取或者设置科室代码
    /// </summary>
    [MaxLength(20)]
    [Column("deptid", Order = 100)]
    public string Deptid { get; set; }
    /// <summary>
    /// 获取或者设置医嘱代码
    /// </summary>
    [MaxLength(200)]
    [Column("ordercode", Order = 101)]
    public string Ordercode { get; set; }
    /// <summary>
    /// 获取或者设置费用名称
    /// </summary>
    [MaxLength(200)]
    [Column("ordername", Order = 102)]
    public string Ordername { get; set; }
    /// <summary>
    /// 获取或者设置费用大类
    /// </summary>
    [MaxLength(3)]
    [Column("orderflag", Order = 103)]
    public string Orderflag { get; set; }
    /// <summary>
    /// 获取或者设置费用代码
    /// </summary>
    [MaxLength(18)]
    [Column("drcode", Order = 104)]
    public string Drcode { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Column("abc", Order = 105)]
    public int? Abc { get; set; }
    /// <summary>
    /// 获取或者设置数量
    /// </summary>
    [Precision(16, 4)]
    [Column("dosageday", Order = 106)]
    public decimal? Dosageday { get; set; }
    /// <summary>
    /// 获取或者设置剂量
    /// </summary>
    [MaxLength(15)]
    [Column("dosage", Order = 107)]
    public string Dosage { get; set; }
    /// <summary>
    /// 获取或者设置用法
    /// </summary>
    [MaxLength(3)]
    [Column("admission", Order = 108)]
    public string Admission { get; set; }
    /// <summary>
    /// 获取或者设置频度
    /// </summary>
    [MaxLength(8)]
    [Column("frequency", Order = 109)]
    public string Frequency { get; set; }
    /// <summary>
    /// 获取或者设置最小单位
    /// </summary>
    [MaxLength(8)]
    [Column("drunit", Order = 110)]
    public string Drunit { get; set; }
    /// <summary>
    /// 获取或者设置经办
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 111)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置有效标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 112)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置包装单位
    /// </summary>
    [MaxLength(10)]
    [Column("packunit", Order = 113)]
    public string Packunit { get; set; }
    /// <summary>
    /// 获取或者设置包装规格
    /// </summary>
    [Precision(10, 0)]
    [Column("pack", Order = 114)]
    public decimal? Pack { get; set; }
    /// <summary>
    /// 获取或者设置住院包装单位
    /// </summary>
    [MaxLength(10)]
    [Column("inpackunit", Order = 115)]
    public string Inpackunit { get; set; }
    /// <summary>
    /// 获取或者设置住院包装
    /// </summary>
    [Precision(10, 0)]
    [Column("inpack", Order = 116)]
    public decimal? Inpack { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("foro", Order = 117)]
    public string Foro { get; set; }
    /// <summary>
    /// 获取或者设置取药途径
    /// </summary>
    [MaxLength(1)]
    [Column("firstchare", Order = 118)]
    public string Firstchare { get; set; }
    /// <summary>
    /// 获取或者设置公费标志（3：省医保不收，其他医保和自费收）
    /// </summary>
    [MaxLength(1)]
    [Column("dcflag", Order = 119)]
    public string Dcflag { get; set; }
    /// <summary>
    /// 获取或者设置唯一标志
    /// </summary>
    [MaxLength(1)]
    [Column("onlyflag", Order = 120)]
    public string Onlyflag { get; set; }
    /// <summary>
    /// 获取或者设置医保编码
    /// </summary>
    [MaxLength(18)]
    [Column("insucode", Order = 121)]
    public string Insucode { get; set; }
    /// <summary>
    /// 获取或者设置医保限定说明
    /// </summary>
    [MaxLength(200)]
    [Column("ybxdmark", Order = 122)]
    public string Ybxdmark { get; set; }
    /// <summary>
    /// 获取或者设置医保限定标志
    /// </summary>
    [MaxLength(1)]
    [Column("ybxdflag", Order = 123)]
    public string Ybxdflag { get; set; }
    /// <summary>
    /// 获取或者设置费用分类
    /// </summary>
    [MaxLength(2)]
    [Column("ftype", Order = 124)]
    public string Ftype { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("dosageunit", Order = 125)]
    public string Dosageunit { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("sunit", Order = 126)]
    public string Sunit { get; set; }

}