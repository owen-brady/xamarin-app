using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipmentPage : ContentPage
    {
        public CoffeeEquipmentPage()
        {
            InitializeComponent();
            
        }

        private int _count = 0;

        private void ButtonClick_OnClicked(object sender, EventArgs e)
        {
            _count++;
            LabelCount.Text = _count == 1 ? "You clicked 1 time" : $"You clicked {_count} times";
        }
    }
}