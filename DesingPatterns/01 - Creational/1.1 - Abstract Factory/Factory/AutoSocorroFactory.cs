using DesingPatterns.Abstract_Factory.Enum;
using DesingPatterns.Abstract_Factory.Models;

namespace DesingPatterns.Abstract_Factory.Factory;

public abstract class AutoSocorroFactory
{
    public abstract Guincho CriarGuincho();
    public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
}
