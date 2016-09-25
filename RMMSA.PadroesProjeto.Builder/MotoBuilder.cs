namespace RMMSA.PadroesProjeto.Builder
{
    public class MotoBuilder : VeiculoBuilder
    {
        public MotoBuilder()
        {
            _veiculo = new Veiculo("Moto");
        }

        public override void BuildMotor()
        {
            _veiculo["motor"] = "600c";
        }

        public override void BuildPneus()
        {
            _veiculo["pneus"] = "2";
        }

        public override void BuilPortas()
        {
            _veiculo["portas"] = "0";
        }
    }
}

