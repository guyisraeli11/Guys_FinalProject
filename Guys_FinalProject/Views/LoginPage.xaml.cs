using System.Net.Mail;

namespace Guys_FinalProject.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        MessageLabel.TextColor = Colors.Red;

        if (string.IsNullOrWhiteSpace(EmailEntry.Text) ||
            string.IsNullOrWhiteSpace(PasswordEntry.Text))

        {
            MessageLabel.Text = "Please fill in all fields.";
            return;
        }

        try
        {
            _ = new MailAddress(EmailEntry.Text.Trim());
        }
        catch
        {
            MessageLabel.Text = "Please enter a valid e-mail.";
            return;
        }



        await DisplayAlert(
            "Login",
            "Input is valid, but authentication is not connected yet.",
            "OK");
    }

    private async void OnGoToRegisterClicked(
        object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
}