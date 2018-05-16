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

namespace M.B.N.G.B.T.AttentivenessTest
{
    /// <summary>
    /// Логика взаимодействия для AttentivenessTestRulePage.xaml
    /// </summary>
    public partial class AttentivenessTestRulePage : Page
    {
        public AttentivenessTestRulePage()
        {
            InitializeComponent();
        }

        private void Button_Exit_the_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void Button_Start_Test(object sender, RoutedEventArgs e)
        {
            AttentivenessTestTablePage.stage = 1;
            NavigationService.Navigate(new AttentivenessTestTablePage());
        }
    }
}