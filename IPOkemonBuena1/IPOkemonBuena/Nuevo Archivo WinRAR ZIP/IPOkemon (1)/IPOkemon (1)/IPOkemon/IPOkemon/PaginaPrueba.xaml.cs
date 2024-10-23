using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
using Windows.Media.Playback;
using Windows.Storage;
using Windows.UI.Xaml.Navigation;
using System.Windows;
using System.Threading.Tasks;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPOkemon
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class PaginaPrueba : Page
    {

        const int VIDA_CRITICA = 8;
        private MediaPlayer mediaPlayer;
        Frame frame = Window.Current.Content as Frame;
        private int numJugadores;
        private int tokenTurno;
        private UserControl Pokemon1;
        private UserControl Pokemon2;
        private string nombrePokemon1;
        private string nombrePokemon2;
        private UserControl CBotones1;
        private UserControl CBotones2;
        public PaginaPrueba()
        {
            this.InitializeComponent();
            tokenTurno = 1;
        }

        private void rendirse1(object sender, RoutedEventArgs e)
        {
            DeshabilitarBotones();
             mostrarGanador("JUGADOR 2", nombrePokemon2);
        }

        private void rendirse2(object sender, RoutedEventArgs e)
        {
            DeshabilitarBotones();
             mostrarGanador("JUGADOR 1", nombrePokemon1);
        }

private void mostrarGanador(string jugadorGanador, string nombrePokemon)
    {
        string tituloVictoria = $"¡{jugadorGanador} gana!";
        string textoVictoria = $"El Pokémon del {jugadorGanador}, {nombrePokemon}, ha ganado la batalla.";

        // Crear el XML de la notificación
        string toastXml = $@"
    <toast>
        <visual>
            <binding template='ToastGeneric'>
                <text>{tituloVictoria}</text>
                <text>{textoVictoria}</text>
            </binding>
        </visual>
    </toast>";

        // Crear la notificación y mostrarla
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(toastXml);
        ToastNotification notification = new ToastNotification(doc);
        ToastNotificationManager.CreateToastNotifier().Show(notification);

        // Navegar a la página de Combate
        this.Frame.Navigate(typeof(Combate));
    }
    private void DeshabilitarBotones()
        {
            btnAtaqueFuerte.IsEnabled = false;
            btnAtaqueFlojo.IsEnabled = false;
            btnRendirse1.IsEnabled = false;
            btnActivarEscudo.IsEnabled = false;
            btnAtaqueFuerte1.IsEnabled = false;
            btnAtaqueFlojo1.IsEnabled = false;
            btnRendirse2.IsEnabled = false;
            btnActivarEscudo1.IsEnabled = false;
        }

        private void HabilitarBotones()
        {
            btnAtaqueFuerte.IsEnabled = true;
            btnAtaqueFlojo.IsEnabled = true;
            btnRendirse1.IsEnabled = true;
            btnActivarEscudo.IsEnabled = true;
            btnAtaqueFuerte1.IsEnabled = true;
            btnAtaqueFlojo1.IsEnabled = true;
            btnRendirse2.IsEnabled = true;
            btnActivarEscudo1.IsEnabled = true;
        }


        private void pokemon1AtaqueRealizado(object sender, AtaqueEventArgs e)
        {
            // Obtener la cantidad de daño del ataque
            int cantidadDanio = e.CantidadDanio;
            
            double vida = 100;
          
     

            //Le quitamos vida al pokemon 2
            switch (nombrePokemon2)
            {
                case "Charmander":
                    ((CharmanderFJDR)Pokemon2).recibirDaño(cantidadDanio);
                  
                    vida = ((CharmanderFJDR)Pokemon2).Vida;
                 
                    break;
                case "Aron":
                    ((AronMCC)Pokemon2).recibirDaño(cantidadDanio);
                   
                    vida = ((AronMCC)Pokemon2).Vida;
                    break;
                case "Gengar":
                    ((GengarJCC)Pokemon2).recibirDaño(cantidadDanio);
           
                    vida = ((GengarJCC)Pokemon2).Vida;
                    break;
                case "Azumarill":
                    ((AzumarillACR)Pokemon2).recibirDaño(cantidadDanio);
                   
                    vida = ((AzumarillACR)Pokemon2).Vida;
                    break;
                case "Articuno":
                    ((ArticunoACG)Pokemon2).recibirDaño(cantidadDanio);
                 
                    vida = ((ArticunoACG)Pokemon2).Vida;
                    break;
                case "ButterFree":
                    ((ButterFreeACC)Pokemon2).recibirDaño(cantidadDanio);
                
                    vida = ((ButterFreeACC)Pokemon2).Vida;
                    break;
                case "Chandelure":
                    ((ChandelureNDAA)Pokemon2).recibirDaño(cantidadDanio);
                  
                    vida = ((ChandelureNDAA)Pokemon2).Vida;
                    break;
                case "Charizard":
                    ((CharizardASM)Pokemon2).recibirDaño(cantidadDanio);
              
                    vida = ((CharizardASM)Pokemon2).Vida;
                    break;
                case "Dracofire":
                    ((DracofireGDLRS)Pokemon2).recibirDaño(cantidadDanio);
                  
                    vida = ((DracofireGDLRS)Pokemon2).Vida;
                    break;
                case "Dragonitee":
                    ((DragoniteCSD)Pokemon2).recibirDaño(cantidadDanio);
                  
                    vida = ((DragoniteCSD)Pokemon2).Vida;
                    break;
                case "Makuhita":
                    ((MakuhitaAPQ2)Pokemon2).recibirDaño(cantidadDanio);
               
                    vida = ((MakuhitaAPQ2)Pokemon2).Vida;
                    break;
                case "Piplup":
                    ((PiplupMLTN)Pokemon2).recibirDaño(cantidadDanio);
                 
                    vida = ((PiplupMLTN)Pokemon2).Vida;
                    break;
            }
            switch (nombrePokemon1)
            {
                case "Charmander":
                   
                    ((CharmanderFJDR)Pokemon1).disminuirEnergia(0, 0);
                

                    break;
                case "Aron":
                  
                    ((AronMCC)Pokemon1).disminuirEnergia(0, 0);
         
                    break;
                case "Gengar":
          
                    ((GengarJCC)Pokemon1).disminuirEnergia(0, 0);
            
                    break;
                case "Azumarill":
                   
                    ((AzumarillACR)Pokemon1).disminuirEnergia(0, 0);
           
                    break;
                case "Articuno":
                    ((ArticunoACG)Pokemon1).disminuirEnergia(0, 0);

                    break;
                case "ButterFree":
                   
                    ((ButterFreeACC)Pokemon1).disminuirEnergia(0, 0);
                
                    break;
                case "Chandelure":
                  
                    ((ChandelureNDAA)Pokemon1).disminuirEnergia(0, 0);
             
                    break;
                case "Charizard":
                   
                    ((CharizardASM)Pokemon1).disminuirEnergia(0, 0);
     
                    break;
                case "Dracofire":
                   
                    ((DracofireGDLRS)Pokemon1).disminuirEnergia(0, 0);
         
                    break;
                case "Dragonitee":
                 
                    ((DragoniteCSD)Pokemon1).disminuirEnergia(0, 0);
         
                    break;
                case "Makuhita":
                
                    ((MakuhitaAPQ2)Pokemon1).disminuirEnergia(0, 0);
             
                    break;
                case "Piplup":
                 
                    ((PiplupMLTN)Pokemon1).disminuirEnergia(0, 0);
            
                    break;
            }
            // Si la vida es menor o igual a 0, mostramos el ganador
            if (vida <= 0)
            {
                mostrarGanador("JUGADOR 1", nombrePokemon1);
            }

            else
            {
                // Solo cambiamos el turno si el Pokémon no ha sido derrotado
                cambiarTurno();
            }
        }
        private void pokemon2AtaqueRealizado(object sender, AtaqueEventArgs e)
        {
            // Obtener la cantidad de daño del ataque
            int cantidadDanio = e.CantidadDanio;
            double vida = 100;
          

            //Le quitamos vida al pokemon 1
            switch (nombrePokemon1)
            {
                case "Charmander":
                    ((CharmanderFJDR)Pokemon1).recibirDaño(cantidadDanio);
             
                    vida = ((CharmanderFJDR)Pokemon1).Vida;
                 

                    break;
                case "Aron":
                    ((AronMCC)Pokemon1).recibirDaño(cantidadDanio);
                
                    vida = ((AronMCC)Pokemon1).Vida;
                    break;
                case "Gengar":
                    ((GengarJCC)Pokemon1).recibirDaño(cantidadDanio);
         
                    vida = ((GengarJCC)Pokemon1).Vida;
                    break;
                case "Azumarill":
                    ((AzumarillACR)Pokemon1).recibirDaño(cantidadDanio);
                   
                    vida = ((AzumarillACR)Pokemon1).Vida;
                    break;
                case "Articuno":
                    ((ArticunoACG)Pokemon1).recibirDaño(cantidadDanio);
         
                    vida = ((ArticunoACG)Pokemon1).Vida;
                    break;
                case "ButterFree":
                    ((ButterFreeACC)Pokemon1).recibirDaño(cantidadDanio);
                 
                    vida = ((ButterFreeACC)Pokemon1).Vida;
                    break;
                case "Chandelure":
                    ((ChandelureNDAA)Pokemon1).recibirDaño(cantidadDanio);
               
                    vida = ((ChandelureNDAA)Pokemon1).Vida;
                    break;
                case "Charizard":
                    ((CharizardASM)Pokemon1).recibirDaño(cantidadDanio);
                 
                    vida = ((CharizardASM)Pokemon1).Vida;
                    break;
                case "Dracofire":
                    ((DracofireGDLRS)Pokemon1).recibirDaño(cantidadDanio);
                
                    vida = ((DracofireGDLRS)Pokemon1).Vida;
                    break;
                case "Dragonitee":
                    ((DragoniteCSD)Pokemon1).recibirDaño(cantidadDanio);
                
                    vida = ((DragoniteCSD)Pokemon1).Vida;
                    break;
                case "Makuhita":
                    ((MakuhitaAPQ2)Pokemon1).recibirDaño(cantidadDanio);
              
                    vida = ((MakuhitaAPQ2)Pokemon1).Vida;
                    break;
                case "Piplup":
                    ((PiplupMLTN)Pokemon1).recibirDaño(cantidadDanio);
              
                    vida = ((PiplupMLTN)Pokemon1).Vida;
                    break;
            }

            switch (nombrePokemon2)
            {
                case "Charmander":
                
                    ((CharmanderFJDR)Pokemon2).disminuirEnergia(0, 0);
                

                    break;
                case "Aron":
                  
                    ((AronMCC)Pokemon2).disminuirEnergia(0, 0);
                  
                    break;
                case "Gengar":
               
                    ((GengarJCC)Pokemon2).disminuirEnergia(0, 0);
                
                    break;
                case "Azumarill":
                
                    ((AzumarillACR)Pokemon2).disminuirEnergia(0, 0);
                   
                    break;
                case "Articuno":
                    
                    ((ArticunoACG)Pokemon2).disminuirEnergia(0, 0);
                   
                    break;
                case "ButterFree":
        
                    ((ButterFreeACC)Pokemon2).disminuirEnergia(0, 0);
               
                    break;
                case "Chandelure":
                
                    ((ChandelureNDAA)Pokemon2).disminuirEnergia(0, 0);
                
                    break;
                case "Charizard":
             
                    ((CharizardASM)Pokemon2).disminuirEnergia(0, 0);
                
                    break;
                case "Dracofire":
                
                    ((DracofireGDLRS)Pokemon2).disminuirEnergia(0, 0);
              
                    break;
                case "Dragonitee":
             
                    ((DragoniteCSD)Pokemon2).disminuirEnergia(0, 0);
              
                    break;
                case "Makuhita":
                 
                    ((MakuhitaAPQ2)Pokemon2).disminuirEnergia(0, 0);
                  
                    break;
                case "Piplup":
                   
                    ((PiplupMLTN)Pokemon2).disminuirEnergia(0, 0);
            
                    break;
            }
            // Si la vida es menor o igual a 0, mostramos el ganador
            if (vida <= 0)
            {
                mostrarGanador("JUGADOR 2", nombrePokemon2);
            }

            else
            {
                // Solo cambiamos el turno si el Pokémon no ha sido derrotado
                cambiarTurno();
            }
        }



        Boolean escudoActivado;

        private void btnAtaqueFuerte_Click(object sender, RoutedEventArgs e)
        {
            DeshabilitarBotones();
            // Supongamos que un ataque fuerte hace 20 de daño
            AtaqueEventArgs ataqueEventArgs = new AtaqueEventArgs(escudoActivado ? 0 : 35);

            // Si el escudo está activado, lo desactivamos
            if (escudoActivado)
            {
                escudoActivado = false;
            }

            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            timer.Tick += (s, ev) =>
            {
                // Llama al método de ataque del Pokemon 1
                pokemon1AtaqueRealizado(sender, ataqueEventArgs);
                timer.Stop();
            };
            timer.Start();
        }
        private void btnAtaqueFlojo_Click(object sender, RoutedEventArgs e)
        {
            DeshabilitarBotones();
            AtaqueEventArgs ataqueEventArgs = new AtaqueEventArgs(escudoActivado ? 0 : 15);

            // Si el escudo está activado, lo desactivamos
            if (escudoActivado)
            {
                escudoActivado = false;
            }
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            timer.Tick += (s, ev) =>
            {
                // Llama al método de ataque del Pokemon 1
                pokemon1AtaqueRealizado(sender, ataqueEventArgs);
                timer.Stop();
            };
            timer.Start();
        }
     
        private void btnActivarEscudo_Click(object sender, RoutedEventArgs e)
        {
            DeshabilitarBotones();
            AtaqueEventArgs ataqueEventArgs = new AtaqueEventArgs(0);
            escudoActivado = true;

            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            timer.Tick += (s, ev) =>
            {
                // Llama al método de ataque del Pokemon 1
                pokemon1AtaqueRealizado(sender, ataqueEventArgs);
                timer.Stop();
            };
            timer.Start();
        }

        private void btnAtaqueFuerte1_Click(object sender, RoutedEventArgs e)
        {
            DeshabilitarBotones();
            AtaqueEventArgs ataqueEventArgs = new AtaqueEventArgs(escudoActivado ? 0 : 35);

            // Si el escudo está activado, lo desactivamos
            if (escudoActivado)
            {
                escudoActivado = false;
            }

            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            timer.Tick += (s, ev) =>
            {
                // Llama al método de ataque del Pokemon 1
                pokemon2AtaqueRealizado(sender, ataqueEventArgs);
                timer.Stop();
            };
            timer.Start();
        }

        private void btnAtaqueFlojo1_Click(object sender, RoutedEventArgs e)
        {
            DeshabilitarBotones();
            AtaqueEventArgs ataqueEventArgs = new AtaqueEventArgs(escudoActivado ? 0 : 15);

            // Si el escudo está activado, lo desactivamos
            if (escudoActivado)
            {
                escudoActivado = false;
            }

            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            timer.Tick += (s, ev) =>
            {
                // Llama al método de ataque del Pokemon 1
                pokemon2AtaqueRealizado(sender, ataqueEventArgs);
                timer.Stop();
            };
            timer.Start();
        }
      
        private void btnActivarEscudo1_Click(object sender, RoutedEventArgs e)
        {
            DeshabilitarBotones();
            AtaqueEventArgs ataqueEventArgs = new AtaqueEventArgs(0);
            escudoActivado = true;
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(4) };
            timer.Tick += (s, ev) =>
            {
                // Llama al método de ataque del Pokemon 1
                pokemon2AtaqueRealizado(sender, ataqueEventArgs);
                timer.Stop();
            };
            timer.Start();
        }





        private void cargarControlUsuario1(String pokemon1)
        {

            // En función del pokemon elegido, cargamos el control de usuario correspondiente
            if (pokemon1 == "Charmander")
            {
                Pokemon1 = new CharmanderFJDR();

                ContenedorPokemon1.Content = Pokemon1;
                ((CharmanderFJDR)Pokemon1).verFondo(false);
                ((CharmanderFJDR)Pokemon1).verNombre(false);
                // Asignar los eventos de clic de los botones
                btnAtaqueFuerte.Click += (sender, e) => ((CharmanderFJDR)Pokemon1).animacionAtaqueFuerte(null, null);
                btnAtaqueFlojo.Click += (sender, e) => ((CharmanderFJDR)Pokemon1).animacionAtaqueFlojo(null, null);
              
                btnActivarEscudo.Click += (sender, e) => ((CharmanderFJDR)Pokemon1).animacionDefensa(null, null);

            }
            else if (pokemon1 == "Aron")
            {
                Pokemon1 = new AronMCC();
                ContenedorPokemon1.Content = Pokemon1;
                ((AronMCC)Pokemon1).verFondo(false);
                ((AronMCC)Pokemon1).verNombre(false);
                btnAtaqueFuerte.Click += (sender, e) => ((AronMCC)Pokemon1).animacionAtaqueFuerte(10);
                btnAtaqueFlojo.Click += (sender, e) => ((AronMCC)Pokemon1).animacionAtaqueFlojo(null, null);
               
                btnActivarEscudo.Click += (sender, e) => ((AronMCC)Pokemon1).animacionDefensa(null, null);


            }
            else if (pokemon1 == "Articuno")
            {
                Pokemon1 = new ArticunoACG();

                ContenedorPokemon1.Content = Pokemon1;
                ((ArticunoACG)Pokemon1).verFondo(false);
                ((ArticunoACG)Pokemon1).verNombre(false);
                btnAtaqueFuerte.Click += (sender, e) => ((ArticunoACG)Pokemon1).animacionAtaqueFuerte();
                btnAtaqueFlojo.Click += (sender, e) => ((ArticunoACG)Pokemon1).animacionAtaqueFlojo();
               
                btnActivarEscudo.Click += (sender, e) => ((ArticunoACG)Pokemon1).animacionDefensa();
            }
            else if (pokemon1 == "Azumarill")
            {
                Pokemon1 = new AzumarillACR();
                ContenedorPokemon1.Content = Pokemon1;

                ((AzumarillACR)Pokemon1).verFondo(false);
                ((AzumarillACR)Pokemon1).verNombre(false);

                btnAtaqueFuerte.Click += (sender, e) => ((AzumarillACR)Pokemon1).animacionAtaqueFuerte();
                btnAtaqueFlojo.Click += (sender, e) => ((AzumarillACR)Pokemon1).animacionAtaqueFlojo();
              
                btnActivarEscudo.Click += (sender, e) => ((AzumarillACR)Pokemon1).animacionDefensa();
            }
            else if (pokemon1 == "ButterFree")
            {
                Pokemon1 = new ButterFreeACC();
                ContenedorPokemon1.Content = Pokemon1;
                ((ButterFreeACC)Pokemon1).verFondo(false);
                ((ButterFreeACC)Pokemon1).verNombre(false);
                btnAtaqueFuerte.Click += (sender, e) => ((ButterFreeACC)Pokemon1).animacionAtaqueFuerte();
                btnAtaqueFlojo.Click += (sender, e) => ((ButterFreeACC)Pokemon1).animacionAtaqueFlojo();
              
                btnActivarEscudo.Click += (sender, e) => ((ButterFreeACC)Pokemon1).animacionDefensa();
            }
            else if (pokemon1 == "Chandelure")
            {
                Pokemon1 = new ChandelureNDAA();
                ContenedorPokemon1.Content = Pokemon1;
                ((ChandelureNDAA)Pokemon1).verFondo(false);
                ((ChandelureNDAA)Pokemon1).verNombre(false);
                btnAtaqueFuerte.Click += (sender, e) => ((ChandelureNDAA)Pokemon1).animacionAtaqueFuerte();
                btnAtaqueFlojo.Click += (sender, e) => ((ChandelureNDAA)Pokemon1).animacionAtaqueFlojo();
               
                btnActivarEscudo.Click += (sender, e) => ((ChandelureNDAA)Pokemon1).animacionDefensa();
            }
            else if (pokemon1 == "Dracofire")
            {
                Pokemon1 = new DracofireGDLRS();
                ContenedorPokemon1.Content = Pokemon1;
                ((DracofireGDLRS)Pokemon1).verFondo(false);
                ((DracofireGDLRS)Pokemon1).verNombre(false);
                btnAtaqueFuerte.Click += (sender, e) => ((DracofireGDLRS)Pokemon1).animacionAtaqueFuerte();
                btnAtaqueFlojo.Click += (sender, e) => ((DracofireGDLRS)Pokemon1).animacionAtaqueFlojo();
                
                btnActivarEscudo.Click += (sender, e) => ((DracofireGDLRS)Pokemon1).animacionDefensa();
            }
            else if (pokemon1 == "Dragonitee")
            {
                Pokemon1 = new DragoniteCSD();
                ContenedorPokemon1.Content = Pokemon1;
                ((DragoniteCSD)Pokemon1).VerFondo(false);
                ((DragoniteCSD)Pokemon1).VerNombre(false);
                btnAtaqueFuerte.Click += (sender, e) => ((DragoniteCSD)Pokemon1).AnimacionAtaqueFuerte();
                btnAtaqueFlojo.Click += (sender, e) => ((DragoniteCSD)Pokemon1).AnimacionAtaqueFlojo();
              
                btnActivarEscudo.Click += (sender, e) => ((DragoniteCSD)Pokemon1).AnimacionDefensa();
            }
            else if (pokemon1 == "Gengar")
            {
                Pokemon1 = new GengarJCC();
                ContenedorPokemon1.Content = Pokemon1;
                ((GengarJCC)Pokemon1).verFondo(false);
                ((GengarJCC)Pokemon1).verNombre(false);
                btnAtaqueFuerte.Click += (sender, e) => ((GengarJCC)Pokemon1).animacionAtaqueFuerte();
                btnAtaqueFlojo.Click += (sender, e) => ((GengarJCC)Pokemon1).animacionAtaqueFlojo();
              
                btnActivarEscudo.Click += (sender, e) => ((GengarJCC)Pokemon1).animacionDefensa();
            }
            else if (pokemon1 == "Piplup")
            {
                Pokemon1 = new PiplupMLTN();
                ContenedorPokemon1.Content = Pokemon1;
                ((PiplupMLTN)Pokemon1).verFondo(false);
                ((PiplupMLTN)Pokemon1).verNombre(false);
                btnAtaqueFuerte.Click += (sender, e) => ((PiplupMLTN)Pokemon1).animacionAtaqueFuerte();
                btnAtaqueFlojo.Click += (sender, e) => ((PiplupMLTN)Pokemon1).animacionAtaqueFlojo();
               
                btnActivarEscudo.Click += (sender, e) => ((PiplupMLTN)Pokemon1).animacionDefensa();
            }
            else if (pokemon1 == "Charizard")
            {
                Pokemon1 = new CharizardASM(); // Asegúrate de que 'Charizard' es el nombre correcto de la clase
                ContenedorPokemon1.Content = Pokemon1;
                ((CharizardASM)Pokemon1).verFondo(false);
                ((CharizardASM)Pokemon1).verNombre(false);
                btnAtaqueFuerte.Click += (sender, e) => ((CharizardASM)Pokemon1).animacionAtaqueFuerte();
                btnAtaqueFlojo.Click += (sender, e) => ((CharizardASM)Pokemon1).animacionAtaqueFlojo();
               
                btnActivarEscudo.Click += (sender, e) => ((CharizardASM)Pokemon1).animacionDefensa();
            }
            else if (pokemon1 == "Makuhita")
            {
                Pokemon1 = new MakuhitaAPQ2(); // Asegúrate de que 'Makuhita' es el nombre correcto de la clase
                ContenedorPokemon1.Content = Pokemon1;
                ((MakuhitaAPQ2)Pokemon1).verFondo(false);
                ((MakuhitaAPQ2)Pokemon1).verNombre(false);
                btnAtaqueFuerte.Click += (sender, e) => ((MakuhitaAPQ2)Pokemon1).animacionAtaqueFuerte();
                btnAtaqueFlojo.Click += (sender, e) => ((MakuhitaAPQ2)Pokemon1).animacionAtaqueFlojo();
                
                btnActivarEscudo.Click += (sender, e) => ((MakuhitaAPQ2)Pokemon1).animacionDefensa();
            }
          



        }

        private void cargarControlUsuario2(String pokemon2)
        {
            if (pokemon2 == "Charmander")
            {
                Pokemon2 = new CharmanderFJDR();

                ContenedorPokemon2.Content = Pokemon2;
                ((CharmanderFJDR)Pokemon2).verFondo(false);
                ((CharmanderFJDR)Pokemon2).verNombre(false);
                // Asignar los eventos de clic de los botones
                btnAtaqueFuerte1.Click += (sender, e) => ((CharmanderFJDR)Pokemon2).animacionAtaqueFuerte(null, null);
                btnAtaqueFlojo1.Click += (sender, e) => ((CharmanderFJDR)Pokemon2).animacionAtaqueFlojo(null, null);
               
                btnActivarEscudo1.Click += (sender, e) => ((CharmanderFJDR)Pokemon2).animacionDefensa(null, null);

            }
            else if (pokemon2 == "Aron")
            {
                Pokemon2 = new AronMCC();
                ContenedorPokemon2.Content = Pokemon2;
                ((AronMCC)Pokemon2).verFondo(false);
                ((AronMCC)Pokemon2).verNombre(false);
                btnAtaqueFuerte1.Click += (sender, e) => ((AronMCC)Pokemon2).animacionAtaqueFuerte(10);
                btnAtaqueFlojo1.Click += (sender, e) => ((AronMCC)Pokemon2).animacionAtaqueFlojo(null, null);
               
                btnActivarEscudo1.Click += (sender, e) => ((AronMCC)Pokemon2).animacionDefensa(null, null);


            }
            else if (pokemon2 == "Articuno")
            {
                Pokemon2 = new ArticunoACG();

                ContenedorPokemon2.Content = Pokemon2;
                ((ArticunoACG)Pokemon2).verFondo(false);
                ((ArticunoACG)Pokemon2).verNombre(false);
                btnAtaqueFuerte1.Click += (sender, e) => ((ArticunoACG)Pokemon2).animacionAtaqueFuerte();
                btnAtaqueFlojo1.Click += (sender, e) => ((ArticunoACG)Pokemon2).animacionAtaqueFlojo();
              
                btnActivarEscudo1.Click += (sender, e) => ((ArticunoACG)Pokemon2).animacionDefensa();
            }
            else if (pokemon2 == "Azumarill")
            {
                Pokemon2 = new AzumarillACR();
                ContenedorPokemon2.Content = Pokemon2;
                ((AzumarillACR)Pokemon2).verFondo(false);
                ((AzumarillACR)Pokemon2).verNombre(false);
                btnAtaqueFuerte1.Click += (sender, e) => ((AzumarillACR)Pokemon2).animacionAtaqueFuerte();
                btnAtaqueFlojo1.Click += (sender, e) => ((AzumarillACR)Pokemon2).animacionAtaqueFlojo();
               
                btnActivarEscudo1.Click += (sender, e) => ((AzumarillACR)Pokemon2).animacionDefensa();
            }
            else if (pokemon2 == "ButterFree")
            {
                Pokemon2 = new ButterFreeACC();
                ContenedorPokemon2.Content = Pokemon2;
                ((ButterFreeACC)Pokemon2).verFondo(false);
                ((ButterFreeACC)Pokemon2).verNombre(false);
                btnAtaqueFuerte1.Click += (sender, e) => ((ButterFreeACC)Pokemon2).animacionAtaqueFuerte();
                btnAtaqueFlojo1.Click += (sender, e) => ((ButterFreeACC)Pokemon2).animacionAtaqueFlojo();
              
                btnActivarEscudo1.Click += (sender, e) => ((ButterFreeACC)Pokemon2).animacionDefensa();
            }
            else if (pokemon2 == "Chandelure")
            {
                Pokemon2 = new ChandelureNDAA();
                ContenedorPokemon2.Content = Pokemon2;
                ((ChandelureNDAA)Pokemon2).verFondo(false);
                ((ChandelureNDAA)Pokemon2).verNombre(false);
                btnAtaqueFuerte1.Click += (sender, e) => ((ChandelureNDAA)Pokemon2).animacionAtaqueFuerte();
                btnAtaqueFlojo1.Click += (sender, e) => ((ChandelureNDAA)Pokemon2).animacionAtaqueFlojo();
               
                btnActivarEscudo1.Click += (sender, e) => ((ChandelureNDAA)Pokemon2).animacionDefensa();
            }
            else if (pokemon2 == "Dracofire")
            {
                Pokemon2 = new DracofireGDLRS();
                ContenedorPokemon2.Content = Pokemon2;
                ((DracofireGDLRS)Pokemon2).verFondo(false);
                ((DracofireGDLRS)Pokemon2).verNombre(false);
                btnAtaqueFuerte1.Click += (sender, e) => ((DracofireGDLRS)Pokemon2).animacionAtaqueFuerte();
                btnAtaqueFlojo1.Click += (sender, e) => ((DracofireGDLRS)Pokemon2).animacionAtaqueFlojo();
              
                btnActivarEscudo1.Click += (sender, e) => ((DracofireGDLRS)Pokemon2).animacionDefensa();
            }
            else if (pokemon2 == "Dragonitee")
            {
                Pokemon2 = new DragoniteCSD();
                ContenedorPokemon2.Content = Pokemon2;
                ((DragoniteCSD)Pokemon2).VerFondo(false);
                ((DragoniteCSD)Pokemon2).VerNombre(false);
                btnAtaqueFuerte1.Click += (sender, e) => ((DragoniteCSD)Pokemon2).AnimacionAtaqueFuerte();
                btnAtaqueFlojo1.Click += (sender, e) => ((DragoniteCSD)Pokemon2).AnimacionAtaqueFlojo();
              
                btnActivarEscudo1.Click += (sender, e) => ((DragoniteCSD)Pokemon2).AnimacionDefensa();
            }
            else if (pokemon2 == "Gengar")
            {
                Pokemon2 = new GengarJCC();
                ContenedorPokemon2.Content = Pokemon2;
                ((GengarJCC)Pokemon2).verFondo(false);
                ((GengarJCC)Pokemon2).verNombre(false);
                btnAtaqueFuerte.Click += (sender, e) => ((GengarJCC)Pokemon2).animacionAtaqueFuerte();
                btnAtaqueFlojo.Click += (sender, e) => ((GengarJCC)Pokemon2).animacionAtaqueFlojo();
               
                btnActivarEscudo.Click += (sender, e) => ((GengarJCC)Pokemon2).animacionDefensa();
            }
            else if (pokemon2 == "Piplup")
            {
                Pokemon2 = new PiplupMLTN();
                ContenedorPokemon2.Content = Pokemon2;
                ((PiplupMLTN)Pokemon2).verFondo(false);
                ((PiplupMLTN)Pokemon2).verNombre(false);
                btnAtaqueFuerte1.Click += (sender, e) => ((PiplupMLTN)Pokemon2).animacionAtaqueFuerte();
                btnAtaqueFlojo1.Click += (sender, e) => ((PiplupMLTN)Pokemon2).animacionAtaqueFlojo();
           
                btnActivarEscudo1.Click += (sender, e) => ((PiplupMLTN)Pokemon2).animacionDefensa();
            }
            else if (pokemon2 == "Charizard")
            {
                Pokemon2 = new CharizardASM(); // Asegúrate de que 'Charizard' es el nombre correcto de la clase
                ContenedorPokemon2.Content = Pokemon2;
                ((CharizardASM)Pokemon2).verFondo(false);
                ((CharizardASM)Pokemon2).verNombre(false);
                btnAtaqueFuerte1.Click += (sender, e) => ((CharizardASM)Pokemon2).animacionAtaqueFuerte();
                btnAtaqueFlojo1.Click += (sender, e) => ((CharizardASM)Pokemon2).animacionAtaqueFlojo();
             
                btnActivarEscudo1.Click += (sender, e) => ((CharizardASM)Pokemon2).animacionDefensa();
            }
            else if (pokemon2 == "Makuhita")
            {
                Pokemon2 = new MakuhitaAPQ2(); // Asegúrate de que 'Makuhita' es el nombre correcto de la clase
                ContenedorPokemon2.Content = Pokemon2;
                ((MakuhitaAPQ2)Pokemon2).verFondo(false);
                ((MakuhitaAPQ2)Pokemon2).verNombre(false);
                btnAtaqueFuerte1.Click += (sender, e) => ((MakuhitaAPQ2)Pokemon2).animacionAtaqueFuerte();
                btnAtaqueFlojo1.Click += (sender, e) => ((MakuhitaAPQ2)Pokemon2).animacionAtaqueFlojo();
               
                btnActivarEscudo1.Click += (sender, e) => ((MakuhitaAPQ2)Pokemon2).animacionDefensa();
            }
         
        }
        private void CpuPlay()
        {
            // Genera un número aleatorio entre 1 y 3
            Random random = new Random();
            int action = random.Next(1, 3);

            // Asegúrate de que todos los Pokemons implementen una de las interfaces IPokemon
            if (Pokemon2 is iPokemon1 cpuPokemon1)
            {
                switch (action)
                {
                    case 1:
                        btnAtaqueFuerte1_Click(this, null);
                        cpuPokemon1.animacionAtaqueFuerte(20);
                        break;
                    case 2:
                        btnAtaqueFlojo1_Click(this, null);
                        cpuPokemon1.animacionAtaqueFlojo(null, null);
                        break;
                   
                   case 3:
                        btnActivarEscudo1_Click(this, null);
                        cpuPokemon1.animacionDefensa(null, null);
                        break;
                }
            }
            else if (Pokemon2 is iPokemon2 cpuPokemon2)
            {
                switch (action)
                {
                    case 1:
                        btnAtaqueFuerte1_Click(this, null);
                        cpuPokemon2.animacionAtaqueFuerte(null, null);
                        break;
                    case 2:
                        btnAtaqueFlojo1_Click(this, null);
                        cpuPokemon2.animacionAtaqueFlojo(null,null);
                        break;
                   
                    case 3:
                        btnActivarEscudo1_Click(this, null);
                        cpuPokemon2.animacionDefensa(null,null);
                        break;
                }
            }
            else if (Pokemon2 is iPokemon cpuPokemon3)
            {
                switch (action)
                {
                    case 1:
                        btnAtaqueFuerte1_Click(this, null);
                        
                        cpuPokemon3.animacionAtaqueFuerte();
                        break;
                    case 2:
                        btnAtaqueFlojo1_Click(this, null);
                        cpuPokemon3.animacionAtaqueFlojo();
                        break;
                    
                    case 3:
                        btnActivarEscudo1_Click(this, null);
                        cpuPokemon3.animacionDefensa();
                        break;
                }
            }
       
        }

        private void accionRealizada(object sender, EventArgs e)
        {
            cambiarTurno();
        }
        private void cambiarTurno()
        {
            HabilitarBotones();
            // Si tokenTurno = 0 -> Turno del jugador 1
            // Si tokenTurno = 1 -> Turno del jugador 2
            if (tokenTurno == 0)
            {
                ContenedorBotones1.Visibility = Visibility.Visible;
                ContenedorBotones1.IsEnabled = true;
                ContenedorBotones2.IsEnabled = false;
                ContenedorBotones2.Visibility = Visibility.Collapsed;
                txtbEsperaJ1.Visibility = Visibility.Visible;
                txtbEsperaJ2.Visibility = Visibility.Collapsed;
                tokenTurno = 1;
            }
            else
            {
                if (numJugadores == 2)
                {
                    ContenedorBotones2.Visibility = Visibility.Visible;
                    ContenedorBotones1.Visibility = Visibility.Collapsed;
                    ContenedorBotones2.IsEnabled = true;
                    ContenedorBotones1.IsEnabled = false;
                    txtbEsperaJ2.Visibility = Visibility.Visible;
                    txtbEsperaJ1.Visibility = Visibility.Collapsed;
                    tokenTurno = 0;
                }
                else //IA
                {
                    CpuPlay();
                    ContenedorBotones1.Visibility = Visibility.Collapsed;
                    ContenedorBotones1.IsEnabled = false;
                    txtbEsperaJ2.Visibility = Visibility.Visible;
                    txtbEsperaJ1.Visibility = Visibility.Collapsed;
                    tokenTurno = 0;

                }
            }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (e.Parameter is Tuple<int, string, string> data)
            {
                // Desempaquetar los datos
                numJugadores = data.Item1;
                nombrePokemon1 = data.Item2;
                nombrePokemon2 = data.Item3;

                cargarControlUsuario1(nombrePokemon1);
                cargarControlUsuario2(nombrePokemon2);

               

            }


        }


    }
}