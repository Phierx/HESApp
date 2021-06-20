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
            double currentNum ;
            double labPriceValue ;
          //  double zero;
            
            
            double resVal;
           
            //int weLenght = currentNum.Length - 1;
            if (price.Text == String.Empty || price.Text == null)
            {
                (sender as Button).Text = "please insert a value";

            }
            
            else if(labPrice.Text == String.Empty || labPrice.Text == null)
             {

                labPriceValue  = 0;
                currentNum = double.Parse(price.Text);
                resVal = RateCalulator(currentNum, labPriceValue);
                (sender as Button).Text = resVal.ToString();
            }
            else if (price.Equals(typeof(string)) == true|| labPrice.Equals(typeof(string)) == true)
            {
                (sender as Button).Text = "please insert a Number";

            }
          
            else 
            {
               currentNum = double.Parse(price.Text);
               labPriceValue   = double.Parse(labPrice.Text);
                resVal = RateCalulator(currentNum, labPriceValue);
                (sender as Button).Text = resVal.ToString();
            }
            

        }

        public static double RateCalulator (double a, double b)
        {
            double currentNum = a;
            double labPriceValue = b;
            double resVal=0;
            double rate;
            if (currentNum <= 30)
            {
                rate = (currentNum * 3.5);
                resVal = rate + labPriceValue;
              
            }
            else if (currentNum <= 40)
            {
                rate = (currentNum * 3.25);
                resVal = rate + labPriceValue;
               
            }
            else if (currentNum <= 75)
            {
                rate = (currentNum * 2.75);
                resVal = rate + labPriceValue;
               
            }
            else if (currentNum <= 175)
            {
                rate = (currentNum * 2);
                resVal = rate + labPriceValue;
                
            }
            else if (currentNum <= 275)
            {
                rate = (currentNum * 1.75);
                resVal = rate + labPriceValue;
                
            }
            else if (currentNum > 275)
            {
                rate = (currentNum * 1.5);
                resVal = rate + labPriceValue;
                
            }
            return resVal;
        }
        
    }
}