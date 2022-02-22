using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRWatch.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HRWatch.View
{
    public partial class DayOff : ContentPage
    {
        public DayOff()
        {
            InitializeComponent();
        }
        public void GoBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}