using Geolocation.Models;
using Geolocation.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Geolocation.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var location = await Xamarin.Essentials.Geolocation.GetLastKnownLocationAsync();
                if(location == null)
                {
                    location = await Xamarin.Essentials.Geolocation.GetLocationAsync(new GeolocationRequest
                    { 
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(10)
                    });
                }
                if (location != null)
                    LabelLocation.Text = $"{location.Latitude} {location.Longitude}";
                else
                    LabelLocation.Text = "No GPS";
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Something is wrong: {ex.Message}");
            }//Deez nuts
        }
    }
}