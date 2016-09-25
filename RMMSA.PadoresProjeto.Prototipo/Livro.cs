using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadoresProjeto.Prototipo
{
    //Concrete Prototipo
    public class Livro : Item
    {
        public Livro(int id, string descricao, double preco) : base(id, descricao, preco)
        {
        }


        public override Item Clone()
        {
            return (Item)this.MemberwiseClone();
        }
    }
}
