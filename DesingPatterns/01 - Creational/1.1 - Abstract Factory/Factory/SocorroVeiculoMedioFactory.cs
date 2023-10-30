using DesingPatterns.Abstract_Factory.Enum;
using DesingPatterns.Abstract_Factory.Models;
using static DesingPatterns.Abstract_Factory.Models.Guincho;
using static DesingPatterns.Abstract_Factory.Models.Veiculo;

namespace DesingPatterns.Abstract_Factory.Factory;

public class SocorroVeiculoMedioFactory : AutoSocorroFactory
{
    public override Guincho CriarGuincho()
    {
        return GuinchoCreator.Criar(Porte.Medio);
    }

    public override Veiculo CriarVeiculo(string modelo, Porte porte)
    {
        return VeiculoCreator.Criar(modelo, porte);
    }
}
