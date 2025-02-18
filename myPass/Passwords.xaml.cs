using myPass.ViewModels;

namespace myPass;

public partial class Passwords : ContentPage
{
	public Passwords(PasswordViewModel pVm)
	{
		InitializeComponent();
        BindingContext = pVm;
    }
}