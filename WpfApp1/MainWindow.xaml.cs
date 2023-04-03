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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declaración de Variable Global
        string nombre;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            //Cierra la aplicación
            this.Close();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            //Permite limpiar los controles
            this.txtNombre.Text = string.Empty;
            this.lblMensaje.Content = string.Empty;
        }

        private void btnMostrar_Click(object sender, RoutedEventArgs e)
        {
            //Variable Local
            string mensaje;
            //Recuperar el valor del TextBox
            nombre = this.txtNombre.Text;
            //Fromar el mensaje
            mensaje = "Bienvenid@ al curso " + nombre;
            //Mostrar mensaje
            this.lblMensaje.Content = mensaje;
        }
    }
}
