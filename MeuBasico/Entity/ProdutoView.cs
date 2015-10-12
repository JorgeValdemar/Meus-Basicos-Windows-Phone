using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using WP.SqlCEMercado;

namespace MeuBasico.Entity
{
    public class ProdutoView
    {
        public ObservableCollection<Produto> Itens { get; set; }

        public ProdutoView()
        {
            this.Itens = new ObservableCollection<Produto>();
        }

        public void Carregar()
        {
            IList<Produto> _contato = null;

            using (var _context = new MercadoDbContext(App._connectionString))
            {
                IQueryable<Produto> _query = _context.Produtos;
                _contato = _query.ToList();

                this.Itens.Clear();
                foreach (var item in _contato)
                {
                    this.Itens.Add(item);
                }
            }
        }
    }
}
