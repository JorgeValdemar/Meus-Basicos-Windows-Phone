using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WP.SqlCEMercado;

namespace MeuBasico
{
    public partial class adicionarPage : PhoneApplicationPage
    {
        public adicionarPage()
        {
            InitializeComponent();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string _identity = "-1";
            if (NavigationContext.QueryString.TryGetValue("identity", out _identity))
            {
                if (!string.IsNullOrWhiteSpace(_identity))
                {
                    lblTitulo.Text = "Editar";
                    lblIdentity.Text = _identity;
                    using (var context = new MercadoDbContext(App._connectionString))
                    {
                        var query = (from _con in context.Produtos
                                     where _con.Id == int.Parse(_identity)
                                     select _con).FirstOrDefault();

                        txtNome.Text = query.Nome;
                        txtPreco.Text = query.Preco.ToString();
                        txtDescricao.Text = query.Descricao;
                    }
                }
                else
                {
                    lblIdentity.Text = string.Empty;
                    lblTitulo.Text = "Adicionar";
                }
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "Editar")
                Editar();
            else Inserir();
        }


        private void Editar()
        {
            using (var _context = new MercadoDbContext(App._connectionString))
            {
                Produto _contato = (_context.Produtos.Where(a => a.Id == int.Parse(lblIdentity.Text)).First() as Produto);

                _contato.Nome = txtNome.Text;
                _contato.Preco = int.Parse(txtPreco.Text);
                _contato.Descricao = txtDescricao.Text;

                try
                {
                    _context.SubmitChanges();

                    if (NavigationService.CanGoBack) NavigationService.GoBack();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void Inserir()
        {
            using (var _context = new MercadoDbContext(App._connectionString))
            {
                Produto _p = new Produto()
                {
                    Nome = txtNome.Text,
                    Preco = int.Parse(txtPreco.Text),
                    Descricao = txtDescricao.Text
                };

                try
                {
                    _context.Produtos.InsertOnSubmit(_p);
                    _context.SubmitChanges();

                    if (NavigationService.CanGoBack) NavigationService.GoBack();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (NavigationService.CanGoBack)
                NavigationService.GoBack();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            base.OnBackKeyPress(e);

            e.Cancel = (MessageBox.Show("Tem certeza que deseja cancelar?",
                "Atenção", MessageBoxButton.OKCancel) == MessageBoxResult.OK);
        }
    }
}