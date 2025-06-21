using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synyi.GyxcInterface.Domain.EntityFramework;
/// <summary>
/// 实体上下文
/// </summary>
internal sealed class EfDbContext : EfDbContextBase<EfDbContext>
{
    /// <summary>
    /// 初始化实体上下文
    /// </summary>
    /// <param name="options">配置</param>
    public EfDbContext(DbContextOptions<EfDbContext> options)
        : base(options)
    {
    }
}
