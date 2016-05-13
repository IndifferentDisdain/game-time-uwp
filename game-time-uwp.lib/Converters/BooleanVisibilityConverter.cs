﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace game_time_uwp.lib.Converters
{
    public class BooleanVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return (bool)value ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return (Visibility)value == Visibility.Visible;
        }
    }
}
