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

namespace M.B.N.G.B.T.TestEclecticAttention
{
    /// <summary>
    /// Логика взаимодействия для TestEclecticAttentionResultPage.xaml
    /// </summary>
    public partial class TestEclecticAttentionResultPage : Page
    {
        public TestEclecticAttentionResultPage()
        {
            InitializeComponent();
        }

        private void Button_Click_Try_Again(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TestEclecticAttentionRulePage());
        }

        private void Button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
