﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M.B.N.G.B.T.KrepelTest
{
    /// <summary>
    /// Логика взаимодействия для KrepelTestResultPage.xaml
    /// </summary>
    public partial class KrepelinTestResultPage : Page
    {
        ClassLibraryMBNGBT cl = new ClassLibraryMBNGBT();

        public KrepelinTestResultPage()
        {
            InitializeComponent();
            DiagramDate();

            if (KrepelinTestTablePage.arrAllStageRightAnswers[0][0] != 0)
            {
                double tamp = (Convert.ToDouble(KrepelinTestTablePage.arrAllStageRightAnswers[4][0])
               + Convert.ToDouble(KrepelinTestTablePage.arrAllStageRightAnswers[5][0]) +
               Convert.ToDouble(KrepelinTestTablePage.arrAllStageRightAnswers[6][0]) +
               Convert.ToDouble(KrepelinTestTablePage.arrAllStageRightAnswers[7][0])) /
               (Convert.ToDouble(KrepelinTestTablePage.arrAllStageRightAnswers[0][0]) +
               Convert.ToDouble(KrepelinTestTablePage.arrAllStageRightAnswers[1][0]) +
               Convert.ToDouble(KrepelinTestTablePage.arrAllStageRightAnswers[2][0]) +
               Convert.ToDouble(KrepelinTestTablePage.arrAllStageRightAnswers[3][0]));

                if (tamp.ToString().Length > 4)
                    label1.Content = $"K-աշխ․ = {cl.DecreaseInNumbersAfterTheDecimalPoint(tamp, 2)}";
                else
                    label1.Content = $"K-աշխ․ = {tamp}";
            }
            else
                label1.Content = "K-աշխ․ = 0";
        }

        private void Button_Click_Try_Again(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new KrepelinTestRulePage());
        }

        private void Button_Click_Exit_Main(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void DiagramDate()
        {
            ((ColumnSeries)Diagramma.Series[0]).ItemsSource = new KeyValuePair<int, int>[] {
             new KeyValuePair<int, int>(1, KrepelinTestTablePage.arrAllStageRightAnswers[0][0]),
             new KeyValuePair<int, int>(2, KrepelinTestTablePage.arrAllStageRightAnswers[1][0]),
             new KeyValuePair<int, int>(3, KrepelinTestTablePage.arrAllStageRightAnswers[2][0]),
             new KeyValuePair<int, int>(4, KrepelinTestTablePage.arrAllStageRightAnswers[3][0]),
             new KeyValuePair<int, int>(5, KrepelinTestTablePage.arrAllStageRightAnswers[4][0]),
             new KeyValuePair<int, int>(6, KrepelinTestTablePage.arrAllStageRightAnswers[5][0]),
             new KeyValuePair<int, int>(7, KrepelinTestTablePage.arrAllStageRightAnswers[6][0]),
             new KeyValuePair<int, int>(8, KrepelinTestTablePage.arrAllStageRightAnswers[7][0])};


            ((ColumnSeries)Diagramma.Series[1]).ItemsSource = new KeyValuePair<int, int>[]{
             new KeyValuePair<int, int>(1, KrepelinTestTablePage.arrAllStageWrongAnswers[0][0]),
             new KeyValuePair<int, int>(2, KrepelinTestTablePage.arrAllStageWrongAnswers[1][0]),
             new KeyValuePair<int, int>(3, KrepelinTestTablePage.arrAllStageWrongAnswers[2][0]),
             new KeyValuePair<int, int>(4, KrepelinTestTablePage.arrAllStageWrongAnswers[3][0]),
             new KeyValuePair<int, int>(5, KrepelinTestTablePage.arrAllStageWrongAnswers[4][0]),
             new KeyValuePair<int, int>(6, KrepelinTestTablePage.arrAllStageWrongAnswers[5][0]),
             new KeyValuePair<int, int>(7, KrepelinTestTablePage.arrAllStageWrongAnswers[6][0]),
             new KeyValuePair<int, int>(8, KrepelinTestTablePage.arrAllStageWrongAnswers[7][0])};

            ((LineSeries)Diagramma.Series[2]).ItemsSource = new KeyValuePair<int, int>[]{
            new KeyValuePair<int, int>(1, KrepelinTestTablePage.arrAllStageRightAnswers[0][0]),
            new KeyValuePair<int, int>(2, KrepelinTestTablePage.arrAllStageRightAnswers[1][0]),
            new KeyValuePair<int, int>(3, KrepelinTestTablePage.arrAllStageRightAnswers[2][0]),
            new KeyValuePair<int, int>(4, KrepelinTestTablePage.arrAllStageRightAnswers[3][0]),
            new KeyValuePair<int, int>(5, KrepelinTestTablePage.arrAllStageRightAnswers[4][0]),
            new KeyValuePair<int, int>(6, KrepelinTestTablePage.arrAllStageRightAnswers[5][0]),
            new KeyValuePair<int, int>(7, KrepelinTestTablePage.arrAllStageRightAnswers[6][0]),
            new KeyValuePair<int, int>(8, KrepelinTestTablePage.arrAllStageRightAnswers[7][0])};


        }
    }
}
