﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace M.B.N.G.B.T.WalterSchulteTest
{
    /// <summary>
    /// Логика взаимодействия для WalterSchulteTestRulePage.xaml
    /// </summary>
    public partial class WalterSchulteTestRulePage : Page
    {
        public WalterSchulteTestRulePage()
        {
            InitializeComponent();
        }

        private void Button_Exit_The_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void Button_Start_Test(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WalterSchulteTestTablePage());
        }
    }
}