namespace RMMSA.PadroesProjeto.Builder
{
    public abstract class VeiculoBuilder
    {
        protected Veiculo _veiculo;

        public Veiculo veiculo
        {
            get { return _veiculo; }
        }

        //processo de construçao do veiculo
        public abstract void BuildMotor();
        public abstract void BuilPortas();
        public abstract void BuildPneus();

    }
}
