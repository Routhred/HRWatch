using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using HRWatch.View;

namespace HRWatch
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DayOff(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DayOff());
        }
        private void Data(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PersonalData());
        }
    }
}
