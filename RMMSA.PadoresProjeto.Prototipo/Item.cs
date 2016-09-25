using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadoresProjeto.Prototipo
{
    //Prototipo
    public abstract class Item
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Item(int id, string descricao, double preco)
        {
            Id = id;
            Descricao = descricao;
            Preco = preco;
        }

        public abstract Item Clone();

    }
}
