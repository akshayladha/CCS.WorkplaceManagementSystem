using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using CCS.WorkplaceManagementSystem.Models;

namespace CCS.CustomControlLibrary
{
    class EnumToVerticalAllignmentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var verAllign = (MachinePosition)value;
            switch (verAllign)
            {
                case MachinePosition.TopLeft:
                case MachinePosition.TopRight:
                    return VerticalAlignment.Top;
                case MachinePosition.BottonLeft:
                case MachinePosition.BottomRight:
                    return VerticalAlignment.Bottom;
                default:
                    return VerticalAlignment.Top;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
