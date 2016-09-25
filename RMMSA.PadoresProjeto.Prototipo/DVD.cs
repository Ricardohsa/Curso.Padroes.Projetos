using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMMSA.PadoresProjeto.Prototipo
{
    public class DVD : Item
    {
        public DVD(int id, string descricao, double preco) : base(id, descricao, preco)
        {
        }

        public override Item Clone()
        {
            return (Item)MemberwiseClone();
        }
    }
}
