using myPass.ViewModels;

namespace myPass;

public partial class About : ContentPage
{
	public About(AboutViewModel pVm)
	{
		InitializeComponent();
		BindingContext = pVm;
	}
}