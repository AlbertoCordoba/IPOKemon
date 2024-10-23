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

namespace IPOkemon
{
    public sealed partial class PokeDex : Page
    {
        Frame frame = Window.Current.Content as Frame;
        public PokeDex()
        {
            this.InitializeComponent();
            DracoControl.Loaded += DracoControl_Loaded;
            DragoControl.Loaded += DragoControl_Loaded;
            GengarControl.Loaded += GengarControl_Loaded;
            PiplupControl.Loaded += PiplupControl_Loaded;
            AronControl.Loaded += AronControl_Loaded;
            ButterControl.Loaded += ButterControl_Loaded;
            ArticunoControl.Loaded += ArticunoControl_Loaded;
            AzumarillControl.Loaded += AzumarillControl_Loaded;
            ChandelureControl.Loaded += ChandelureControl_Loaded;
            CharizardControl.Loaded += CharizardControl_Loaded;
            CharmanderControl.Loaded += CharmanderControl_Loaded;
            MakuhitaControl.Loaded += MakuhitaControl_Loaded;




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

        }
        private void AronControl_Click(object sender, RoutedEventArgs e)
        {
            // Obtén la información del Pokémon Aron
            AronMCC aron = new AronMCC();

            // Actualiza la información en la página PokeDex
            Nombre_txt.Text = aron.Nombre;
            Descripcion_txt.Text = aron.Descripcion;
            Tipo_txt.Text = aron.Tipo;
            Categoria_txt.Text = aron.Categoría;
            Altura_txt.Text = aron.Altura.ToString();
            Peso_txt.Text = aron.Peso.ToString();
        }

        private void ArticunoControl_Click(object sender, RoutedEventArgs e)
        {
            ArticunoACG articuno = new ArticunoACG();
            Nombre_txt.Text = articuno.Nombre;
            Descripcion_txt.Text = articuno.Descripcion;
            Tipo_txt.Text = articuno.Tipo;
            Categoria_txt.Text = articuno.Categoría;
            Altura_txt.Text = articuno.Altura.ToString();
            Peso_txt.Text = articuno.Peso.ToString();
        }

        private void AzumarillControl_Click(object sender, RoutedEventArgs e)
        {
            AzumarillACR azumarill = new AzumarillACR();
            Nombre_txt.Text = azumarill.Nombre;
            Descripcion_txt.Text = azumarill.Descripcion;
            Tipo_txt.Text = azumarill.Tipo;
            Categoria_txt.Text = azumarill.Categoría;
            Altura_txt.Text = azumarill.Altura.ToString();
            Peso_txt.Text = azumarill.Peso.ToString();
        }

        private void CharizardControl_Click(object sender, RoutedEventArgs e)
        {
            CharizardASM charizard = new CharizardASM();
            Nombre_txt.Text = charizard.Nombre;
            Descripcion_txt.Text = charizard.Descripcion;
            Tipo_txt.Text = charizard.Tipo;
            Categoria_txt.Text = charizard.Categoría;
            Altura_txt.Text = charizard.Altura.ToString();
            Peso_txt.Text = charizard.Peso.ToString();
        }

        private void ChandelureControl_Click(object sender, RoutedEventArgs e)
        {
            ChandelureNDAA chandelure = new ChandelureNDAA();
            Nombre_txt.Text = chandelure.Nombre;
            Descripcion_txt.Text = chandelure.Descripcion;
            Tipo_txt.Text = chandelure.Tipo;
            Categoria_txt.Text = chandelure.Categoría;
            Altura_txt.Text = chandelure.Altura.ToString();
            Peso_txt.Text = chandelure.Peso.ToString();
        }

        private void ButterControl_Click(object sender, RoutedEventArgs e)
        {
            ButterFreeACC butterFree = new ButterFreeACC();
            Nombre_txt.Text = butterFree.Nombre;
            Descripcion_txt.Text = butterFree.Descripcion;
            Tipo_txt.Text = butterFree.Tipo;
            Categoria_txt.Text = butterFree.Categoría;
            Altura_txt.Text = butterFree.Altura.ToString();
            Peso_txt.Text = butterFree.Peso.ToString();
        }

        private void CharmanderControl_Click(object sender, RoutedEventArgs e)
        {
            CharmanderFJDR charmander = new CharmanderFJDR();
            Nombre_txt.Text = charmander.Nombre;
            Descripcion_txt.Text = charmander.Descripcion;
            Tipo_txt.Text = charmander.Tipo;
            Categoria_txt.Text = charmander.Categoría;
            Altura_txt.Text = charmander.Altura.ToString();
            Peso_txt.Text = charmander.Peso.ToString();
        }

        private void DracoControl_Click(object sender, RoutedEventArgs e)
        {
            DracofireGDLRS dracofire = new DracofireGDLRS();
            Nombre_txt.Text = dracofire.Nombre;
            Descripcion_txt.Text = dracofire.Descripcion;
            Tipo_txt.Text = dracofire.Tipo;
            Categoria_txt.Text = dracofire.Categoría;
            Altura_txt.Text = dracofire.Altura.ToString();
            Peso_txt.Text = dracofire.Peso.ToString();
        }

        private void DragoControl_Click(object sender, RoutedEventArgs e)
        {
            DragoniteCSD dragonite = new DragoniteCSD();
            Nombre_txt.Text = dragonite.Nombre;
            Descripcion_txt.Text = dragonite.Descripcion;
            Tipo_txt.Text = dragonite.Tipo;
            Categoria_txt.Text = dragonite.Categoria;
            Altura_txt.Text = dragonite.Altura.ToString();
            Peso_txt.Text = dragonite.Peso.ToString();
        }

        private void MakuhitaControl_Click(object sender, RoutedEventArgs e)
        {
            MakuhitaAPQ2 makuhita = new MakuhitaAPQ2();
            Nombre_txt.Text = makuhita.Nombre;
            Descripcion_txt.Text = makuhita.Descripcion;
            Tipo_txt.Text = makuhita.Tipo;
            Categoria_txt.Text = makuhita.Categoría;
            Altura_txt.Text = makuhita.Altura.ToString();
            Peso_txt.Text = makuhita.Peso.ToString();
        }

        private void GengarControl_Click(object sender, RoutedEventArgs e)
        {
            GengarJCC gengar = new GengarJCC();
            Nombre_txt.Text = gengar.Nombre;
            Descripcion_txt.Text = gengar.Descripcion;
            Tipo_txt.Text = gengar.Tipo;
            Categoria_txt.Text = gengar.Categoría;
            Altura_txt.Text = gengar.Altura.ToString();
            Peso_txt.Text = gengar.Peso.ToString();
        }

        private void PiplupControl_Click(object sender, RoutedEventArgs e)
        {
            PiplupMLTN piplup = new PiplupMLTN();
            Nombre_txt.Text = piplup.Nombre;
            Descripcion_txt.Text = piplup.Descripcion;
            Tipo_txt.Text = piplup.Tipo;
            Categoria_txt.Text = piplup.Categoría;
            Altura_txt.Text = piplup.Altura.ToString();
            Peso_txt.Text = piplup.Peso.ToString();
        }
        // Añade un campo para almacenar todos los Pokémon
        private List<Button> allPokemon;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // Llenar el ComboBox con las categorías de Pokémon
            var categories = new List<string> { "Todos", "Roca", "Volador", "Agua", "Fuego", "Lucha", "Veneno" };
            foreach (var category in categories)
            {
                CategoryComboBox.Items.Add(category);
            }

            // Almacenar todos los Pokémon
            allPokemon = PokemonFlipView.Items.Cast<Button>().ToList();
        }

        private void CategoryComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string category = CategoryComboBox.SelectedItem.ToString();

            List<Button> filteredPokemon;

            if (category == "Todos")
            {
                // Si la categoría seleccionada es "Todos", usar todos los Pokémon
                filteredPokemon = allPokemon;
            }
            else
            {
                // Filtrar los Pokémon en el FlipView basándose en la categoría
                filteredPokemon = allPokemon.Where(b =>
                {
                    var pokemon = b.Content;

                    switch (category)
                    {
                        case "Roca":
                            return pokemon is AronMCC;
                        case "Volador":
                            return pokemon is ArticunoACG || pokemon is CharizardASM || pokemon is ButterFreeACC || pokemon is DragoniteCSD;
                        case "Agua":
                            return pokemon is AzumarillACR || pokemon is PiplupMLTN;
                        case "Fuego":
                            return pokemon is CharizardASM || pokemon is ChandelureNDAA || pokemon is CharmanderFJDR || pokemon is DracofireGDLRS;
                        case "Lucha":
                            return pokemon is MakuhitaAPQ2;
                        case "Veneno":
                            return pokemon is GengarJCC;
                        default:
                            return false;
                    }
                }).ToList();
            }

            // Limpiar el FlipView y agregar los Pokémon filtrados
            PokemonFlipView.Items.Clear();
            foreach (var pokemon in filteredPokemon)
            {
                PokemonFlipView.Items.Add(pokemon);
            }
        }
    }
}