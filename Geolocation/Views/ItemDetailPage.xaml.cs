using Geolocation.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Geolocation.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}