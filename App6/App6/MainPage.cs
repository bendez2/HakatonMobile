using System;
using System.Linq;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {    
        static User user;
        public MainPage()
        {
                      
            InitializeComponent();
            
        }

        public void LoginCliked_Button(object sender, EventArgs e)
        {
            try
            {
                string login = log.Text;
                string password = pass.Text;

                using (var dbContext = new ApplicationContext())
                {
                    user = dbContext.Users.Where(user => (user.Email == login) && (user.Password == password)).First();
                }
                if (user.Pin == "" || user.Pin == null) { Application.Current.MainPage = new NewPinCode(user); }
                else { Application.Current.MainPage = new EnterPinCode(user); }
            }
            catch
            {

            }
        }
    }
}
