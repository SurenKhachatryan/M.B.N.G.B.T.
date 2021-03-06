﻿using System.Diagnostics;
using System.Windows;

namespace M.B.N.G.B.T.ConcentrationDefinitionTest
{
    /// <summary>
    /// Логика взаимодействия для ConcentrationDefinitionTestRuleWindow.xaml
    /// </summary>
    public partial class ConcentrationDefinitionTestRuleWindow : Window
    {
        public ConcentrationDefinitionTestRuleWindow()
        {
            InitializeComponent();
        }

        private void Button_Exit_The_Main(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            Process.Start(Application.ResourceAssembly.Location);
        }

        private void Button_Start_Test(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new ConcentrationDefinitionTestTablePage());
        }
    }
}
