using System;
using System.Windows.Input;
using Xamarin.Essentials;
using System.Text;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HahasEcoSys.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
           
        }

        public ICommand OpenWebCommand { get; }
       
        

    }

}