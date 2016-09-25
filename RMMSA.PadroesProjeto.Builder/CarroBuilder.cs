
namespace RMMSA.PadroesProjeto.Builder
{
    public class CarroBuilder : VeiculoBuilder
    {
        public CarroBuilder()
        {
            _veiculo = new Veiculo("Carro Passeio");
        }

        public override void BuildMotor()
        {
            _veiculo["motor"] = "225 Cavalos";
        }

        public override void BuildPneus()
        {
            _veiculo["pneus"] = "4 banda branca";
        }

        public override void BuilPortas()
        {
            _veiculo["portas"] = "2 Portas";
        }
    }
}
