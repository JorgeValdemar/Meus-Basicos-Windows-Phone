﻿#pragma checksum "C:\Users\jorge\Documents\Visual Studio 2013\26174_47905\WP.Prova\WP.Prova\adicionarPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7D23328DAB42F8A9CEDA8EC125FBBEAE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace MeuBasico {
    
    
    public partial class adicionarPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock lblTitulo;
        
        internal System.Windows.Controls.StackPanel ContentPanel;
        
        internal System.Windows.Controls.TextBlock lblIdentity;
        
        internal System.Windows.Controls.TextBox txtNome;
        
        internal System.Windows.Controls.TextBox txtPreco;
        
        internal System.Windows.Controls.TextBox txtDescricao;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnSalvar;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnCancelar;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/WP.Prova;component/adicionarPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.lblTitulo = ((System.Windows.Controls.TextBlock)(this.FindName("lblTitulo")));
            this.ContentPanel = ((System.Windows.Controls.StackPanel)(this.FindName("ContentPanel")));
            this.lblIdentity = ((System.Windows.Controls.TextBlock)(this.FindName("lblIdentity")));
            this.txtNome = ((System.Windows.Controls.TextBox)(this.FindName("txtNome")));
            this.txtPreco = ((System.Windows.Controls.TextBox)(this.FindName("txtPreco")));
            this.txtDescricao = ((System.Windows.Controls.TextBox)(this.FindName("txtDescricao")));
            this.btnSalvar = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnSalvar")));
            this.btnCancelar = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnCancelar")));
        }
    }
}

