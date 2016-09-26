using System;

namespace RMMSA.PadroesProjeto.Estruturais.Adapter
{
    //Transforma Adpatee em um Target
    public class Adapter :Target
    {
        //composião simples
        private readonly Adaptee _adaptee = new Adaptee();

        //delegação simple repassa chamada ao adaptee
        public override void Request()
        {
            //chamada de método que tem uma interface diferente
            _adaptee.SpecifcRequest();
        }
    }
}
