using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.GyxcInterface.Domain.EntityFramework;
/// <summary>
/// 实体框架提供程序
/// </summary>
internal sealed class EfProvider : EfProviderBase<EfDbContext>
{
    public EfProvider()
        : base(HisV1Const.DbName)
    {
    }

    /// <summary>
    /// 创建实体上下文
    /// </summary>
    /// <param name="options">实体上下文配置</param>
    /// <returns>返回实体上下文</returns>
    protected override DbContext CreateContext(DbContextOptions<EfDbContext> options)
    {
        return new EfDbContext(options);
    }

}