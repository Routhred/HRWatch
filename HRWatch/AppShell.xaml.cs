using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRWatch.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HRWatch
{

    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DayOff), typeof(DayOff));
        }
    }
}