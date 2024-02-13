namespace PracticaMaui_AlejandroPisonero;

public partial class App : Application
{

    static public ListaUsuarios ListaUsuarios = new ListaUsuarios();
    public App()
	{
		InitializeComponent();
        ListaUsuarios.DatosMock();
        MainPage = new AppShell();
	}
}

