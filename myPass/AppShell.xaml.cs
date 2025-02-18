using myPass.ViewModels;

namespace myPass
{
    public partial class AppShell : Shell
    {
        public AppShell(ShellViewModel pVm)
        {
            InitializeComponent();
            BindingContext = pVm;
        }
    }
}
