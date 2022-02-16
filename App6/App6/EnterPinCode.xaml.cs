using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterPinCode : ContentPage
    {
        User user;
        public EnterPinCode(User user)
        {
            this.user = user;
            InitializeComponent();
        }


      
        private void Button_Clicked(object sender, EventArgs e)
        {
            string[] pinMassive = new string[4];
            Button button = (Button)sender;
            string content = (string)button.Text;

            if (Regex.IsMatch(content, "[0-9]")) 
            {
                pinCodeBox.Text += content;
            }

            if (Regex.IsMatch(content, "[×]")) 
            {
                pinCodeBox.Text = null;
            }

            if (Regex.IsMatch(content, "[→]"))
            {
                if (pinCodeBox.Text == user.Pin)
                {
                    Application.Current.MainPage = new Page1(user);
                }
            }
        }
    }
}