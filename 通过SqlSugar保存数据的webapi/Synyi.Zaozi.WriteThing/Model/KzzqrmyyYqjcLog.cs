using SqlSugar;
using System.ComponentModel.DataAnnotations;

namespace Synyi.Zaozi.WriteThing.Model;

public class KzzqrmyyYqjcLog
{
    [SugarColumn(IsPrimaryKey = true)]
    public long Id { get; set; }

    [SugarColumn(Length = 8000)]
    public string LogText { get; set; }
    public DateTime CreateTime { get; set; }
}
