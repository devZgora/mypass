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
            
            var loginPage = _serviceProvider.GetRequiredService<LoginPage>();
            return new Window(loginPage) {  Title = "myPass"} ;
        }
    }
}