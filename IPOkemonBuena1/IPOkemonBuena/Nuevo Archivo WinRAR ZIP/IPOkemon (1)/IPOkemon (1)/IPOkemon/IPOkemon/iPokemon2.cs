﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace IPOkemon
{
    interface iPokemon2
    {
        public double Vida { get; set; }
        public double Energia { get; set; }
        public string Nombre { get; set; } //Nombre del Pokemon
        public string Categoría { get; set; } //Gas, Murciélago, Ratón..
        public string Tipo { get; set; } //Eléctrico, Veneno, Volador...
        public double Altura { get; set; } // En metros
        public double Peso { get; set; } // En kilos
        public string Evolucion { get; set; } // Nombre de la evolución o evoluciones
        public string Descripcion { get; set; } // Entre 200 y 500 caracteres

        public void verFondo(bool ver);
        public void verFilaVida(bool ver);
        public void verFilaEnergia(bool ver);
        public void verPocionVida(object sender, PointerRoutedEventArgs e);
        public void verPocionEnergia(object sender, PointerRoutedEventArgs e);
        public void verNombre(bool ver);

        public void activarAniIdle(bool activar);
        public void animacionAtaqueFlojo(object sender, RoutedEventArgs e);
        public void animacionAtaqueFuerte(object sender, RoutedEventArgs e);
        public void animacionDefensa(object sender, RoutedEventArgs e);
        public void animacionDescasar(object sender, object e);

        public void animacionCansado(object sender, RoutedEventArgs e);
        public void animacionNoCansado();
        public void animacionHerido(object sender, RoutedEventArgs e);
        public void animacionNoHerido();
        public void animacionDerrota(object sender, RoutedEventArgs e);

    }
}
