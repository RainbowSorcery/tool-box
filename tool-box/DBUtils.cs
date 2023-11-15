
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tool_box
{
    internal class DBUtils
    {
        public static SqlSugarScope sqlClient = new SqlSugarScope(new ConnectionConfig()
        {
            ConnectionString = @"Data Source=data.db;Pooling=true",
            DbType = DbType.Sqlite,//数据库类型
            IsAutoCloseConnection = true //不设成true要手动close
        },
 db =>
 {
     //(A)全局生效配置点，一般AOP和程序启动的配置扔这里面 ，所有上下文生效
     //调试SQL事件，可以删掉
     db.Aop.OnLogExecuting = (sql, pars) =>
     {

         //获取原生SQL推荐 5.1.4.63  性能OK
         UtilMethods.GetNativeSql(sql, pars);

     };

     //多个配置就写下面
     //db.Ado.IsDisableMasterSlaveSeparation=true;

     //注意多租户 有几个设置几个
     //db.GetConnection(i).Aop
 });

        public static void CheckAndCreateTable<T>(SqlSugarScope sqlClient, String tableName)
        {
            if (sqlClient != null && !sqlClient.DbMaintenance.IsAnyTable(tableName))
            {
                sqlClient.CodeFirst.InitTables(typeof(T));
            }
        }
    }



}
