using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace mvalenciaT3.Views;

public partial class login : ContentPage
{
     string[] users = { "Carlos", "Ana", "Jose" };
     string[] passwords = { "carlos123", "ana123", "jose123" };
    public login()
    {
        InitializeComponent();
    }

    private void btn_inicio_Clicked(object sender, EventArgs e)
    {
        

        for (int i = 0; i < 2; i++)
        {
            if (users[i] == txt_usuario.Text && passwords[i] == txt_contrasena.Text)
            {
                    Navigation.PushAsync(new home(users[i]));
                    break;
            }
        }
    }
}