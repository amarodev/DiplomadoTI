﻿using PaganaSoft.BuscadorIO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using FolBrowDia = System.Windows.Forms.FolderBrowserDialog;
using Result = System.Windows.Forms.DialogResult;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using PaganaSoft.BuscadorIO.ViewModels;

namespace PaganaSoft.BuscadorIO
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public DefaultViewModel MyViewModel { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Buscador bus = new Buscador();
            bus.Search(txtParameter.Text, txtPath.Text, chkSub.IsChecked);
        }

        private void btnSelPathClick(object sender, RoutedEventArgs e)
        {
            try
            {
                FolBrowDia dlg = new FolBrowDia();   
                if (dlg.ShowDialog() == Result.OK)
                {
                    txtPath.Text = dlg.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
            
        }
    
    }
}
