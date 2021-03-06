﻿using System;

#if NET452
using System.Windows.Data;
using System.Globalization;
#endif

#if UAP10_0_18362
using Windows.UI.Xaml.Data;
#endif

namespace HTools.Converters
{
    /// <summary>
    /// 末尾有L表示Local
    /// </summary>
    internal class DateFormatConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter,
#if NET452
            CultureInfo language
#endif
#if UAP10_0_18362
            string language
#endif
            )
        {
            return ConverterHelper.TimeToStr(value, parameter as string);
        }

        public object ConvertBack(object value, Type targetType, object parameter,
#if NET452
            CultureInfo language
#endif
#if UAP10_0_18362
            string language
#endif
            )
        {
            return DateTime.ParseExact(value as string, parameter as string, System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}