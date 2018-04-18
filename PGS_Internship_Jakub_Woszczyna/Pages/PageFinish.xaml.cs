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
    /// Interaction logic for PageFinish.xaml
    /// </summary>
    public partial class PageFinish : Page
    {
        public PageFinish(PersonalData personalData)
        {
            InitializeComponent();
            labelFinish.Content = $@"
{personalData.Name}
{ personalData.Surname}
{personalData.HomeAddress}
{personalData.PhoneNumber}
";
        }
    }
}
