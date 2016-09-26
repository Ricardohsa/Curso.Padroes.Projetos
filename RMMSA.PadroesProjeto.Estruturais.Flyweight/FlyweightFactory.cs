using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Estruturais.Flyweight
{
    public class FlyweightFactory
    {
        private Hashtable _flyweights = new Hashtable();

        public FlyweightFactory()
        {
            _flyweights.Add("A", new ConcreteFlyweight());
            _flyweights.Add("B", new ConcreteFlyweight());
            _flyweights.Add("C", new ConcreteFlyweight());
        }

        public Flyweight getFlyweight(string key)
        {
            return (Flyweight) _flyweights[key];

        }
    }
}
