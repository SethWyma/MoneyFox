﻿using System;
using Windows.UI.Xaml;
using MoneyManager.Core.ViewModels;
using MoneyManager.Windows.Dialogs;

namespace MoneyManager.Windows.Views
{
    public sealed partial class StatisticMonthlyExpensesPage : IDisposable
    {
        public StatisticMonthlyExpensesPage()
        {
            InitializeComponent();
        }

        private async void SetDate(object sender, RoutedEventArgs e)
        {
            await new SelectDateRangeDialog().ShowAsync();
            (DataContext as StatisticCashFlowViewModel)?.LoadCommand.Execute();
        }

        public void Dispose()
        {
            ExpensePlotView.Model = null;
        }
    }
}
