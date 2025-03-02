using System.Web;
using Microsoft.Maui.Controls;

namespace URI_BASED_NAVIGATION;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnSignupClicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text?.Trim();
        string email = emailEntry.Text?.Trim();
        string password = passwordEntry.Text;
        string confirmPassword = confirmPasswordEntry.Text;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
        {
            errorLabel.Text = "All fields are required.";
            errorLabel.IsVisible = true;
            return;
        }

        if (password != confirmPassword)
        {
            errorLabel.Text = "Passwords do not match.";
            errorLabel.IsVisible = true;
            return;
        }

        errorLabel.IsVisible = false;

        string uri = $"///profile?username={HttpUtility.UrlEncode(username)}&email={HttpUtility.UrlEncode(email)}";
        await Shell.Current.GoToAsync(uri);
    }
}
