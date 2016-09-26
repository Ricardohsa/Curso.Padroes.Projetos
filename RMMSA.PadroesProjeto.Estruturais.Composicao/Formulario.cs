using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Composicao
{
    public class Formulario: Component
    {

        private List<Component> _children = new List<Component>();

        public Formulario(string nome) : base(nome)
        {
        }

        public override void Add(Component c)
        {
            _children.Add(c);
        }

        public override void Remove(Component c)
        {
            _children.Remove(c);
        }

        public override void Display()
        {
            Console.WriteLine(_name);
            foreach (var f in _children)
            {
                f.Display();

            }
        }
    }
}
