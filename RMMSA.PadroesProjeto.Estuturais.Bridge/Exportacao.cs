namespace RMMSA.PadroesProjeto.Estuturais.Bridge
{
    //Abstração 
    public abstract class Exportacao
    {
        //Composição
        protected ExportacaoImpl _implementor;

        public ExportacaoImpl Implementor
        {
            set { _implementor = value; }
            
        }

        public virtual void Exportar()
        {
            //implementação por delegação
            _implementor.Exportar();
        }
    }
}