using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
	public sealed partial class SeleccionarPokemon : Page
	{
		int numJugadores;


		private Border lastSelectedPokemonP1 = null;
		private Border lastSelectedPokemonP2 = null;
		private Brush defaultBorderBrush;
		private Brush defaultBackground;


		public SeleccionarPokemon()
		{
			this.InitializeComponent();
			DracoControl.Loaded += DracoControl_Loaded;
			DragoControl.Loaded += DragoControl_Loaded;
			GengarControl.Loaded += GengarControl_Loaded;
            MakuhitaControl.Loaded += MakuhitaControl_Loaded;
            PiplupControl.Loaded += PiplupControl_Loaded;
			AronControl.Loaded += AronControl_Loaded;
			ButterControl.Loaded += ButterControl_Loaded;
			ArticunoControl.Loaded += ArticunoControl_Loaded;
			AzumarillControl.Loaded += AzumarillControl_Loaded;
			ChandelureControl.Loaded += ChandelureControl_Loaded;
			CharizardControl.Loaded += CharizardControl_Loaded;
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
			CharmanderControl1.verFondo(false);
			CharmanderControl1.verFilaVida(false);
			CharmanderControl1.verFilaEnergia(false);
			CharmanderControl1.verPocionVida(false);
			CharmanderControl1.verPocionEnergia(false);
			CharmanderControl1.verNombre(false);
			CharmanderControl1.verCorazon(false);
			CharmanderControl1.verEscudo(false);


		}

		private void CharizardControl_Loaded(object sender, RoutedEventArgs e)
		{
			CharizardControl.verFondo(false);
			CharizardControl.verFilaVida(false);
			CharizardControl.verFilaEnergia(false);
			CharizardControl.verPocionVida(false);
			CharizardControl.verPocionEnergia(false);
			CharizardControl.verNombre(false);
			CharizardControl.verCorazon(false);
			CharizardControl.verEscudo(false);
			CharizardControl1.verFondo(false);
			CharizardControl1.verFilaVida(false);
			CharizardControl1.verFilaEnergia(false);
			CharizardControl1.verPocionVida(false);
			CharizardControl1.verPocionEnergia(false);
			CharizardControl1.verNombre(false);
			CharizardControl1.verCorazon(false);
			CharizardControl1.verEscudo(false);

		}
        private void MakuhitaControl_Loaded(object sender, RoutedEventArgs e)
        {
            MakuhitaControl.verFondo(false);
            MakuhitaControl.verFilaVida(false);
            MakuhitaControl.verFilaEnergia(false);
            MakuhitaControl.verPocionVida(false);
            MakuhitaControl.verPocionEnergia(false);
            MakuhitaControl.verNombre(false);
            MakuhitaControl.verCorazon(false);
            MakuhitaControl.verEscudo(false);

            MakuhitaControl1.verFondo(false);
            MakuhitaControl1.verFilaVida(false);
            MakuhitaControl1.verFilaEnergia(false);
            MakuhitaControl1.verPocionVida(false);
            MakuhitaControl1.verPocionEnergia(false);
            MakuhitaControl1.verNombre(false);
            MakuhitaControl1.verCorazon(false);
            MakuhitaControl1.verEscudo(false);
        }
        private void ArticunoControl_Loaded(object sender, RoutedEventArgs e)
		{
			ArticunoControl.verFondo(false);
			ArticunoControl.verFilaVida(false);
			ArticunoControl.verFilaEnergia(false);
			ArticunoControl.verPocionVida(false);
			ArticunoControl.verPocionEnergia(false);
			ArticunoControl.verNombre(false);
			ArticunoControl.verCorazon(false);
			ArticunoControl.verEscudo(false);
			ArticunoControl1.verFondo(false);
			ArticunoControl1.verFilaVida(false);
			ArticunoControl1.verFilaEnergia(false);
			ArticunoControl1.verPocionVida(false);
			ArticunoControl1.verPocionEnergia(false);
			ArticunoControl1.verNombre(false);
			ArticunoControl1.verCorazon(false);
			ArticunoControl1.verEscudo(false);

		}
		private void ChandelureControl_Loaded(object sender, RoutedEventArgs e)
		{
			ChandelureControl.verFondo(false);
			ChandelureControl.verFilaVida(false);
			ChandelureControl.verFilaEnergia(false);
			ChandelureControl.verPocionVida(false);
			ChandelureControl.verPocionEnergia(false);
			ChandelureControl.verNombre(false);
			ChandelureControl.verCorazon(false);
			ChandelureControl.verEscudo(false);
			ChandelureControl1.verFondo(false);
			ChandelureControl1.verFilaVida(false);
			ChandelureControl1.verFilaEnergia(false);
			ChandelureControl1.verPocionVida(false);
			ChandelureControl1.verPocionEnergia(false);
			ChandelureControl1.verNombre(false);
			ChandelureControl1.verCorazon(false);
			ChandelureControl1.verEscudo(false);

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
			AzumarillControl1.verFondo(false);
			AzumarillControl1.verFilaVida(false);
			AzumarillControl1.verFilaEnergia(false);
			AzumarillControl1.verPocionVida(false);
			AzumarillControl1.verPocionEnergia(false);
			AzumarillControl1.verNombre(false);
			AzumarillControl1.verCorazon(false);
			AzumarillControl1.verEscudo(false);

		}
		private void ButterControl_Loaded(object sender, RoutedEventArgs e)
		{
			ButterControl.verFondo(false);
			ButterControl.verFilaVida(false);
			ButterControl.verFilaEnergia(false);
			ButterControl.verPocionVida(false);
			ButterControl.verPocionEnergia(false);
			ButterControl.verNombre(false);
			ButterControl.verCorazon(false);
			ButterControl.verEscudo(false);
			ButterControl1.verFondo(false);
			ButterControl1.verFilaVida(false);
			ButterControl1.verFilaEnergia(false);
			ButterControl1.verPocionVida(false);
			ButterControl1.verPocionEnergia(false);
			ButterControl1.verNombre(false);
			ButterControl1.verCorazon(false);
			ButterControl1.verEscudo(false);


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
			AronControl1.verFondo(false);
			AronControl1.verFilaVida(false);
			AronControl1.verFilaEnergia(false);
			AronControl1.verPocionVida(false);
			AronControl1.verPocionEnergia(false);
			AronControl1.verNombre(false);
			AronControl1.verCorazon(false);
			AronControl1.verEscudo(false);

		}

		private void DracoControl_Loaded(object sender, RoutedEventArgs e)
		{
			DracoControl.verFondo(false);
			DracoControl.verFilaVida(false);
			DracoControl.verFilaEnergia(false);
			DracoControl.verPocionVida(false);
			DracoControl.verPocionEnergia(false);
			DracoControl.verNombre(false);
			DracoControl.verCorazon(false);
			DracoControl.verEscudo(false);
			DracoControl1.verFondo(false);
			DracoControl1.verFilaVida(false);
			DracoControl1.verFilaEnergia(false);
			DracoControl1.verPocionVida(false);
			DracoControl1.verPocionEnergia(false);
			DracoControl1.verNombre(false);
			DracoControl1.verCorazon(false);
			DracoControl1.verEscudo(false);

		}
		private void DragoControl_Loaded(object sender, RoutedEventArgs e)
		{
			DragoControl.VerFondo(false);
			DragoControl.VerFilaVida(false);
			DragoControl.VerFilaEnergia(false);
			DragoControl.VerPocionVida(false);
			DragoControl.VerPocionEnergia(false);
			DragoControl.VerNombre(false);
			DragoControl.verCorazon(false);
			DragoControl.verEscudo(false);
			DragoControl1.VerFondo(false);
			DragoControl1.VerFilaVida(false);
			DragoControl1.VerFilaEnergia(false);
			DragoControl1.VerPocionVida(false);
			DragoControl1.VerPocionEnergia(false);
			DragoControl1.VerNombre(false);
			DragoControl1.verCorazon(false);
			DragoControl1.verEscudo(false);
		}

		private void GengarControl_Loaded(object sender, RoutedEventArgs e)
		{
			GengarControl.verFondo(false);
			GengarControl.verFilaVida(false);
			GengarControl.verFilaEnergia(false);
			GengarControl.verPocionVida(false);
			GengarControl.verPocionEnergia(false);
			GengarControl.verNombre(false);
			GengarControl.verCorazon(false);
			GengarControl.verEscudo(false);
			GengarControl1.verFondo(false);
			GengarControl1.verFilaVida(false);
			GengarControl1.verFilaEnergia(false);
			GengarControl1.verPocionVida(false);
			GengarControl1.verPocionEnergia(false);
			GengarControl1.verNombre(false);
			GengarControl1.verCorazon(false);
			GengarControl1.verEscudo(false);
		}
        private void PiplupControl_Loaded(object sender, RoutedEventArgs e)
        {
            PiplupControl.verFondo(false);
            PiplupControl.verFilaVida(false);
            PiplupControl.verFilaEnergia(false);
            PiplupControl.verPocionVida(false);
            PiplupControl.verPocionEnergia(false);
            PiplupControl.verNombre(false);
            PiplupControl.verCorazon(false);
            PiplupControl.verEscudo(false);

            PiplupControl1.verFondo(false);
            PiplupControl1.verFilaVida(false);
            PiplupControl1.verFilaEnergia(false);
            PiplupControl1.verPocionVida(false);
            PiplupControl1.verPocionEnergia(false);
            PiplupControl1.verNombre(false);
            PiplupControl1.verCorazon(false);
            PiplupControl1.verEscudo(false);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            numJugadores = (int)e.Parameter;

          

            PersonalizarPagina();
        }
        private void PersonalizarPagina()
        {
            if (numJugadores == 1)
            {
                txtJugador2.Text = "CPU";
                SeleccionarPokemonCPU();
            }
            else

                txtJugador2.Text = "Jugador 2";

        }
        private void SeleccionarPokemonCPU()
        {
            var borders = new List<Border> { borderAronP2, borderArticunoP2, borderAzumarillP2, borderCharizardP2, borderChandelureP2, borderButterFreeP2, borderCharmanderP2, borderDracofireP2, borderDragoniteeP2, borderMakuhitaP2, borderGengarP2, borderPiplupP2 };
            var buttons = new List<Button> { btnAronP2, btnArticunoP2, btnAzumarillP2, btnCharizardP2, btnChandelureP2, btnButterFreeP2, btnCharmanderP2, btnDracofireP2, btnDragoniteeP2, btnMakuhitaP2, btnGengarP2, btnPiplupP2 };
            Random rnd = new Random();
            int selectedIndex = rnd.Next(borders.Count);

            for (int i = 0; i < borders.Count; i++)
            {
                if (i == selectedIndex)
                {
                    borders[i].Background = new SolidColorBrush(Colors.NavajoWhite);
                    buttons[i].IsEnabled = false;
                    lastSelectedPokemonP2 = borders[i];

                    // Establece el elemento seleccionado en el Pokémon seleccionado
                    flipViewJugador2.SelectedIndex = selectedIndex;

                    // Llama a los métodos Loaded dependiendo del Pokémon seleccionado
                    switch (selectedIndex)
                    {
                        case 0: // Aron
                            AronControl_Loaded(null, null);
                            break;
                        case 1: // Articuno
                            ArticunoControl_Loaded(null, null);
                            break;
                        case 2: // Azumarill
                            AzumarillControl_Loaded(null, null);
                            break;
                        case 3: // Charizard
                            CharizardControl_Loaded(null, null);
                            break;
                        case 4: // Chandelure
                            ChandelureControl_Loaded(null, null);
                            break;
                        case 5: // ButterFree
                            ButterControl_Loaded(null, null);
                            break;
                        case 6: // Charmander
                            CharmanderControl_Loaded(null, null);
                            break;
                        case 7: // Dracofire
                            DracoControl_Loaded(null, null);
                            break;
                        case 8: // Dragonitee
                            DragoControl_Loaded(null, null);
                            break;
                        case 9: // Makuhita
                            MakuhitaControl_Loaded(null, null);
                            break;
                        case 10: // Gengar
                            GengarControl_Loaded(null, null);
                            break;
                        case 11: // Piplup
                            PiplupControl_Loaded(null, null);
                            break;
                    }

                    flipViewJugador2.IsHitTestVisible = false;
                    flipViewJugador2.IsEnabled = false;
                }
            }
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
		{
			// Comprueba si hay alguna página en el historial de navegación para retroceder
			if (this.Frame.CanGoBack)
			{
				this.Frame.GoBack();
			}
		}

		private async void btnComenzarBatalla_Click(object sender, RoutedEventArgs e)
		{
			// Comprobar que los dos jugadores han seleccionado un Pokémon
			if (lastSelectedPokemonP1 == null || (numJugadores == 2 && lastSelectedPokemonP2 == null))
			{
				// Mostrar un mensaje de error
				var dialog = new Windows.UI.Popups.MessageDialog("Ambos jugadores deben seleccionar un Pokemon antes de comenzar la batalla.");
				await dialog.ShowAsync();
			}
			else
			{
				// Obtener los nombres de los Pokémon seleccionados
				string pokemonP1 = lastSelectedPokemonP1.Name.Replace("border", "").Replace("P1", "");

				string pokemonP2 = lastSelectedPokemonP2.Name.Replace("border", "").Replace("P2", "");

				// Cambiamos al siguiente frame pasando los datos como parámetros
				Frame.Navigate(typeof(PaginaPrueba), new Tuple<int, string, string>(numJugadores, pokemonP1, pokemonP2));
			}
		}

		private void SelectPokemonP1(Button clickedButton, Border border)
		{
			if (lastSelectedPokemonP1 != null)
			{
				// Restaurar la apariencia del Pokémon anteriormente seleccionado.
				lastSelectedPokemonP1.Background = defaultBackground;
			}

			// Resaltar el Pokémon seleccionado.
			border.Background = new SolidColorBrush(Colors.Blue);

			// Recordar la última selección.
			lastSelectedPokemonP1 = border;
		}

		private void SelectPokemonP2(Button clickedButton, Border border)
		{
			if (lastSelectedPokemonP2 != null)
			{
				// Restaurar la apariencia del Pokémon anteriormente seleccionado.
				lastSelectedPokemonP2.Background = defaultBackground;
			}

			// Resaltar el Pokémon seleccionado.
			border.Background = new SolidColorBrush(Colors.Red);

			// Recordar la última selección.
			lastSelectedPokemonP2 = border;
		}

		private void btnAronP1_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP1(btnAronP1, borderAronP1);

		}

		private void btnArticunoP1_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP1(btnArticunoP1, borderArticunoP1);
		}


		private void btnAzumarillP1_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP1(btnAzumarillP1, borderAzumarillP1);
		}

		private void btnCharizardP1_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP1(btnCharizardP1, borderCharizardP1);
		}

		private void btnChandelureP1_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP1(btnChandelureP1, borderChandelureP1);
		}

		private void btnButterFreeP1_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP1(btnButterFreeP1, borderButterFreeP1);
		}

		private void btnCharmanderP1_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP1(btnCharmanderP1, borderCharmanderP1);
		}

		private void btnDracofireP1_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP1(btnDracofireP1, borderDracofireP1);
		}

		private void btnDragoniteP1_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP1(btnDragoniteeP1, borderDragoniteeP1);
		}
		private void btnMakuhitaP1_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP1(btnMakuhitaP1, borderMakuhitaP1);
		}

		private void btnGengarP1_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP1(btnGengarP1, borderGengarP1);
		}

		private void btnPiplupP1_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP1(btnPiplupP1, borderPiplupP1);
		}
		private void btnAronP2_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP2(btnAronP2, borderAronP2);
		}

		private void btnArticunoP2_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP2(btnArticunoP2, borderArticunoP2);
		}

		private void btnAzumarillP2_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP2(btnAzumarillP2, borderAzumarillP2);
		}

		private void btnCharizardP2_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP2(btnCharizardP2, borderCharizardP2);
		}

		private void btnChandelureP2_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP2(btnChandelureP2, borderChandelureP2);
		}

		private void btnButterFreeP2_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP2(btnButterFreeP2, borderButterFreeP2);
		}

		private void btnCharmanderP2_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP2(btnCharmanderP2, borderCharmanderP2);
		}

		private void btnDracofireP2_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP2(btnDracofireP2, borderDracofireP2);
		}

		private void btnDragoniteP2_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP2(btnDragoniteeP2, borderDragoniteeP2);
		}

		private void btnMakuhitaP2_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP2(btnMakuhitaP2, borderMakuhitaP2);
		}

		private void btnGengarP2_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP2(btnGengarP2, borderGengarP2);
		}

		private void btnPiplupP2_Click(object sender, RoutedEventArgs e)
		{
			SelectPokemonP2(btnPiplupP2, borderPiplupP2);
		}


    }
}