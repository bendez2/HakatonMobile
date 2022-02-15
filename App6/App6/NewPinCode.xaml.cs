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
    public partial class NewPinCode : ContentPage
    {
        User user;
        string pin = "";
        public NewPinCode(User user)
        {
            pin = user.Pin; 
            this.user = user;
            InitializeComponent();
        }

       

        public void Button_Clicked(object sender, EventArgs e)
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
                user.Pin = pinCodeBox.Text;
                using (var dbContext = new ApplicationContext())
                {
                    dbContext.Users.Update(user);
                    dbContext.SaveChanges();
                }
                
                Application.Current.MainPage = new Page1(user);
            }
        }



    }
}