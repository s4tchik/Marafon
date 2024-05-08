using Marafon.ClassHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Marafon.Pages.Runners
{
    /// <summary>
    /// Логика взаимодействия для NewRunner.xaml
    /// </summary>
    public partial class NewRunner : Page
    {
        public NewRunner()
        {
            InitializeComponent();

            cmbCountry.DisplayMemberPath = "CountryName";
            cmbCountry.SelectedValuePath = "CountryCode";
            cmbCountry.ItemsSource = OdbConectHelper.dbobj.Countries.ToList();

            cmb_gender.DisplayMemberPath = "Gender1";
            cmb_gender.SelectedValuePath = "Id";
            cmb_gender.ItemsSource = OdbConectHelper.dbobj.Genders.ToList();
        }

        private void btn_Reg_Click(object sender, RoutedEventArgs e)
        {
            string email = txb_email.Text;

            string name = txb_name.Text;
            string surname = txb_surname.Text;
            //string selectgender = (string)cmb_gender.SelectedItem;
            string photo = txb_pathphoto.Text;
            DateTime? selectedDate = dateBirth.SelectedDate;
            //string selectcountry = (string)cmbCountry.SelectedItem;

            Runner runner = new Runner
            {
                //Gender = selectgender,
                DateOfBirth = selectedDate
                //CountryCode = selectcountry
            };

            if (txb_pass.Text == txb_repeatpass.Text)
            {
                string pass = txb_pass.Text;
                User user = new User
                {
                    Email = email,
                    Password = pass,
                    FirstName = name,
                    LastName = surname
                };
                OdbConectHelper.dbobj.Users.Add(user);
                OdbConectHelper.dbobj.Runners.Add(runner);
                MessageBox.Show("Пароли совпадают",
                        "Уведомление",
                         MessageBoxButton.OK,
                         MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show("Пароли не совпадают",
                        "Уведомление",
                         MessageBoxButton.OK,
                         MessageBoxImage.Warning);
            }

        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void btn_source_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txb_email_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txb_pass_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txb_repeatpass_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txb_name_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txb_surname_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txb_pathphoto_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
