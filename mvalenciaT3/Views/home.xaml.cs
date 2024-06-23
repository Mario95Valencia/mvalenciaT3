namespace mvalenciaT3.Views;

public partial class home : ContentPage
{
	public home(string usuario)
	{
		InitializeComponent();
        lbl_nombre.Text = "Usuario conectado: " + usuario;
    }
}