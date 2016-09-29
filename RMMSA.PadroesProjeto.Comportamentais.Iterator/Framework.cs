using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadroesProjeto.Comportamentais.Iterator
{
    //Iterator
    public abstract class Iterator
    {
        public abstract object First();
        public abstract Object Next();
        public abstract bool IsDone();
        public abstract Object CurrenItem();
    }

    //Aggrefate
    public abstract class Aggregate
    {
        public abstract Iterator CreaIterator { get; }
    }

    //Concrete Aggregate
    public class Equipe : Aggregate
    {
        private List<string> _items = new List<string>();

        public override Iterator CreaIterator
        {
            get
            {
                return new ConcreteIterator(this);
            }
        }

        public int Count
        {
            get { return _items.Count; }
        }

        //indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, (string) value);}
        }
       
    }

    //Concrete Iteragor
    public class ConcreteIterator : Iterator
    {
        private Equipe _aggregate;

        private int current = 0;

        public ConcreteIterator(Equipe aggregate)
        {
            _aggregate = aggregate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            if (current < _aggregate.Count - 1)
                ret = _aggregate[++current];
            return ret;
        }

        public override bool IsDone()
        {
            return current >= _aggregate.Count;
        }

        public override object CurrenItem()
        {
            return _aggregate[current];
        }
    }

}
