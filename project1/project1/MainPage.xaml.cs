using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace project1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {

        }
        //this was from the tutorial and relates to the handling of clicking a button
        //when the event is used, it adds 1 to the counter variable
        int count = 0;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";


        }
    }
    
}
