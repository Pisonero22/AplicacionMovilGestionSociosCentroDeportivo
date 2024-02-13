namespace PracticaMaui_AlejandroPisonero;

[QueryProperty(nameof(ModUsuario),"ModUsuario")]

public partial class ModificarCondicion : ContentPage
{
    ListaUsuarios lUsuarios = App.ListaUsuarios;

    public Usuario ModUsuario { get;  set; }
    
    public ModificarCondicion()
	{
		InitializeComponent();    
	}

    void switchSocio_Toggled(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
    {
        if (e.Value == true)
        {
            etiquetaSwitch.Text = "Socio: Sí";
        }
        else
        {
            etiquetaSwitch.Text = "Socio: No";
        }
    }

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
                     
        if (ModUsuario == null)
        {
            await DisplayAlert("Aviso", "No se ha encontrado el usuario", "OK");
        }
        else
        {

            foreach (Usuario usuario1 in lUsuarios)
            {
                if (usuario1.codigoUsu == ModUsuario.codigoUsu)
                {
                    if (usuario1.Socio== true)
                    {
                        usuario1.Socio = false;
                        await DisplayAlert("Informacion", "EL usuario se ha modificado correctamente", "OK");

                    }
                    else
                    {
                        usuario1.Socio = true;
                        await DisplayAlert("Informacion", "EL usuario se ha modificado correctamente", "OK");


                    }                    

                }
            }


                    
        }
        
    }
}
