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
                Application.Current.MainPage = new Page1(user);
            }
            catch
            {

            }
        }
    }
}
