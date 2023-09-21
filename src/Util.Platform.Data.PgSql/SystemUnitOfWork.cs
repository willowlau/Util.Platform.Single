namespace Util.Platform.Data.PgSql;

/// <summary>
/// 系统工作单元
/// </summary>
public class SystemUnitOfWork : PgSqlUnitOfWorkBase, ISystemUnitOfWork {
    /// <summary>
    /// 初始化系统工作单元
    /// </summary>
    /// <param name="serviceProvider">服务提供器</param>
    /// <param name="options">配置项</param>
    public SystemUnitOfWork( IServiceProvider serviceProvider,DbContextOptions<SystemUnitOfWork> options ) : base( serviceProvider,options ) {
    }
}