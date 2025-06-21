namespace Synyi.Hrp.Third.His.HisV1.Domain.Entity;

/// <summary>
/// 通用药品字典
/// </summary>
[Table("drugs")]
[PrimaryKey(nameof(Drcode))]
public sealed class Drugs : EqualObject
{
    /// <summary>
    /// 获取或者设置药品代码
    /// </summary>
    [MaxLength(18)]
    [Required]
    [Column("drcode", Order = 100)]
    public string Drcode { get; set; }
    /// <summary>
    /// 获取或者设置通用名
    /// </summary>
    [MaxLength(100)]
    [Column("drname", Order = 101)]
    public string Drname { get; set; }
    /// <summary>
    /// 获取或者设置物品名
    /// </summary>
    [MaxLength(100)]
    [Column("drname1", Order = 102)]
    public string Drname1 { get; set; }
    /// <summary>
    /// 获取或者设置别名
    /// </summary>
    [MaxLength(100)]
    [Column("drname2", Order = 103)]
    public string Drname2 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("drname3", Order = 104)]
    public string Drname3 { get; set; }
    /// <summary>
    /// 获取或者设置英文名
    /// </summary>
    [MaxLength(100)]
    [Column("drname4", Order = 105)]
    public string Drname4 { get; set; }
    /// <summary>
    /// 获取或者设置药品规格
    /// </summary>
    [MaxLength(500)]
    [Column("drmodel", Order = 106)]
    public string Drmodel { get; set; }
    /// <summary>
    /// 获取或者设置药品剂型
    /// </summary>
    [MaxLength(3)]
    [Column("drtype", Order = 107)]
    public string Drtype { get; set; }
    /// <summary>
    /// 获取或者设置最小包装单位
    /// </summary>
    [MaxLength(3)]
    [Column("drunit", Order = 108)]
    public string Drunit { get; set; }
    /// <summary>
    /// 获取或者设置用法
    /// </summary>
    [MaxLength(8)]
    [Column("dradmi", Order = 109)]
    public string Dradmi { get; set; }
    /// <summary>
    /// 获取或者设置功能
    /// </summary>
    [MaxLength(8)]
    [Column("drfunction", Order = 110)]
    public string Drfunction { get; set; }
    /// <summary>
    /// 获取或者设置药品分类
    /// </summary>
    [MaxLength(2)]
    [Column("drchina", Order = 111)]
    public string Drchina { get; set; }
    /// <summary>
    /// 获取或者设置拼音码（drname）
    /// </summary>
    [MaxLength(50)]
    [Column("drserch", Order = 112)]
    public string Drserch { get; set; }
    /// <summary>
    /// 获取或者设置拼音码（drname1）
    /// </summary>
    [MaxLength(50)]
    [Column("drserch1", Order = 113)]
    public string Drserch1 { get; set; }
    /// <summary>
    /// 获取或者设置拼音码（drname4）
    /// </summary>
    [MaxLength(50)]
    [Column("drserch2", Order = 114)]
    public string Drserch2 { get; set; }
    /// <summary>
    /// 获取或者设置特殊分类
    /// </summary>
    [MaxLength(1)]
    [Column("drkind", Order = 115)]
    public string Drkind { get; set; }
    /// <summary>
    /// 获取或者设置自制药品
    /// </summary>
    [MaxLength(1)]
    [Column("drself", Order = 116)]
    public string Drself { get; set; }
    /// <summary>
    /// 获取或者设置公费标记
    /// </summary>
    [MaxLength(1)]
    [Column("drgf", Order = 117)]
    public string Drgf { get; set; }
    /// <summary>
    /// 获取或者设置社保标志
    /// </summary>
    [MaxLength(1)]
    [Column("drinsu", Order = 118)]
    public string Drinsu { get; set; }
    /// <summary>
    /// 获取或者设置使用标志
    /// </summary>
    [MaxLength(1)]
    [Column("useflag", Order = 119)]
    public string Useflag { get; set; }
    /// <summary>
    /// 获取或者设置是否皮试药
    /// </summary>
    [MaxLength(1)]
    [Column("drtest", Order = 120)]
    public string Drtest { get; set; }
    /// <summary>
    /// 获取或者设置过敏原
    /// </summary>
    [MaxLength(10)]
    [Column("allegyflag", Order = 121)]
    public string Allegyflag { get; set; }
    /// <summary>
    /// 获取或者设置最小单位剂量
    /// </summary>
    [Precision(16, 4)]
    [Column("countnumb", Order = 122)]
    public decimal? Countnumb { get; set; }
    /// <summary>
    /// 获取或者设置每次限量
    /// </summary>
    [Precision(16, 4)]
    [Column("limited", Order = 123)]
    public decimal? Limited { get; set; }
    /// <summary>
    /// 获取或者设置操作人
    /// </summary>
    [MaxLength(20)]
    [Column("jp", Order = 124)]
    public string Jp { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("numb", Order = 125)]
    public decimal? Numb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(15)]
    [Column("drcodes", Order = 126)]
    public string Drcodes { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(8)]
    [Column("code2", Order = 127)]
    public string Code2 { get; set; }
    /// <summary>
    /// 获取或者设置热键
    /// </summary>
    [MaxLength(8)]
    [Column("hotkey", Order = 128)]
    public string Hotkey { get; set; }
    /// <summary>
    /// 获取或者设置进口
    /// </summary>
    [MaxLength(1)]
    [Column("importflag", Order = 129)]
    public string Importflag { get; set; }
    /// <summary>
    /// 获取或者设置剂量单位
    /// </summary>
    [MaxLength(4)]
    [Column("countunit", Order = 130)]
    public string Countunit { get; set; }
    /// <summary>
    /// 获取或者设置最小单位体积
    /// </summary>
    [Precision(16, 4)]
    [Column("dvolume", Order = 131)]
    public decimal? Dvolume { get; set; }
    /// <summary>
    /// 获取或者设置配伍位
    /// </summary>
    [Column("matrixind", Order = 132)]
    public int? Matrixind { get; set; }
    /// <summary>
    /// 获取或者设置更新时间
    /// </summary>
    [Column("updatetime", Order = 133)]
    public DateTime? Updatetime { get; set; }
    /// <summary>
    /// 获取或者设置门诊限量
    /// </summary>
    [Precision(16, 4)]
    [Column("maxnumb", Order = 134)]
    public decimal? Maxnumb { get; set; }
    /// <summary>
    /// 获取或者设置抗生素等级
    /// </summary>
    [MaxLength(1)]
    [Column("noeat", Order = 135)]
    public string Noeat { get; set; }
    /// <summary>
    /// 获取或者设置医保码
    /// </summary>
    [MaxLength(30)]
    [Column("insudcode", Order = 136)]
    public string Insudcode { get; set; }
    /// <summary>
    /// 获取或者设置管理（0：西药库；1：中成药库；2：中药库；3：材料库）
    /// </summary>
    [MaxLength(10)]
    [Column("cc", Order = 137)]
    public string Cc { get; set; }
    /// <summary>
    /// 获取或者设置医保等级
    /// </summary>
    [MaxLength(1)]
    [Column("drtt", Order = 138)]
    public string Drtt { get; set; }
    /// <summary>
    /// 获取或者设置处方药
    /// </summary>
    [MaxLength(1)]
    [Column("dp", Order = 139)]
    public string Dp { get; set; }
    /// <summary>
    /// 获取或者设置自付比例
    /// </summary>
    [Precision(16, 4)]
    [Column("selfper", Order = 140)]
    public decimal? Selfper { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("insuper", Order = 141)]
    public decimal? Insuper { get; set; }
    /// <summary>
    /// 获取或者设置第一套五笔码
    /// </summary>
    [MaxLength(15)]
    [Column("drserchx", Order = 142)]
    public string Drserchx { get; set; }
    /// <summary>
    /// 获取或者设置第二套五笔码
    /// </summary>
    [MaxLength(15)]
    [Column("drserchx1", Order = 143)]
    public string Drserchx1 { get; set; }
    /// <summary>
    /// 获取或者设置第三套五笔码
    /// </summary>
    [MaxLength(15)]
    [Column("drserchx2", Order = 144)]
    public string Drserchx2 { get; set; }
    /// <summary>
    /// 获取或者设置排序
    /// </summary>
    [Column("sortnumb", Order = 145)]
    public int? Sortnumb { get; set; }
    /// <summary>
    /// 获取或者设置备注说明
    /// </summary>
    [MaxLength(4000)]
    [Column("remark", Order = 146)]
    public string Remark { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(18)]
    [Column("drcode1", Order = 147)]
    public string Drcode1 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("insucode2", Order = 148)]
    public string Insucode2 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(12)]
    [Column("match", Order = 149)]
    public string Match { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(100)]
    [Column("remark1", Order = 150)]
    public string Remark1 { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("sendflag", Order = 151)]
    public string Sendflag { get; set; }
    /// <summary>
    /// 获取或者设置医保控制类型
    /// </summary>
    [MaxLength(1)]
    [Column("medicontroltype", Order = 152)]
    public string Medicontroltype { get; set; }
    /// <summary>
    /// 获取或者设置医保控制内容
    /// </summary>
    [MaxLength(4000)]
    [Column("medicontroltext", Order = 153)]
    public string Medicontroltext { get; set; }
    /// <summary>
    /// 获取或者设置使用说明
    /// </summary>
    [MaxLength(200)]
    [Column("usedmark", Order = 154)]
    public string Usedmark { get; set; }
    /// <summary>
    /// 获取或者设置用法类型
    /// </summary>
    [MaxLength(1)]
    [Column("usedtype", Order = 155)]
    public string Usedtype { get; set; }
    /// <summary>
    /// 获取或者设置进零差价标志（1：是；0：否）
    /// </summary>
    [MaxLength(1)]
    [Column("tempmz", Order = 156)]
    public string Tempmz { get; set; }
    /// <summary>
    /// 获取或者设置输液稳定时间
    /// </summary>
    [Precision(8, 2)]
    [Column("stabilitytime", Order = 157)]
    public decimal? Stabilitytime { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(20)]
    [Column("insucode_szyb", Order = 158)]
    public string InsucodeSzyb { get; set; }
    /// <summary>
    /// 获取或者设置医保计量单位
    /// </summary>
    [MaxLength(5)]
    [Column("yb_countunit", Order = 159)]
    public string YbCountunit { get; set; }
    /// <summary>
    /// 获取或者设置医保体积
    /// </summary>
    [Column("yb_dvolume", Order = 160)]
    public float? YbDvolume { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(50)]
    [Column("drname5", Order = 161)]
    public string Drname5 { get; set; }
    /// <summary>
    /// 获取或者设置内服药
    /// </summary>
    [MaxLength(1)]
    [Column("eatflag", Order = 162)]
    public string Eatflag { get; set; }
    /// <summary>
    /// 获取或者设置储存条件
    /// </summary>
    [MaxLength(1)]
    [Column("storeCondition", Order = 163)]
    public string StoreCondition { get; set; }
    /// <summary>
    /// 获取或者设置门诊限量周期天数
    /// </summary>
    [Precision(10, 2)]
    [Column("maxnumbday", Order = 164)]
    public decimal? Maxnumbday { get; set; }
    /// <summary>
    /// 获取或者设置默认频度
    /// </summary>
    [MaxLength(8)]
    [Column("drfre", Order = 165)]
    public string Drfre { get; set; }
    /// <summary>
    /// 获取或者设置高危药标志
    /// </summary>
    [MaxLength(1)]
    [Column("highriskflag", Order = 166)]
    public string Highriskflag { get; set; }
    /// <summary>
    /// 获取或者设置自动包药标志
    /// </summary>
    [MaxLength(1)]
    [Column("AutoPackFlag", Order = 167)]
    public string AutoPackFlag { get; set; }
    /// <summary>
    /// 获取或者设置用药同意书打印
    /// </summary>
    [MaxLength(1)]
    [Column("consentprint", Order = 168)]
    public string Consentprint { get; set; }
    /// <summary>
    /// 获取或者设置基药<0 非基药 1 国家基药 2 省级基药 3 市级基药>
    /// </summary>
    [MaxLength(1)]
    [Column("baseflag", Order = 169)]
    public string Baseflag { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(18)]
    [Column("bak", Order = 170)]
    public string Bak { get; set; }
    /// <summary>
    /// 获取或者设置院区代码
    /// </summary>
    [MaxLength(20)]
    [Column("hoscode", Order = 171)]
    public string Hoscode { get; set; }
    /// <summary>
    /// 获取或者设置转院日期
    /// </summary>
    [Column("hostrandt", Order = 172)]
    public DateTime? Hostrandt { get; set; }
    /// <summary>
    /// 获取或者设置转院标志
    /// </summary>
    [MaxLength(1)]
    [Column("hostranflag", Order = 173)]
    public string Hostranflag { get; set; }
    /// <summary>
    /// 获取或者设置主标志
    /// </summary>
    [MaxLength(1)]
    [Column("primaryflag", Order = 174)]
    public string Primaryflag { get; set; }
    /// <summary>
    /// 获取或者设置DDD值
    /// </summary>
    [Column("DDD", Order = 175)]
    public string DDD { get; set; }
    /// <summary>
    /// 获取或者设置门诊限用
    /// </summary>
    [Column("mzxy", Order = 176)]
    public int? Mzxy { get; set; }
    /// <summary>
    /// 获取或者设置住院限用
    /// </summary>
    [Column("zyxy", Order = 177)]
    public int? Zyxy { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("drugType", Order = 178)]
    public string DrugType { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("drugAttr", Order = 179)]
    public string DrugAttr { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("drugSpecr", Order = 180)]
    public string DrugSpecr { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("drugSpecrUnit", Order = 181)]
    public string DrugSpecrUnit { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(5)]
    [Column("drugSpecrName", Order = 182)]
    public string DrugSpecrName { get; set; }
    /// <summary>
    /// 获取或者设置其他分类
    /// </summary>
    [MaxLength(5)]
    [Column("qtkind", Order = 183)]
    public string Qtkind { get; set; }
    /// <summary>
    /// 获取或者设置皮试发药
    /// </summary>
    [MaxLength(1)]
    [Column("drtest1", Order = 184)]
    public string Drtest1 { get; set; }
    /// <summary>
    /// 获取或者设置一次性发药
    /// </summary>
    [MaxLength(1)]
    [Column("oncesend", Order = 185)]
    public string Oncesend { get; set; }
    /// <summary>
    /// 获取或者设置计量倍数
    /// </summary>
    [MaxLength(6)]
    [Column("numbmultiple", Order = 186)]
    public string Numbmultiple { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(3)]
    [Column("numbmultiplem", Order = 187)]
    public string Numbmultiplem { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("minnumb", Order = 188)]
    public decimal? Minnumb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("inminnumb", Order = 189)]
    public decimal? Inminnumb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("inmaxnumb", Order = 190)]
    public decimal? Inmaxnumb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("emminnumb", Order = 191)]
    public decimal? Emminnumb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("emmaxnumb", Order = 192)]
    public decimal? Emmaxnumb { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [Precision(16, 4)]
    [Column("kjddd", Order = 193)]
    public decimal? Kjddd { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(1)]
    [Column("fzymark", Order = 194)]
    public string Fzymark { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(18)]
    [Column("hxzl", Order = 195)]
    public string Hxzl { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(18)]
    [Column("fzbx", Order = 196)]
    public string Fzbx { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(18)]
    [Column("myzl", Order = 197)]
    public string Myzl { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(18)]
    [Column("nfmzl", Order = 198)]
    public string Nfmzl { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(18)]
    [Column("tpzjs", Order = 199)]
    public string Tpzjs { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(10)]
    [Column("measurement", Order = 200)]
    public string Measurement { get; set; }
    /// <summary>
    /// 获取或者设置
    /// </summary>
    [MaxLength(16)]
    [Column("provicedrcode", Order = 201)]
    public string Provicedrcode { get; set; }
    /// <summary>
    /// 获取或者设置抗菌药物ddd值对应剂量
    /// </summary>
    [Precision(16, 4)]
    [Column("Kjddddyjl", Order = 202)]
    public decimal? Kjddddyjl { get; set; }
    /// <summary>
    /// 获取或者设置品种代码
    /// </summary>
    [MaxLength(32)]
    [Column("pzid", Order = 203)]
    public string PzId { get; set; }

    /// <summary>
    /// 获取参与比较运算的值
    /// </summary>
    /// <returns>返回参与比较运算的值</returns>
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Drcode;
    }
}