using SqlSugar;

namespace Synyi.Zaozi.WriteThing.DB;

public class DBHelper
{
    public SqlSugarScope SqlDB { get; set; }

    public DBHelper(IConfiguration configuration)
    {  
        var connStr = configuration.GetConnectionString("DefaultConnection");
        var dbType = configuration.GetConnectionString("DbType"); 
        var dbTypeEnum = GetDbTypeFromString(dbType);
        SqlDB = new SqlSugarScope(new ConnectionConfig()
        {
            ConnectionString = connStr,// "Data Source=.;uid=sa;pwd=whj123;database=Zaozi;Encrypt=True;TrustServerCertificate=True;Persist Security Info=True",
            DbType = dbTypeEnum,
            IsAutoCloseConnection = true
        });
    }
    public DbType GetDbTypeFromString(string? dbType)
    {
        if (Enum.TryParse(dbType, true, out DbType result))
        {
            return result;
        }
        else
        {
            throw new ArgumentException("Invalid string for DbType enum.", nameof(dbType));
        }
    }
}
