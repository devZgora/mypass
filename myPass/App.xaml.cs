using myPass.ViewModels;

namespace myPass
{
    public partial class App : Application
    {
        private IServiceProvider _serviceProvider; 
        public App(IServiceProvider pServiceProvider)
        {
            _serviceProvider = pServiceProvider;
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var shellVm = _serviceProvider.GetRequiredService<ShellViewModel>();

            return new Window(new AppShell(shellVm));
        }
    }
}