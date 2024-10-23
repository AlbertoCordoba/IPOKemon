using System;
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
    public sealed partial class PokeData : Page
    {
        private iPokemon pokemon;

        Frame frame = Window.Current.Content as Frame;
        public PokeData()
        {
            this.InitializeComponent();
        }
        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            // Comprueba si hay alguna página en el historial de navegación para retroceder
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var pokemon = e.Parameter as iPokemon;
            var pokemon1 = e.Parameter as iPokemon1;
            var pokemon2 = e.Parameter as iPokemon2;

            if (pokemon != null)
            {
                tbNombre.Text = "Nombre: " + pokemon.Nombre;
                tbCategoria.Text = "Categoria: " + pokemon.Categoría;
                tbTipo.Text = "Tipo: " + pokemon.Tipo;
                tbAltura.Text = "Altura: " + pokemon.Altura;
                tbPeso.Text = "Peso: " + pokemon.Peso;
                tbEvolucion.Text = "Evolucion: " + pokemon.Evolucion;
                tbDesc.Text = "Descripción: " + pokemon.Descripcion;
            }
            else if (pokemon1 != null)
            {
                tbNombre.Text = "Nombre: " + pokemon1.Nombre;
                tbCategoria.Text = "Categoria: " + pokemon1.Categoría;
                tbTipo.Text = "Tipo: " + pokemon1.Tipo;
                tbAltura.Text = "Altura: " + pokemon1.Altura;
                tbPeso.Text = "Peso: " + pokemon1.Peso;
                tbEvolucion.Text = "Evolucion: " + pokemon1.Evolucion;
                tbDesc.Text = "Descripción: " + pokemon1.Descripcion;
            }
            else if (pokemon2 != null)
            {
                tbNombre.Text = "Nombre: " + pokemon2.Nombre;
                tbCategoria.Text = "Categoria: " + pokemon2.Categoría;
                tbTipo.Text = "Tipo: " + pokemon2.Tipo;
                tbAltura.Text = "Altura: " + pokemon2.Altura;
                tbPeso.Text = "Peso: " + pokemon2.Peso;
                tbEvolucion.Text = "Evolucion: " + pokemon2.Evolucion;
                tbDesc.Text = "Descripción: " + pokemon2.Descripcion;
            }
        }
    }
}
