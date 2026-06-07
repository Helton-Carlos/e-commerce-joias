namespace e_commerceJoias.view;

public partial class LoginPages : ContentPage
{
    public LoginPages()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text;
        string senha = SenhaEntry.Text;

        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
        {
            MensagemLabel.Text = "Preencha todos os campos.";
            return;
        }

        MensagemLabel.Text = "";
        await DisplayAlert("Login", "Login realizado com sucesso!", "OK");
    }
}
