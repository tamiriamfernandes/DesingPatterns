using DesingPatterns.Abstract_Factory.Enum;
using DesingPatterns.Abstract_Factory.Models;
using static DesingPatterns.Abstract_Factory.Models.Guincho;
using static DesingPatterns.Abstract_Factory.Models.Veiculo;

namespace DesingPatterns.Abstract_Factory.Factory;

public class SocorroVeiculoGrandeFactory : AutoSocorroFactory
{
    public override Guincho CriarGuincho()
    {
        return GuinchoCreator.Criar(Porte.Grande);
    }

    public override Veiculo CriarVeiculo(string modelo, Porte porte)
    {
        return VeiculoCreator.Criar(modelo, porte);
    }
}
