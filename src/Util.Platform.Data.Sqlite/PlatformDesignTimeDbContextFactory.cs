﻿using Util.Helpers;

namespace Util.Platform.Data.Sqlite; 

/// <summary>
/// 设计时数据上下文工厂
/// </summary>
public class PlatformDesignTimeDbContextFactory : IDesignTimeDbContextFactory<PlatformUnitOfWork> {
    /// <summary>
    /// 创建数据上下文
    /// </summary>
    public PlatformUnitOfWork CreateDbContext( string[] args ) {
        var connectionString = GetConnectionString();
        var services = Ioc.GetServices();
        services.AddDbContext<PlatformUnitOfWork>( t => t.UseSqlite( connectionString ) );
        return Ioc.Create<PlatformUnitOfWork>();
    }

    /// <summary>
    /// 获取连接字符串
    /// </summary>
    private string GetConnectionString() {
        var basePath = Common.JoinPath( Common.GetParentDirectory(), "Util.Platform.Api" );
        var config = Config.CreateConfiguration( basePath );
        return config.GetConnectionString( "Sqlite" );
    }
}