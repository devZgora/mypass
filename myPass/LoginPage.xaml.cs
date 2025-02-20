using myPass.ViewModels;

namespace myPass;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel pVm)
	{
		InitializeComponent();
		BindingContext = pVm;
	}
}