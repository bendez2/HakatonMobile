using Android;
using System.IO;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Svg;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Net.Mobile.Forms;
using ZXing.QrCode;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        User users;
        public Page1(User user)
        {
            users = user;
            InitializeComponent();
            zxingImageView.BarcodeValue = user.ID.ToString();
            Position.Text = user.Position;
            nameOfCorp.Text = user.NameOfCorp;
            firstnameOfUser.Text = user.Surname;
            nameOfUser.Text = user.Name;
            puperOfUser.Text = user.Patronymic;
            dateOfUser.Text = user.Date;
        }

        private void ClickedBack_Button(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void ClickedNewPin_Button(object sender, System.EventArgs e)
        {
            Application.Current.MainPage = new NewPinCode(users);
        }
    }
}