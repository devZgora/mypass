using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPass.ViewModels
{
    public partial class LoginPageViewModel : ObservableObject
    {
        private readonly IServiceProvider _serviceProvider;

        public LoginPageViewModel(IServiceProvider pServiceProvider)
        {
            _serviceProvider = pServiceProvider;
        }
        [RelayCommand]

        private async Task Login()
        {
            if (App.Current != null)
            {
                App.Current.Windows[0].Page = _serviceProvider.GetRequiredService<LoginPage>();
            }
        }
        
    }
}
