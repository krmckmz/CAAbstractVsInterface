using CAAbstractVsInteface;

namespace CAAbstractVsInterface
{
    class Program
    {
        static public void Main(String[] args)
        {
            //Interface : Agreement , Ability
            var sqlDb = new SqlServerDb();
            sqlDb.ExecuteSql("");

            var oracleDb = new OracleDb();
            oracleDb.ExecuteSql("");
            var oracleVersion = oracleDb.GetDbVersion();

            //var baseDb = new BaseDb();
            //Abstract class'tan instance create edilemez.

            var car = new Car();
            car.Go();
            car.Stop();

            var plane = new Plane();
            plane.Go();
            plane.Stop();
            plane.Soar();


        }
    }
}


