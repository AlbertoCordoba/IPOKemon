﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPOkemon
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Combate : Page
    {
        int numJugadores;
        Frame frame = Window.Current.Content as Frame;
        public Combate()
        {
            this.InitializeComponent();
        }

        private void BtnUnJugador_Click(object sender, RoutedEventArgs e)
        {
            numJugadores = 1;
            this.Frame.Navigate(typeof(SeleccionarPokemon), numJugadores);
        }
        private void BtnDosJugadores_Click(object sender, RoutedEventArgs e)
        {
            numJugadores = 2;
            this.Frame.Navigate(typeof(SeleccionarPokemon), numJugadores);
        }
    }
}