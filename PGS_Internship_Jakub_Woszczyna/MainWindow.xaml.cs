using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PGS_Internship_Jakub_Woszczyna.Pages;
using PGS_Internship_Jakub_Woszczyna.Models;
namespace PGS_Internship_Jakub_Woszczyna
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonalData personalData;
        public MainWindow()
        {
            InitializeComponent();
            personalData = new PersonalData();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            frameMainWindow.NavigationService.Navigate(new PageName(personalData));
        }
    }
}
