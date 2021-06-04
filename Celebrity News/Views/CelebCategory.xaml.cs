using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Celebrity_News.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CelebCategory : ContentView
    {
        public CelebCategory(List<Celebs<CelebData>> data)
        {
            InitializeComponent();
            BindingContext = new CelebCategory(data);
        }
    }
}