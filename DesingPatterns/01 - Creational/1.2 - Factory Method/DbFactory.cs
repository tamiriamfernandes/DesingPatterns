namespace DesingPatterns._01___Creational._1._2___Factory_Method;

// Abstract Creator
public abstract class DbFactory
{
    // Factory Method
    public abstract DbConnector CreateConnector(string connectionString);

    public static DbFactory Database(DataBase dataBase)
    {
        switch (dataBase)
        {
            case DataBase.SqlServer:
                return new SqlFactory();
            case DataBase.Oracle:
                return new OracleFactory();
            default:
                throw new ApplicationException("Banco de dados não reconhecido.");
        }
    }
}
