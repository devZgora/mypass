using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPass
{
    public class MainPageGetter
    {
        private const string _dbPassKey = "db_pass";
        private readonly IServiceProvider _serviceProvider;

        public MainPageGetter(IServiceProvider pServiceProvider)
        {

            _serviceProvider = pServiceProvider;
        }

        public async Task<ContentPage> GetMainPage()
        {
            string stringDbPass = await SecureStorage.Default.GetAsync("oauth_token");

            try
            {
                var isBiometricAvailable = await CrossFingerprint.Current.IsAvailableAsync();

                /*

                1. hasło puste / nie poprawne
                    - jeżeli nie to tworzymy nową  z ustawieniem hasła 
                2. hasło jest poprawne  i obsługjemy biometrie - baza istnieje
                    - biomateria
                3. baza istnieje /   niebsłgujemy biotmetrii lub hasło nie porpawne  / pustelogowanie
                    - logowanie


                 */
                if (!string.IsNullOrEmpty(stringDbPass))
                {
                    // jak jest baza to logowanie, jak  nie to tworzenie ....
                }
                else
                {
                    // if 
                }


                if (isBiometricAvailable)
                {
                    var request = new AuthenticationRequestConfiguration("Prove you have fingers!", "Because without it you can't have access");
                    var authResult = await CrossFingerprint.Current.AuthenticateAsync(request);

                    if (authResult.Authenticated)
                    {
                        //  MainPage = new MainPage();
                    }
                    else
                    {
                        //   MainPage = new OtherAuthenticationPage();
                    }
                }
                else
                {
                    //    MainPage = new OtherAuthenticationPage();
                }
            }catch (Exception ex)
            {

            }
            return null;
        }
    }
}
