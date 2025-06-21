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
    /// <summary>
    /// 方法入参 标注了 FromRoute后，要在特性中体现
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    [HttpPost("{username}/getpatname")]
    public Task<string> TestRoute([FromRoute] string username, int age  )
    {
        var result  = new {username,age };

        var temp = Newtonsoft.Json.JsonConvert.SerializeObject(result);

        return Task.FromResult(temp);
         
    }
    /// <summary>
    /// 方法入参 标注了 FromQuery username=xx&&age=1
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    [HttpPost("TestQuery")]
    public Task<string> TestQuery([FromQuery] string username, int age)
    {
        var result = new { username, age };

        var temp = Newtonsoft.Json.JsonConvert.SerializeObject(result);

        return Task.FromResult(temp);

    }

    /// <summary>
    /// 方法入参 标注了 FromQuery username=xx&&age=1
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    [HttpPost("TestForm")]
    public Task<string> TestForm([FromForm] string username, [FromForm] int age)
    {
        var result = new { username, age };

        var temp = Newtonsoft.Json.JsonConvert.SerializeObject(result);

        return Task.FromResult(temp);

    }

}
