using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniExcelLibs;

namespace ProVisual;
public class MainViewModel:INotifyPropertyChanged
{
    public int sxhcount;
    public int SxhCount
    {
        get { return sxhcount; }
        set { 
            sxhcount = value;
            OnPropertyChanged(nameof(SxhCount));
        }
    }
    public int sxqcount;
    public int SxqCount
    {
        get { return sxqcount; }
        set
        {
            sxqcount = value;
            OnPropertyChanged(nameof(SxqCount));
        }
    }

    
    protected void OnPropertyChanged(string name)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
    public MainViewModel()
    {
        ResolveExcel();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void ResolveExcel()
    {
        string excelPath = @"D:\1.森亿医疗\1.项目\6.遵义红花岗\红花岗任务管理-新.xlsx";
        var data = MiniExcel.Query<ExcelData>(excelPath, "01-1需求").ToList();

        SxqCount = data.FindAll(r=>r.来源 == "上线前").Count();
        SxhCount = data.FindAll(r=>r.来源 == "上线后").Count();
    }
}

public class ExcelData
{
    public string? 系统模块 { get; set; }
    public string? 内容 { get; set; }
    public string? 登记人 { get; set; }
    public string? 登记日期 { get; set; }
    public string? 来源 { get; set; }
    public string? 提出对象 { get; set; }
    public string? 重要程度 { get; set; }
    public string? 紧急程度 { get; set; }
    public string? 研发负责人 { get; set; }
    public string? 当前负责人 { get; set; }
    public string? 研发排期 { get; set; }
    public string? 研发完成时间 { get; set; }
    public string? 交付负责人 { get; set; }
    public string? 进度状态 { get; set; }
}