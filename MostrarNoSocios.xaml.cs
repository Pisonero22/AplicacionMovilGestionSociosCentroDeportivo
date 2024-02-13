using System.Collections.ObjectModel;

namespace PracticaMaui_AlejandroPisonero;

public partial class MostrarNoSocios : ContentPage
{
    ListaUsuarios lUsuarios = App.ListaUsuarios;
    public MostrarNoSocios()
	{
		InitializeComponent();
        listViewUsuarios.ItemsSource = null;
        listViewUsuarios.ItemsSource = mostrarNoSocios();
    }
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        listViewUsuarios.ItemsSource = new ObservableCollection<Usuario>(mostrarNoSocios());
    }

    public List<Usuario> mostrarNoSocios()
    {
        List<Usuario> listaUsuFecha = new List<Usuario>();

        foreach (Usuario usu in lUsuarios)
        {
            if (usu.Socio == false)
            {
                listaUsuFecha.Add(usu);
            }
        }

        return listaUsuFecha;
    }




}
