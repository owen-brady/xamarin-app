using System.ComponentModel;
using Xamarin.Forms;
using MyFirstXamarinApp.ViewModels;

namespace MyFirstXamarinApp.Views
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
