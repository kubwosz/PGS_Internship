using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PGS_Internship_Jakub_Woszczyna.Pages;
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
    /// Interaction logic for PageName.xaml
    /// </summary>
    public partial class PageName : Page
    {
        PersonalData personalData;

        public PageName(PersonalData personalDataTmp)
        {
            InitializeComponent();
            personalData = personalDataTmp;
            textBoxName.Text = personalData.Name;
        }

        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            if(textBoxName.Text == "" || textBoxName.Text == "Wpisz numer telefonu...")
            {
                MessageBox.Show("Proszę wpisać imię", "Brak imienia");
            }
            else
            {
                personalData.Name = textBoxName.Text;
                this.NavigationService.Navigate(new PageSurname(personalData));
            }
        }

        private void textBoxName_GotFocus(object sender, RoutedEventArgs e)
        {
                textBoxName.Text = string.Empty;
        }
    }
}
