using System.Net.Mail;

namespace Guys_FinalProject.Views;

public partial class RegisterPage : ContentPage
{
  
    public RegisterPage()
	{
		InitializeComponent();
	}
    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        MessageLabel.TextColor = Colors.Red;

        // Check that all fields are filled
        if (string.IsNullOrWhiteSpace(FullNameEntry.Text) ||
            string.IsNullOrWhiteSpace(UsernameEntry.Text) ||
            string.IsNullOrWhiteSpace(EmailEntry.Text) ||
            string.IsNullOrWhiteSpace(PasswordEntry.Text) ||
            string.IsNullOrWhiteSpace(ConfirmPasswordEntry.Text)
           )
        {
            MessageLabel.Text = "Please fill in all fields.";
            return;
        }

        // Validate email
        try
        {
            _ = new MailAddress(EmailEntry.Text.Trim());
        }
        catch
        {
            MessageLabel.Text = "Please enter a valid e-mail.";
            return;
        }

        // Check password length
        if (PasswordEntry.Text.Length < 6)
        {
            MessageLabel.Text =
                "Password must contain at least 6 characters.";
            return;
        }

        // Check that passwords match
        if (PasswordEntry.Text != ConfirmPasswordEntry.Text)
        {
            MessageLabel.Text = "Passwords do not match.";
            return;
        }

  

        // Registration is not connected to a database yet
        MessageLabel.TextColor = Colors.Green;
        MessageLabel.Text = "All fields are valid.";

        await DisplayAlert(
            "Sign up",
            "Validation successful. No account has been saved yet.",
            "OK");
    }

    private async void OnGoToLoginClicked(
        object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}