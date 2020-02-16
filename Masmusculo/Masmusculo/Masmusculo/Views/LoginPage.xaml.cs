using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Masmusculo.Models;
using Masmusculo.Configuration;

namespace Masmusculo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        Setting Settings;

        public LoginPage()
        {
            InitializeComponent();
        }

        //when you click the register button, run this function. 
        private void OnRegister(object sendor, EventArgs e)
        {
            //This function dispaly the register page.
            Navigation.PushAsync(new RegisterPage());
        }

        //when you click the Recovery password button, run this function. 
        private void OnRecoveryPassword(object sendor, EventArgs e)
        {
            //This function dispaly the Recovery password page.
            Navigation.PushAsync(new PasswordRecoveryPage());
        }

        //when you click the Login button, run this function. 
        //This function don't complete, I need the token to store in app.
        private async void OnLogin(object sendor, EventArgs e)
        {
            // receive the email and pass in app
            var username = txt_email.Text;
            var password = txt_pass.Text;

            // make the new key
            var keyValues = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username",username),
                new KeyValuePair<string, string>("password",password),
                new KeyValuePair<string, string>("grant-type","password")
            };

            // request in specific url, this is post request
            var request = new HttpRequestMessage(HttpMethod.Post, Constants.LoginUrl);

            ////////////////////// 
            /*  get the token   */
            //////////////////////
            request.Content = new FormUrlEncodedContent(keyValues);

            var client = new HttpClient();

            var response = await client.SendAsync(request);
            var content = await response.Content.ReadAsStringAsync();

            JObject jdynamic = JsonConvert.DeserializeObject<dynamic>(content);
            var accessToken = jdynamic.Value<string>("access_token");
            var refershToken = jdynamic.Value<string>("refresh_token");
            var date = DateTime.Now.ToString();
            var accessTokenExpiration = jdynamic.Value<DateTime>(".expires");

            await Application.Current.MainPage.DisplayAlert("Alert", content, "OK");
            Debug.WriteLine(content);

            Settings.AccessToken = accessToken;
            Settings.RefreshToken = refershToken;

            Settings.AccessTokenexpiration = accessTokenExpiration;
//            return accessToken;
        }
    }
}