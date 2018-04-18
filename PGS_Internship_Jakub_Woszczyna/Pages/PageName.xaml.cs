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
        public PageName()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            PersonalData personalData = new PersonalData();
            personalData.Name = textBoxName.Text;
            this.NavigationService.Navigate(new PageSurname(personalData));
        }
    }
}
