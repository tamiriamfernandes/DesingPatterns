namespace DesingPatterns._01___Creational._1._2___Factory_Method;

// Concrete Creator
public class OracleFactory : DbFactory
{
    // Factory Method
    public override DbConnector CreateConnector(string connectionString)
    {
        return new OracleDbConnector(connectionString);
    }
}
