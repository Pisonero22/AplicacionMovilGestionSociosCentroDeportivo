using System.Collections.ObjectModel;

namespace PracticaMaui_AlejandroPisonero;

public partial class MostrarUsuarios : ContentPage
{
    ListaUsuarios lUsuarios = App.ListaUsuarios;
	public MostrarUsuarios()
	{
		InitializeComponent();
        listViewUsuarios.ItemsSource = new ObservableCollection<Usuario>(lUsuarios);        
    }
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        listViewUsuarios.ItemsSource = new ObservableCollection<Usuario>(lUsuarios); 
    }

    void listViewUsuarios_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        Usuario usuario = (Usuario)e.SelectedItem;
        var parametroUsuario = new Dictionary<string, object> { { "ModUsuario", usuario } };
        Shell.Current.GoToAsync($"//TabModificar/ModificarCondicion", parametroUsuario);

    }
}
