using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Composicao
{
    //Component
    public abstract class Component
    {
        protected string _name;

        public Component(string nome)
        {
            _name = nome;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display();
    }
}
