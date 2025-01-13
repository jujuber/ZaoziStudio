using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Synyi.Zaozi.WriteThing.DB;
using Synyi.Zaozi.WriteThing.Model; 

namespace Synyi.Zaozi.WriteThing.Controllers;
[Route("api/[controller]")]
[ApiController]
public class WriteLogController : ControllerBase
{
    private readonly IConfiguration Configuration;
    public WriteLogController(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    [HttpPost]
    public async Task<ActionResult> Write(InputDto value)
    {
        DBHelper dBHelper = new DBHelper(Configuration);

        //long id = db.Insertable(实体).ExecuteReturnSnowflakeId();//单条插入返回雪花ID

        await dBHelper.SqlDB.Insertable(new KzzqrmyyYqjcLog()
        {
            LogText = value.Log,
            CreateTime = DateTime.Now
        }).ExecuteReturnSnowflakeIdAsync();

        return Ok("保存成功");
    }

    [HttpGet("Create-Table")]
    public ActionResult CreateTable()
    {
        DBHelper dBHelper = new DBHelper(Configuration);

        dBHelper.SqlDB.CodeFirst.SetStringDefaultLength(200).InitTables(typeof(KzzqrmyyYqjcLog));

        return Ok("建表成功");
    }

    [HttpPost("WriteString")]
    public async Task<ActionResult> WriteString([FromBody] object logText)
    {
        if (logText == null)
        {
            return BadRequest("日志内容不能为空");
        }

        DBHelper dBHelper = new DBHelper(Configuration);

        await dBHelper.SqlDB.Insertable(new KzzqrmyyYqjcLog()
        {
            LogText = $"{logText}",
            CreateTime = DateTime.Now
        }).ExecuteReturnSnowflakeIdAsync();

        return Ok("保存成功");
    }
}
