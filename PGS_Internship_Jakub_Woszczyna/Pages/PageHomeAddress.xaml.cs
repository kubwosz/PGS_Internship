﻿using System;
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
    /// Interaction logic for PageHomeAddress.xaml
    /// </summary>
    public partial class PageHomeAddress : Page
    {
        PersonalData personalData;
        public PageHomeAddress(PersonalData personalDataTmp)
        {
            InitializeComponent();
            personalData = personalDataTmp;
            textBoxHomeAddress.Text = personalData.HomeAddress;
        }

        private void buttonPrev_Click(object sender, RoutedEventArgs e)
        {
            personalData.HomeAddress = textBoxHomeAddress.Text;
            this.NavigationService.Navigate(new PageSurname(personalData));
        }

        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxHomeAddress.Text == "" || textBoxHomeAddress.Text == "Wpisz adres...")
            {
                MessageBox.Show("Proszę wpisać adres", "Brak adresu");
            }
            else
            {
                personalData.HomeAddress = textBoxHomeAddress.Text;
                this.NavigationService.Navigate(new PagePhoneNumber(personalData));
            }

        }

        private void textBoxHomeAddress_GotFocus(object sender, RoutedEventArgs e)
        {
            textBoxHomeAddress.Text = string.Empty;
        }
    }
}
