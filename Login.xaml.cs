namespace MauiApp1305;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try {
		
			List<DadosUsuario> lista_usuarios = new List<DadosUsuario>();
			{


				new DadosUsuario()
				{
					Usuario = "jose",
					Senha = "123"
				};

				new DadosUsuario()
				{
					Usuario = "Nathan",
					Senha = "321"
				};

			};

			DadosUsuario dados_digitados = new DadosUsuario()
			{
				Usuario = txt_usuario.Text,
				Senha = txt_senha.Text
			};

			//LINQ

			if (lista_usuarios.Any(i => dados_digitados.Usuario == i.Usuario && dados_digitados.Senha == i.Senha))
			
			{
				await SecureStorage.Default.SetAsync("usuario_logado", dados_digitados.Usuario);
				App.Current.MainPage = new Protegida();
			}
			
			else

			{

				throw new Exception("usuario ou senha incorreto");
			}
			
			} catch (Exception ex) 
		// catch baertura
		{
			   await DisplayAlert("iiiih", ex.Message, "Fechar");
		} 
		//catch fechamento
    }
}