using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using CCS.WorkplaceManagementSystem.Models;

namespace CCS.CustomControlLibrary
{
    public class EnumToThicknessConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var pos = (MachinePosition)value;
            switch (pos)
            {
                case MachinePosition.TopLeft:
                    return new Thickness(5, 5, 0, 0);
                case MachinePosition.TopRight:
                    return new Thickness(0, 5, 5, 0);
                case MachinePosition.BottonLeft:
                    return new Thickness(5, 0, 0, 5);
                case MachinePosition.BottomRight:
                    return new Thickness(0, 0, 5, 5);
                default:
                    return new Thickness(5, 5, 0, 0);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
