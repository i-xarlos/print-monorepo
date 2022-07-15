using Microsoft.ReactNative;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
//using Auth0.OidcClient;
using System.Threading.Tasks;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace listprinters5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();


           
            var app = Application.Current as App;
            reactRootView.ReactNativeHost = app.Host;
           // Task<string> task = LoginAsync();
        }

       /* public async Task<string> LoginAsync()
        {
            var client = new Auth0Client(new Auth0ClientOptions
            {
                Domain = "dev-p22ghhry.us.auth0.com",
                ClientId = "yNpnHf0jyuhwQRVzbMhrbsFNPUZJH5eV"
            });

            var loginResult = await client.LoginAsync();

            if (loginResult.IsError)
            {
                return $"An error occurred during login: {loginResult.Error}";
            }
            else
            {
                return "loggin";
            }
        }*/
    }
}
