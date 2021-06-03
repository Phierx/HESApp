using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HahasEcoSys.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        void OnButtonClicked(object sender, EventArgs e)
        {

            int nameValue = int.Parse(price.Text) ;
            int labPriceValue = int.Parse(labPrice.Text);
            int resVal;
            //int weLenght = nameValue.Length - 1;
            if ( labPriceValue <= 0)
            {
                
                
                resVal = nameValue;

                (sender as Button).Text = resVal.ToString();
            }
            else if( nameValue <= 0 ) 
            {
                (sender as Button).Text = "please insert a value";
            }
            else
            {
                
                resVal = nameValue + labPriceValue;
                (sender as Button).Text = resVal.ToString();
            }

            
        }
    }
}