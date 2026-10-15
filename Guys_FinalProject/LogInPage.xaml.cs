
using System.Net.Mail;

namespace Guys_FinalProject;

public partial class LogInPage : ContentPage
{
    private const string DemoCaptcha = "CAPtChA";

    public LogInPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        MessageLabel.TextColor = Colors.Red;

        if (string.IsNullOrWhiteSpace(EmailEntry.Text) ||
            string.IsNullOrWhiteSpace(PasswordEntry.Text) ||
            string.IsNullOrWhiteSpace(CaptchaEntry.Text))
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

        if (!string.Equals(
            CaptchaEntry.Text.Trim(),
            DemoCaptcha,
            StringComparison.OrdinalIgnoreCase))
        {
            MessageLabel.Text = "CAPTCHA is incorrect.";
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
        await Navigation.PushAsync(new Register());
    }
}
