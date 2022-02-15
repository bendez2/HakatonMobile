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
        User users;
        public EnterPinCode(User user)
        {
            users = user;
            InitializeComponent();
        }


      
        private void Button_Clicked(object sender, EventArgs e)
        {
            string[] pinMassive = new string[4];
            Button button = (Button)sender;
            string content = (string)button.Text;

            if (Regex.IsMatch(content, "[0-9]")) // ввод пин-кода
            {
                pinCodeBox.Text += content;
            }

            if (Regex.IsMatch(content, "[×]")) // очистка поля пин-кода
            {
                pinCodeBox.Text = null;
            }

            if (Regex.IsMatch(content, "[→]"))
            {
                if (pinCodeBox.Text == users.Pin)
                {
                    Application.Current.MainPage = new Page1(users);
                }
            }
        }
    }
}