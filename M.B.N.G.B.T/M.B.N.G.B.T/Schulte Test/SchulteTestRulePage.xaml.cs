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

namespace M.B.N.G.B.T.Schulte_Test
{
    /// <summary>
    /// Логика взаимодействия для SchulteTestRulePage.xaml
    /// </summary>
    public partial class SchulteTestRulePage : Page
    {
        

        public SchulteTestRulePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            SchulteTestTablePage1.stage = 1;
            NavigationService.Navigate(new SchulteTestTablePage1());
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            SchulteTestTablePage2.stage = 1;
            SchulteTestTablePage2.listAllStageMistakes.Clear();
            NavigationService.Navigate(new SchulteTestTablePage2());
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            SchulteTestTablePage3.stage = 1;
            NavigationService.Navigate(new SchulteTestTablePage3());
        }
    }
}
