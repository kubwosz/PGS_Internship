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
using PGS_Internship_Jakub_Woszczyna.Models;

namespace PGS_Internship_Jakub_Woszczyna.Pages
{
    /// <summary>
    /// Interaction logic for PagePhoneNumber.xaml
    /// </summary>
    public partial class PagePhoneNumber : Page
    {
        PersonalData personalData;
        public PagePhoneNumber(PersonalData personalDataTmp)
        {
            InitializeComponent();
            personalData = personalDataTmp;
            textBoxPhoneNumber.Text = personalData.PhoneNumber;
        }

        private void buttonPrev_Click(object sender, RoutedEventArgs e)
        {
            personalData.PhoneNumber = textBoxPhoneNumber.Text;
            this.NavigationService.Navigate(new PageHomeAddress(personalData));
        }

        private void buttonFinish_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxPhoneNumber.Text == "" || textBoxPhoneNumber.Text == "Wpisz numer telefonu...")
            {
                MessageBox.Show("Proszę wpisać numer telefonu", "Brak numeru");
            }
            else
            {
                personalData.PhoneNumber = textBoxPhoneNumber.Text;
                this.NavigationService.Navigate(new PageFinish(personalData));
            }
        }

        private void textBoxPhoneNumber_GotFocus(object sender, RoutedEventArgs e)
        {
            textBoxPhoneNumber.Text = string.Empty;
        }
    }
}
