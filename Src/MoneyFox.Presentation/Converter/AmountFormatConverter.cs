﻿using System;
using System.Globalization;
using MvvmCross.Converters;
using Xamarin.Forms;

namespace MoneyFox.Presentation.Converter
{
    /// <summary>
    ///     Displays the amount as currency of the current culture.
    /// </summary>
    public class AmountFormatConverter : MvxValueConverter, IValueConverter
    {
        /// <summary>
        ///     Converts the passed value to a currency string.
        /// </summary>
        /// <param name="value">value to convert</param>
        /// <param name="targetType">Is not used.</param>
        /// <param name="parameter">Is not used.</param>
        /// <param name="culture">Culture to use to convert.</param>
        /// <returns>Converted currency string.</returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var noParens = (NumberFormatInfo)culture.NumberFormat.Clone();
            noParens.CurrencyNegativePattern = 1;
            var currencyValue = (double)value;
            return currencyValue.ToString("C", noParens);
        }

        /// <summary>
        ///     Returns the value.
        /// </summary>
        /// <returns>Passed value.</returns>
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => value;
    }
}