using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClickDot
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }        

        private void DotLabel_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Wow!", "You clicked dot successfully.", "Do Again");
        }
    }
}
