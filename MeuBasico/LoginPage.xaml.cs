using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace MeuBasico
{
    public partial class LoginPage : PhoneApplicationPage
    {

        private string login = "Feliz";
        private string senha = "123";

        public LoginPage()
        {
            InitializeComponent();

            if (IsolatedStorageSettings.ApplicationSettings.Contains("LoginOK"))
            {
                this.Loaded += (s, e) =>
                {
                    var ns = NavigationService;
                    ns.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                };
            }

            
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            if (txtLogin.Text == login && txtSenha.Text == senha)
            {
                IsolatedStorageSettings.ApplicationSettings["LoginOK"] = true;
                IsolatedStorageSettings.ApplicationSettings.Save();
            
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos", "Login inválido", MessageBoxButton.OK);
            }

        }
    }
}