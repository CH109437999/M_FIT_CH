using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Masmusculo.Configuration;

namespace Masmusculo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PasswordRecoveryPage : ContentPage
    {
        public PasswordRecoveryPage()
        {
            InitializeComponent();
            // URL for password recovery page
            webView.Source = Constants.RecoveryPasswordUrl;
        }

        public void OnNavigating(object sendor, EventArgs e)
        {
            // when the new page is loading, display the loading icon
            isLoading.IsRunning = true;
        }

        public void OnNavigated(object sendor, EventArgs e)
        {
            // when the new page finished loading, disappear the loading icon
            isLoading.IsRunning = false;
        }
    }
}