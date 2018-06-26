﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfView
{
    public partial class Exemplos : Window
    {
        public Exemplos()
        {
            //InitializeComponent();

            txtNome.Text = "Olá mundo!";
        }

        private void btnCliqueMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Eai usuário, tudo bem?");
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            btnCliqueMe.Visibility = Visibility.Hidden;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            btnCliqueMe.Visibility = Visibility.Visible;
        }

        private void btnCarregarCadastroUsuario_Click(object sender, RoutedEventArgs e)
        {
            //frmSystem frm = new frmSystem();
            //frm.ShowDialog();
            //frm.ShowDialog();
        }
    }
}
