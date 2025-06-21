using Synyi.Framework.Data.Database;

namespace Synyi.GyxcInterface.WebApi.Launcher;

/// <summary>
/// 数据库字符串提供程序
/// </summary>
internal class ConnectionStringProvider : ConnectionStringProviderBase
{
    /// <summary>
    /// 返回数据库字符串提供程序
    /// </summary>
    /// <param name="configuration">配置</param>
    public ConnectionStringProvider(IConfiguration configuration)
    {
        this.configuration = configuration
            ?? throw new ArgumentNullException(nameof(configuration));
    }
    /// <summary>
    /// 配置
    /// </summary>
    private readonly IConfiguration configuration;

    /// <summary>
    /// 获取数据库字符串
    /// </summary>
    /// <param name="name">名称</param>
    /// <returns>返回数据库字符串</returns>
    protected override string DoGetConnectionString(string name)
    {
        var result = configuration.GetConnectionString(name);
        return result;
    }
    /// <summary>
    /// 获取数据库类型
    /// </summary>
    /// <param name="name">名称</param>
    /// <returns>返回数据库类型</returns>
    protected override DatabaseType DoGetDatabaseType(string name)
    {
        return DatabaseType.MSSQL;
    }
}
