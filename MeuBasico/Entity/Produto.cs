using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP.SqlCEMercado
{
    public partial class Produto
    {
        private string selecionado;
        public string Selecionado
        {
            get { return selecionado; }
            set
            {
                if (this.selecionado != value)
                {
                    selecionado = value;
                    this.SendPropertyChanged("Selecionado");
                }
            }
        }

    }
}
