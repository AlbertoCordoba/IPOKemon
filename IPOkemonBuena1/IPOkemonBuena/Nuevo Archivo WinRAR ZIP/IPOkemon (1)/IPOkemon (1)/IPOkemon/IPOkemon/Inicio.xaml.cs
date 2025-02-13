﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
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
    public sealed partial class Inicio : Page

    {
        private string textoBienvenida;
        private int indexLetra = 0;
        private DispatcherTimer timer;

        Frame frame = Window.Current.Content as Frame;

        public Inicio()
        {
            this.InitializeComponent();
            stringInicio();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(25);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void stringInicio()
        {
            //En español
            textoBienvenida = "¡Bienvenido, futuro Maestro Pokémon! Aquí comienza tu increíble viaje. Entrena a tus Pokémon, enfrenta desafíos épicos, descubre nuevas especies y busca convertirte en el mejor. \n¡Tu aventura Pokémon comienza ahora!";
        }

        private void Timer_Tick(object sender, object e)
        {
            if (indexLetra < textoBienvenida.Length)
            {
                tbBienvenida.Text += textoBienvenida[indexLetra];
                indexLetra++;
                if (textoBienvenida[indexLetra - 1] != ' ' && indexLetra < textoBienvenida.Length && textoBienvenida[indexLetra] == ' ')
                {
                    tbBienvenida.Text += ' ';
                }
            }
            else
            {
                timer.Stop();
            }
        }
    }
}
