using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MeuBasico.Resources;
using WP.SqlCEMercado;

namespace MeuBasico
{
    public partial class MainPage : PhoneApplicationPage
    {
        public Produto prod;
        // Constructor
        public MainPage()
        {
            InitializeComponent();


            this.DataContext = App.ViewProduto;
            this.Loaded += MainPage_Loaded;

            

        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            App.ViewProduto.Carregar();
        }



        private void mainLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (Produto item in e.RemovedItems)
            {
                item.Selecionado = "Black";
            }
            foreach (Produto item in e.AddedItems)
            {
                item.Selecionado = "Green";
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover o produto?",
                "Atenção", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                using (var context = new MercadoDbContext(App._connectionString))
                {
                    Produto _p = (mainLista.SelectedItem as Produto);

                    context.Produtos.Attach(_p);
                    context.Produtos.DeleteOnSubmit(_p);
                    context.SubmitChanges();

                    _p = null;
                }
                App.ViewProduto.Carregar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/adicionarPage.xaml?identity=" +
                (mainLista.SelectedItem as Produto).Id.ToString(),
                UriKind.Relative));
        }

        private void iconAdd_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/adicionarPage.xaml", UriKind.Relative));
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (App.ViewProduto.Itens != null)
            {
                this.mainLista.ItemsSource = App.ViewProduto.Itens.Where(w => w.Nome.ToUpper().Contains(txtPesquisa.Text.ToUpper()));
            }
        }
    }
}