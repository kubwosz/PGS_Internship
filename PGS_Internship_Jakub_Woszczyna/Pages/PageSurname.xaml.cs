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
    /// Interaction logic for PageSurname.xaml
    /// </summary>
    public partial class PageSurname : Page
    {
        public PageSurname(PersonalData personalDataTmp)
        {
            InitializeComponent();
            personalData = personalDataTmp;
        }

        PersonalData personalData;

        private void buttonPrev_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PageName());
        }

        private void buttonNext_Click(object sender, RoutedEventArgs e)
        {
            personalData.Surname = textBoxSurname.Text;
            this.NavigationService.Navigate(new PageHomeAddress(personalData));
        }
    }
}
