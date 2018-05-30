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

namespace M.B.N.G.B.T.ConcentrationDefinitionTest
{
    /// <summary>
    /// Логика взаимодействия для ConcentrationDefinitionTestRulePage.xaml
    /// </summary>
    public partial class ConcentrationDefinitionTestRulePage : Page
    {
        public ConcentrationDefinitionTestRulePage()
        {
            InitializeComponent();
        }

        private void Button_Exit_The_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void Button_Start_Test(object sender, RoutedEventArgs e)
        {
            ConcentrationDefinitionTestTablePage.arrAllStageRandomDigits = new int[5][];
            ConcentrationDefinitionTestTablePage.arrAllStageDigitsInTextBox = new int[5][];
            ConcentrationDefinitionTestTablePage.arrAllStageRightNumbers = new int[5][];
            ConcentrationDefinitionTestTablePage.arrAllStageAbsentNumbers = new int[5][];
            ConcentrationDefinitionTestTablePage.arrAllStageExtraNumbers = new int[5][];
            ConcentrationDefinitionTestTablePage.stage = 1;
            NavigationService.Navigate(new ConcentrationDefinitionTestTablePage());
        }
    }
}
