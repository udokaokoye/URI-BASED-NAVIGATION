using Microsoft.Maui.Controls;

namespace URI_BASED_NAVIGATION;

[QueryProperty(nameof(Username), "username")]
[QueryProperty(nameof(Email), "email")]
public partial class ProfilePage : ContentPage
{
    public string Username
    {
        set { usernameLabel.Text = value; }
    }

    public string Email
    {
        set { emailLabel.Text = value; }
    }

    public ProfilePage()
    {
        InitializeComponent();
    }

    private async void OnSignOutClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//signup");
    }
}
