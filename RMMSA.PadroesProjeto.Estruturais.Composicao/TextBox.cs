using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Composicao
{
    public class TextBox: Component
    {
        public TextBox(string nome) : base(nome)
        {
            _name = nome;
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Não é possível adicionar elementos a este componente");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Não é possível removerr elementos a este componente");
        }

        public override void Display()
        {
            Console.WriteLine(_name);
        }

    }
}
