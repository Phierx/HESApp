using HahasEcoSys.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace HahasEcoSys.Views
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