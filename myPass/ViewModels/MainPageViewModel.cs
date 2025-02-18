using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPass.ViewModels
{
    public partial class MainPageViewModel :ObservableObject
    {
        [ObservableProperty]
        private string _sth;

        private ShellViewModel _shell;
        public MainPageViewModel(ShellViewModel pSHell)
        {
            _shell = pSHell;
            _sth = "dfsdofhsdjf";
        }

        [RelayCommand]
        public void SetVisible()
        {
            _shell.IsVisible = true;
        }
    }
}
