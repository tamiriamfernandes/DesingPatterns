
using DesingPatterns._01___Creational._1._2___Factory_Method;
using DesingPatterns.Abstract_Factory.Factory;

Console.WriteLine("Escolha a operação:");
Console.WriteLine("------------------------");
Console.WriteLine("Creational Patterns");
Console.WriteLine("------------------------");
Console.WriteLine("1 - Abstract Factory");
Console.WriteLine("2 - Method Factory");

var opcao = Console.ReadKey();

Console.WriteLine("");
Console.WriteLine("------------------------");
Console.WriteLine("");

switch (opcao.KeyChar)
{
    case '1':
        ExecucaoAbstractFactory.Executar();
        break;
    case '2':
        ExecucaoFactoryMethod.Executar();
        break;
}

Console.ReadKey();
Console.Clear();


