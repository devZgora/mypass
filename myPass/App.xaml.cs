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

        public event EventHandler _test;

        protected override Window CreateWindow(IActivationState? activationState)
        {

            _test += App__test;

            _test.Invoke(null, null);
            return new Window(new Wait()) {  Title = "myPass"} ;
        }


        private async  void App__test(object? sender, EventArgs e)
        {
            await Task.Delay(500);

            Windows[0].Page = await _serviceProvider.GetRequiredService<MainPageGetter>().GetMainPage(); 
            Windows[0].Resumed += App_Resumed;
        }

        private async void App_Resumed(object? sender, EventArgs e)
        {
            if (Windows[0].Page is AppShell)
            {
                var mainPage =
                Windows[0].Page = await _serviceProvider.GetRequiredService<MainPageGetter>().GetMainPage(); ;
            }
        }
    }
}