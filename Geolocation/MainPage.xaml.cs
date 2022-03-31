using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Geolocation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        bool firstTime = true;
        void map_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var m = (Map)sender;
            if(m.VisibleRegion != null)
                if(firstTime == true)
                {
                    firstTime = false;
                    return;
                }
            try
            {
                geoLatitude.Text = m.VisibleRegion.Center.Latitude.ToString();
                geoLongitude.Text = m.VisibleRegion.Center.Longitude.ToString();
            }
            catch
            {
                //waits for them to exist
            }
        }
    }
}