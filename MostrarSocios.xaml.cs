using System.Collections.ObjectModel;

namespace PracticaMaui_AlejandroPisonero;

public partial class MostrarSocios : ContentPage
{
    ListaUsuarios lUsuarios = App.ListaUsuarios;
    
    public MostrarSocios()
	{
		InitializeComponent();
        listViewUsuarios.ItemsSource = null;
        listViewUsuarios.ItemsSource = mostrarSocios();
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        listViewUsuarios.ItemsSource = new ObservableCollection<Usuario>(mostrarSocios());
    }

    public List<Usuario> mostrarSocios()
    {
        List<Usuario> listaUsu = new List<Usuario>();

        foreach (Usuario usu in lUsuarios)
        {

            if (usu.Socio == true)
            {
                listaUsu.Add(usu);               
            }
        }

        return listaUsu;
    }
}
