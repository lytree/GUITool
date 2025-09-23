﻿using Avalonia;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ursa.Controls;

namespace App.Converters
{
    public class TimelineIconConverter : IValueConverter
    {
        public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is TimelineItemType t)
            {
                return t switch
                {
                    TimelineItemType.Success => Brushes.Green,
                    TimelineItemType.Ongoing => Brushes.Blue,
                    TimelineItemType.Error => Brushes.Red,
                    _ => Brushes.Gray
                };
            }
            return AvaloniaProperty.UnsetValue;
        }

        public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
