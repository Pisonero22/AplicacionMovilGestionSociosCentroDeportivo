namespace PracticaMaui_AlejandroPisonero;

public partial class AltaUsuario : ContentPage
{

    ListaUsuarios lUsuarios = App.ListaUsuarios;
    Usuario usuario = new Usuario();
    public AltaUsuario()
	{
		InitializeComponent();
	}

    void limpiar()
    {
        textoCod.Text = string.Empty;
        textoNombre.Text = string.Empty;
        textoApellidos.Text = string.Empty;
        switchSocio.IsToggled = true;
        pickerGenero.SelectedIndex = -1;
        etiquetaFechaNacimiento.Date = DateTime.Today;

    }

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        if (string.IsNullOrEmpty(textoCod.Text))
        {
            await DisplayAlert("Aviso", "El codigo del usuario no puede estar vacio", "OK");
        }
        else if (string.IsNullOrEmpty(textoNombre.Text))
        {
            await DisplayAlert("Aviso", "El nombre del usuario no puede estar vacio", "OK");
        }
        else if (string.IsNullOrEmpty(textoApellidos.Text))
        {
            await DisplayAlert("Aviso", "El apellido del usuario no puede estar vacio", "OK");
        }
        else if (pickerGenero.SelectedIndex == -1)
        {
            await DisplayAlert("Aviso", "Selecciona el genero del usuario", "OK");

        }
        else if (lUsuarios.BuscarUsuario(textoCod.Text) == null)
        {

            usuario = new Usuario();
            usuario.codigoUsu = textoCod.Text;
            usuario.nombre = textoNombre.Text;
            usuario.apellidos = textoApellidos.Text;
            usuario.fechaNacimiento = etiquetaFechaNacimiento.Date;
            usuario.Socio = switchSocio.IsToggled;
            usuario.genero = (Genero)Enum.Parse(typeof(Genero), pickerGenero.SelectedIndex.ToString());


            if (lUsuarios.AñadirUsuario(usuario) == true)
            {
                await DisplayAlert("Informacion", "El usuario se ha registrado correctamente", "OK");
                limpiar();
            }

        }
        else
        {
            await DisplayAlert("Aviso", "El usuario ya fue registrado", "OK");
        }
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
}
