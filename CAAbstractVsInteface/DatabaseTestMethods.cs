using System.Data;

namespace CAAbstractVsInteface
{
    public class SqlServerDb : BaseDb
    {
        public override string GetDbVersion() => "SqlServer2012";

        public string GenerateSql(int id)
        {
            return $"Select* From Users With(NOLOCK) Where ID= {id}";
        }
    }

    public class OracleDb : BaseDb
    {
        public override string GetDbVersion() => "OracleLast";

        public string GenerateSql(int id)
        {
            return $"Select* From Users Where USER_ID= {id}";
        }


    }
    public class MysqlDb : BaseDb
    {
        public override string GetDbVersion() => "MysqLlast";

    }

    public abstract class BaseDb
    {
        //Abstraction => Ortaklaştırma ve Sözleşme
        public abstract string GetDbVersion();
        public DataTable ExecuteSql(string sql)
        {
            return new DataTable();
        }
    }
}
