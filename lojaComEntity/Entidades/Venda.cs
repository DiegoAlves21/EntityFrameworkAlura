using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entidades
{
    public class Venda
    {
        public Venda()
        {
            this.ProdutosVenda = new List<ProdutoVenda>();
        }
        public int ID { get; set; }
        public int UsuarioID { get; set; }
        public virtual Usuario Cliente { get; set; }
        public virtual IList<ProdutoVenda> ProdutosVenda { get; set; }
    }
}
