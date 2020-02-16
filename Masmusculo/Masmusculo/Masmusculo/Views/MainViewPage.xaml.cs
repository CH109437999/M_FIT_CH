using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Masmusculo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainViewPage : ContentPage
    {
        public MainViewPage()
        {
            InitializeComponent();
        }
        //when you click the enter button, run this function
        private void OnEnter(object sendor, EventArgs e)
        {

        }

        //when you click the Exercises button, run this function
        private void OnExercises(object sendor, EventArgs e)
        {

        }

        //when you click the My account button, run this function
        private void OnMyaccount(object sendor, EventArgs e)
        {

        }
    }
}