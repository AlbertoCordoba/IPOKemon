using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Claims;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPOkemon
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MisPokemon : Page
    {

        Frame frame = Window.Current.Content as Frame;

        public MisPokemon()
        {
            this.InitializeComponent();
            AronControl.Loaded += AronControl_Loaded;
            AzumarillControl.Loaded += AzumarillControl_Loaded;
            CharmanderControl.Loaded += CharmanderControl_Loaded;

        }
        private void CharmanderControl_Loaded(object sender, RoutedEventArgs e)
        {
            CharmanderControl.verFondo(false);
            CharmanderControl.verFilaVida(false);
            CharmanderControl.verFilaEnergia(false);
            CharmanderControl.verPocionVida(false);
            CharmanderControl.verPocionEnergia(false);
            CharmanderControl.verNombre(false);
            CharmanderControl.verCorazon(false);
            CharmanderControl.verEscudo(false);


        }
        private void AronControl_Loaded(object sender, RoutedEventArgs e)
        {
            AronControl.verFondo(false);
            AronControl.verFilaVida(false);
            AronControl.verFilaEnergia(false);
            AronControl.verPocionVida(false);
            AronControl.verPocionEnergia(false);
            AronControl.verNombre(false);
            AronControl.verCorazon(false);
            AronControl.verEscudo(false);

        }
        private void AzumarillControl_Loaded(object sender, RoutedEventArgs e)
        {
            AzumarillControl.verFondo(false);
            AzumarillControl.verFilaVida(false);
            AzumarillControl.verFilaEnergia(false);
            AzumarillControl.verPocionVida(false);
            AzumarillControl.verPocionEnergia(false);
            AzumarillControl.verNombre(false);
            AzumarillControl.verCorazon(false);
            AzumarillControl.verEscudo(false);

        }
        
        private void btnCharmander_Click(object sender, RoutedEventArgs e)
        {
            CharmanderFJDR charmander = new CharmanderFJDR();
            this.Frame.Navigate(typeof(PokeData), charmander);
        }

        private void btnAzumarill_Click(object sender, RoutedEventArgs e)
        {
            AzumarillACR azumarill = new AzumarillACR();
            this.Frame.Navigate(typeof(PokeData), azumarill);
        }

        private void btnAron_Click(object sender, RoutedEventArgs e)
        {
            AronMCC aron = new AronMCC();
            this.Frame.Navigate(typeof(PokeData), aron);
        }
    }
}