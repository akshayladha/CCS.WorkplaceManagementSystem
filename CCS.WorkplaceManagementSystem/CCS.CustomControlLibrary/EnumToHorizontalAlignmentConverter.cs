using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using CCS.WorkplaceManagementSystem.Models;

namespace CCS.CustomControlLibrary
{
    class EnumToHorizontalAlignmentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var horAllign = (MachinePosition)value;
            switch (horAllign)
            {
                case MachinePosition.TopLeft:
                case MachinePosition.BottonLeft:
                    return HorizontalAlignment.Left;
                case MachinePosition.TopRight:
                case MachinePosition.BottomRight:
                    return HorizontalAlignment.Right;
                default:
                    return HorizontalAlignment.Left;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
