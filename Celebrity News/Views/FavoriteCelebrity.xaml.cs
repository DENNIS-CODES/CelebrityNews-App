using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Celebrity_News.ViewModel
{
    public partial class FavoriteCelebrity : ContentPage
    {
        public FavoriteCelebrity()
        {
            InitializeComponent();
            BindingContext = new CelebrityPageViewModel();
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var Celebs = ((ListView)sender).SelectedItem as Celebrity;
            if (Celebs != null)
            {
                var page = new FavoriteCelebrity();
                page.BindingContext = Celebs;
                await Navigation.PushAsync(page);
            }
        }
    }
}

