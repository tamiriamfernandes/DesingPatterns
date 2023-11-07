using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns._01___Creational._1._2___Factory_Method;

public class ExecucaoFactoryMethod
{
    public static void Executar()
    {
        var sqlCn = DbFactory.Database(DataBase.SqlServer)
                             .CreateConnector("minhaCS")
                             .Connect();

        sqlCn.ExecuteCommand("select * from tabelaSql");
        sqlCn.Close();

        Console.WriteLine("");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("");

        var oracleCn = DbFactory.Database(DataBase.Oracle)
                                .CreateConnector("minhaCS")
                                .Connect();

        oracleCn.ExecuteCommand("select * from tabelaOracle");
        oracleCn.Close();
    }
}
