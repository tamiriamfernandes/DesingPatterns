namespace DesingPatterns._01___Creational._1._2___Factory_Method;

public class SqlServerConnector : DbConnector
{
    // Concrete Product
    public SqlServerConnector(string connectionString) : base(connectionString)
    {
        ConnectionString = connectionString;
    }
    public override Connection Connect()
    {
        Console.WriteLine("Conectando ao banco SQL Server...");
        var connection = new Connection(ConnectionString);
        connection.Open();

        return connection;
    }
}
